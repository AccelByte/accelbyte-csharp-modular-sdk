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

using AccelByte.Sdk.Api.Cloudsave.Model;

namespace AccelByte.Sdk.Api.Cloudsave.Operation
{
    /// <summary>
    /// putPlayerBinaryRecordV1
    ///
    /// Update a player binary record file by its key
    /// </summary>
    public class PutPlayerBinaryRecordV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PutPlayerBinaryRecordV1Builder Builder { get => new PutPlayerBinaryRecordV1Builder(); }

        public class PutPlayerBinaryRecordV1Builder
            : OperationBuilder<PutPlayerBinaryRecordV1Builder>
        {





            internal PutPlayerBinaryRecordV1Builder() { }

            internal PutPlayerBinaryRecordV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PutPlayerBinaryRecordV1 Build(
                ModelsBinaryRecordRequest body,
                string key,
                string namespace_,
                string userId
            )
            {
                PutPlayerBinaryRecordV1 op = new PutPlayerBinaryRecordV1(this,
                    body,                    
                    key,                    
                    namespace_,                    
                    userId                    
                );

                op.SetBaseFields<PutPlayerBinaryRecordV1Builder>(this);
                return op;
            }

            public PutPlayerBinaryRecordV1.Response Execute(
                ModelsBinaryRecordRequest body,
                string key,
                string namespace_,
                string userId
            )
            {
                PutPlayerBinaryRecordV1 op = Build(
                    body,
                    key,
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
            public async Task<PutPlayerBinaryRecordV1.Response> ExecuteAsync(
                ModelsBinaryRecordRequest body,
                string key,
                string namespace_,
                string userId
            )
            {
                PutPlayerBinaryRecordV1 op = Build(
                    body,
                    key,
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

        private PutPlayerBinaryRecordV1(PutPlayerBinaryRecordV1Builder builder,
            ModelsBinaryRecordRequest body,
            string key,
            string namespace_,
            string userId
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsPlayerBinaryRecordResponse>
        {

            public ModelsResponseError? Error400 { get; set; } = null;

            public ModelsResponseError? Error401 { get; set; } = null;

            public ModelsResponseError? Error403 { get; set; } = null;

            public ModelsResponseError? Error404 { get; set; } = null;

            public ModelsResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Cloudsave::PublicPlayerBinaryRecord::PutPlayerBinaryRecordV1";
        }

        #endregion

        public PutPlayerBinaryRecordV1(
            string key,            
            string namespace_,            
            string userId,            
            Model.ModelsBinaryRecordRequest body            
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/cloudsave/v1/namespaces/{namespace}/users/{userId}/binaries/{key}";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public PutPlayerBinaryRecordV1.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PutPlayerBinaryRecordV1.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsPlayerBinaryRecordResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ModelsResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<ModelsResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<ModelsResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ModelsResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ModelsResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}