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

using AccelByte.Sdk.Api.Qosm.Model;

namespace AccelByte.Sdk.Api.Qosm.Operation
{
    /// <summary>
    /// SetServerAlias
    ///
    /// ```
    /// Required permission: ADMIN:QOS:SERVER [UDPATE]
    /// Required scope: social
    /// 
    /// This endpoint modifies a registered QoS service's region alias.
    /// ```
    /// </summary>
    public class SetServerAlias : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SetServerAliasBuilder Builder { get => new SetServerAliasBuilder(); }

        public class SetServerAliasBuilder
            : OperationBuilder<SetServerAliasBuilder>
        {





            internal SetServerAliasBuilder() { }

            internal SetServerAliasBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public SetServerAlias Build(
                ModelsSetAliasRequest body,
                string region
            )
            {
                SetServerAlias op = new SetServerAlias(this,
                    body,                    
                    region                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
                ModelsSetAliasRequest body,
                string region
            )
            {
                SetServerAlias op = Build(
                    body,
                    region
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

        private SetServerAlias(SetServerAliasBuilder builder,
            ModelsSetAliasRequest body,
            string region
        )
        {
            PathParams["region"] = region;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public SetServerAlias(
            string region,            
            Model.ModelsSetAliasRequest body            
        )
        {
            PathParams["region"] = region;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/qosm/admin/servers/{region}/alias";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}