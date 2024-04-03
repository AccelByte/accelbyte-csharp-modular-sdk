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
    /// updateReason
    ///
    /// This endpoint update a reason for a namespace with ID.
    /// </summary>
    public class UpdateReason : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateReasonBuilder Builder { get => new UpdateReasonBuilder(); }

        public class UpdateReasonBuilder
            : OperationBuilder<UpdateReasonBuilder>
        {





            internal UpdateReasonBuilder() { }

            internal UpdateReasonBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdateReason Build(
                RestapiCreateReasonRequest body,
                string namespace_,
                string reasonId
            )
            {
                UpdateReason op = new UpdateReason(this,
                    body,
                    namespace_,
                    reasonId
                );

                op.SetBaseFields<UpdateReasonBuilder>(this);
                return op;
            }

            public Model.RestapiAdminReasonResponse? Execute(
                RestapiCreateReasonRequest body,
                string namespace_,
                string reasonId
            )
            {
                UpdateReason op = Build(
                    body,
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
            public async Task<Model.RestapiAdminReasonResponse?> ExecuteAsync(
                RestapiCreateReasonRequest body,
                string namespace_,
                string reasonId
            )
            {
                UpdateReason op = Build(
                    body,
                    namespace_,
                    reasonId
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

        private UpdateReason(UpdateReasonBuilder builder,
            RestapiCreateReasonRequest body,
            string namespace_,
            string reasonId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["reasonId"] = reasonId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateReason(
            string namespace_,
            string reasonId,
            Model.RestapiCreateReasonRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["reasonId"] = reasonId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/reporting/v1/admin/namespaces/{namespace}/reasons/{reasonId}";

        public override HttpMethod Method => HttpMethod.Patch;

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