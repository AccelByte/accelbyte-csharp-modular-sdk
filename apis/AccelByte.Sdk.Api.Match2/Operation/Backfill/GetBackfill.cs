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
    /// GetBackfill
    ///
    /// Required Permission: NAMESPACE:{namespace}:MATCHMAKING:BACKFILL [GET]
    /// 
    /// Required Scope: social
    /// 
    /// Get backfill ticket by ID
    /// </summary>
    public class GetBackfill : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetBackfillBuilder Builder { get => new GetBackfillBuilder(); }

        public class GetBackfillBuilder
            : OperationBuilder<GetBackfillBuilder>
        {





            internal GetBackfillBuilder() { }

            internal GetBackfillBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetBackfill Build(
                string backfillID,
                string namespace_
            )
            {
                GetBackfill op = new GetBackfill(this,
                    backfillID,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ApiBackfillGetResponse? Execute(
                string backfillID,
                string namespace_
            )
            {
                GetBackfill op = Build(
                    backfillID,
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

        private GetBackfill(GetBackfillBuilder builder,
            string backfillID,
            string namespace_
        )
        {
            PathParams["backfillID"] = backfillID;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetBackfill(
            string backfillID,            
            string namespace_            
        )
        {
            PathParams["backfillID"] = backfillID;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/match2/v1/namespaces/{namespace}/backfill/{backfillID}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.ApiBackfillGetResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApiBackfillGetResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApiBackfillGetResponse>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}