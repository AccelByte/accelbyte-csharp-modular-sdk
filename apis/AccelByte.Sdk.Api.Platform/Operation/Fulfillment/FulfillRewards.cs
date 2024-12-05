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
    /// fulfillRewards
    ///
    ///  [SERVICE COMMUNICATION ONLY] Fulfill rewards.
    /// Other detail info:
    /// 
    ///   * Returns : fulfillment result
    /// </summary>
    public class FulfillRewards : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static FulfillRewardsBuilder Builder { get => new FulfillRewardsBuilder(); }

        public class FulfillRewardsBuilder
            : OperationBuilder<FulfillRewardsBuilder>
        {





            internal FulfillRewardsBuilder() { }

            internal FulfillRewardsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public FulfillRewards Build(
                RewardsRequest body,
                string namespace_,
                string userId
            )
            {
                FulfillRewards op = new FulfillRewards(this,
                    body,
                    namespace_,
                    userId
                );

                op.SetBaseFields<FulfillRewardsBuilder>(this);
                return op;
            }

            public FulfillRewards.Response Execute(
                RewardsRequest body,
                string namespace_,
                string userId
            )
            {
                FulfillRewards op = Build(
                    body,
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
            public async Task<FulfillRewards.Response> ExecuteAsync(
                RewardsRequest body,
                string namespace_,
                string userId
            )
            {
                FulfillRewards op = Build(
                    body,
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

        private FulfillRewards(FulfillRewardsBuilder builder,
            RewardsRequest body,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public ErrorEntity? Error400 { get; set; } = null;

            public ErrorEntity? Error404 { get; set; } = null;

            public ErrorEntity? Error409 { get; set; } = null;


            protected override string GetFullOperationId() => "Platform::Fulfillment::FulfillRewards";
        }

        #endregion

        public FulfillRewards(
            string namespace_,
            string userId,
            Model.RewardsRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/fulfillment/rewards";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public FulfillRewards.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new FulfillRewards.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)400)

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