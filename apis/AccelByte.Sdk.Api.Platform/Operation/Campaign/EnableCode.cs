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

using AccelByte.Sdk.Api.Platform.Model;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// enableCode
    ///
    /// Enable code.
    /// Other detail info:
    /// 
    ///   * Returns : enabled code
    /// </summary>
    public class EnableCode : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static EnableCodeBuilder Builder { get => new EnableCodeBuilder(); }

        public class EnableCodeBuilder
            : OperationBuilder<EnableCodeBuilder>
        {





            internal EnableCodeBuilder() { }

            internal EnableCodeBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public EnableCode Build(
                string code,
                string namespace_
            )
            {
                EnableCode op = new EnableCode(this,
                    code,
                    namespace_
                );

                op.SetBaseFields<EnableCodeBuilder>(this);
                return op;
            }

            public EnableCode.Response Execute(
                string code,
                string namespace_
            )
            {
                EnableCode op = Build(
                    code,
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
            public async Task<EnableCode.Response> ExecuteAsync(
                string code,
                string namespace_
            )
            {
                EnableCode op = Build(
                    code,
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

        private EnableCode(EnableCodeBuilder builder,
            string code,
            string namespace_
        )
        {
            PathParams["code"] = code;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.CodeInfo>
        {

            public ErrorEntity? Error404 { get; set; } = null;


            protected override string GetFullOperationId() => "Platform::Campaign::EnableCode";
        }

        #endregion

        public EnableCode(
            string code,
            string namespace_
        )
        {
            PathParams["code"] = code;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/codes/{code}/enable";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public EnableCode.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new EnableCode.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.CodeInfo>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }

            return response;
        }
    }

}