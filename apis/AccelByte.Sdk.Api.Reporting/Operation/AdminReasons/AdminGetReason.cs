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
    /// adminGetReason
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:REASON [READ]
    /// </summary>
    public class AdminGetReason : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetReasonBuilder Builder { get => new AdminGetReasonBuilder(); }

        public class AdminGetReasonBuilder
            : OperationBuilder<AdminGetReasonBuilder>
        {





            internal AdminGetReasonBuilder() { }

            internal AdminGetReasonBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminGetReason Build(
                string namespace_,
                string reasonId
            )
            {
                AdminGetReason op = new AdminGetReason(this,
                    namespace_,
                    reasonId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.RestapiAdminReasonResponse? Execute(
                string namespace_,
                string reasonId
            )
            {
                AdminGetReason op = Build(
                    namespace_,
                    reasonId
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

        private AdminGetReason(AdminGetReasonBuilder builder,
            string namespace_,
            string reasonId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["reasonId"] = reasonId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetReason(
            string namespace_,
            string reasonId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["reasonId"] = reasonId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/reporting/v1/admin/namespaces/{namespace}/reasons/{reasonId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.RestapiAdminReasonResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.RestapiAdminReasonResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.RestapiAdminReasonResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}