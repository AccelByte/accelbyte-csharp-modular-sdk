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
    /// updateTier
    ///
    /// This API is used to update a tier. Only draft season pass can be updated.
    /// </summary>
    public class UpdateTier : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateTierBuilder Builder { get => new UpdateTierBuilder(); }

        public class UpdateTierBuilder
            : OperationBuilder<UpdateTierBuilder>
        {


            public Model.TierInput? Body { get; set; }




            internal UpdateTierBuilder() { }

            internal UpdateTierBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public UpdateTierBuilder SetBody(Model.TierInput _body)
            {
                Body = _body;
                return this;
            }




            public UpdateTier Build(
                string id,
                string namespace_,
                string seasonId
            )
            {
                UpdateTier op = new UpdateTier(this,
                    id,                    
                    namespace_,                    
                    seasonId                    
                );

                op.SetBaseFields<UpdateTierBuilder>(this);
                return op;
            }

            public UpdateTier.Response Execute(
                string id,
                string namespace_,
                string seasonId
            )
            {
                UpdateTier op = Build(
                    id,
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
            public async Task<UpdateTier.Response> ExecuteAsync(
                string id,
                string namespace_,
                string seasonId
            )
            {
                UpdateTier op = Build(
                    id,
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

        private UpdateTier(UpdateTierBuilder builder,
            string id,
            string namespace_,
            string seasonId
        )
        {
            PathParams["id"] = id;
            PathParams["namespace"] = namespace_;
            PathParams["seasonId"] = seasonId;
            
            

            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.Tier>
        {

            public ErrorEntity? Error400 { get; set; } = null;

            public ErrorEntity? Error404 { get; set; } = null;

            public ErrorEntity? Error409 { get; set; } = null;

            public ValidationErrorEntity? Error422 { get; set; } = null;


            protected override string GetFullOperationId() => "Seasonpass::Tier::UpdateTier";
        }

        #endregion

        public UpdateTier(
            string id,            
            string namespace_,            
            string seasonId,            
            Model.TierInput body            
        )
        {
            PathParams["id"] = id;
            PathParams["namespace"] = namespace_;
            PathParams["seasonId"] = seasonId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/tiers/{id}";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public UpdateTier.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new UpdateTier.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.Tier>(payload, ResponseJsonOptions);
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