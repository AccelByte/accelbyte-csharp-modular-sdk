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
    /// PublicUpgradeHeadlessAccountV4
    ///
    /// Upgrade headless account to full account without verifying email address. Client does not need to provide verification code which sent to email address.
    /// action code : 10124
    /// </summary>
    public class PublicUpgradeHeadlessAccountV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicUpgradeHeadlessAccountV4Builder Builder { get => new PublicUpgradeHeadlessAccountV4Builder(); }

        public class PublicUpgradeHeadlessAccountV4Builder
            : OperationBuilder<PublicUpgradeHeadlessAccountV4Builder>
        {





            internal PublicUpgradeHeadlessAccountV4Builder() { }

            internal PublicUpgradeHeadlessAccountV4Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicUpgradeHeadlessAccountV4 Build(
                AccountUpgradeHeadlessAccountRequestV4 body,
                string namespace_
            )
            {
                PublicUpgradeHeadlessAccountV4 op = new PublicUpgradeHeadlessAccountV4(this,
                    body,
                    namespace_
                );

                op.SetBaseFields<PublicUpgradeHeadlessAccountV4Builder>(this);
                return op;
            }

            public Model.AccountUserResponseV4? Execute(
                AccountUpgradeHeadlessAccountRequestV4 body,
                string namespace_
            )
            {
                PublicUpgradeHeadlessAccountV4 op = Build(
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
            public async Task<Model.AccountUserResponseV4?> ExecuteAsync(
                AccountUpgradeHeadlessAccountRequestV4 body,
                string namespace_
            )
            {
                PublicUpgradeHeadlessAccountV4 op = Build(
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

        private PublicUpgradeHeadlessAccountV4(PublicUpgradeHeadlessAccountV4Builder builder,
            AccountUpgradeHeadlessAccountRequestV4 body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicUpgradeHeadlessAccountV4(
            string namespace_,
            Model.AccountUpgradeHeadlessAccountRequestV4 body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/public/namespaces/{namespace}/users/me/headless/verify";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.AccountUserResponseV4? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.AccountUserResponseV4>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.AccountUserResponseV4>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}