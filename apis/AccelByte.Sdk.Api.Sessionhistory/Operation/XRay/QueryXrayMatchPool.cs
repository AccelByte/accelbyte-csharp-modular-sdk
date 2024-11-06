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

using AccelByte.Sdk.Api.Sessionhistory.Model;

namespace AccelByte.Sdk.Api.Sessionhistory.Operation
{
    /// <summary>
    /// queryXrayMatchPool
    ///
    /// Query xray match pool.
    /// query can using matchpool array with separate ","
    /// </summary>
    public class QueryXrayMatchPool : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryXrayMatchPoolBuilder Builder { get => new QueryXrayMatchPoolBuilder(); }

        public class QueryXrayMatchPoolBuilder
            : OperationBuilder<QueryXrayMatchPoolBuilder>
        {





            internal QueryXrayMatchPoolBuilder() { }

            internal QueryXrayMatchPoolBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public QueryXrayMatchPool Build(
                string namespace_,
                List<string> poolName,
                string endDate,
                string startDate
            )
            {
                QueryXrayMatchPool op = new QueryXrayMatchPool(this,
                    namespace_,                    
                    poolName,                    
                    endDate,                    
                    startDate                    
                );

                op.SetBaseFields<QueryXrayMatchPoolBuilder>(this);
                return op;
            }

            public QueryXrayMatchPool.Response Execute(
                string namespace_,
                List<string> poolName,
                string endDate,
                string startDate
            )
            {
                QueryXrayMatchPool op = Build(
                    namespace_,
                    poolName,
                    endDate,
                    startDate
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<QueryXrayMatchPool.Response> ExecuteAsync(
                string namespace_,
                List<string> poolName,
                string endDate,
                string startDate
            )
            {
                QueryXrayMatchPool op = Build(
                    namespace_,
                    poolName,
                    endDate,
                    startDate
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

        private QueryXrayMatchPool(QueryXrayMatchPoolBuilder builder,
            string namespace_,
            List<string> poolName,
            string endDate,
            string startDate
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["poolName"] = Convert.ToString(poolName);
            
            if (endDate is not null) QueryParams["endDate"] = endDate;
            if (startDate is not null) QueryParams["startDate"] = startDate;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ApimodelsXRayMatchPoolQueryResponse>
        {

            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error403 { get; set; } = null;

            public ResponseError? Error404 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Sessionhistory::XRay::QueryXrayMatchPool";
        }

        #endregion

        public QueryXrayMatchPool(
            string namespace_,            
            List<string> poolName,            
            string endDate,            
            string startDate            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["poolName"] = Convert.ToString(poolName);
            
            if (endDate is not null) QueryParams["endDate"] = endDate;
            if (startDate is not null) QueryParams["startDate"] = startDate;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/sessionhistory/v2/admin/namespaces/{namespace}/xray/match-pools/{poolName}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public QueryXrayMatchPool.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new QueryXrayMatchPool.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ApimodelsXRayMatchPoolQueryResponse>(payload, ResponseJsonOptions);
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
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
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