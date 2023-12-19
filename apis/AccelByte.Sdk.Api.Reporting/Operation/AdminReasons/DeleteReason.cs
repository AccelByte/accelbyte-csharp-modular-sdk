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
    /// deleteReason
    ///
    /// This endpoint delete a reason for a namespace with ID.
    /// </summary>
    public class DeleteReason : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteReasonBuilder Builder { get => new DeleteReasonBuilder(); }

        public class DeleteReasonBuilder
            : OperationBuilder<DeleteReasonBuilder>
        {





            internal DeleteReasonBuilder() { }

            internal DeleteReasonBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteReason Build(
                string namespace_,
                string reasonId
            )
            {
                DeleteReason op = new DeleteReason(this,
                    namespace_,
                    reasonId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
                string namespace_,
                string reasonId
            )
            {
                DeleteReason op = Build(
                    namespace_,
                    reasonId
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

        private DeleteReason(DeleteReasonBuilder builder,
            string namespace_,
            string reasonId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["reasonId"] = reasonId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteReason(
            string namespace_,
            string reasonId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["reasonId"] = reasonId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/reporting/v1/admin/namespaces/{namespace}/reasons/{reasonId}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}