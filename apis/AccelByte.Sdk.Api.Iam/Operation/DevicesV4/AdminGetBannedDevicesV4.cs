// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
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

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Net.Http;

using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// AdminGetBannedDevicesV4
    ///
    /// This is the endpoint for an admin to get banned devices
    /// </summary>
    public class AdminGetBannedDevicesV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetBannedDevicesV4Builder Builder { get => new AdminGetBannedDevicesV4Builder(); }

        public class AdminGetBannedDevicesV4Builder
            : OperationBuilder<AdminGetBannedDevicesV4Builder>
        {

            public string? DeviceType { get; set; }

            public string? EndDate { get; set; }

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public string? StartDate { get; set; }





            internal AdminGetBannedDevicesV4Builder() { }

            internal AdminGetBannedDevicesV4Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminGetBannedDevicesV4Builder SetDeviceType(string _deviceType)
            {
                DeviceType = _deviceType;
                return this;
            }

            public AdminGetBannedDevicesV4Builder SetEndDate(string _endDate)
            {
                EndDate = _endDate;
                return this;
            }

            public AdminGetBannedDevicesV4Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminGetBannedDevicesV4Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminGetBannedDevicesV4Builder SetStartDate(string _startDate)
            {
                StartDate = _startDate;
                return this;
            }





            public AdminGetBannedDevicesV4 Build(
                string namespace_
            )
            {
                AdminGetBannedDevicesV4 op = new AdminGetBannedDevicesV4(this,
                    namespace_
                );

                op.SetBaseFields<AdminGetBannedDevicesV4Builder>(this);
                return op;
            }

            public Model.ModelDeviceBannedResponseV4? Execute(
                string namespace_
            )
            {
                AdminGetBannedDevicesV4 op = Build(
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
        }

        private AdminGetBannedDevicesV4(AdminGetBannedDevicesV4Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.DeviceType is not null) QueryParams["deviceType"] = builder.DeviceType;
            if (builder.EndDate is not null) QueryParams["endDate"] = builder.EndDate;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.StartDate is not null) QueryParams["startDate"] = builder.StartDate;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetBannedDevicesV4(
            string namespace_,
            string? deviceType,
            string? endDate,
            long? limit,
            long? offset,
            string? startDate
        )
        {
            PathParams["namespace"] = namespace_;

            if (deviceType is not null) QueryParams["deviceType"] = deviceType;
            if (endDate is not null) QueryParams["endDate"] = endDate;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (startDate is not null) QueryParams["startDate"] = startDate;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/admin/namespaces/{namespace}/devices/banned";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelDeviceBannedResponseV4? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelDeviceBannedResponseV4>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelDeviceBannedResponseV4>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}