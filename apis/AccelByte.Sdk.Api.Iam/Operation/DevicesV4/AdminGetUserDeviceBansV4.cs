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
    /// AdminGetUserDeviceBansV4
    ///
    /// This is the endpoint for an admin to get device bans of user
    /// </summary>
    public class AdminGetUserDeviceBansV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetUserDeviceBansV4Builder Builder { get => new AdminGetUserDeviceBansV4Builder(); }

        public class AdminGetUserDeviceBansV4Builder
            : OperationBuilder<AdminGetUserDeviceBansV4Builder>
        {





            internal AdminGetUserDeviceBansV4Builder() { }

            internal AdminGetUserDeviceBansV4Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminGetUserDeviceBansV4 Build(
                string namespace_,
                string userId
            )
            {
                AdminGetUserDeviceBansV4 op = new AdminGetUserDeviceBansV4(this,
                    namespace_,
                    userId
                );

                op.SetBaseFields<AdminGetUserDeviceBansV4Builder>(this);
                return op;
            }

            public Model.ModelDeviceBansResponseV4? Execute(
                string namespace_,
                string userId
            )
            {
                AdminGetUserDeviceBansV4 op = Build(
                    namespace_,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.ModelDeviceBansResponseV4?> ExecuteAsync(
                string namespace_,
                string userId
            )
            {
                AdminGetUserDeviceBansV4 op = Build(
                    namespace_,
                    userId
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

        private AdminGetUserDeviceBansV4(AdminGetUserDeviceBansV4Builder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;

            if (userId is not null) QueryParams["userId"] = userId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetUserDeviceBansV4(
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;

            if (userId is not null) QueryParams["userId"] = userId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/admin/namespaces/{namespace}/devices/bans";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelDeviceBansResponseV4? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelDeviceBansResponseV4>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelDeviceBansResponseV4>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}