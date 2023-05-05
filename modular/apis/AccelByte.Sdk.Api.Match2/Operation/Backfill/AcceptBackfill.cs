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
    /// AcceptBackfill
    ///
    /// Required Permission: NAMESPACE:{namespace}:MATCHMAKING:BACKFILL [UPDATE]
    /// 
    /// Required Scope: social
    /// 
    /// Accept backfill proposal
    /// </summary>
    public class AcceptBackfill : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AcceptBackfillBuilder Builder { get => new AcceptBackfillBuilder(); }

        public class AcceptBackfillBuilder
            : OperationBuilder<AcceptBackfillBuilder>
        {





            internal AcceptBackfillBuilder() { }

            internal AcceptBackfillBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AcceptBackfill Build(
                ApiBackFillAcceptRequest body,
                string backfillID,
                string namespace_
            )
            {
                AcceptBackfill op = new AcceptBackfill(this,
                    body,                    
                    backfillID,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public void Execute(
                ApiBackFillAcceptRequest body,
                string backfillID,
                string namespace_
            )
            {
                AcceptBackfill op = Build(
                    body,
                    backfillID,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
        }

        private AcceptBackfill(AcceptBackfillBuilder builder,
            ApiBackFillAcceptRequest body,
            string backfillID,
            string namespace_
        )
        {
            PathParams["backfillID"] = backfillID;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AcceptBackfill(
            string backfillID,            
            string namespace_,            
            Model.ApiBackFillAcceptRequest body            
        )
        {
            PathParams["backfillID"] = backfillID;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/match2/v1/namespaces/{namespace}/backfill/{backfillID}/proposal/accept";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return;
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}