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

using AccelByte.Sdk.Api.Gdpr.Model;

namespace AccelByte.Sdk.Api.Gdpr.Operation
{
    /// <summary>
    /// AdminGetUserPlatformAccountClosureHistories
    ///
    /// Get user's platform account closure histories.
    /// Scope: account
    /// 
    /// ------
    /// Supported platforms:
    /// * psn
    /// </summary>
    public class AdminGetUserPlatformAccountClosureHistories : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetUserPlatformAccountClosureHistoriesBuilder Builder { get => new AdminGetUserPlatformAccountClosureHistoriesBuilder(); }

        public class AdminGetUserPlatformAccountClosureHistoriesBuilder
            : OperationBuilder<AdminGetUserPlatformAccountClosureHistoriesBuilder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public string? Platform { get; set; }

            public string? UserId { get; set; }





            internal AdminGetUserPlatformAccountClosureHistoriesBuilder() { }

            internal AdminGetUserPlatformAccountClosureHistoriesBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminGetUserPlatformAccountClosureHistoriesBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminGetUserPlatformAccountClosureHistoriesBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminGetUserPlatformAccountClosureHistoriesBuilder SetPlatform(string _platform)
            {
                Platform = _platform;
                return this;
            }

            public AdminGetUserPlatformAccountClosureHistoriesBuilder SetUserId(string _userId)
            {
                UserId = _userId;
                return this;
            }





            public AdminGetUserPlatformAccountClosureHistories Build(
                string namespace_
            )
            {
                AdminGetUserPlatformAccountClosureHistories op = new AdminGetUserPlatformAccountClosureHistories(this,
                    namespace_                    
                );

                op.SetBaseFields<AdminGetUserPlatformAccountClosureHistoriesBuilder>(this);
                return op;
            }

            public AdminGetUserPlatformAccountClosureHistories.Response Execute(
                string namespace_
            )
            {
                AdminGetUserPlatformAccountClosureHistories op = Build(
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
            public async Task<AdminGetUserPlatformAccountClosureHistories.Response> ExecuteAsync(
                string namespace_
            )
            {
                AdminGetUserPlatformAccountClosureHistories op = Build(
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

        private AdminGetUserPlatformAccountClosureHistories(AdminGetUserPlatformAccountClosureHistoriesBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Platform is not null) QueryParams["platform"] = builder.Platform;
            if (builder.UserId is not null) QueryParams["userId"] = builder.UserId;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.DtoUserPlatformAccountClosureHistoriesResponse>
        {

            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error403 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Gdpr::PlatformAccountClosureHistory::AdminGetUserPlatformAccountClosureHistories";
        }

        #endregion

        public AdminGetUserPlatformAccountClosureHistories(
            string namespace_,            
            long? limit,            
            long? offset,            
            string? platform,            
            string? userId            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (platform is not null) QueryParams["platform"] = platform;
            if (userId is not null) QueryParams["userId"] = userId;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/gdpr/admin/namespaces/{namespace}/users/platforms/closure/histories";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminGetUserPlatformAccountClosureHistories.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminGetUserPlatformAccountClosureHistories.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.DtoUserPlatformAccountClosureHistoriesResponse>(payload, ResponseJsonOptions);
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
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
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