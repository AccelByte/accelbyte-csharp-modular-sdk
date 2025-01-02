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

using AccelByte.Sdk.Api.Challenge.Model;

namespace AccelByte.Sdk.Api.Challenge.Operation
{
    /// <summary>
    /// adminCreateAssignmentPlugin
    ///
    /// - Required permission: ADMIN:NAMESPACE:{namespace}:CHALLENGE:PLUGIN [CREATE]
    /// </summary>
    public class AdminCreateAssignmentPlugin : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminCreateAssignmentPluginBuilder Builder { get => new AdminCreateAssignmentPluginBuilder(); }

        public class AdminCreateAssignmentPluginBuilder
            : OperationBuilder<AdminCreateAssignmentPluginBuilder>
        {





            internal AdminCreateAssignmentPluginBuilder() { }

            internal AdminCreateAssignmentPluginBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminCreateAssignmentPlugin Build(
                ModelPluginAssignmentRequest body,
                string namespace_
            )
            {
                AdminCreateAssignmentPlugin op = new AdminCreateAssignmentPlugin(this,
                    body,
                    namespace_
                );

                op.SetBaseFields<AdminCreateAssignmentPluginBuilder>(this);
                return op;
            }

            public AdminCreateAssignmentPlugin.Response Execute(
                ModelPluginAssignmentRequest body,
                string namespace_
            )
            {
                AdminCreateAssignmentPlugin op = Build(
                    body,
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
            public async Task<AdminCreateAssignmentPlugin.Response> ExecuteAsync(
                ModelPluginAssignmentRequest body,
                string namespace_
            )
            {
                AdminCreateAssignmentPlugin op = Build(
                    body,
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

        private AdminCreateAssignmentPlugin(AdminCreateAssignmentPluginBuilder builder,
            ModelPluginAssignmentRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelPluginAssignmentResponse>
        {

            public ResponseError? Error400 { get; set; } = null;

            public IamErrorResponse? Error401 { get; set; } = null;

            public IamErrorResponse? Error403 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Challenge::Plugins::AdminCreateAssignmentPlugin";
        }

        #endregion

        public AdminCreateAssignmentPlugin(
            string namespace_,
            Model.ModelPluginAssignmentRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/challenge/v1/admin/namespaces/{namespace}/plugins/assignment";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public AdminCreateAssignmentPlugin.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminCreateAssignmentPlugin.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelPluginAssignmentResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<IamErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<IamErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
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