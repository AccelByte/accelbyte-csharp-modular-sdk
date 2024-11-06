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
    /// retireSeason
    ///
    /// This API is used to retire a published season, if the season has not ended it will report error except with force.
    /// 
    /// Other detail info:
    /// 
    ///   * Returns : season info
    /// </summary>
    public class RetireSeason : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RetireSeasonBuilder Builder { get => new RetireSeasonBuilder(); }

        public class RetireSeasonBuilder
            : OperationBuilder<RetireSeasonBuilder>
        {

            public bool? Force { get; set; }





            internal RetireSeasonBuilder() { }

            internal RetireSeasonBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public RetireSeasonBuilder SetForce(bool _force)
            {
                Force = _force;
                return this;
            }





            public RetireSeason Build(
                string namespace_,
                string seasonId
            )
            {
                RetireSeason op = new RetireSeason(this,
                    namespace_,                    
                    seasonId                    
                );

                op.SetBaseFields<RetireSeasonBuilder>(this);
                return op;
            }

            public RetireSeason.Response Execute(
                string namespace_,
                string seasonId
            )
            {
                RetireSeason op = Build(
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
            public async Task<RetireSeason.Response> ExecuteAsync(
                string namespace_,
                string seasonId
            )
            {
                RetireSeason op = Build(
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

        private RetireSeason(RetireSeasonBuilder builder,
            string namespace_,
            string seasonId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["seasonId"] = seasonId;
            
            if (builder.Force != null) QueryParams["force"] = Convert.ToString(builder.Force)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.SeasonInfo>
        {

            public ErrorEntity? Error400 { get; set; } = null;

            public ErrorEntity? Error404 { get; set; } = null;

            public ErrorEntity? Error409 { get; set; } = null;


            protected override string GetFullOperationId() => "Seasonpass::Season::RetireSeason";
        }

        #endregion

        public RetireSeason(
            string namespace_,            
            string seasonId,            
            bool? force            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["seasonId"] = seasonId;
            
            if (force != null) QueryParams["force"] = Convert.ToString(force)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/retire";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public RetireSeason.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new RetireSeason.Response()
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

            return response;
        }
    }

}