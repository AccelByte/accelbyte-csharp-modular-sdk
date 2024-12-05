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
    /// getUserSubscriptionActivities
    ///
    /// Get user subscription activity.
    /// Other detail info:
    /// 
    ///   * Returns : paginated subscription activity
    /// </summary>
    public class GetUserSubscriptionActivities : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserSubscriptionActivitiesBuilder Builder { get => new GetUserSubscriptionActivitiesBuilder(); }

        public class GetUserSubscriptionActivitiesBuilder
            : OperationBuilder<GetUserSubscriptionActivitiesBuilder>
        {

            public bool? ExcludeSystem { get; set; }

            public int? Limit { get; set; }

            public int? Offset { get; set; }

            public string? SubscriptionId { get; set; }





            internal GetUserSubscriptionActivitiesBuilder() { }

            internal GetUserSubscriptionActivitiesBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetUserSubscriptionActivitiesBuilder SetExcludeSystem(bool _excludeSystem)
            {
                ExcludeSystem = _excludeSystem;
                return this;
            }

            public GetUserSubscriptionActivitiesBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetUserSubscriptionActivitiesBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public GetUserSubscriptionActivitiesBuilder SetSubscriptionId(string _subscriptionId)
            {
                SubscriptionId = _subscriptionId;
                return this;
            }





            public GetUserSubscriptionActivities Build(
                string namespace_,
                string userId
            )
            {
                GetUserSubscriptionActivities op = new GetUserSubscriptionActivities(this,
                    namespace_,
                    userId
                );

                op.SetBaseFields<GetUserSubscriptionActivitiesBuilder>(this);
                return op;
            }

            public GetUserSubscriptionActivities.Response Execute(
                string namespace_,
                string userId
            )
            {
                GetUserSubscriptionActivities op = Build(
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
            public async Task<GetUserSubscriptionActivities.Response> ExecuteAsync(
                string namespace_,
                string userId
            )
            {
                GetUserSubscriptionActivities op = Build(
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

        private GetUserSubscriptionActivities(GetUserSubscriptionActivitiesBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (builder.ExcludeSystem != null) QueryParams["excludeSystem"] = Convert.ToString(builder.ExcludeSystem)!;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.SubscriptionId is not null) QueryParams["subscriptionId"] = builder.SubscriptionId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.SubscriptionActivityPagingSlicedResult>
        {


            protected override string GetFullOperationId() => "Platform::Subscription::GetUserSubscriptionActivities";
        }

        #endregion

        public GetUserSubscriptionActivities(
            string namespace_,
            string userId,
            bool? excludeSystem,
            int? limit,
            int? offset,
            string? subscriptionId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (excludeSystem != null) QueryParams["excludeSystem"] = Convert.ToString(excludeSystem)!;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (subscriptionId is not null) QueryParams["subscriptionId"] = subscriptionId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/subscriptions/activities";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public GetUserSubscriptionActivities.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetUserSubscriptionActivities.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.SubscriptionActivityPagingSlicedResult>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }

            return response;
        }
    }

}