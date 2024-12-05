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
    /// getThirdPartySubscriptionDetails
    ///
    /// Admin get user subscription details.Other detail info:
    ///   * Returns :
    /// </summary>
    public class GetThirdPartySubscriptionDetails : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetThirdPartySubscriptionDetailsBuilder Builder { get => new GetThirdPartySubscriptionDetailsBuilder(); }

        public class GetThirdPartySubscriptionDetailsBuilder
            : OperationBuilder<GetThirdPartySubscriptionDetailsBuilder>
        {





            internal GetThirdPartySubscriptionDetailsBuilder() { }

            internal GetThirdPartySubscriptionDetailsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetThirdPartySubscriptionDetails Build(
                string id,
                string namespace_,
                string userId
            )
            {
                GetThirdPartySubscriptionDetails op = new GetThirdPartySubscriptionDetails(this,
                    id,
                    namespace_,
                    userId
                );

                op.SetBaseFields<GetThirdPartySubscriptionDetailsBuilder>(this);
                return op;
            }

            public GetThirdPartySubscriptionDetails.Response Execute(
                string id,
                string namespace_,
                string userId
            )
            {
                GetThirdPartySubscriptionDetails op = Build(
                    id,
                    namespace_,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<GetThirdPartySubscriptionDetails.Response> ExecuteAsync(
                string id,
                string namespace_,
                string userId
            )
            {
                GetThirdPartySubscriptionDetails op = Build(
                    id,
                    namespace_,
                    userId
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

        private GetThirdPartySubscriptionDetails(GetThirdPartySubscriptionDetailsBuilder builder,
            string id,
            string namespace_,
            string userId
        )
        {
            PathParams["id"] = id;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ThirdPartySubscriptionTransactionInfo>
        {

            public ErrorEntity? Error404 { get; set; } = null;


            protected override string GetFullOperationId() => "Platform::IAPSubscription::GetThirdPartySubscriptionDetails";
        }

        #endregion

        public GetThirdPartySubscriptionDetails(
            string id,
            string namespace_,
            string userId
        )
        {
            PathParams["id"] = id;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/iap/subscriptions/transactions/{id}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public GetThirdPartySubscriptionDetails.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetThirdPartySubscriptionDetails.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ThirdPartySubscriptionTransactionInfo>(payload, ResponseJsonOptions);
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