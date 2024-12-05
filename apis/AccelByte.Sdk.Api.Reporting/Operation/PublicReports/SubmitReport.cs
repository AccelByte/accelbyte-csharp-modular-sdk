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
    /// Supported category: - UGC - USER - CHAT - EXTENSION
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

                op.SetBaseFields<SubmitReportBuilder>(this);
                return op;
            }

            public SubmitReport.Response Execute(
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
            public async Task<SubmitReport.Response> ExecuteAsync(
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

                var response = await _Sdk.RunRequestAsync(op);
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

        #region Response Part        
        public class Response : ApiResponse<Model.RestapiSubmitReportResponse>
        {

            public RestapiErrorResponse? Error400 { get; set; } = null;

            public RestapiErrorResponse? Error409 { get; set; } = null;

            public RestapiErrorResponse? Error429 { get; set; } = null;

            public RestapiErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Reporting::PublicReports::SubmitReport";
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

        public SubmitReport.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new SubmitReport.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.RestapiSubmitReportResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<RestapiErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)409)
            {
                response.Error409 = JsonSerializer.Deserialize<RestapiErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error409!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)429)
            {
                response.Error429 = JsonSerializer.Deserialize<RestapiErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error429!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<RestapiErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}