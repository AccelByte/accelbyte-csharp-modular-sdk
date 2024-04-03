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
    /// AdminBanDeviceV4
    ///
    /// This is the endpoint for an admin to ban a device
    /// </summary>
    public class AdminBanDeviceV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminBanDeviceV4Builder Builder { get => new AdminBanDeviceV4Builder(); }

        public class AdminBanDeviceV4Builder
            : OperationBuilder<AdminBanDeviceV4Builder>
        {





            internal AdminBanDeviceV4Builder() { }

            internal AdminBanDeviceV4Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminBanDeviceV4 Build(
                ModelDeviceBanRequestV4 body,
                string namespace_
            )
            {
                AdminBanDeviceV4 op = new AdminBanDeviceV4(this,
                    body,
                    namespace_
                );

                op.SetBaseFields<AdminBanDeviceV4Builder>(this);
                return op;
            }

            public void Execute(
                ModelDeviceBanRequestV4 body,
                string namespace_
            )
            {
                AdminBanDeviceV4 op = Build(
                    body,
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
                ModelDeviceBanRequestV4 body,
                string namespace_
            )
            {
                AdminBanDeviceV4 op = Build(
                    body,
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

        private AdminBanDeviceV4(AdminBanDeviceV4Builder builder,
            ModelDeviceBanRequestV4 body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminBanDeviceV4(
            string namespace_,
            Model.ModelDeviceBanRequestV4 body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/admin/namespaces/{namespace}/devices/bans";

        public override HttpMethod Method => HttpMethod.Post;

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