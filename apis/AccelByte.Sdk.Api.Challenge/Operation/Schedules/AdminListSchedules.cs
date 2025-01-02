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

using AccelByte.Sdk.Api.Challenge.Model;

namespace AccelByte.Sdk.Api.Challenge.Operation
{
    /// <summary>
    /// adminListSchedules
    ///
    /// 
    /// 
    ///   * Required permission: ADMIN:NAMESPACE:{namespace}:CHALLENGE [READ]
    /// 
    /// List schedules of given challenge for specific user. To query schedules prior to specific date time, use dateTime parameter.
    /// </summary>
    public class AdminListSchedules : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminListSchedulesBuilder Builder { get => new AdminListSchedulesBuilder(); }

        public class AdminListSchedulesBuilder
            : OperationBuilder<AdminListSchedulesBuilder>
        {

            public DateTime? DateTime { get; set; }

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public string? UserId { get; set; }





            internal AdminListSchedulesBuilder() { }

            internal AdminListSchedulesBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminListSchedulesBuilder SetDateTime(DateTime _dateTime)
            {
                DateTime = _dateTime;
                return this;
            }

            public AdminListSchedulesBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminListSchedulesBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminListSchedulesBuilder SetUserId(string _userId)
            {
                UserId = _userId;
                return this;
            }





            public AdminListSchedules Build(
                string challengeCode,
                string namespace_
            )
            {
                AdminListSchedules op = new AdminListSchedules(this,
                    challengeCode,
                    namespace_
                );

                op.SetBaseFields<AdminListSchedulesBuilder>(this);
                return op;
            }

            public AdminListSchedules.Response Execute(
                string challengeCode,
                string namespace_
            )
            {
                AdminListSchedules op = Build(
                    challengeCode,
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
            public async Task<AdminListSchedules.Response> ExecuteAsync(
                string challengeCode,
                string namespace_
            )
            {
                AdminListSchedules op = Build(
                    challengeCode,
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

        private AdminListSchedules(AdminListSchedulesBuilder builder,
            string challengeCode,
            string namespace_
        )
        {
            PathParams["challengeCode"] = challengeCode;
            PathParams["namespace"] = namespace_;

            if (builder.DateTime != null)
                QueryParams["dateTime"] = builder.DateTime.Value.ToString("O", System.Globalization.CultureInfo.InvariantCulture);
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.UserId is not null) QueryParams["userId"] = builder.UserId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelListSchedulesResponse>
        {

            public IamErrorResponse? Error400 { get; set; } = null;

            public IamErrorResponse? Error401 { get; set; } = null;

            public IamErrorResponse? Error403 { get; set; } = null;

            public ResponseError? Error404 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Challenge::Schedules::AdminListSchedules";
        }

        #endregion

        public AdminListSchedules(
            string challengeCode,
            string namespace_,
            DateTime? dateTime,
            long? limit,
            long? offset,
            string? userId
        )
        {
            PathParams["challengeCode"] = challengeCode;
            PathParams["namespace"] = namespace_;

            if (dateTime != null)
                QueryParams["dateTime"] = dateTime.Value.ToString("O", System.Globalization.CultureInfo.InvariantCulture);
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (userId is not null) QueryParams["userId"] = userId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/challenge/v1/admin/namespaces/{namespace}/challenges/{challengeCode}/schedules";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public AdminListSchedules.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminListSchedules.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelListSchedulesResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<IamErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<IamErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<IamErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}