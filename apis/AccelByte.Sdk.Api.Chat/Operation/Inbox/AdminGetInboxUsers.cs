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

using AccelByte.Sdk.Api.Chat.Model;

namespace AccelByte.Sdk.Api.Chat.Operation
{
    /// <summary>
    /// adminGetInboxUsers
    ///
    /// Get inbox users
    /// </summary>
    public class AdminGetInboxUsers : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetInboxUsersBuilder Builder { get => new AdminGetInboxUsersBuilder(); }

        public class AdminGetInboxUsersBuilder
            : OperationBuilder<AdminGetInboxUsersBuilder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public AdminGetInboxUsersStatus? Status { get; set; }

            public string? UserId { get; set; }





            internal AdminGetInboxUsersBuilder() { }

            internal AdminGetInboxUsersBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminGetInboxUsersBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminGetInboxUsersBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminGetInboxUsersBuilder SetStatus(AdminGetInboxUsersStatus _status)
            {
                Status = _status;
                return this;
            }

            public AdminGetInboxUsersBuilder SetUserId(string _userId)
            {
                UserId = _userId;
                return this;
            }





            public AdminGetInboxUsers Build(
                string inbox,
                string namespace_
            )
            {
                AdminGetInboxUsers op = new AdminGetInboxUsers(this,
                    inbox,
                    namespace_
                );

                op.SetBaseFields<AdminGetInboxUsersBuilder>(this);
                return op;
            }

            public Model.ModelsGetInboxUsersResponse? Execute(
                string inbox,
                string namespace_
            )
            {
                AdminGetInboxUsers op = Build(
                    inbox,
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
            public async Task<Model.ModelsGetInboxUsersResponse?> ExecuteAsync(
                string inbox,
                string namespace_
            )
            {
                AdminGetInboxUsers op = Build(
                    inbox,
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

        private AdminGetInboxUsers(AdminGetInboxUsersBuilder builder,
            string inbox,
            string namespace_
        )
        {
            PathParams["inbox"] = inbox;
            PathParams["namespace"] = namespace_;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Status is not null) QueryParams["status"] = builder.Status.Value;
            if (builder.UserId is not null) QueryParams["userId"] = builder.UserId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetInboxUsers(
            string inbox,
            string namespace_,
            long? limit,
            long? offset,
            AdminGetInboxUsersStatus? status,
            string? userId
        )
        {
            PathParams["inbox"] = inbox;
            PathParams["namespace"] = namespace_;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (status is not null) QueryParams["status"] = status.Value;
            if (userId is not null) QueryParams["userId"] = userId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/chat/v1/admin/inbox/namespaces/{namespace}/messages/{inbox}/users";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsGetInboxUsersResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetInboxUsersResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetInboxUsersResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

    public class AdminGetInboxUsersStatus : StringEnum<AdminGetInboxUsersStatus>
    {
        public static readonly AdminGetInboxUsersStatus READ
            = new AdminGetInboxUsersStatus("READ");

        public static readonly AdminGetInboxUsersStatus UNREAD
            = new AdminGetInboxUsersStatus("UNREAD");


        public static implicit operator AdminGetInboxUsersStatus(string value)
        {
            return NewValue(value);
        }

        public AdminGetInboxUsersStatus(string enumValue)
            : base(enumValue)
        {

        }
    }

}