// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
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

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Net.Http;

using AccelByte.Sdk.Api.Social.Model;

namespace AccelByte.Sdk.Api.Social.Operation
{
    /// <summary>
    /// bulkFetchStatItems_1
    ///
    /// Public bulk fetch multiple user's statitem value for a given namespace and statCode.
    /// Other detail info:
    /// + *Required permission*: resource="NAMESPACE:{namespace}:STATITEM", action=2 (READ)
    /// + *Returns*: list of user's statItem
    /// </summary>
    public class BulkFetchStatItems1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static BulkFetchStatItems1Builder Builder { get => new BulkFetchStatItems1Builder(); }

        public class BulkFetchStatItems1Builder
            : OperationBuilder<BulkFetchStatItems1Builder>
        {





            internal BulkFetchStatItems1Builder() { }

            internal BulkFetchStatItems1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public BulkFetchStatItems1 Build(
                string namespace_,
                string statCode,
                string userIds
            )
            {
                BulkFetchStatItems1 op = new BulkFetchStatItems1(this,
                    namespace_,                    
                    statCode,                    
                    userIds                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public List<Model.UserStatItemInfo>? Execute(
                string namespace_,
                string statCode,
                string userIds
            )
            {
                BulkFetchStatItems1 op = Build(
                    namespace_,
                    statCode,
                    userIds
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }

            public List<Model.UserStatItemInfo<T1>>? Execute<T1>(
                string namespace_,
                string statCode,
                string userIds
            )
            {
                BulkFetchStatItems1 op = Build(
                    namespace_,
                    statCode,
                    userIds
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse<T1>(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
        }

        private BulkFetchStatItems1(BulkFetchStatItems1Builder builder,
            string namespace_,
            string statCode,
            string userIds
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (statCode is not null) QueryParams["statCode"] = statCode;
            if (userIds is not null) QueryParams["userIds"] = userIds;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public BulkFetchStatItems1(
            string namespace_,            
            string statCode,            
            string userIds            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (statCode is not null) QueryParams["statCode"] = statCode;
            if (userIds is not null) QueryParams["userIds"] = userIds;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/v1/public/namespaces/{namespace}/statitems/bulk";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };        
        
        public List<Model.UserStatItemInfo>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.UserStatItemInfo>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.UserStatItemInfo>>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }

        public List<Model.UserStatItemInfo<T1>>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }            
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.UserStatItemInfo<T1>>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.UserStatItemInfo<T1>>>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}