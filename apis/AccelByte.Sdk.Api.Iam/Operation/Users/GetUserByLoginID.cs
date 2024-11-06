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
    /// GetUserByLoginID
    ///
    /// ## The endpoint is going to be deprecated
    /// ### Endpoint migration guide
    /// - **Substitute endpoint: _/iam/v3/public/namespaces/{namespace}/users [GET]_**
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class GetUserByLoginID : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserByLoginIDBuilder Builder { get => new GetUserByLoginIDBuilder(); }

        public class GetUserByLoginIDBuilder
            : OperationBuilder<GetUserByLoginIDBuilder>
        {

            public string? LoginId { get; set; }





            internal GetUserByLoginIDBuilder() { }

            internal GetUserByLoginIDBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetUserByLoginIDBuilder SetLoginId(string _loginId)
            {
                LoginId = _loginId;
                return this;
            }





            public GetUserByLoginID Build(
                string namespace_
            )
            {
                GetUserByLoginID op = new GetUserByLoginID(this,
                    namespace_                    
                );

                op.SetBaseFields<GetUserByLoginIDBuilder>(this);
                return op;
            }

            [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
            public GetUserByLoginID.Response Execute(
                string namespace_
            )
            {
                GetUserByLoginID op = Build(
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
            public async Task<GetUserByLoginID.Response> ExecuteAsync(
                string namespace_
            )
            {
                GetUserByLoginID op = Build(
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

        private GetUserByLoginID(GetUserByLoginIDBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.LoginId is not null) QueryParams["loginId"] = builder.LoginId;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelPublicUserResponse>
        {

            public string Error400 { get; set; } = "";

            public string Error404 { get; set; } = "";

            public string Error500 { get; set; } = "";


            protected override string GetFullOperationId() => "Iam::Users::GetUserByLoginID";
        }

        #endregion

        public GetUserByLoginID(
            string namespace_,            
            string? loginId            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (loginId is not null) QueryParams["loginId"] = loginId;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/namespaces/{namespace}/users/byLoginId";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public GetUserByLoginID.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetUserByLoginID.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelPublicUserResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = payload.ReadToString();
                response.Error = new ApiError("-1", response.Error400!);
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