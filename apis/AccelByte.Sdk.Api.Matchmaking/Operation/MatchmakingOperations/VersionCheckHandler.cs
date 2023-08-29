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

using AccelByte.Sdk.Api.Matchmaking.Model;

namespace AccelByte.Sdk.Api.Matchmaking.Operation
{
    /// <summary>
    /// versionCheckHandler
    /// </summary>
    public class VersionCheckHandler : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static VersionCheckHandlerBuilder Builder { get => new VersionCheckHandlerBuilder(); }

        public class VersionCheckHandlerBuilder
            : OperationBuilder<VersionCheckHandlerBuilder>
        {





            internal VersionCheckHandlerBuilder() { }

            internal VersionCheckHandlerBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public VersionCheckHandler Build(
            )
            {
                VersionCheckHandler op = new VersionCheckHandler(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
            )
            {
                VersionCheckHandler op = Build(
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

        private VersionCheckHandler(VersionCheckHandlerBuilder builder
        )
        {
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public VersionCheckHandler(
        )
        {
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/matchmaking/version";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() {  };        
        
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