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

using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// AdminGetClientsbyNamespacebyIDV3
    ///
    /// action code: 10309
    /// </summary>
    public class AdminGetClientsbyNamespacebyIDV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetClientsbyNamespacebyIDV3Builder Builder { get => new AdminGetClientsbyNamespacebyIDV3Builder(); }

        public class AdminGetClientsbyNamespacebyIDV3Builder
            : OperationBuilder<AdminGetClientsbyNamespacebyIDV3Builder>
        {





            internal AdminGetClientsbyNamespacebyIDV3Builder() { }

            internal AdminGetClientsbyNamespacebyIDV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminGetClientsbyNamespacebyIDV3 Build(
                string clientId,
                string namespace_
            )
            {
                AdminGetClientsbyNamespacebyIDV3 op = new AdminGetClientsbyNamespacebyIDV3(this,
                    clientId,
                    namespace_
                );

                op.SetBaseFields<AdminGetClientsbyNamespacebyIDV3Builder>(this);
                return op;
            }

            public AdminGetClientsbyNamespacebyIDV3.Response Execute(
                string clientId,
                string namespace_
            )
            {
                AdminGetClientsbyNamespacebyIDV3 op = Build(
                    clientId,
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
            public async Task<AdminGetClientsbyNamespacebyIDV3.Response> ExecuteAsync(
                string clientId,
                string namespace_
            )
            {
                AdminGetClientsbyNamespacebyIDV3 op = Build(
                    clientId,
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

        private AdminGetClientsbyNamespacebyIDV3(AdminGetClientsbyNamespacebyIDV3Builder builder,
            string clientId,
            string namespace_
        )
        {
            PathParams["clientId"] = clientId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ClientmodelClientV3Response>
        {

            public RestErrorResponse? Error400 { get; set; } = null;

            public RestErrorResponse? Error401 { get; set; } = null;

            public RestErrorResponse? Error403 { get; set; } = null;

            public RestErrorResponse? Error404 { get; set; } = null;


            protected override string GetFullOperationId() => "Iam::Clients::AdminGetClientsbyNamespacebyIDV3";
        }

        #endregion

        public AdminGetClientsbyNamespacebyIDV3(
            string clientId,
            string namespace_
        )
        {
            PathParams["clientId"] = clientId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/clients/{clientId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public AdminGetClientsbyNamespacebyIDV3.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminGetClientsbyNamespacebyIDV3.Response()
            {
                StatusCode = code,
                ContentType = contentType
            };

            if (code == (HttpStatusCode)204)
            {
                response.IsSuccess = true;
            }
            else if ((code == (HttpStatusCode)201) || (code == (HttpStatusCode)202) || (code == (HttpStatusCode)200))
            {
                response.Data = JsonSerializer.Deserialize<Model.ClientmodelClientV3Response>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }

            return response;
        }
    }

}