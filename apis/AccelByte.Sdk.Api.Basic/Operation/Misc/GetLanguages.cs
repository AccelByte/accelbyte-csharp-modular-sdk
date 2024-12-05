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

using AccelByte.Sdk.Api.Basic.Model;

namespace AccelByte.Sdk.Api.Basic.Operation
{
    /// <summary>
    /// getLanguages
    ///
    /// List languages.
    /// Other detail info:
    /// 
    ///   * Action code : 11206
    ///   *  Returns : language list
    /// </summary>
    public class GetLanguages : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetLanguagesBuilder Builder { get => new GetLanguagesBuilder(); }

        public class GetLanguagesBuilder
            : OperationBuilder<GetLanguagesBuilder>
        {





            internal GetLanguagesBuilder() { }

            internal GetLanguagesBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetLanguages Build(
                string namespace_
            )
            {
                GetLanguages op = new GetLanguages(this,
                    namespace_
                );

                op.SetBaseFields<GetLanguagesBuilder>(this);
                return op;
            }

            public GetLanguages.Response Execute(
                string namespace_
            )
            {
                GetLanguages op = Build(
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
            public async Task<GetLanguages.Response> ExecuteAsync(
                string namespace_
            )
            {
                GetLanguages op = Build(
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

        private GetLanguages(GetLanguagesBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Dictionary<string, string>>
        {

            public ValidationErrorEntity? Error400 { get; set; } = null;

            public ErrorEntity? Error401 { get; set; } = null;


            protected override string GetFullOperationId() => "Basic::Misc::GetLanguages";
        }

        #endregion

        public GetLanguages(
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/basic/v1/admin/namespaces/{namespace}/misc/languages";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public GetLanguages.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetLanguages.Response()
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
                response.Data = JsonSerializer.Deserialize<Dictionary<string, string>>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ValidationErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }

            return response;
        }
    }

}