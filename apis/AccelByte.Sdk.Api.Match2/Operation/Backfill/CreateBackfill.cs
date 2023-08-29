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

using AccelByte.Sdk.Api.Match2.Model;

namespace AccelByte.Sdk.Api.Match2.Operation
{
    /// <summary>
    /// CreateBackfill
    ///
    /// Required Permission: NAMESPACE:{namespace}:MATCHMAKING:BACKFILL [CREATE]
    /// 
    /// Required Scope: social
    /// 
    /// Create backfill ticket
    /// </summary>
    public class CreateBackfill : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateBackfillBuilder Builder { get => new CreateBackfillBuilder(); }

        public class CreateBackfillBuilder
            : OperationBuilder<CreateBackfillBuilder>
        {





            internal CreateBackfillBuilder() { }

            internal CreateBackfillBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public CreateBackfill Build(
                ApiBackFillCreateRequest body,
                string namespace_
            )
            {
                CreateBackfill op = new CreateBackfill(this,
                    body,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ApiBackfillCreateResponse? Execute(
                ApiBackFillCreateRequest body,
                string namespace_
            )
            {
                CreateBackfill op = Build(
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

        private CreateBackfill(CreateBackfillBuilder builder,
            ApiBackFillCreateRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreateBackfill(
            string namespace_,            
            Model.ApiBackFillCreateRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/match2/v1/namespaces/{namespace}/backfill";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.ApiBackfillCreateResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApiBackfillCreateResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApiBackfillCreateResponse>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}