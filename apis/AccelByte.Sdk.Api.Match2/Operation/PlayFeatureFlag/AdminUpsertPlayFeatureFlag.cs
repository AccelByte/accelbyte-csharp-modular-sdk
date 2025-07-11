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

using AccelByte.Sdk.Api.Match2.Model;

namespace AccelByte.Sdk.Api.Match2.Operation
{
    /// <summary>
    /// adminUpsertPlayFeatureFlag
    ///
    /// Upsert matchmaking Play Feature Flag.
    /// </summary>
    public class AdminUpsertPlayFeatureFlag : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpsertPlayFeatureFlagBuilder Builder { get => new AdminUpsertPlayFeatureFlagBuilder(); }

        public class AdminUpsertPlayFeatureFlagBuilder
            : OperationBuilder<AdminUpsertPlayFeatureFlagBuilder>
        {





            internal AdminUpsertPlayFeatureFlagBuilder() { }

            internal AdminUpsertPlayFeatureFlagBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminUpsertPlayFeatureFlag Build(
                ModelsPlayFeatureFlag body,
                string namespace_
            )
            {
                AdminUpsertPlayFeatureFlag op = new AdminUpsertPlayFeatureFlag(this,
                    body,                    
                    namespace_                    
                );

                op.SetBaseFields<AdminUpsertPlayFeatureFlagBuilder>(this);
                return op;
            }

            public AdminUpsertPlayFeatureFlag.Response Execute(
                ModelsPlayFeatureFlag body,
                string namespace_
            )
            {
                AdminUpsertPlayFeatureFlag op = Build(
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
            public async Task<AdminUpsertPlayFeatureFlag.Response> ExecuteAsync(
                ModelsPlayFeatureFlag body,
                string namespace_
            )
            {
                AdminUpsertPlayFeatureFlag op = Build(
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

        private AdminUpsertPlayFeatureFlag(AdminUpsertPlayFeatureFlagBuilder builder,
            ModelsPlayFeatureFlag body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsPlayFeatureFlag>
        {

            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error403 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Match2::PlayFeatureFlag::AdminUpsertPlayFeatureFlag";
        }

        #endregion

        public AdminUpsertPlayFeatureFlag(
            string namespace_,            
            Model.ModelsPlayFeatureFlag body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/match2/v1/admin/namespaces/{namespace}/playfeatureflag";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminUpsertPlayFeatureFlag.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminUpsertPlayFeatureFlag.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsPlayFeatureFlag>(payload, ResponseJsonOptions);
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