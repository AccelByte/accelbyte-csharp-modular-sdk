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
    /// adminGetUnusedReasons
    ///
    /// This endpoint get reasons not used by moderation rules.
    /// </summary>
    public class AdminGetUnusedReasons : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetUnusedReasonsBuilder Builder { get => new AdminGetUnusedReasonsBuilder(); }

        public class AdminGetUnusedReasonsBuilder
            : OperationBuilder<AdminGetUnusedReasonsBuilder>
        {

            public string? ExtensionCategory { get; set; }





            internal AdminGetUnusedReasonsBuilder() { }

            internal AdminGetUnusedReasonsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminGetUnusedReasonsBuilder SetExtensionCategory(string _extensionCategory)
            {
                ExtensionCategory = _extensionCategory;
                return this;
            }





            public AdminGetUnusedReasons Build(
                string namespace_,
                string category
            )
            {
                AdminGetUnusedReasons op = new AdminGetUnusedReasons(this,
                    namespace_,                    
                    category                    
                );

                op.SetBaseFields<AdminGetUnusedReasonsBuilder>(this);
                return op;
            }

            public AdminGetUnusedReasons.Response Execute(
                string namespace_,
                string category
            )
            {
                AdminGetUnusedReasons op = Build(
                    namespace_,
                    category
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<AdminGetUnusedReasons.Response> ExecuteAsync(
                string namespace_,
                string category
            )
            {
                AdminGetUnusedReasons op = Build(
                    namespace_,
                    category
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

        private AdminGetUnusedReasons(AdminGetUnusedReasonsBuilder builder,
            string namespace_,
            string category
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.ExtensionCategory is not null) QueryParams["extensionCategory"] = builder.ExtensionCategory;
            if (category is not null) QueryParams["category"] = category;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.RestapiUnusedReasonListResponse>
        {

            public RestapiErrorResponse? Error404 { get; set; } = null;

            public RestapiErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Reporting::AdminReasons::AdminGetUnusedReasons";
        }

        #endregion

        public AdminGetUnusedReasons(
            string namespace_,            
            string? extensionCategory,            
            string category            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (extensionCategory is not null) QueryParams["extensionCategory"] = extensionCategory;
            if (category is not null) QueryParams["category"] = category;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/reporting/v1/admin/namespaces/{namespace}/reasons/unused";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminGetUnusedReasons.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminGetUnusedReasons.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.RestapiUnusedReasonListResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<RestapiErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
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