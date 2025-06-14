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
    /// updateSeason
    ///
    /// This API is used to update a season. Only draft season can be updated.
    /// 
    /// Other detail info:
    /// 
    ///   * Returns : updated season
    /// </summary>
    public class UpdateSeason : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateSeasonBuilder Builder { get => new UpdateSeasonBuilder(); }

        public class UpdateSeasonBuilder
            : OperationBuilder<UpdateSeasonBuilder>
        {


            public Model.SeasonUpdate? Body { get; set; }




            internal UpdateSeasonBuilder() { }

            internal UpdateSeasonBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public UpdateSeasonBuilder SetBody(Model.SeasonUpdate _body)
            {
                Body = _body;
                return this;
            }




            public UpdateSeason Build(
                string namespace_,
                string seasonId
            )
            {
                UpdateSeason op = new UpdateSeason(this,
                    namespace_,                    
                    seasonId                    
                );

                op.SetBaseFields<UpdateSeasonBuilder>(this);
                return op;
            }

            public UpdateSeason.Response Execute(
                string namespace_,
                string seasonId
            )
            {
                UpdateSeason op = Build(
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
            public async Task<UpdateSeason.Response> ExecuteAsync(
                string namespace_,
                string seasonId
            )
            {
                UpdateSeason op = Build(
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

        private UpdateSeason(UpdateSeasonBuilder builder,
            string namespace_,
            string seasonId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["seasonId"] = seasonId;
            
            

            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.SeasonInfo>
        {

            public ErrorEntity? Error400 { get; set; } = null;

            public ErrorEntity? Error404 { get; set; } = null;

            public ErrorEntity? Error409 { get; set; } = null;

            public ValidationErrorEntity? Error422 { get; set; } = null;


            protected override string GetFullOperationId() => "Seasonpass::Season::UpdateSeason";
        }

        #endregion

        public UpdateSeason(
            string namespace_,            
            string seasonId,            
            Model.SeasonUpdate body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["seasonId"] = seasonId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}";

        public override HttpMethod Method => HttpMethod.Patch;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public UpdateSeason.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new UpdateSeason.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.SeasonInfo>(payload, ResponseJsonOptions);
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