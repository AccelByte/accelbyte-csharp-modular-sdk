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

using AccelByte.Sdk.Api.Group.Model;

namespace AccelByte.Sdk.Api.Group.Operation
{
    /// <summary>
    /// getListGroupByIDsV2
    ///
    /// Required valid user authentication
    /// 
    /// Get list of groups by group Ids.
    /// 
    /// Action Code: 73303
    /// </summary>
    public class GetListGroupByIDsV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetListGroupByIDsV2Builder Builder { get => new GetListGroupByIDsV2Builder(); }

        public class GetListGroupByIDsV2Builder
            : OperationBuilder<GetListGroupByIDsV2Builder>
        {





            internal GetListGroupByIDsV2Builder() { }

            internal GetListGroupByIDsV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetListGroupByIDsV2 Build(
                ModelsGetGroupListRequestV2 body,
                string namespace_
            )
            {
                GetListGroupByIDsV2 op = new GetListGroupByIDsV2(this,
                    body,
                    namespace_
                );

                op.SetBaseFields<GetListGroupByIDsV2Builder>(this);
                return op;
            }

            public GetListGroupByIDsV2.Response Execute(
                ModelsGetGroupListRequestV2 body,
                string namespace_
            )
            {
                GetListGroupByIDsV2 op = Build(
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
            public async Task<GetListGroupByIDsV2.Response> ExecuteAsync(
                ModelsGetGroupListRequestV2 body,
                string namespace_
            )
            {
                GetListGroupByIDsV2 op = Build(
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

        private GetListGroupByIDsV2(GetListGroupByIDsV2Builder builder,
            ModelsGetGroupListRequestV2 body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsGetGroupsResponseV1>
        {

            public ResponseErrorResponse? Error400 { get; set; } = null;

            public ResponseErrorResponse? Error401 { get; set; } = null;

            public ResponseErrorResponse? Error403 { get; set; } = null;

            public ResponseErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Group::Group::GetListGroupByIDsV2";
        }

        #endregion

        public GetListGroupByIDsV2(
            string namespace_,
            Model.ModelsGetGroupListRequestV2 body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/group/v2/public/namespaces/{namespace}/groups/bulk";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public GetListGroupByIDsV2.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetListGroupByIDsV2.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsGetGroupsResponseV1>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}