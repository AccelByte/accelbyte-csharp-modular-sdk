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
    /// bulkFetchStatItems
    ///
    /// Bulk fetch multiple user's statitem value for a given namespace and statCode.
    /// Other detail info:
    /// + *Returns*: list of user's statItem
    /// </summary>
    public class BulkFetchStatItems : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static BulkFetchStatItemsBuilder Builder { get => new BulkFetchStatItemsBuilder(); }

        public class BulkFetchStatItemsBuilder
            : OperationBuilder<BulkFetchStatItemsBuilder>
        {





            internal BulkFetchStatItemsBuilder() { }

            internal BulkFetchStatItemsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public BulkFetchStatItems Build(
                string namespace_,
                string statCode,
                string userIds
            )
            {
                BulkFetchStatItems op = new BulkFetchStatItems(this,
                    namespace_,                    
                    statCode,                    
                    userIds                    
                );

                op.SetBaseFields<BulkFetchStatItemsBuilder>(this);
                return op;
            }

            public BulkFetchStatItems.Response Execute(
                string namespace_,
                string statCode,
                string userIds
            )
            {
                BulkFetchStatItems op = Build(
                    namespace_,
                    statCode,
                    userIds
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<BulkFetchStatItems.Response> ExecuteAsync(
                string namespace_,
                string statCode,
                string userIds
            )
            {
                BulkFetchStatItems op = Build(
                    namespace_,
                    statCode,
                    userIds
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }

            public BulkFetchStatItems.Response<T1> Execute<T1>(
                string namespace_,
                string statCode,
                string userIds
            )
            {
                BulkFetchStatItems op = Build(
                    namespace_,
                    statCode,
                    userIds
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse<T1>(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<BulkFetchStatItems.Response<T1>> ExecuteAsync<T1>(
                string namespace_,
                string statCode,
                string userIds
            )
            {
                BulkFetchStatItems op = Build(
                    namespace_,
                    statCode,
                    userIds
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

        private BulkFetchStatItems(BulkFetchStatItemsBuilder builder,
            string namespace_,
            string statCode,
            string userIds
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (statCode is not null) QueryParams["statCode"] = statCode;
            if (userIds is not null) QueryParams["userIds"] = userIds;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<List<Model.UserStatItemInfo>>
        {

            public ErrorEntity? Error401 { get; set; } = null;

            public ErrorEntity? Error403 { get; set; } = null;

            public ValidationErrorEntity? Error422 { get; set; } = null;

            public ErrorEntity? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Social::UserStatistic::BulkFetchStatItems";
        }

        public class Response<T1> : ApiResponse<List<Model.UserStatItemInfo<T1>>>
        {
            public ErrorEntity? Error401 { get; set; } = null;

            public ErrorEntity? Error403 { get; set; } = null;

            public ValidationErrorEntity? Error422 { get; set; } = null;

            public ErrorEntity? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Social::UserStatistic::BulkFetchStatItems";
        }
        #endregion

        public BulkFetchStatItems(
            string namespace_,            
            string statCode,            
            string userIds            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (statCode is not null) QueryParams["statCode"] = statCode;
            if (userIds is not null) QueryParams["userIds"] = userIds;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/v1/admin/namespaces/{namespace}/statitems/bulk";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public BulkFetchStatItems.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new BulkFetchStatItems.Response()
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
                response.Data = JsonSerializer.Deserialize<List<Model.UserStatItemInfo>>(payload, ResponseJsonOptions);
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

        public BulkFetchStatItems.Response<T1> ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new BulkFetchStatItems.Response<T1>()
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
                response.Data = JsonSerializer.Deserialize<List<Model.UserStatItemInfo<T1>>>(payload, ResponseJsonOptions);
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