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
    /// AdminGetUserByEmailAddressV3
    ///
    /// This endpoint search user who owns the given email address
    /// action code : 10132
    /// </summary>
    public class AdminGetUserByEmailAddressV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetUserByEmailAddressV3Builder Builder { get => new AdminGetUserByEmailAddressV3Builder(); }

        public class AdminGetUserByEmailAddressV3Builder
            : OperationBuilder<AdminGetUserByEmailAddressV3Builder>
        {

            public string? EmailAddress { get; set; }





            internal AdminGetUserByEmailAddressV3Builder() { }

            internal AdminGetUserByEmailAddressV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminGetUserByEmailAddressV3Builder SetEmailAddress(string _emailAddress)
            {
                EmailAddress = _emailAddress;
                return this;
            }





            public AdminGetUserByEmailAddressV3 Build(
                string namespace_
            )
            {
                AdminGetUserByEmailAddressV3 op = new AdminGetUserByEmailAddressV3(this,
                    namespace_
                );

                op.SetBaseFields<AdminGetUserByEmailAddressV3Builder>(this);
                return op;
            }

            public Model.ModelUserResponseV3? Execute(
                string namespace_
            )
            {
                AdminGetUserByEmailAddressV3 op = Build(
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
            public async Task<Model.ModelUserResponseV3?> ExecuteAsync(
                string namespace_
            )
            {
                AdminGetUserByEmailAddressV3 op = Build(
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

        private AdminGetUserByEmailAddressV3(AdminGetUserByEmailAddressV3Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.EmailAddress is not null) QueryParams["emailAddress"] = builder.EmailAddress;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetUserByEmailAddressV3(
            string namespace_,
            string? emailAddress
        )
        {
            PathParams["namespace"] = namespace_;

            if (emailAddress is not null) QueryParams["emailAddress"] = emailAddress;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelUserResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelUserResponseV3>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelUserResponseV3>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}