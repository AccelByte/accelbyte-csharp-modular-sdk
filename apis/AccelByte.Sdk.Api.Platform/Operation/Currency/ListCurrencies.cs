// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Net;
using System.Net.Http;
using System.IO;
using System.Threading.Tasks;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Net.Http;

using AccelByte.Sdk.Api.Platform.Model;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// listCurrencies
    ///
    /// List currencies of a namespace.
    /// Other detail info:
    /// 
    ///   * Returns : Currency List
    /// </summary>
    public class ListCurrencies : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ListCurrenciesBuilder Builder { get => new ListCurrenciesBuilder(); }

        public class ListCurrenciesBuilder
            : OperationBuilder<ListCurrenciesBuilder>
        {

            public ListCurrenciesCurrencyType? CurrencyType { get; set; }





            internal ListCurrenciesBuilder() { }

            internal ListCurrenciesBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public ListCurrenciesBuilder SetCurrencyType(ListCurrenciesCurrencyType _currencyType)
            {
                CurrencyType = _currencyType;
                return this;
            }





            public ListCurrencies Build(
                string namespace_
            )
            {
                ListCurrencies op = new ListCurrencies(this,
                    namespace_                    
                );

                op.SetBaseFields<ListCurrenciesBuilder>(this);
                return op;
            }

            public List<Model.CurrencyInfo>? Execute(
                string namespace_
            )
            {
                ListCurrencies op = Build(
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<List<Model.CurrencyInfo>?> ExecuteAsync(
                string namespace_
            )
            {
                ListCurrencies op = Build(
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
        }

        private ListCurrencies(ListCurrenciesBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.CurrencyType is not null) QueryParams["currencyType"] = builder.CurrencyType.Value;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ListCurrencies(
            string namespace_,            
            ListCurrenciesCurrencyType? currencyType            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (currencyType is not null) QueryParams["currencyType"] = currencyType.Value;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/currencies";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public List<Model.CurrencyInfo>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.CurrencyInfo>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.CurrencyInfo>>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

    public class ListCurrenciesCurrencyType : StringEnum<ListCurrenciesCurrencyType>
    {
        public static readonly ListCurrenciesCurrencyType REAL
            = new ListCurrenciesCurrencyType("REAL");

        public static readonly ListCurrenciesCurrencyType VIRTUAL
            = new ListCurrenciesCurrencyType("VIRTUAL");


        public static implicit operator ListCurrenciesCurrencyType(string value)
        {
            return NewValue(value);
        }

        public ListCurrenciesCurrencyType(string enumValue)
            : base(enumValue)
        {

        }
    }

}