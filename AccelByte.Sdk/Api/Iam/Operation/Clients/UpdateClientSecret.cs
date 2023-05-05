// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// UpdateClientSecret
    ///
    /// 
    /// 
    /// ## The endpoint is going to be deprecated
    /// 
    /// 
    /// 
    /// 
    /// Required permission 'CLIENT:ADMIN [UPDATE]'
    /// Endpoint migration guide
    /// 
    /// 
    /// 
    /// 
    ///   * Substitute endpoint: /iam/v3/admin/namespaces/{namespace}/{clientId}/secret [PUT]
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class UpdateClientSecret : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateClientSecretBuilder Builder { get => new UpdateClientSecretBuilder(); }

        public class UpdateClientSecretBuilder
            : OperationBuilder<UpdateClientSecretBuilder>
        {





            internal UpdateClientSecretBuilder() { }






            public UpdateClientSecret Build(
                ClientmodelClientUpdateSecretRequest body,
                string clientId
            )
            {
                UpdateClientSecret op = new UpdateClientSecret(this,
                    body,                    
                    clientId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private UpdateClientSecret(UpdateClientSecretBuilder builder,
            ClientmodelClientUpdateSecretRequest body,
            string clientId
        )
        {
            PathParams["clientId"] = clientId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateClientSecret(
            string clientId,            
            Model.ClientmodelClientUpdateSecretRequest body            
        )
        {
            PathParams["clientId"] = clientId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/clients/{clientId}/secret";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}