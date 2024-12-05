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

using AccelByte.Sdk.Api.Dsartifact.Model;

namespace AccelByte.Sdk.Api.Dsartifact.Operation
{
    /// <summary>
    /// checkServerArtifact
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSAM:ARTIFACT [READ]
    /// 
    /// Required scope: social
    /// 
    /// This endpoint will check artifact file existence before download file.
    /// 
    /// This endpoint will return the artifact status.
    /// 
    /// The possible status is : 'Empty', 'In Queue', 'Uploading', 'Ready', 'Failed'
    /// </summary>
    public class CheckServerArtifact : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CheckServerArtifactBuilder Builder { get => new CheckServerArtifactBuilder(); }

        public class CheckServerArtifactBuilder
            : OperationBuilder<CheckServerArtifactBuilder>
        {





            internal CheckServerArtifactBuilder() { }

            internal CheckServerArtifactBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public CheckServerArtifact Build(
                string namespace_,
                string podName
            )
            {
                CheckServerArtifact op = new CheckServerArtifact(this,
                    namespace_,
                    podName
                );

                op.SetBaseFields<CheckServerArtifactBuilder>(this);
                return op;
            }

            public CheckServerArtifact.Response Execute(
                string namespace_,
                string podName
            )
            {
                CheckServerArtifact op = Build(
                    namespace_,
                    podName
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<CheckServerArtifact.Response> ExecuteAsync(
                string namespace_,
                string podName
            )
            {
                CheckServerArtifact op = Build(
                    namespace_,
                    podName
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

        private CheckServerArtifact(CheckServerArtifactBuilder builder,
            string namespace_,
            string podName
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["podName"] = podName;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsArtifactFileStatus>
        {

            public ResponseError? Error404 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Dsartifact::DownloadServerArtifact::CheckServerArtifact";
        }

        #endregion

        public CheckServerArtifact(
            string namespace_,
            string podName
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["podName"] = podName;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsartifact/namespaces/{namespace}/servers/{podName}/artifacts/exists";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json", "text/x-log" };

        public CheckServerArtifact.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new CheckServerArtifact.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsArtifactFileStatus>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
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