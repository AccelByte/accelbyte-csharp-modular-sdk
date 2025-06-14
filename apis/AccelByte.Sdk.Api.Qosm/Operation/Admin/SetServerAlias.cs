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

                op.SetBaseFields<SetServerAliasBuilder>(this);
                return op;
            }

            public SetServerAlias.Response Execute(
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
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<SetServerAlias.Response> ExecuteAsync(
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

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse(
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

        #region Response Part        
        public class Response : ApiResponse
        {

            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error404 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Qosm::Admin::SetServerAlias";
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
        
        public SetServerAlias.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new SetServerAlias.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)400)
            
            {
                response.Error400 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            
            {
                response.Error404 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}