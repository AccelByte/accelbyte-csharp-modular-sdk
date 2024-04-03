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
    /// AdminGetListBanReasonV3
    ///
    /// Ban reasons is the code available to justify ban assignment. It is applicable globally for any namespace.
    /// action code : 10202
    /// </summary>
    public class AdminGetListBanReasonV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetListBanReasonV3Builder Builder { get => new AdminGetListBanReasonV3Builder(); }

        public class AdminGetListBanReasonV3Builder
            : OperationBuilder<AdminGetListBanReasonV3Builder>
        {





            internal AdminGetListBanReasonV3Builder() { }

            internal AdminGetListBanReasonV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminGetListBanReasonV3 Build(
            )
            {
                AdminGetListBanReasonV3 op = new AdminGetListBanReasonV3(this
                );

                op.SetBaseFields<AdminGetListBanReasonV3Builder>(this);
                return op;
            }

            public Model.AccountcommonBanReasonsV3? Execute(
            )
            {
                AdminGetListBanReasonV3 op = Build(
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.AccountcommonBanReasonsV3?> ExecuteAsync(
            )
            {
                AdminGetListBanReasonV3 op = Build(
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

        private AdminGetListBanReasonV3(AdminGetListBanReasonV3Builder builder
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetListBanReasonV3(
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/bans/reasons";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.AccountcommonBanReasonsV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.AccountcommonBanReasonsV3>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.AccountcommonBanReasonsV3>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}