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
    /// DeleteServer
    ///
    /// ```
    /// Required permission: ADMIN:QOS:SERVER [DELETE]
    /// Required scope: social
    /// 
    /// This endpoint delete a registered QoS service record.
    /// ```
    /// </summary>
    public class DeleteServer : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteServerBuilder Builder { get => new DeleteServerBuilder(); }

        public class DeleteServerBuilder
            : OperationBuilder<DeleteServerBuilder>
        {





            internal DeleteServerBuilder() { }

            internal DeleteServerBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteServer Build(
                string region
            )
            {
                DeleteServer op = new DeleteServer(this,
                    region                    
                );

                op.SetBaseFields<DeleteServerBuilder>(this);
                return op;
            }

            public DeleteServer.Response Execute(
                string region
            )
            {
                DeleteServer op = Build(
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
            public async Task<DeleteServer.Response> ExecuteAsync(
                string region
            )
            {
                DeleteServer op = Build(
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

        private DeleteServer(DeleteServerBuilder builder,
            string region
        )
        {
            PathParams["region"] = region;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Qosm::Admin::DeleteServer";
        }

        #endregion

        public DeleteServer(
            string region            
        )
        {
            PathParams["region"] = region;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/qosm/admin/servers/{region}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public DeleteServer.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new DeleteServer.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)500)
            
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}