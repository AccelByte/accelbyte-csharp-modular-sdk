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
    /// GetLeaderboardConfigurationsPublicV2
    ///
    /// This endpoint return all leaderboard configurations
    /// </summary>
    public class GetLeaderboardConfigurationsPublicV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetLeaderboardConfigurationsPublicV2Builder Builder { get => new GetLeaderboardConfigurationsPublicV2Builder(); }

        public class GetLeaderboardConfigurationsPublicV2Builder
            : OperationBuilder<GetLeaderboardConfigurationsPublicV2Builder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }





            internal GetLeaderboardConfigurationsPublicV2Builder() { }

            internal GetLeaderboardConfigurationsPublicV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetLeaderboardConfigurationsPublicV2Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetLeaderboardConfigurationsPublicV2Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public GetLeaderboardConfigurationsPublicV2 Build(
                string namespace_
            )
            {
                GetLeaderboardConfigurationsPublicV2 op = new GetLeaderboardConfigurationsPublicV2(this,
                    namespace_                    
                );

                op.SetBaseFields<GetLeaderboardConfigurationsPublicV2Builder>(this);
                return op;
            }

            public GetLeaderboardConfigurationsPublicV2.Response Execute(
                string namespace_
            )
            {
                GetLeaderboardConfigurationsPublicV2 op = Build(
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
            public async Task<GetLeaderboardConfigurationsPublicV2.Response> ExecuteAsync(
                string namespace_
            )
            {
                GetLeaderboardConfigurationsPublicV2 op = Build(
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

        private GetLeaderboardConfigurationsPublicV2(GetLeaderboardConfigurationsPublicV2Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.V2GetAllLeaderboardConfigsPublicResp>
        {

            public ResponseErrorResponse? Error400 { get; set; } = null;

            public ResponseErrorResponse? Error401 { get; set; } = null;

            public ResponseErrorResponse? Error403 { get; set; } = null;

            public ResponseErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Leaderboard::LeaderboardConfiguration::GetLeaderboardConfigurationsPublicV2";
        }

        #endregion

        public GetLeaderboardConfigurationsPublicV2(
            string namespace_,            
            long? limit,            
            long? offset            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/leaderboard/v2/public/namespaces/{namespace}/leaderboards";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public GetLeaderboardConfigurationsPublicV2.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetLeaderboardConfigurationsPublicV2.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.V2GetAllLeaderboardConfigsPublicResp>(payload, ResponseJsonOptions);
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