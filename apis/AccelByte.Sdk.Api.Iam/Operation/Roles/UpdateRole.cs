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

using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// UpdateRole
    ///
    /// ## The endpoint is going to be deprecated
    /// ### Endpoint migration guide
    /// - **Substitute endpoint: _/iam/v3/admin/roles/{roleId} [PATCH]_**
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class UpdateRole : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateRoleBuilder Builder { get => new UpdateRoleBuilder(); }

        public class UpdateRoleBuilder
            : OperationBuilder<UpdateRoleBuilder>
        {





            internal UpdateRoleBuilder() { }

            internal UpdateRoleBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdateRole Build(
                ModelRoleUpdateRequest body,
                string roleId
            )
            {
                UpdateRole op = new UpdateRole(this,
                    body,
                    roleId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public Model.ModelRoleResponse? Execute(
                ModelRoleUpdateRequest body,
                string roleId
            )
            {
                UpdateRole op = Build(
                    body,
                    roleId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private UpdateRole(UpdateRoleBuilder builder,
            ModelRoleUpdateRequest body,
            string roleId
        )
        {
            PathParams["roleId"] = roleId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateRole(
            string roleId,
            Model.ModelRoleUpdateRequest body
        )
        {
            PathParams["roleId"] = roleId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/roles/{roleId}";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelRoleResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelRoleResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelRoleResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}