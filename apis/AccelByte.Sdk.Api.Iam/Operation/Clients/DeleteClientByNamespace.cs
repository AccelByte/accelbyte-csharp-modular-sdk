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

using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// DeleteClientByNamespace
    ///
    /// 
    /// 
    /// ## The endpoint is going to be deprecated
    /// 
    /// 
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:CLIENT:{clientId} [DELETE]'
    /// Endpoint migration guide
    /// 
    /// 
    /// 
    /// 
    ///   * Substitute endpoint: /iam/v3/admin/namespaces/{namespace}/clients/{clientId} [DELETE]
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class DeleteClientByNamespace : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteClientByNamespaceBuilder Builder { get => new DeleteClientByNamespaceBuilder(); }

        public class DeleteClientByNamespaceBuilder
            : OperationBuilder<DeleteClientByNamespaceBuilder>
        {





            internal DeleteClientByNamespaceBuilder() { }

            internal DeleteClientByNamespaceBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteClientByNamespace Build(
                string clientId,
                string namespace_
            )
            {
                DeleteClientByNamespace op = new DeleteClientByNamespace(this,
                    clientId,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
            public void Execute(
                string clientId,
                string namespace_
            )
            {
                DeleteClientByNamespace op = Build(
                    clientId,
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

        private DeleteClientByNamespace(DeleteClientByNamespaceBuilder builder,
            string clientId,
            string namespace_
        )
        {
            PathParams["clientId"] = clientId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteClientByNamespace(
            string clientId,            
            string namespace_            
        )
        {
            PathParams["clientId"] = clientId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/namespaces/{namespace}/clients/{clientId}";

        public override HttpMethod Method => HttpMethod.Delete;

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