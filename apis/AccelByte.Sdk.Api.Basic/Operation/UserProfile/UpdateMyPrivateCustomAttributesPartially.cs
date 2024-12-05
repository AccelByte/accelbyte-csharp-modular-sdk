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
    /// updateMyPrivateCustomAttributesPartially
    ///
    /// Update partially private custom attributes tied to me.
    /// Other detail info:
    /// 
    ///   * Action code : 11402
    ///   *  Request body : allowed format: JSON object
    ///   *  Returns : Updated custom attributes
    /// </summary>
    public class UpdateMyPrivateCustomAttributesPartially : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateMyPrivateCustomAttributesPartiallyBuilder Builder { get => new UpdateMyPrivateCustomAttributesPartiallyBuilder(); }

        public class UpdateMyPrivateCustomAttributesPartiallyBuilder
            : OperationBuilder<UpdateMyPrivateCustomAttributesPartiallyBuilder>
        {


            public Dictionary<string, object>? Body { get; set; }




            internal UpdateMyPrivateCustomAttributesPartiallyBuilder() { }

            internal UpdateMyPrivateCustomAttributesPartiallyBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public UpdateMyPrivateCustomAttributesPartiallyBuilder SetBody(Dictionary<string, object> _body)
            {
                Body = _body;
                return this;
            }




            public UpdateMyPrivateCustomAttributesPartially Build(
                string namespace_
            )
            {
                UpdateMyPrivateCustomAttributesPartially op = new UpdateMyPrivateCustomAttributesPartially(this,
                    namespace_
                );

                op.SetBaseFields<UpdateMyPrivateCustomAttributesPartiallyBuilder>(this);
                return op;
            }

            public UpdateMyPrivateCustomAttributesPartially.Response Execute(
                string namespace_
            )
            {
                UpdateMyPrivateCustomAttributesPartially op = Build(
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
            public async Task<UpdateMyPrivateCustomAttributesPartially.Response> ExecuteAsync(
                string namespace_
            )
            {
                UpdateMyPrivateCustomAttributesPartially op = Build(
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

        private UpdateMyPrivateCustomAttributesPartially(UpdateMyPrivateCustomAttributesPartiallyBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Dictionary<string, object>>
        {

            public ValidationErrorEntity? Error400 { get; set; } = null;

            public ErrorEntity? Error401 { get; set; } = null;

            public ErrorEntity? Error403 { get; set; } = null;

            public ErrorEntity? Error404 { get; set; } = null;


            protected override string GetFullOperationId() => "Basic::UserProfile::UpdateMyPrivateCustomAttributesPartially";
        }

        #endregion

        public UpdateMyPrivateCustomAttributesPartially(
            string namespace_,
            Dictionary<string, object> body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/basic/v1/public/namespaces/{namespace}/users/me/profiles/privateCustomAttributes";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public UpdateMyPrivateCustomAttributesPartially.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new UpdateMyPrivateCustomAttributesPartially.Response()
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
                response.Data = JsonSerializer.Deserialize<Dictionary<string, object>>(payload, ResponseJsonOptions);
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
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
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