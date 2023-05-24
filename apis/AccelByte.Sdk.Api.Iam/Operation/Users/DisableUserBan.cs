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
    /// DisableUserBan
    ///
    /// 
    /// 
    /// ## The endpoint is going to be deprecated
    /// 
    /// 
    /// Endpoint migration guide
    /// 
    /// 
    ///     * Substitute endpoint: /iam/v3/admin/namespaces/{namespace}/users/{userId}/bans/{banId} [PATCH]
    /// 
    /// 
    /// 
    /// 
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:BAN:USER:{userId} [UPDATE]'.
    /// "+
    /// "
    ///  Notes for using IAM in publisher - game studio scenarios
    /// "+
    /// "
    /// 
    /// The endpoint allows:
    /// 
    /// "+
    /// "
    ///     * The admin user in publisher namespace disables userâs ban in publisher namespace.
    /// "+
    /// "
    ///     * The admin user in game namespace disables userâs ban in game namespace.
    /// "+
    /// "
    ///     * The admin user in publisher namespace disables userâs ban in publisher namespace.
    /// "+
    /// "
    /// 
    /// Other scenarios are not supported and will return 403: Forbidden.
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class DisableUserBan : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DisableUserBanBuilder Builder { get => new DisableUserBanBuilder(); }

        public class DisableUserBanBuilder
            : OperationBuilder<DisableUserBanBuilder>
        {





            internal DisableUserBanBuilder() { }

            internal DisableUserBanBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DisableUserBan Build(
                string banId,
                string namespace_,
                string userId
            )
            {
                DisableUserBan op = new DisableUserBan(this,
                    banId,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public Model.ModelUserBanResponse? Execute(
                string banId,
                string namespace_,
                string userId
            )
            {
                DisableUserBan op = Build(
                    banId,
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
        }

        private DisableUserBan(DisableUserBanBuilder builder,
            string banId,
            string namespace_,
            string userId
        )
        {
            PathParams["banId"] = banId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DisableUserBan(
            string banId,
            string namespace_,
            string userId
        )
        {
            PathParams["banId"] = banId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/namespaces/{namespace}/users/{userId}/bans/{banId}/disable";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "*/*" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelUserBanResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelUserBanResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelUserBanResponse>(payload);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}