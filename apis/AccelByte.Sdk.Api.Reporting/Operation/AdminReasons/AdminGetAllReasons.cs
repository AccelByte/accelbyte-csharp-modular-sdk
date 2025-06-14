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
    /// adminGetAllReasons
    ///
    /// This endpoint get all reasons without pagination.
    /// </summary>
    public class AdminGetAllReasons : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetAllReasonsBuilder Builder { get => new AdminGetAllReasonsBuilder(); }

        public class AdminGetAllReasonsBuilder
            : OperationBuilder<AdminGetAllReasonsBuilder>
        {





            internal AdminGetAllReasonsBuilder() { }

            internal AdminGetAllReasonsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminGetAllReasons Build(
                string namespace_
            )
            {
                AdminGetAllReasons op = new AdminGetAllReasons(this,
                    namespace_                    
                );

                op.SetBaseFields<AdminGetAllReasonsBuilder>(this);
                return op;
            }

            public AdminGetAllReasons.Response Execute(
                string namespace_
            )
            {
                AdminGetAllReasons op = Build(
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
            public async Task<AdminGetAllReasons.Response> ExecuteAsync(
                string namespace_
            )
            {
                AdminGetAllReasons op = Build(
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

        private AdminGetAllReasons(AdminGetAllReasonsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.RestapiAdminAllReasonsResponse>
        {

            public RestapiErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Reporting::AdminReasons::AdminGetAllReasons";
        }

        #endregion

        public AdminGetAllReasons(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/reporting/v1/admin/namespaces/{namespace}/reasons/all";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminGetAllReasons.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminGetAllReasons.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.RestapiAdminAllReasonsResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
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