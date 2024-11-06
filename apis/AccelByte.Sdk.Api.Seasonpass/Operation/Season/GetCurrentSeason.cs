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
    /// getCurrentSeason
    ///
    /// [SERVICE COMMUNICATION ONLY]This API is used to get current published season summary which includes previous published season summary if exists, season only located in non-publisher namespace.
    /// 
    /// Other detail info:
    /// 
    ///   * Returns : season summary data
    /// </summary>
    public class GetCurrentSeason : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetCurrentSeasonBuilder Builder { get => new GetCurrentSeasonBuilder(); }

        public class GetCurrentSeasonBuilder
            : OperationBuilder<GetCurrentSeasonBuilder>
        {





            internal GetCurrentSeasonBuilder() { }

            internal GetCurrentSeasonBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetCurrentSeason Build(
                string namespace_
            )
            {
                GetCurrentSeason op = new GetCurrentSeason(this,
                    namespace_                    
                );

                op.SetBaseFields<GetCurrentSeasonBuilder>(this);
                return op;
            }

            public GetCurrentSeason.Response Execute(
                string namespace_
            )
            {
                GetCurrentSeason op = Build(
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
            public async Task<GetCurrentSeason.Response> ExecuteAsync(
                string namespace_
            )
            {
                GetCurrentSeason op = Build(
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

        private GetCurrentSeason(GetCurrentSeasonBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.SeasonSummary>
        {

            public ErrorEntity? Error400 { get; set; } = null;

            public ErrorEntity? Error404 { get; set; } = null;


            protected override string GetFullOperationId() => "Seasonpass::Season::GetCurrentSeason";
        }

        #endregion

        public GetCurrentSeason(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/seasonpass/admin/namespaces/{namespace}/seasons/current";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public GetCurrentSeason.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetCurrentSeason.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.SeasonSummary>(payload, ResponseJsonOptions);
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