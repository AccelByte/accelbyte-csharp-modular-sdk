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

using AccelByte.Sdk.Api.Session.Model;

namespace AccelByte.Sdk.Api.Session.Operation
{
    /// <summary>
    /// publicDeletePlayerAttributes
    ///
    /// Reset player attributes.
    /// </summary>
    public class PublicDeletePlayerAttributes : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicDeletePlayerAttributesBuilder Builder { get => new PublicDeletePlayerAttributesBuilder(); }

        public class PublicDeletePlayerAttributesBuilder
            : OperationBuilder<PublicDeletePlayerAttributesBuilder>
        {





            internal PublicDeletePlayerAttributesBuilder() { }

            internal PublicDeletePlayerAttributesBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicDeletePlayerAttributes Build(
                string namespace_
            )
            {
                PublicDeletePlayerAttributes op = new PublicDeletePlayerAttributes(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public void Execute(
                string namespace_
            )
            {
                PublicDeletePlayerAttributes op = Build(
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

        private PublicDeletePlayerAttributes(PublicDeletePlayerAttributesBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicDeletePlayerAttributes(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/public/namespaces/{namespace}/users/me/attributes";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() {  };

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