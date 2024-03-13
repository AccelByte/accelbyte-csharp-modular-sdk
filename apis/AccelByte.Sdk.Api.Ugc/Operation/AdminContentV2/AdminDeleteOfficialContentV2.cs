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

using AccelByte.Sdk.Api.Ugc.Model;

namespace AccelByte.Sdk.Api.Ugc.Operation
{
    /// <summary>
    /// AdminDeleteOfficialContentV2
    ///
    /// Delete existing official content
    /// </summary>
    public class AdminDeleteOfficialContentV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeleteOfficialContentV2Builder Builder { get => new AdminDeleteOfficialContentV2Builder(); }

        public class AdminDeleteOfficialContentV2Builder
            : OperationBuilder<AdminDeleteOfficialContentV2Builder>
        {





            internal AdminDeleteOfficialContentV2Builder() { }

            internal AdminDeleteOfficialContentV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminDeleteOfficialContentV2 Build(
                string channelId,
                string contentId,
                string namespace_
            )
            {
                AdminDeleteOfficialContentV2 op = new AdminDeleteOfficialContentV2(this,
                    channelId,
                    contentId,
                    namespace_
                );

                op.SetBaseFields<AdminDeleteOfficialContentV2Builder>(this);
                return op;
            }

            public void Execute(
                string channelId,
                string contentId,
                string namespace_
            )
            {
                AdminDeleteOfficialContentV2 op = Build(
                    channelId,
                    contentId,
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

        private AdminDeleteOfficialContentV2(AdminDeleteOfficialContentV2Builder builder,
            string channelId,
            string contentId,
            string namespace_
        )
        {
            PathParams["channelId"] = channelId;
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminDeleteOfficialContentV2(
            string channelId,
            string contentId,
            string namespace_
        )
        {
            PathParams["channelId"] = channelId;
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v2/admin/namespaces/{namespace}/channels/{channelId}/contents/{contentId}";

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