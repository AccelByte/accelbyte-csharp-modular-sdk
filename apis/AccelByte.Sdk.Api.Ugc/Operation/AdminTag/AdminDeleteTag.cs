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
    /// AdminDeleteTag
    ///
    /// Delete existing tag
    /// </summary>
    public class AdminDeleteTag : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeleteTagBuilder Builder { get => new AdminDeleteTagBuilder(); }

        public class AdminDeleteTagBuilder
            : OperationBuilder<AdminDeleteTagBuilder>
        {





            internal AdminDeleteTagBuilder() { }

            internal AdminDeleteTagBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminDeleteTag Build(
                string namespace_,
                string tagId
            )
            {
                AdminDeleteTag op = new AdminDeleteTag(this,
                    namespace_,                    
                    tagId                    
                );

                op.SetBaseFields<AdminDeleteTagBuilder>(this);
                return op;
            }

            public AdminDeleteTag.Response Execute(
                string namespace_,
                string tagId
            )
            {
                AdminDeleteTag op = Build(
                    namespace_,
                    tagId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<AdminDeleteTag.Response> ExecuteAsync(
                string namespace_,
                string tagId
            )
            {
                AdminDeleteTag op = Build(
                    namespace_,
                    tagId
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

        private AdminDeleteTag(AdminDeleteTagBuilder builder,
            string namespace_,
            string tagId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["tagId"] = tagId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error404 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Ugc::AdminTag::AdminDeleteTag";
        }

        #endregion

        public AdminDeleteTag(
            string namespace_,            
            string tagId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["tagId"] = tagId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v1/admin/namespaces/{namespace}/tags/{tagId}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminDeleteTag.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminDeleteTag.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)401)
            
            {
                response.Error401 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
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