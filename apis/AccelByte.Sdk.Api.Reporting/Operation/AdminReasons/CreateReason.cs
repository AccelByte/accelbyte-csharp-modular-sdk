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

using AccelByte.Sdk.Api.Reporting.Model;

namespace AccelByte.Sdk.Api.Reporting.Operation
{
    /// <summary>
    /// createReason
    ///
    /// This endpoint create a reason for a namespace.
    /// </summary>
    public class CreateReason : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateReasonBuilder Builder { get => new CreateReasonBuilder(); }

        public class CreateReasonBuilder
            : OperationBuilder<CreateReasonBuilder>
        {





            internal CreateReasonBuilder() { }

            internal CreateReasonBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public CreateReason Build(
                RestapiCreateReasonRequest body,
                string namespace_
            )
            {
                CreateReason op = new CreateReason(this,
                    body,                    
                    namespace_                    
                );

                op.SetBaseFields<CreateReasonBuilder>(this);
                return op;
            }

            public CreateReason.Response Execute(
                RestapiCreateReasonRequest body,
                string namespace_
            )
            {
                CreateReason op = Build(
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
            public async Task<CreateReason.Response> ExecuteAsync(
                RestapiCreateReasonRequest body,
                string namespace_
            )
            {
                CreateReason op = Build(
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

        private CreateReason(CreateReasonBuilder builder,
            RestapiCreateReasonRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.RestapiAdminReasonResponse>
        {

            public RestapiErrorResponse? Error400 { get; set; } = null;

            public RestapiErrorResponse? Error409 { get; set; } = null;

            public RestapiErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Reporting::AdminReasons::CreateReason";
        }

        #endregion

        public CreateReason(
            string namespace_,            
            Model.RestapiCreateReasonRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/reporting/v1/admin/namespaces/{namespace}/reasons";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public CreateReason.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new CreateReason.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.RestapiAdminReasonResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<RestapiErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)409)
            {
                response.Error409 = JsonSerializer.Deserialize<RestapiErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error409!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<RestapiErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}