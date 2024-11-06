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

using AccelByte.Sdk.Api.Ugc.Model;

namespace AccelByte.Sdk.Api.Ugc.Operation
{
    /// <summary>
    /// AdminUpdateOfficialContentV2
    ///
    /// Update existing official content
    /// </summary>
    public class AdminUpdateOfficialContentV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateOfficialContentV2Builder Builder { get => new AdminUpdateOfficialContentV2Builder(); }

        public class AdminUpdateOfficialContentV2Builder
            : OperationBuilder<AdminUpdateOfficialContentV2Builder>
        {





            internal AdminUpdateOfficialContentV2Builder() { }

            internal AdminUpdateOfficialContentV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminUpdateOfficialContentV2 Build(
                ModelsAdminUpdateContentRequestV2 body,
                string channelId,
                string contentId,
                string namespace_
            )
            {
                AdminUpdateOfficialContentV2 op = new AdminUpdateOfficialContentV2(this,
                    body,                    
                    channelId,                    
                    contentId,                    
                    namespace_                    
                );

                op.SetBaseFields<AdminUpdateOfficialContentV2Builder>(this);
                return op;
            }

            public AdminUpdateOfficialContentV2.Response Execute(
                ModelsAdminUpdateContentRequestV2 body,
                string channelId,
                string contentId,
                string namespace_
            )
            {
                AdminUpdateOfficialContentV2 op = Build(
                    body,
                    channelId,
                    contentId,
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
            public async Task<AdminUpdateOfficialContentV2.Response> ExecuteAsync(
                ModelsAdminUpdateContentRequestV2 body,
                string channelId,
                string contentId,
                string namespace_
            )
            {
                AdminUpdateOfficialContentV2 op = Build(
                    body,
                    channelId,
                    contentId,
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

            public AdminUpdateOfficialContentV2.Response<T1> Execute<T1>(
                ModelsAdminUpdateContentRequestV2 body,
                string channelId,
                string contentId,
                string namespace_
            )
            {
                AdminUpdateOfficialContentV2 op = Build(
                    body,
                    channelId,
                    contentId,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse<T1>(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<AdminUpdateOfficialContentV2.Response<T1>> ExecuteAsync<T1>(
                ModelsAdminUpdateContentRequestV2 body,
                string channelId,
                string contentId,
                string namespace_
            )
            {
                AdminUpdateOfficialContentV2 op = Build(
                    body,
                    channelId,
                    contentId,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse<T1>(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
        }

        private AdminUpdateOfficialContentV2(AdminUpdateOfficialContentV2Builder builder,
            ModelsAdminUpdateContentRequestV2 body,
            string channelId,
            string contentId,
            string namespace_
        )
        {
            PathParams["channelId"] = channelId;
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsUpdateContentResponseV2>
        {

            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error404 { get; set; } = null;

            public ResponseError? Error409 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Ugc::AdminContentV2::AdminUpdateOfficialContentV2";
        }

        public class Response<T1> : ApiResponse<Model.ModelsUpdateContentResponseV2<T1>>
        {
            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error404 { get; set; } = null;

            public ResponseError? Error409 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Ugc::AdminContentV2::AdminUpdateOfficialContentV2";
        }
        #endregion

        public AdminUpdateOfficialContentV2(
            string channelId,            
            string contentId,            
            string namespace_,            
            Model.ModelsAdminUpdateContentRequestV2 body            
        )
        {
            PathParams["channelId"] = channelId;
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v2/admin/namespaces/{namespace}/channels/{channelId}/contents/{contentId}";

        public override HttpMethod Method => HttpMethod.Patch;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminUpdateOfficialContentV2.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminUpdateOfficialContentV2.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsUpdateContentResponseV2>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)409)
            {
                response.Error409 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error409!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }

        public AdminUpdateOfficialContentV2.Response<T1> ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminUpdateOfficialContentV2.Response<T1>()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsUpdateContentResponseV2<T1>>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)409)
            {
                response.Error409 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error409!.TranslateToApiError();
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