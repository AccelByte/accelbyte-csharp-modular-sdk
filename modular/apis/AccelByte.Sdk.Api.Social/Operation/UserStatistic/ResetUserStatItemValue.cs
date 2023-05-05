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
    /// resetUserStatItemValue
    ///
    /// Reset user's statitem value for a given namespace and user.
    /// User's statitem value will be reset to the default value defined in the statistic configuration.
    /// 
    /// Other detail info:
    /// + *Required permission*: resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:STATITEM", action=4 (UPDATE)
    /// + *Returns*: updated user's statItem
    /// </summary>
    public class ResetUserStatItemValue : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ResetUserStatItemValueBuilder Builder { get => new ResetUserStatItemValueBuilder(); }

        public class ResetUserStatItemValueBuilder
            : OperationBuilder<ResetUserStatItemValueBuilder>
        {

            public string? AdditionalKey { get; set; }


            public Model.StatResetInfo? Body { get; set; }




            internal ResetUserStatItemValueBuilder() { }

            internal ResetUserStatItemValueBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public ResetUserStatItemValueBuilder SetAdditionalKey(string _additionalKey)
            {
                AdditionalKey = _additionalKey;
                return this;
            }


            public ResetUserStatItemValueBuilder SetBody(Model.StatResetInfo _body)
            {
                Body = _body;
                return this;
            }




            public ResetUserStatItemValue Build(
                string namespace_,
                string statCode,
                string userId
            )
            {
                ResetUserStatItemValue op = new ResetUserStatItemValue(this,
                    namespace_,                    
                    statCode,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.StatItemIncResult? Execute(
                string namespace_,
                string statCode,
                string userId
            )
            {
                ResetUserStatItemValue op = Build(
                    namespace_,
                    statCode,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
        }

        private ResetUserStatItemValue(ResetUserStatItemValueBuilder builder,
            string namespace_,
            string statCode,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["statCode"] = statCode;
            PathParams["userId"] = userId;
            
            if (builder.AdditionalKey is not null) QueryParams["additionalKey"] = builder.AdditionalKey;
            

            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ResetUserStatItemValue(
            string namespace_,            
            string statCode,            
            string userId,            
            string? additionalKey,            
            Model.StatResetInfo body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["statCode"] = statCode;
            PathParams["userId"] = userId;
            
            if (additionalKey is not null) QueryParams["additionalKey"] = additionalKey;
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/v1/admin/namespaces/{namespace}/users/{userId}/stats/{statCode}/statitems/value/reset";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.StatItemIncResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.StatItemIncResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.StatItemIncResult>(payload);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}