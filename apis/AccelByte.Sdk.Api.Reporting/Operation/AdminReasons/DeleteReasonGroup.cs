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
    /// deleteReasonGroup
    ///
    /// This endpoint delete a reason group for a namespace with ID.
    /// </summary>
    public class DeleteReasonGroup : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteReasonGroupBuilder Builder { get => new DeleteReasonGroupBuilder(); }

        public class DeleteReasonGroupBuilder
            : OperationBuilder<DeleteReasonGroupBuilder>
        {





            internal DeleteReasonGroupBuilder() { }

            internal DeleteReasonGroupBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteReasonGroup Build(
                string groupId,
                string namespace_
            )
            {
                DeleteReasonGroup op = new DeleteReasonGroup(this,
                    groupId,
                    namespace_
                );

                op.SetBaseFields<DeleteReasonGroupBuilder>(this);
                return op;
            }

            public void Execute(
                string groupId,
                string namespace_
            )
            {
                DeleteReasonGroup op = Build(
                    groupId,
                    namespace_
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

        private DeleteReasonGroup(DeleteReasonGroupBuilder builder,
            string groupId,
            string namespace_
        )
        {
            PathParams["groupId"] = groupId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteReasonGroup(
            string groupId,
            string namespace_
        )
        {
            PathParams["groupId"] = groupId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/reporting/v1/admin/namespaces/{namespace}/reasonGroups/{groupId}";

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