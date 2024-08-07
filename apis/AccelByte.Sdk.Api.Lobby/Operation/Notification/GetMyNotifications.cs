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

using AccelByte.Sdk.Api.Lobby.Model;

namespace AccelByte.Sdk.Api.Lobby.Operation
{
    /// <summary>
    /// getMyNotifications
    ///
    /// Get list of notifications in a namespace.
    /// The query parameters **startTime** and **endTime** can be filled with the **sequenceID** value in the notification, where the value is an epoch timestamp.
    /// Example **sequenceID** or epoch timestamp value: **1706595813**
    /// </summary>
    public class GetMyNotifications : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetMyNotificationsBuilder Builder { get => new GetMyNotificationsBuilder(); }

        public class GetMyNotificationsBuilder
            : OperationBuilder<GetMyNotificationsBuilder>
        {

            public long? EndTime { get; set; }

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public long? StartTime { get; set; }





            internal GetMyNotificationsBuilder() { }

            internal GetMyNotificationsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetMyNotificationsBuilder SetEndTime(long _endTime)
            {
                EndTime = _endTime;
                return this;
            }

            public GetMyNotificationsBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetMyNotificationsBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public GetMyNotificationsBuilder SetStartTime(long _startTime)
            {
                StartTime = _startTime;
                return this;
            }





            public GetMyNotifications Build(
                string namespace_
            )
            {
                GetMyNotifications op = new GetMyNotifications(this,
                    namespace_
                );

                op.SetBaseFields<GetMyNotificationsBuilder>(this);
                return op;
            }

            public Model.ModelNotificationResponse? Execute(
                string namespace_
            )
            {
                GetMyNotifications op = Build(
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
            public async Task<Model.ModelNotificationResponse?> ExecuteAsync(
                string namespace_
            )
            {
                GetMyNotifications op = Build(
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

        private GetMyNotifications(GetMyNotificationsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.EndTime != null) QueryParams["endTime"] = Convert.ToString(builder.EndTime)!;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.StartTime != null) QueryParams["startTime"] = Convert.ToString(builder.StartTime)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetMyNotifications(
            string namespace_,
            long? endTime,
            long? limit,
            long? offset,
            long? startTime
        )
        {
            PathParams["namespace"] = namespace_;

            if (endTime != null) QueryParams["endTime"] = Convert.ToString(endTime)!;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (startTime != null) QueryParams["startTime"] = Convert.ToString(startTime)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/notification/namespaces/{namespace}/me";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelNotificationResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelNotificationResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelNotificationResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}