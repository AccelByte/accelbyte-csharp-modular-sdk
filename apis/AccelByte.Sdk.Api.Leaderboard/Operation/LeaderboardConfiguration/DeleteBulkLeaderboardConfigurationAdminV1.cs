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
    /// deleteBulkLeaderboardConfigurationAdminV1
    ///
    /// 
    /// 
    /// This endpoint delete multiple leaderboards configuration in one request
    /// </summary>
    public class DeleteBulkLeaderboardConfigurationAdminV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteBulkLeaderboardConfigurationAdminV1Builder Builder { get => new DeleteBulkLeaderboardConfigurationAdminV1Builder(); }

        public class DeleteBulkLeaderboardConfigurationAdminV1Builder
            : OperationBuilder<DeleteBulkLeaderboardConfigurationAdminV1Builder>
        {





            internal DeleteBulkLeaderboardConfigurationAdminV1Builder() { }

            internal DeleteBulkLeaderboardConfigurationAdminV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteBulkLeaderboardConfigurationAdminV1 Build(
                ModelsDeleteBulkLeaderboardsReq body,
                string namespace_
            )
            {
                DeleteBulkLeaderboardConfigurationAdminV1 op = new DeleteBulkLeaderboardConfigurationAdminV1(this,
                    body,                    
                    namespace_                    
                );

                op.SetBaseFields<DeleteBulkLeaderboardConfigurationAdminV1Builder>(this);
                return op;
            }

            public DeleteBulkLeaderboardConfigurationAdminV1.Response Execute(
                ModelsDeleteBulkLeaderboardsReq body,
                string namespace_
            )
            {
                DeleteBulkLeaderboardConfigurationAdminV1 op = Build(
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
            public async Task<DeleteBulkLeaderboardConfigurationAdminV1.Response> ExecuteAsync(
                ModelsDeleteBulkLeaderboardsReq body,
                string namespace_
            )
            {
                DeleteBulkLeaderboardConfigurationAdminV1 op = Build(
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

        private DeleteBulkLeaderboardConfigurationAdminV1(DeleteBulkLeaderboardConfigurationAdminV1Builder builder,
            ModelsDeleteBulkLeaderboardsReq body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsDeleteBulkLeaderboardsResp>
        {

            public ResponseErrorResponse? Error400 { get; set; } = null;

            public ResponseErrorResponse? Error401 { get; set; } = null;

            public ResponseErrorResponse? Error403 { get; set; } = null;

            public ResponseErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Leaderboard::LeaderboardConfiguration::DeleteBulkLeaderboardConfigurationAdminV1";
        }

        #endregion

        public DeleteBulkLeaderboardConfigurationAdminV1(
            string namespace_,            
            Model.ModelsDeleteBulkLeaderboardsReq body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/leaderboard/v1/admin/namespaces/{namespace}/leaderboards/delete";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public DeleteBulkLeaderboardConfigurationAdminV1.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new DeleteBulkLeaderboardConfigurationAdminV1.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsDeleteBulkLeaderboardsResp>(payload, ResponseJsonOptions);
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