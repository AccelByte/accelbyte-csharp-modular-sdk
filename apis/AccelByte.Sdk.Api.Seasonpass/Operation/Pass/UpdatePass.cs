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
    /// updatePass
    ///
    /// This API is used to update a pass. Only draft season pass can be updated.
    /// 
    /// Other detail info:
    /// 
    ///   * Returns : updated pass
    /// </summary>
    public class UpdatePass : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdatePassBuilder Builder { get => new UpdatePassBuilder(); }

        public class UpdatePassBuilder
            : OperationBuilder<UpdatePassBuilder>
        {


            public Model.PassUpdate? Body { get; set; }




            internal UpdatePassBuilder() { }

            internal UpdatePassBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public UpdatePassBuilder SetBody(Model.PassUpdate _body)
            {
                Body = _body;
                return this;
            }




            public UpdatePass Build(
                string code,
                string namespace_,
                string seasonId
            )
            {
                UpdatePass op = new UpdatePass(this,
                    code,                    
                    namespace_,                    
                    seasonId                    
                );

                op.SetBaseFields<UpdatePassBuilder>(this);
                return op;
            }

            public UpdatePass.Response Execute(
                string code,
                string namespace_,
                string seasonId
            )
            {
                UpdatePass op = Build(
                    code,
                    namespace_,
                    seasonId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<UpdatePass.Response> ExecuteAsync(
                string code,
                string namespace_,
                string seasonId
            )
            {
                UpdatePass op = Build(
                    code,
                    namespace_,
                    seasonId
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

        private UpdatePass(UpdatePassBuilder builder,
            string code,
            string namespace_,
            string seasonId
        )
        {
            PathParams["code"] = code;
            PathParams["namespace"] = namespace_;
            PathParams["seasonId"] = seasonId;
            
            

            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.PassInfo>
        {

            public ErrorEntity? Error400 { get; set; } = null;

            public ErrorEntity? Error404 { get; set; } = null;

            public ErrorEntity? Error409 { get; set; } = null;

            public ValidationErrorEntity? Error422 { get; set; } = null;


            protected override string GetFullOperationId() => "Seasonpass::Pass::UpdatePass";
        }

        #endregion

        public UpdatePass(
            string code,            
            string namespace_,            
            string seasonId,            
            Model.PassUpdate body            
        )
        {
            PathParams["code"] = code;
            PathParams["namespace"] = namespace_;
            PathParams["seasonId"] = seasonId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/passes/{code}";

        public override HttpMethod Method => HttpMethod.Patch;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public UpdatePass.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new UpdatePass.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.PassInfo>(payload, ResponseJsonOptions);
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
            else if (code == (HttpStatusCode)409)
            {
                response.Error409 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error409!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)422)
            {
                response.Error422 = JsonSerializer.Deserialize<ValidationErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error422!.TranslateToApiError();
            }

            return response;
        }
    }

}