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
    /// bulkUpdateUserStatItem_1
    ///
    /// Public bulk update multiple user's statitems value with specific update strategy.
    /// There are four supported update strategies:
    /// + *OVERRIDE*: update user statitem with the new value
    /// + *INCREMENT*: increment user statitem with the specified value
    /// + *MAX*: update user statitem with the specified value if it's larger than the existing value
    /// + *MIN*: update user statitem with the specified value if it's lower than the existing value
    /// 
    /// Other detail info:
    /// + *Returns*: bulk updated result
    /// </summary>
    public class BulkUpdateUserStatItem1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static BulkUpdateUserStatItem1Builder Builder { get => new BulkUpdateUserStatItem1Builder(); }

        public class BulkUpdateUserStatItem1Builder
            : OperationBuilder<BulkUpdateUserStatItem1Builder>
        {


            public List<Model.BulkUserStatItemUpdate>? Body { get; set; }




            internal BulkUpdateUserStatItem1Builder() { }

            internal BulkUpdateUserStatItem1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public BulkUpdateUserStatItem1Builder SetBody(List<Model.BulkUserStatItemUpdate> _body)
            {
                Body = _body;
                return this;
            }




            public BulkUpdateUserStatItem1 Build(
                string namespace_
            )
            {
                BulkUpdateUserStatItem1 op = new BulkUpdateUserStatItem1(this,
                    namespace_                    
                );

                op.SetBaseFields<BulkUpdateUserStatItem1Builder>(this);
                return op;
            }

            public BulkUpdateUserStatItem1.Response Execute(
                string namespace_
            )
            {
                BulkUpdateUserStatItem1 op = Build(
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
            public async Task<BulkUpdateUserStatItem1.Response> ExecuteAsync(
                string namespace_
            )
            {
                BulkUpdateUserStatItem1 op = Build(
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

            public BulkUpdateUserStatItem1.Response<T1> Execute<T1>(
                string namespace_
            )
            {
                BulkUpdateUserStatItem1 op = Build(
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse<T1>(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<BulkUpdateUserStatItem1.Response<T1>> ExecuteAsync<T1>(
                string namespace_
            )
            {
                BulkUpdateUserStatItem1 op = Build(
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse<T1>(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
        }

        private BulkUpdateUserStatItem1(BulkUpdateUserStatItem1Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<List<Model.BulkStatOperationResult>>
        {

            public ErrorEntity? Error400 { get; set; } = null;

            public ErrorEntity? Error401 { get; set; } = null;

            public ErrorEntity? Error403 { get; set; } = null;

            public ValidationErrorEntity? Error422 { get; set; } = null;

            public ErrorEntity? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Social::UserStatistic::BulkUpdateUserStatItem1";
        }

        public class Response<T1> : ApiResponse<List<Model.BulkStatOperationResult<T1>>>
        {
            public ErrorEntity? Error400 { get; set; } = null;

            public ErrorEntity? Error401 { get; set; } = null;

            public ErrorEntity? Error403 { get; set; } = null;

            public ValidationErrorEntity? Error422 { get; set; } = null;

            public ErrorEntity? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Social::UserStatistic::BulkUpdateUserStatItem1";
        }
        #endregion

        public BulkUpdateUserStatItem1(
            string namespace_,            
            List<Model.BulkUserStatItemUpdate> body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/v2/public/namespaces/{namespace}/statitems/value/bulk";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public BulkUpdateUserStatItem1.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new BulkUpdateUserStatItem1.Response()
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
                response.Data = JsonSerializer.Deserialize<List<Model.BulkStatOperationResult>>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
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
            else if (code == (HttpStatusCode)422)
            {
                response.Error422 = JsonSerializer.Deserialize<ValidationErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error422!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }

        public BulkUpdateUserStatItem1.Response<T1> ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new BulkUpdateUserStatItem1.Response<T1>()
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
                response.Data = JsonSerializer.Deserialize<List<Model.BulkStatOperationResult<T1>>>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
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
            else if (code == (HttpStatusCode)422)
            {
                response.Error422 = JsonSerializer.Deserialize<ValidationErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error422!.TranslateToApiError();
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