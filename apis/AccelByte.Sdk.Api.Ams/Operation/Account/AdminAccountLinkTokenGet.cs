// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
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
using System.Threading.Tasks;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Net.Http;

using AccelByte.Sdk.Api.Ams.Model;

namespace AccelByte.Sdk.Api.Ams.Operation
{
    /// <summary>
    /// AdminAccountLinkTokenGet
    ///
    /// The link token returned can be used to connect another namespace to the account in which the provided namespace is linked. This route fails if there is no account linked to the specified namespace.
    /// 
    /// Required Permission: ADMIN:NAMESPACE:{namespace}:ARMADA:ACCOUNT [READ]
    /// </summary>
    public class AdminAccountLinkTokenGet : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminAccountLinkTokenGetBuilder Builder { get => new AdminAccountLinkTokenGetBuilder(); }

        public class AdminAccountLinkTokenGetBuilder
            : OperationBuilder<AdminAccountLinkTokenGetBuilder>
        {





            internal AdminAccountLinkTokenGetBuilder() { }

            internal AdminAccountLinkTokenGetBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminAccountLinkTokenGet Build(
                string namespace_
            )
            {
                AdminAccountLinkTokenGet op = new AdminAccountLinkTokenGet(this,
                    namespace_                    
                );

                op.SetBaseFields<AdminAccountLinkTokenGetBuilder>(this);
                return op;
            }

            public Model.ApiAccountLinkTokenResponse? Execute(
                string namespace_
            )
            {
                AdminAccountLinkTokenGet op = Build(
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
            public async Task<Model.ApiAccountLinkTokenResponse?> ExecuteAsync(
                string namespace_
            )
            {
                AdminAccountLinkTokenGet op = Build(
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
        }

        private AdminAccountLinkTokenGet(AdminAccountLinkTokenGetBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminAccountLinkTokenGet(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ams/v1/admin/namespaces/{namespace}/account/link";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.ApiAccountLinkTokenResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApiAccountLinkTokenResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApiAccountLinkTokenResponse>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}