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
    /// AdminGetRoleOverrideConfigV3
    ///
    /// Get role override config.
    /// This API has upsert behavior, if there is no config yet, it will create a new one with inactive status.
    /// </summary>
    public class AdminGetRoleOverrideConfigV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetRoleOverrideConfigV3Builder Builder { get => new AdminGetRoleOverrideConfigV3Builder(); }

        public class AdminGetRoleOverrideConfigV3Builder
            : OperationBuilder<AdminGetRoleOverrideConfigV3Builder>
        {





            internal AdminGetRoleOverrideConfigV3Builder() { }

            internal AdminGetRoleOverrideConfigV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminGetRoleOverrideConfigV3 Build(
                string namespace_,
                AdminGetRoleOverrideConfigV3Identity identity
            )
            {
                AdminGetRoleOverrideConfigV3 op = new AdminGetRoleOverrideConfigV3(this,
                    namespace_,
                    identity
                );

                op.SetBaseFields<AdminGetRoleOverrideConfigV3Builder>(this);
                return op;
            }

            public Model.ModelRoleOverrideResponse? Execute(
                string namespace_,
                string identity
            )
            {
                AdminGetRoleOverrideConfigV3 op = Build(
                    namespace_,
                    identity
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.ModelRoleOverrideResponse?> ExecuteAsync(
                string namespace_,
                string identity
            )
            {
                AdminGetRoleOverrideConfigV3 op = Build(
                    namespace_,
                    identity
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

        private AdminGetRoleOverrideConfigV3(AdminGetRoleOverrideConfigV3Builder builder,
            string namespace_,
            AdminGetRoleOverrideConfigV3Identity identity
        )
        {
            PathParams["namespace"] = namespace_;

            if (identity is not null) QueryParams["identity"] = identity.Value;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetRoleOverrideConfigV3(
            string namespace_,
            AdminGetRoleOverrideConfigV3Identity identity
        )
        {
            PathParams["namespace"] = namespace_;

            if (identity is not null) QueryParams["identity"] = identity.Value;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/roleoverride";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelRoleOverrideResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelRoleOverrideResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelRoleOverrideResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

    public class AdminGetRoleOverrideConfigV3Identity : StringEnum<AdminGetRoleOverrideConfigV3Identity>
    {
        public static readonly AdminGetRoleOverrideConfigV3Identity GAMEADMIN
            = new AdminGetRoleOverrideConfigV3Identity("GAME_ADMIN");

        public static readonly AdminGetRoleOverrideConfigV3Identity USER
            = new AdminGetRoleOverrideConfigV3Identity("USER");

        public static readonly AdminGetRoleOverrideConfigV3Identity VIEWONLY
            = new AdminGetRoleOverrideConfigV3Identity("VIEW_ONLY");


        public static implicit operator AdminGetRoleOverrideConfigV3Identity(string value)
        {
            return NewValue(value);
        }

        public AdminGetRoleOverrideConfigV3Identity(string enumValue)
            : base(enumValue)
        {

        }
    }

}