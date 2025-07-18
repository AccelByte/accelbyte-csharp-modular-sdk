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

using AccelByte.Sdk.Api.Leaderboard.Model;

namespace AccelByte.Sdk.Api.Leaderboard.Operation
{
    /// <summary>
    /// getLeaderboardConfigurationsAdminV1
    ///
    /// This endpoint return all leaderboard configurations
    /// </summary>
    public class GetLeaderboardConfigurationsAdminV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetLeaderboardConfigurationsAdminV1Builder Builder { get => new GetLeaderboardConfigurationsAdminV1Builder(); }

        public class GetLeaderboardConfigurationsAdminV1Builder
            : OperationBuilder<GetLeaderboardConfigurationsAdminV1Builder>
        {

            public bool? IsArchived { get; set; }

            public bool? IsDeleted { get; set; }

            public long? Limit { get; set; }

            public long? Offset { get; set; }





            internal GetLeaderboardConfigurationsAdminV1Builder() { }

            internal GetLeaderboardConfigurationsAdminV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetLeaderboardConfigurationsAdminV1Builder SetIsArchived(bool _isArchived)
            {
                IsArchived = _isArchived;
                return this;
            }

            public GetLeaderboardConfigurationsAdminV1Builder SetIsDeleted(bool _isDeleted)
            {
                IsDeleted = _isDeleted;
                return this;
            }

            public GetLeaderboardConfigurationsAdminV1Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetLeaderboardConfigurationsAdminV1Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public GetLeaderboardConfigurationsAdminV1 Build(
                string namespace_
            )
            {
                GetLeaderboardConfigurationsAdminV1 op = new GetLeaderboardConfigurationsAdminV1(this,
                    namespace_                    
                );

                op.SetBaseFields<GetLeaderboardConfigurationsAdminV1Builder>(this);
                return op;
            }

            public GetLeaderboardConfigurationsAdminV1.Response Execute(
                string namespace_
            )
            {
                GetLeaderboardConfigurationsAdminV1 op = Build(
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
            public async Task<GetLeaderboardConfigurationsAdminV1.Response> ExecuteAsync(
                string namespace_
            )
            {
                GetLeaderboardConfigurationsAdminV1 op = Build(
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

        private GetLeaderboardConfigurationsAdminV1(GetLeaderboardConfigurationsAdminV1Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.IsArchived != null) QueryParams["isArchived"] = Convert.ToString(builder.IsArchived)!;
            if (builder.IsDeleted != null) QueryParams["isDeleted"] = Convert.ToString(builder.IsDeleted)!;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsGetAllLeaderboardConfigsResp>
        {

            public ResponseErrorResponse? Error400 { get; set; } = null;

            public ResponseErrorResponse? Error401 { get; set; } = null;

            public ResponseErrorResponse? Error403 { get; set; } = null;

            public ResponseErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Leaderboard::LeaderboardConfiguration::GetLeaderboardConfigurationsAdminV1";
        }

        #endregion

        public GetLeaderboardConfigurationsAdminV1(
            string namespace_,            
            bool? isArchived,            
            bool? isDeleted,            
            long? limit,            
            long? offset            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (isArchived != null) QueryParams["isArchived"] = Convert.ToString(isArchived)!;
            if (isDeleted != null) QueryParams["isDeleted"] = Convert.ToString(isDeleted)!;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/leaderboard/v1/admin/namespaces/{namespace}/leaderboards";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public GetLeaderboardConfigurationsAdminV1.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetLeaderboardConfigurationsAdminV1.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsGetAllLeaderboardConfigsResp>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}