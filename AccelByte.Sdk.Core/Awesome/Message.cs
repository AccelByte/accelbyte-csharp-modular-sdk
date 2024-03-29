// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Globalization;
using System.Reflection;
using System.IO;

namespace AccelByte.Sdk.Core.Awesome
{
    public class Message
    {
        public string MessageType { get; set; } = String.Empty;

        public string Id { get; set; } = String.Empty;

        public int? Code { get; set; } = null;

        public Dictionary<string, string> Data { get; set; }

        public bool StrictConversion { get; private set; } = false;

        protected void ReadHeader(string message)
        {
            StringReader reader = new StringReader(message);
            string? strType = reader.ReadLine();

            if (string.IsNullOrEmpty(strType) || !strType.StartsWith("type: "))
                throw new MessageException(ErrorCode.MessageFormatInvalid);

            try
            {
                MessageType = strType.Substring(strType.IndexOf(": ") + 2);
            }
            catch (Exception)
            {
                throw new MessageException(ErrorCode.MessageTypeNotSupported);
            }

            string? strId = reader.ReadLine();
            if (string.IsNullOrEmpty(strId) || !strId.StartsWith("id: "))
                return;

            Id = strId.Substring(strId.IndexOf(": ") + 2);

            string? strCode = reader.ReadLine();
            if (string.IsNullOrEmpty(strCode) || !strCode.StartsWith("code: "))
                return;

            int code;
            if (!int.TryParse(strCode.Substring(strCode.IndexOf(": ") + 2), out code))
                throw new MessageException(ErrorCode.MessageFieldConversionFailed);
            Code = code;
        }

        public void WriteHeader(StringBuilder sb)
        {
            sb.AppendFormat("type: {0}", MessageType);

            if (Id != String.Empty)
                sb.AppendFormat("\nid: {0}", Id);

            if (Code != null)
                sb.AppendFormat("\ncode: {0:D}", Code);
        }

        protected Dictionary<string, string> ParseFields(string inputString)
        {
            Dictionary<string, string> fields = new Dictionary<string, string>();

            foreach (string line in inputString.TrimEnd('\n').Split('\n'))
            {
                string[] parts = line.Split(':', 2, StringSplitOptions.TrimEntries);
                if (parts.Length <= 0)
                    throw new MessageException(ErrorCode.MessageFormatInvalid);

                var key = parts[0];
                var value = (parts.Length > 1 ? parts[1] : String.Empty);

                if (string.IsNullOrEmpty(key))
                    throw new MessageException(ErrorCode.MessageFormatInvalid);

                if (fields.ContainsKey(key))
                    throw new MessageException(ErrorCode.MessageFormatInvalid);

                fields[key] = value;
            }
            return fields;
        }

        protected Dictionary<string, string> GrabValues(object modelObject)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();

            PropertyInfo[] props = modelObject.GetType().GetProperties();
            foreach (PropertyInfo prop in props)
            {
                AwesomePropertyAttribute? attr = prop.GetCustomAttribute<AwesomePropertyAttribute>();
                if (attr == null)
                    continue;

                string aValue = String.Empty;
                Type valueType = prop.GetType();
                if (valueType.IsArray)
                {
                    List<string> items = new List<string>();
                    Array array = (Array)prop.GetValue(modelObject)!;
                    for (int i = 0; i < array.Length - 1; i++)
                        items.Add(array.GetValue(i)!.ToString()!);
                    aValue = "[" + String.Join(',', items) + "]";
                }
                else if (valueType.IsPrimitive || (valueType == typeof(string)))
                    aValue = prop.GetValue(modelObject)!.ToString()!;
                else if (valueType == typeof(DateTime))
                {
                    DateTime inputValue = ((DateTime)prop.GetValue(modelObject)!).ToUniversalTime();
                    aValue = String.Format("{0:0}", inputValue);
                }
                else
                    aValue = String.Format("{0:G}", prop.GetValue(modelObject));

                result.Add(attr.Name, aValue);
            }

            return result;
        }

        public Message(string msgString)
        {
            ReadHeader(msgString);
            Data = ParseFields(msgString);
        }

        public Message(object modelObject)
        {
            AwesomeModelAttribute? attr = modelObject.GetType().GetCustomAttribute<AwesomeModelAttribute>();
            if (attr == null)
                throw new MessageException(ErrorCode.MessageFieldConversionFailed);

            MessageType = attr.Name;
            Data = GrabValues(modelObject);
        }

        public Message(string messageType, Dictionary<string, string> data)
        {
            MessageType = messageType;
            Data = data;
        }

        public object To(Type targetType)
        {
            object newObj = Activator.CreateInstance(targetType)!;

            PropertyInfo[] props = targetType.GetProperties();
            foreach (PropertyInfo prop in props)
            {
                AwesomePropertyAttribute? attr = prop.GetCustomAttribute<AwesomePropertyAttribute>();
                if (attr == null)
                    continue;

                if (!Data.ContainsKey(attr.Name))
                {
                    if (StrictConversion)
                        throw new MessageException(ErrorCode.MessageFieldConversionFailed);
                    else
                        continue;
                }

                string aValue = Data[attr.Name];
                Type valueType = prop.PropertyType;

                if (valueType.IsGenericType && valueType.GetGenericTypeDefinition() == typeof(Nullable<>))
                    valueType = valueType.GetGenericArguments()[0];

                if (valueType.IsArray)
                {
                    var trimmedString = aValue.Trim('[', ']', ',', ' ');
                    if (String.IsNullOrEmpty(trimmedString))
                        prop.SetValue(newObj, Array.CreateInstance(valueType.GetElementType()!, 0));
                    else
                    {
                        Type elementType = valueType.GetElementType()!;
                        var strItems = trimmedString.Split(',');
                        var array = Array.CreateInstance(elementType, strItems.Length);

                        try
                        {
                            for (int i = 0; i < array.Length; i++)
                            {
                                var parsedValue = Convert.ChangeType(strItems[i].Trim(' '), elementType);
                                if (elementType == typeof(string))
                                    array.SetValue(Uri.UnescapeDataString((string)parsedValue), i);
                                else
                                    array.SetValue(parsedValue, i);
                            }
                            prop.SetValue(newObj, array);
                        }
                        catch (Exception)
                        {
                            throw new MessageException(ErrorCode.MessageFieldConversionFailed);
                        }
                    }
                }
                else if (valueType == typeof(string))
                {
                    prop.SetValue(newObj, Uri.UnescapeDataString(aValue));
                }
                else if (valueType.IsPrimitive)
                {
                    try
                    {
                        var convertedValue = Convert.ChangeType(aValue, valueType);
                        prop.SetValue(newObj, convertedValue);
                    }
                    catch (Exception)
                    {
                        throw new MessageException(ErrorCode.MessageFieldConversionFailed);
                    }
                }
                else if (valueType == typeof(DateTime))
                {
                    DateTime convertedValue;
                    if (DateTime.TryParse(aValue, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal, out convertedValue))
                        prop.SetValue(newObj, convertedValue);
                    else
                        throw new MessageException(ErrorCode.MessageFieldConversionFailed);
                }
                else if (valueType.IsEnum)
                {
                    try
                    {
                        var obj = Activator.CreateInstance(valueType);
                        obj = Enum.Parse(valueType, aValue);
                        prop.SetValue(newObj, obj);
                    }
                    catch (Exception)
                    {
                        throw new MessageException(ErrorCode.MessageFieldConversionFailed);
                    }
                }
                else if (valueType == typeof(Dictionary<string, object>))
                {
                    try
                    {
                        Dictionary<string, object>? convertedValue = JsonSerializer.Deserialize<Dictionary<string, object>>(aValue);
                        prop.SetValue(newObj, convertedValue);
                    }
                    catch (Exception)
                    {
                        throw new MessageException(ErrorCode.MessageFieldConversionFailed);
                    }
                }
                else if (valueType == typeof(Dictionary<string, int>))
                {
                    try
                    {
                        Dictionary<string, int>? convertedValue = JsonSerializer.Deserialize<Dictionary<string, int>>(aValue);
                        prop.SetValue(newObj, convertedValue);
                    }
                    catch (Exception)
                    {
                        throw new MessageException(ErrorCode.MessageFieldConversionFailed);
                    }
                }
                else if (valueType == typeof(Dictionary<string, string>))
                {
                    try
                    {
                        Dictionary<string, string>? convertedValue = JsonSerializer.Deserialize<Dictionary<string, string>>(aValue);
                        prop.SetValue(newObj, convertedValue);
                    }
                    catch (Exception)
                    {
                        throw new MessageException(ErrorCode.MessageFieldConversionFailed);
                    }
                }
                else if (aValue.StartsWith("{"))
                {
                    try
                    {
                        var convertedValue = JsonSerializer.Deserialize(aValue, valueType);
                        prop.SetValue(newObj, convertedValue);
                    }
                    catch (Exception)
                    {
                        throw new MessageException(ErrorCode.MessageFieldConversionFailed);
                    }
                }
                else
                {
                    throw new MessageException(ErrorCode.MessageFieldTypeNotSupported);
                }
            }
            return newObj;
        }

        public T To<T>() where T : class, new()
        {
            T newObj = new T();
            return (T)To(typeof(T));
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (Data.ContainsKey("id"))
                Id = Data["id"].Trim();

            WriteHeader(sb);
            foreach (KeyValuePair<string, string> pair in Data)
            {
                if ((pair.Key != "type") && (pair.Key != "id") && (pair.Key != "code"))
                    sb.AppendFormat("\n{0}: {1}", pair.Key, pair.Value);
            }
            return sb.ToString();
        }

        public byte[] ToByteArray()
        {
            string temp = ToString();
            return Encoding.UTF8.GetBytes(temp);
        }
    }
}