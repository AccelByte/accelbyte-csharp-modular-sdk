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

using AccelByte.Sdk.Api.Cloudsave.Model;

namespace AccelByte.Sdk.Api.Cloudsave.Operation
{
    /// <summary>
    /// adminDeleteGameBinaryRecordV1
    ///
    /// Delete a game binary record.
    /// </summary>
    public class AdminDeleteGameBinaryRecordV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeleteGameBinaryRecordV1Builder Builder { get => new AdminDeleteGameBinaryRecordV1Builder(); }

        public class AdminDeleteGameBinaryRecordV1Builder
            : OperationBuilder<AdminDeleteGameBinaryRecordV1Builder>
        {





            internal AdminDeleteGameBinaryRecordV1Builder() { }

            internal AdminDeleteGameBinaryRecordV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminDeleteGameBinaryRecordV1 Build(
                string key,
                string namespace_
            )
            {
                AdminDeleteGameBinaryRecordV1 op = new AdminDeleteGameBinaryRecordV1(this,
                    key,
                    namespace_
                );

                op.SetBaseFields<AdminDeleteGameBinaryRecordV1Builder>(this);
                return op;
            }

            public void Execute(
                string key,
                string namespace_
            )
            {
                AdminDeleteGameBinaryRecordV1 op = Build(
                    key,
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

        private AdminDeleteGameBinaryRecordV1(AdminDeleteGameBinaryRecordV1Builder builder,
            string key,
            string namespace_
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminDeleteGameBinaryRecordV1(
            string key,
            string namespace_
        )
        {
            PathParams["key"] = key;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/cloudsave/v1/admin/namespaces/{namespace}/binaries/{key}";

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