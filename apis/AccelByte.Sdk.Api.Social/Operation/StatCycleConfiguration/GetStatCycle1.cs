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

using AccelByte.Sdk.Api.Social.Model;

namespace AccelByte.Sdk.Api.Social.Operation
{
    /// <summary>
    /// getStatCycle_1
    ///
    /// Get stat cycle.
    /// Other detail info:
    ///             *  Returns : stat cycle info
    /// </summary>
    public class GetStatCycle1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetStatCycle1Builder Builder { get => new GetStatCycle1Builder(); }

        public class GetStatCycle1Builder
            : OperationBuilder<GetStatCycle1Builder>
        {





            internal GetStatCycle1Builder() { }

            internal GetStatCycle1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetStatCycle1 Build(
                string cycleId,
                string namespace_
            )
            {
                GetStatCycle1 op = new GetStatCycle1(this,
                    cycleId,                    
                    namespace_                    
                );

                op.SetBaseFields<GetStatCycle1Builder>(this);
                return op;
            }

            public GetStatCycle1.Response Execute(
                string cycleId,
                string namespace_
            )
            {
                GetStatCycle1 op = Build(
                    cycleId,
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
            public async Task<GetStatCycle1.Response> ExecuteAsync(
                string cycleId,
                string namespace_
            )
            {
                GetStatCycle1 op = Build(
                    cycleId,
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

        private GetStatCycle1(GetStatCycle1Builder builder,
            string cycleId,
            string namespace_
        )
        {
            PathParams["cycleId"] = cycleId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.StatCycleInfo>
        {

            public ErrorEntity? Error401 { get; set; } = null;

            public ErrorEntity? Error403 { get; set; } = null;

            public ErrorEntity? Error404 { get; set; } = null;

            public ErrorEntity? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Social::StatCycleConfiguration::GetStatCycle1";
        }

        #endregion

        public GetStatCycle1(
            string cycleId,            
            string namespace_            
        )
        {
            PathParams["cycleId"] = cycleId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/v1/public/namespaces/{namespace}/statCycles/{cycleId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public GetStatCycle1.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetStatCycle1.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.StatCycleInfo>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}