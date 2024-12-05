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
    /// AdminGetDeviceBansV4
    ///
    /// This is the endpoint for an admin to get device ban list
    /// </summary>
    public class AdminGetDeviceBansV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetDeviceBansV4Builder Builder { get => new AdminGetDeviceBansV4Builder(); }

        public class AdminGetDeviceBansV4Builder
            : OperationBuilder<AdminGetDeviceBansV4Builder>
        {





            internal AdminGetDeviceBansV4Builder() { }

            internal AdminGetDeviceBansV4Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminGetDeviceBansV4 Build(
                string deviceId,
                string namespace_
            )
            {
                AdminGetDeviceBansV4 op = new AdminGetDeviceBansV4(this,
                    deviceId,
                    namespace_
                );

                op.SetBaseFields<AdminGetDeviceBansV4Builder>(this);
                return op;
            }

            public AdminGetDeviceBansV4.Response Execute(
                string deviceId,
                string namespace_
            )
            {
                AdminGetDeviceBansV4 op = Build(
                    deviceId,
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
            public async Task<AdminGetDeviceBansV4.Response> ExecuteAsync(
                string deviceId,
                string namespace_
            )
            {
                AdminGetDeviceBansV4 op = Build(
                    deviceId,
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

        private AdminGetDeviceBansV4(AdminGetDeviceBansV4Builder builder,
            string deviceId,
            string namespace_
        )
        {
            PathParams["deviceId"] = deviceId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelDeviceBansResponseV4>
        {

            public RestErrorResponse? Error400 { get; set; } = null;

            public RestErrorResponse? Error401 { get; set; } = null;

            public RestErrorResponse? Error403 { get; set; } = null;

            public RestErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Iam::DevicesV4::AdminGetDeviceBansV4";
        }

        #endregion

        public AdminGetDeviceBansV4(
            string deviceId,
            string namespace_
        )
        {
            PathParams["deviceId"] = deviceId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/admin/namespaces/{namespace}/devices/{deviceId}/bans";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public AdminGetDeviceBansV4.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminGetDeviceBansV4.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelDeviceBansResponseV4>(payload, ResponseJsonOptions);
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
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}