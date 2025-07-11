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

using AccelByte.Sdk.Api.Platform.Model;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// getAvailablePredicateTypes
    ///
    /// Get available predicate types.
    /// Other detail info:
    /// 
    ///   * Returns : available predicate types
    /// </summary>
    public class GetAvailablePredicateTypes : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetAvailablePredicateTypesBuilder Builder { get => new GetAvailablePredicateTypesBuilder(); }

        public class GetAvailablePredicateTypesBuilder
            : OperationBuilder<GetAvailablePredicateTypesBuilder>
        {





            internal GetAvailablePredicateTypesBuilder() { }

            internal GetAvailablePredicateTypesBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetAvailablePredicateTypes Build(
                string namespace_
            )
            {
                GetAvailablePredicateTypes op = new GetAvailablePredicateTypes(this,
                    namespace_                    
                );

                op.SetBaseFields<GetAvailablePredicateTypesBuilder>(this);
                return op;
            }

            public GetAvailablePredicateTypes.Response Execute(
                string namespace_
            )
            {
                GetAvailablePredicateTypes op = Build(
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
            public async Task<GetAvailablePredicateTypes.Response> ExecuteAsync(
                string namespace_
            )
            {
                GetAvailablePredicateTypes op = Build(
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

        private GetAvailablePredicateTypes(GetAvailablePredicateTypesBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<List<Model.AvailablePredicate>>
        {

            public ErrorEntity? Error404 { get; set; } = null;


            protected override string GetFullOperationId() => "Platform::Item::GetAvailablePredicateTypes";
        }

        #endregion

        public GetAvailablePredicateTypes(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/items/predicate/types";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public GetAvailablePredicateTypes.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetAvailablePredicateTypes.Response()
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
                response.Data = JsonSerializer.Deserialize<List<Model.AvailablePredicate>>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
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