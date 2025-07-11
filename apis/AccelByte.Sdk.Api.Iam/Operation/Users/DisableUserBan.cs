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

using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// DisableUserBan
    ///
    /// ## The endpoint is going to be deprecated
    /// ### Endpoint migration guide
    /// - **Substitute endpoint: _/iam/v3/admin/namespaces/{namespace}/users/{userId}/bans/{banId} [PATCH]_**
    /// 
    /// **Notes for using IAM in publisher - game studio scenarios**
    /// The endpoint allows:
    /// - The admin user in publisher namespace disables userâs ban in publisher namespace.
    /// - The admin user in game namespace disables userâs ban in game namespace.
    /// - The admin user in publisher namespace disables userâs ban in publisher namespace.
    /// 
    /// Other scenarios are not supported and will return 403: Forbidden.
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class DisableUserBan : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DisableUserBanBuilder Builder { get => new DisableUserBanBuilder(); }

        public class DisableUserBanBuilder
            : OperationBuilder<DisableUserBanBuilder>
        {





            internal DisableUserBanBuilder() { }

            internal DisableUserBanBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DisableUserBan Build(
                string banId,
                string namespace_,
                string userId
            )
            {
                DisableUserBan op = new DisableUserBan(this,
                    banId,                    
                    namespace_,                    
                    userId                    
                );

                op.SetBaseFields<DisableUserBanBuilder>(this);
                return op;
            }

            [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
            public DisableUserBan.Response Execute(
                string banId,
                string namespace_,
                string userId
            )
            {
                DisableUserBan op = Build(
                    banId,
                    namespace_,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<DisableUserBan.Response> ExecuteAsync(
                string banId,
                string namespace_,
                string userId
            )
            {
                DisableUserBan op = Build(
                    banId,
                    namespace_,
                    userId
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

        private DisableUserBan(DisableUserBanBuilder builder,
            string banId,
            string namespace_,
            string userId
        )
        {
            PathParams["banId"] = banId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelUserBanResponse>
        {

            public RestErrorResponse? Error401 { get; set; } = null;

            public string Error403 { get; set; } = "";

            public string Error404 { get; set; } = "";

            public string Error500 { get; set; } = "";


            protected override string GetFullOperationId() => "Iam::Users::DisableUserBan";
        }

        #endregion

        public DisableUserBan(
            string banId,            
            string namespace_,            
            string userId            
        )
        {
            PathParams["banId"] = banId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/namespaces/{namespace}/users/{userId}/bans/{banId}/disable";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "*/*" };

        public override List<string> Produces => new() { "application/json" };
        
        public DisableUserBan.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new DisableUserBan.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelUserBanResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = payload.ReadToString();
                response.Error = new ApiError("-1", response.Error403!);
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = payload.ReadToString();
                response.Error = new ApiError("-1", response.Error404!);
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = payload.ReadToString();
                response.Error = new ApiError("-1", response.Error500!);
            }

            return response;
        }
    }

}