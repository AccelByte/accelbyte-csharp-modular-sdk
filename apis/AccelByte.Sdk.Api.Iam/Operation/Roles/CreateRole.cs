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
    /// CreateRole
    ///
    /// ## The endpoint is going to be deprecated
    /// Role can only be assigned to other users by the role's manager.
    /// 
    /// If role is an administrator role (i.e. AdminRole == true), it will list out the role's members.
    /// 
    /// Administrator role can be created only when at least 1 manager is specified.
    /// ### Endpoint migration guide
    /// - **Substitute endpoint: _/iam/v3/admin/roles [POST]_**
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class CreateRole : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateRoleBuilder Builder { get => new CreateRoleBuilder(); }

        public class CreateRoleBuilder
            : OperationBuilder<CreateRoleBuilder>
        {





            internal CreateRoleBuilder() { }

            internal CreateRoleBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public CreateRole Build(
                ModelRoleCreateRequest body
            )
            {
                CreateRole op = new CreateRole(this,
                    body
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public Model.AccountcommonRole? Execute(
                ModelRoleCreateRequest body
            )
            {
                CreateRole op = Build(
                    body
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

        private CreateRole(CreateRoleBuilder builder,
            ModelRoleCreateRequest body
        )
        {





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreateRole(
            Model.ModelRoleCreateRequest body
        )
        {





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/roles";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.AccountcommonRole? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.AccountcommonRole>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.AccountcommonRole>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}