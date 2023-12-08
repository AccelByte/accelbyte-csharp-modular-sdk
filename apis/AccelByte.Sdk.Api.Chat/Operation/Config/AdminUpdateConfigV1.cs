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

using AccelByte.Sdk.Api.Chat.Model;

namespace AccelByte.Sdk.Api.Chat.Operation
{
    /// <summary>
    /// adminUpdateConfigV1
    ///
    /// Update chat config of a namespace.
    /// </summary>
    public class AdminUpdateConfigV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateConfigV1Builder Builder { get => new AdminUpdateConfigV1Builder(); }

        public class AdminUpdateConfigV1Builder
            : OperationBuilder<AdminUpdateConfigV1Builder>
        {





            internal AdminUpdateConfigV1Builder() { }

            internal AdminUpdateConfigV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminUpdateConfigV1 Build(
                ModelsConfigResponse body,
                string namespace_
            )
            {
                AdminUpdateConfigV1 op = new AdminUpdateConfigV1(this,
                    body,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelsConfigResponse? Execute(
                ModelsConfigResponse body,
                string namespace_
            )
            {
                AdminUpdateConfigV1 op = Build(
                    body,
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
        }

        private AdminUpdateConfigV1(AdminUpdateConfigV1Builder builder,
            ModelsConfigResponse body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminUpdateConfigV1(
            string namespace_,            
            Model.ModelsConfigResponse body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/chat/v1/admin/config/namespaces/{namespace}";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.ModelsConfigResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsConfigResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsConfigResponse>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}