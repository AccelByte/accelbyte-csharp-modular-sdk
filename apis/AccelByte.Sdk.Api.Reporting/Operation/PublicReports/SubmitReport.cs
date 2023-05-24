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

using AccelByte.Sdk.Api.Reporting.Model;

namespace AccelByte.Sdk.Api.Reporting.Operation
{
    /// <summary>
    /// submitReport
    ///
    /// User need to be authenticated to access this endpoint.
    /// Submit a report and will return ticket for reported object.
    /// New ticket will be created if no OPEN ticket present for reported object (based by objectId and objectType) in a namespace.
    /// 
    /// User can only submit report once for each different user / object reported in the same OPEN ticket.
    /// Reporting the same user / object in the same OPEN ticket will return HTTP code 409 (conflict).
    /// 
    /// Fill the 'reason' field with a 'reason title'
    /// Supported category:
    /// 
    ///   * UGC
    ///   * USER
    ///   * CHAT
    ///   * EXTENSION
    /// </summary>
    public class SubmitReport : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SubmitReportBuilder Builder { get => new SubmitReportBuilder(); }

        public class SubmitReportBuilder
            : OperationBuilder<SubmitReportBuilder>
        {





            internal SubmitReportBuilder() { }

            internal SubmitReportBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public SubmitReport Build(
                RestapiSubmitReportRequest body,
                string namespace_
            )
            {
                SubmitReport op = new SubmitReport(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.RestapiSubmitReportResponse? Execute(
                RestapiSubmitReportRequest body,
                string namespace_
            )
            {
                SubmitReport op = Build(
                    body,
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

        private SubmitReport(SubmitReportBuilder builder,
            RestapiSubmitReportRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public SubmitReport(
            string namespace_,
            Model.RestapiSubmitReportRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/reporting/v1/public/namespaces/{namespace}/reports";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.RestapiSubmitReportResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.RestapiSubmitReportResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.RestapiSubmitReportResponse>(payload);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}