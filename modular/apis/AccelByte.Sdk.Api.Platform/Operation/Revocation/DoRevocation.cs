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

using AccelByte.Sdk.Api.Platform.Model;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// doRevocation
    ///
    /// Do revocation.
    /// Other detail info:
    /// 
    ///   * Required permission : resource=ADMIN:NAMESPACE:{namespace}:USER:{userId}:REVOCATION, action=4 (UPDATE)
    ///   *  Returns : revocation results
    /// </summary>
    public class DoRevocation : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DoRevocationBuilder Builder { get => new DoRevocationBuilder(); }

        public class DoRevocationBuilder
            : OperationBuilder<DoRevocationBuilder>
        {


            public Model.RevocationRequest? Body { get; set; }




            internal DoRevocationBuilder() { }

            internal DoRevocationBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public DoRevocationBuilder SetBody(Model.RevocationRequest _body)
            {
                Body = _body;
                return this;
            }




            public DoRevocation Build(
                string namespace_,
                string userId
            )
            {
                DoRevocation op = new DoRevocation(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.RevocationResult? Execute(
                string namespace_,
                string userId
            )
            {
                DoRevocation op = Build(
                    namespace_,
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

        private DoRevocation(DoRevocationBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DoRevocation(
            string namespace_,            
            string userId,            
            Model.RevocationRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/revocation";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.RevocationResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.RevocationResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.RevocationResult>(payload);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}