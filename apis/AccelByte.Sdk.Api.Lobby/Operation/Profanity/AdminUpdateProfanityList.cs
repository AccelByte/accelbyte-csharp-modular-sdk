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

using AccelByte.Sdk.Api.Lobby.Model;

namespace AccelByte.Sdk.Api.Lobby.Operation
{
    /// <summary>
    /// adminUpdateProfanityList
    ///
    /// Update the list
    /// </summary>
    public class AdminUpdateProfanityList : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateProfanityListBuilder Builder { get => new AdminUpdateProfanityListBuilder(); }

        public class AdminUpdateProfanityListBuilder
            : OperationBuilder<AdminUpdateProfanityListBuilder>
        {





            internal AdminUpdateProfanityListBuilder() { }

            internal AdminUpdateProfanityListBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminUpdateProfanityList Build(
                ModelsAdminUpdateProfanityList body,
                string list,
                string namespace_
            )
            {
                AdminUpdateProfanityList op = new AdminUpdateProfanityList(this,
                    body,                    
                    list,                    
                    namespace_                    
                );

                op.SetBaseFields<AdminUpdateProfanityListBuilder>(this);
                return op;
            }

            public AdminUpdateProfanityList.Response Execute(
                ModelsAdminUpdateProfanityList body,
                string list,
                string namespace_
            )
            {
                AdminUpdateProfanityList op = Build(
                    body,
                    list,
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
            public async Task<AdminUpdateProfanityList.Response> ExecuteAsync(
                ModelsAdminUpdateProfanityList body,
                string list,
                string namespace_
            )
            {
                AdminUpdateProfanityList op = Build(
                    body,
                    list,
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

        private AdminUpdateProfanityList(AdminUpdateProfanityListBuilder builder,
            ModelsAdminUpdateProfanityList body,
            string list,
            string namespace_
        )
        {
            PathParams["list"] = list;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public RestapiErrorResponseBody? Error400 { get; set; } = null;

            public RestapiErrorResponseBody? Error401 { get; set; } = null;

            public RestapiErrorResponseBody? Error403 { get; set; } = null;

            public RestapiErrorResponseBody? Error404 { get; set; } = null;

            public RestapiErrorResponseBody? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Lobby::Profanity::AdminUpdateProfanityList";
        }

        #endregion

        public AdminUpdateProfanityList(
            string list,            
            string namespace_,            
            Model.ModelsAdminUpdateProfanityList body            
        )
        {
            PathParams["list"] = list;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/admin/profanity/namespaces/{namespace}/lists/{list}";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminUpdateProfanityList.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminUpdateProfanityList.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)400)
            
            {
                response.Error400 = JsonSerializer.Deserialize<RestapiErrorResponseBody>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            
            {
                response.Error401 = JsonSerializer.Deserialize<RestapiErrorResponseBody>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            
            {
                response.Error403 = JsonSerializer.Deserialize<RestapiErrorResponseBody>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            
            {
                response.Error404 = JsonSerializer.Deserialize<RestapiErrorResponseBody>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            
            {
                response.Error500 = JsonSerializer.Deserialize<RestapiErrorResponseBody>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}