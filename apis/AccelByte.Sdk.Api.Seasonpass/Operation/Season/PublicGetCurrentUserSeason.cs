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

using AccelByte.Sdk.Api.Seasonpass.Model;

namespace AccelByte.Sdk.Api.Seasonpass.Operation
{
    /// <summary>
    /// publicGetCurrentUserSeason
    ///
    /// This API is used to get current user season data, it will auto enroll if there's no user season but active published season exist, season only located in non-publisher namespace.
    /// 
    /// Other detail info:
    /// 
    ///   * Returns : user season data
    /// </summary>
    public class PublicGetCurrentUserSeason : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetCurrentUserSeasonBuilder Builder { get => new PublicGetCurrentUserSeasonBuilder(); }

        public class PublicGetCurrentUserSeasonBuilder
            : OperationBuilder<PublicGetCurrentUserSeasonBuilder>
        {





            internal PublicGetCurrentUserSeasonBuilder() { }

            internal PublicGetCurrentUserSeasonBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicGetCurrentUserSeason Build(
                string namespace_,
                string userId
            )
            {
                PublicGetCurrentUserSeason op = new PublicGetCurrentUserSeason(this,
                    namespace_,                    
                    userId                    
                );

                op.SetBaseFields<PublicGetCurrentUserSeasonBuilder>(this);
                return op;
            }

            public PublicGetCurrentUserSeason.Response Execute(
                string namespace_,
                string userId
            )
            {
                PublicGetCurrentUserSeason op = Build(
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
            public async Task<PublicGetCurrentUserSeason.Response> ExecuteAsync(
                string namespace_,
                string userId
            )
            {
                PublicGetCurrentUserSeason op = Build(
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

            public PublicGetCurrentUserSeason.Response<T1, T2> Execute<T1, T2>(
                string namespace_,
                string userId
            )
            {
                PublicGetCurrentUserSeason op = Build(
                    namespace_,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse<T1, T2>(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<PublicGetCurrentUserSeason.Response<T1, T2>> ExecuteAsync<T1, T2>(
                string namespace_,
                string userId
            )
            {
                PublicGetCurrentUserSeason op = Build(
                    namespace_,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse<T1, T2>(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
        }

        private PublicGetCurrentUserSeason(PublicGetCurrentUserSeasonBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ClaimableUserSeasonInfo>
        {

            public ErrorEntity? Error400 { get; set; } = null;

            public ErrorEntity? Error404 { get; set; } = null;


            protected override string GetFullOperationId() => "Seasonpass::Season::PublicGetCurrentUserSeason";
        }

        public class Response<T1, T2> : ApiResponse<Model.ClaimableUserSeasonInfo<T1, T2>>
        {
            public ErrorEntity? Error400 { get; set; } = null;

            public ErrorEntity? Error404 { get; set; } = null;


            protected override string GetFullOperationId() => "Seasonpass::Season::PublicGetCurrentUserSeason";
        }
        #endregion

        public PublicGetCurrentUserSeason(
            string namespace_,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/seasonpass/public/namespaces/{namespace}/users/{userId}/seasons/current/data";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public PublicGetCurrentUserSeason.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PublicGetCurrentUserSeason.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ClaimableUserSeasonInfo>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }

            return response;
        }

        public PublicGetCurrentUserSeason.Response<T1, T2> ParseResponse<T1, T2>(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PublicGetCurrentUserSeason.Response<T1, T2>()
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
                response.Data = JsonSerializer.Deserialize<Model.ClaimableUserSeasonInfo<T1, T2>>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }
            
            return response;
        }
    }

}