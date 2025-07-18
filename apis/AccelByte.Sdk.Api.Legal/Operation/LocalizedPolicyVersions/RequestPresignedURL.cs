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

using AccelByte.Sdk.Api.Legal.Model;

namespace AccelByte.Sdk.Api.Legal.Operation
{
    /// <summary>
    /// requestPresignedURL
    ///
    /// Request presigned URL for upload attachment for a particular localized version of base policy.
    /// </summary>
    public class RequestPresignedURL : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RequestPresignedURLBuilder Builder { get => new RequestPresignedURLBuilder(); }

        public class RequestPresignedURLBuilder
            : OperationBuilder<RequestPresignedURLBuilder>
        {


            public Model.UploadPolicyVersionAttachmentRequest? Body { get; set; }




            internal RequestPresignedURLBuilder() { }

            internal RequestPresignedURLBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public RequestPresignedURLBuilder SetBody(Model.UploadPolicyVersionAttachmentRequest _body)
            {
                Body = _body;
                return this;
            }




            public RequestPresignedURL Build(
                string localizedPolicyVersionId
            )
            {
                RequestPresignedURL op = new RequestPresignedURL(this,
                    localizedPolicyVersionId                    
                );

                op.SetBaseFields<RequestPresignedURLBuilder>(this);
                return op;
            }

            public RequestPresignedURL.Response Execute(
                string localizedPolicyVersionId
            )
            {
                RequestPresignedURL op = Build(
                    localizedPolicyVersionId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<RequestPresignedURL.Response> ExecuteAsync(
                string localizedPolicyVersionId
            )
            {
                RequestPresignedURL op = Build(
                    localizedPolicyVersionId
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

        private RequestPresignedURL(RequestPresignedURLBuilder builder,
            string localizedPolicyVersionId
        )
        {
            PathParams["localizedPolicyVersionId"] = localizedPolicyVersionId;
            
            

            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.UploadLocalizedPolicyVersionAttachmentResponse>
        {

            public ErrorEntity? Error400 { get; set; } = null;


            protected override string GetFullOperationId() => "Legal::LocalizedPolicyVersions::RequestPresignedURL";
        }

        #endregion

        public RequestPresignedURL(
            string localizedPolicyVersionId,            
            Model.UploadPolicyVersionAttachmentRequest body            
        )
        {
            PathParams["localizedPolicyVersionId"] = localizedPolicyVersionId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/localized-policy-versions/{localizedPolicyVersionId}/attachments";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public RequestPresignedURL.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new RequestPresignedURL.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.UploadLocalizedPolicyVersionAttachmentResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }

            return response;
        }
    }

}