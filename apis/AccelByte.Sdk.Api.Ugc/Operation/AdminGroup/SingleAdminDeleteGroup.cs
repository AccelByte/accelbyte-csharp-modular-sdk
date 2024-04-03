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

using AccelByte.Sdk.Api.Ugc.Model;

namespace AccelByte.Sdk.Api.Ugc.Operation
{
    /// <summary>
    /// SingleAdminDeleteGroup
    ///
    /// Delete group by group ID
    /// </summary>
    public class SingleAdminDeleteGroup : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SingleAdminDeleteGroupBuilder Builder { get => new SingleAdminDeleteGroupBuilder(); }

        public class SingleAdminDeleteGroupBuilder
            : OperationBuilder<SingleAdminDeleteGroupBuilder>
        {





            internal SingleAdminDeleteGroupBuilder() { }

            internal SingleAdminDeleteGroupBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public SingleAdminDeleteGroup Build(
                string groupId,
                string namespace_
            )
            {
                SingleAdminDeleteGroup op = new SingleAdminDeleteGroup(this,
                    groupId,
                    namespace_
                );

                op.SetBaseFields<SingleAdminDeleteGroupBuilder>(this);
                return op;
            }

            public void Execute(
                string groupId,
                string namespace_
            )
            {
                SingleAdminDeleteGroup op = Build(
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
            public async Task ExecuteAsync(
                string groupId,
                string namespace_
            )
            {
                SingleAdminDeleteGroup op = Build(
                    groupId,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private SingleAdminDeleteGroup(SingleAdminDeleteGroupBuilder builder,
            string groupId,
            string namespace_
        )
        {
            PathParams["groupId"] = groupId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public SingleAdminDeleteGroup(
            string groupId,
            string namespace_
        )
        {
            PathParams["groupId"] = groupId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v1/admin/namespaces/{namespace}/groups/{groupId}";

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