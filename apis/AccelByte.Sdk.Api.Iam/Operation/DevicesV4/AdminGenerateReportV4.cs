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
    /// AdminGenerateReportV4
    ///
    /// This is the endpoint for an admin to generate device report
    /// </summary>
    public class AdminGenerateReportV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGenerateReportV4Builder Builder { get => new AdminGenerateReportV4Builder(); }

        public class AdminGenerateReportV4Builder
            : OperationBuilder<AdminGenerateReportV4Builder>
        {

            public string? EndDate { get; set; }

            public string? StartDate { get; set; }





            internal AdminGenerateReportV4Builder() { }

            internal AdminGenerateReportV4Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminGenerateReportV4Builder SetEndDate(string _endDate)
            {
                EndDate = _endDate;
                return this;
            }

            public AdminGenerateReportV4Builder SetStartDate(string _startDate)
            {
                StartDate = _startDate;
                return this;
            }





            public AdminGenerateReportV4 Build(
                string namespace_,
                string deviceType
            )
            {
                AdminGenerateReportV4 op = new AdminGenerateReportV4(this,
                    namespace_,
                    deviceType
                );

                op.SetBaseFields<AdminGenerateReportV4Builder>(this);
                return op;
            }

            public void Execute(
                string namespace_,
                string deviceType
            )
            {
                AdminGenerateReportV4 op = Build(
                    namespace_,
                    deviceType
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private AdminGenerateReportV4(AdminGenerateReportV4Builder builder,
            string namespace_,
            string deviceType
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.EndDate is not null) QueryParams["endDate"] = builder.EndDate;
            if (builder.StartDate is not null) QueryParams["startDate"] = builder.StartDate;
            if (deviceType is not null) QueryParams["deviceType"] = deviceType;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGenerateReportV4(
            string namespace_,
            string? endDate,
            string? startDate,
            string deviceType
        )
        {
            PathParams["namespace"] = namespace_;

            if (endDate is not null) QueryParams["endDate"] = endDate;
            if (startDate is not null) QueryParams["startDate"] = startDate;
            if (deviceType is not null) QueryParams["deviceType"] = deviceType;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/admin/namespaces/{namespace}/devices/report";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return;
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}