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

using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// AdminGetNamespaceUserInvitationHistoryV4
    ///
    /// This endpoint is to Get list of users Invitation History for specific new studio namespace in multi tenant mode.
    /// It will return error if the service multi tenant mode is set to false.
    /// Accepted Query:
    /// - offset
    /// - limit
    /// </summary>
    public class AdminGetNamespaceUserInvitationHistoryV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetNamespaceUserInvitationHistoryV4Builder Builder { get => new AdminGetNamespaceUserInvitationHistoryV4Builder(); }

        public class AdminGetNamespaceUserInvitationHistoryV4Builder
            : OperationBuilder<AdminGetNamespaceUserInvitationHistoryV4Builder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }





            internal AdminGetNamespaceUserInvitationHistoryV4Builder() { }

            internal AdminGetNamespaceUserInvitationHistoryV4Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminGetNamespaceUserInvitationHistoryV4Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminGetNamespaceUserInvitationHistoryV4Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public AdminGetNamespaceUserInvitationHistoryV4 Build(
                string namespace_
            )
            {
                AdminGetNamespaceUserInvitationHistoryV4 op = new AdminGetNamespaceUserInvitationHistoryV4(this,
                    namespace_
                );

                op.SetBaseFields<AdminGetNamespaceUserInvitationHistoryV4Builder>(this);
                return op;
            }

            public Model.ModelNamespaceInvitationHistoryUserV4Response? Execute(
                string namespace_
            )
            {
                AdminGetNamespaceUserInvitationHistoryV4 op = Build(
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
            public async Task<Model.ModelNamespaceInvitationHistoryUserV4Response?> ExecuteAsync(
                string namespace_
            )
            {
                AdminGetNamespaceUserInvitationHistoryV4 op = Build(
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

        private AdminGetNamespaceUserInvitationHistoryV4(AdminGetNamespaceUserInvitationHistoryV4Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetNamespaceUserInvitationHistoryV4(
            string namespace_,
            long? limit,
            long? offset
        )
        {
            PathParams["namespace"] = namespace_;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/admin/namespaces/{namespace}/invitationHistories/users";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelNamespaceInvitationHistoryUserV4Response? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelNamespaceInvitationHistoryUserV4Response>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelNamespaceInvitationHistoryUserV4Response>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}