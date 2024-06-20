// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Reflection;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Net.Http;
using AccelByte.Sdk.Core.Net.Logging;
using AccelByte.Sdk.Core.Repository;
using AccelByte.Sdk.Core.Awesome;

namespace AccelByte.Sdk.Sample.Cli
{
    public class SdkHelper
    {
        public static IAccelByteSdk CreateSdkAndLogin(CommandArguments cArgs)
        {
            IHttpClient httpClient = new DefaultHttpClient();
            if (cArgs.IsLogEnabled)
            {
                IHttpLogger dLogger = new DefaultHttpLogger();
                httpClient.SetLogger(dLogger);
            }

            IAccelByteSdk sdk = AccelByteSdk.Builder
                .UseDefaultConfigRepository()
                .SetHttpClient(httpClient)
                .SetTokenRepository(new FileBasedTokenRepository())
                .Build();

            if (!sdk.Configuration.TokenRepository.HasToken)
            {
                Console.WriteLine("No stored token found. Trying to login using supplied credential if any.");
                if (cArgs.LoginType == CommandArguments.LoginTypeUser)
                {
                    if ((cArgs.LoginUsername == String.Empty) || (cArgs.LoginPassword == String.Empty))
                        throw new Exception("Username and/or password cannot be null for login type user.");
                    if (!sdk.LoginUser(cArgs.LoginUsername, cArgs.LoginPassword))
                        throw new Exception("Login for '" + cArgs.LoginUsername + "' has failed!");
                }
                else if (cArgs.LoginType == CommandArguments.LoginTypeClient)
                {
                    if (!sdk.LoginClient())
                        throw new Exception("Client login failed!");
                }
                else
                    throw new Exception("Invalid login type.");
            }

            return sdk;
        }

        public static IAccelByteSdk CreatyEmptySdk()
        {
            return AccelByteSdk.Builder
                .UseDefaultConfigRepository()
                .UseDefaultHttpClient()
                .SetTokenRepository(new FileBasedTokenRepository())
                .Build();
        }

        public static string SerializeToJson(object modelObj)
        {
            return JsonSerializer.Serialize(modelObj, modelObj.GetType(), new JsonSerializerOptions()
            {
                WriteIndented = true
            });
        }

        public static void InjectValueToObjectProperty(PropertyInfo pi, object obj, string srcValue)
        {
            if (pi.PropertyType == typeof(List<string>))
            {
                object? bodyObj = JsonSerializer.Deserialize(srcValue, pi.PropertyType, new JsonSerializerOptions()
                {
                    WriteIndented = true,
                    AllowTrailingCommas = true,
                    ReadCommentHandling = JsonCommentHandling.Skip
                });
                pi.SetValue(obj, bodyObj);
            }
            else if ((pi.PropertyType == typeof(int)) || (pi.PropertyType == typeof(int?)))
            {
                string iValue = srcValue.ToLower();
                pi.SetValue(obj, int.Parse(iValue));
            }
            else if ((pi.PropertyType == typeof(long)) || (pi.PropertyType == typeof(long?)))
            {
                string iValue = srcValue.ToLower();
                pi.SetValue(obj, long.Parse(iValue));
            }
            else if ((pi.PropertyType == typeof(double)) || (pi.PropertyType == typeof(double?)))
            {
                string iValue = srcValue.ToLower();
                pi.SetValue(obj, double.Parse(iValue));
            }
            else if ((pi.PropertyType == typeof(bool)) || (pi.PropertyType == typeof(bool?)))
            {
                string bValue = srcValue.ToLower();
                pi.SetValue(obj, (bValue == "true"));
            }
            else if ((pi.PropertyType == typeof(DateTime)) || (pi.PropertyType == typeof(DateTime?)))
            {
                string bValue = srcValue.Trim();

                if (DateTime.TryParse(bValue, out DateTime output))
                    pi.SetValue(obj, output);
                else
                    throw new Exception($"Could not parse datetime string to datetime object for [{pi.Name}].");
            }
            else
                pi.SetValue(obj, Convert.ChangeType(srcValue, pi.PropertyType));
        }

        public static object CreateWSModelObject(Type wsmType, Func<string, PropertyInfo, object, string> onSetProperty)
        {
            object newObj = Activator.CreateInstance(wsmType)!;
            foreach (PropertyInfo pi in wsmType.GetProperties())
            {
                AwesomePropertyAttribute? attr = pi.GetCustomAttribute<AwesomePropertyAttribute>();
                if (attr != null)
                {
                    if (attr.Name == "id")
                    {
                        string value = Guid.NewGuid().ToString().Replace("-", "");
                        InjectValueToObjectProperty(pi, newObj, value);
                    }
                    else
                    {
                        string value = onSetProperty.Invoke(attr.Name, pi, newObj);
                        InjectValueToObjectProperty(pi, newObj, value);
                    }
                }
            }

            return newObj;
        }
    }
}