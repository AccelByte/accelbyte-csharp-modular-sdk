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

using AccelByte.Sdk.Api.Platform.Model;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// getPlatformEntitlementConfig
    ///
    /// Get platform entitlement config list.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:ENTITLEMENT:CONFIG", action=2 (READ)
    ///   *  Returns : entitlement info
    /// </summary>
    public class GetPlatformEntitlementConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetPlatformEntitlementConfigBuilder Builder { get => new GetPlatformEntitlementConfigBuilder(); }

        public class GetPlatformEntitlementConfigBuilder
            : OperationBuilder<GetPlatformEntitlementConfigBuilder>
        {





            internal GetPlatformEntitlementConfigBuilder() { }

            internal GetPlatformEntitlementConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetPlatformEntitlementConfig Build(
                string namespace_,
                GetPlatformEntitlementConfigPlatform platform
            )
            {
                GetPlatformEntitlementConfig op = new GetPlatformEntitlementConfig(this,
                    namespace_,
                    platform
                );

                op.SetBaseFields<GetPlatformEntitlementConfigBuilder>(this);
                return op;
            }

            public Model.EntitlementPlatformConfigInfo? Execute(
                string namespace_,
                string platform
            )
            {
                GetPlatformEntitlementConfig op = Build(
                    namespace_,
                    platform
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.EntitlementPlatformConfigInfo?> ExecuteAsync(
                string namespace_,
                string platform
            )
            {
                GetPlatformEntitlementConfig op = Build(
                    namespace_,
                    platform
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

        private GetPlatformEntitlementConfig(GetPlatformEntitlementConfigBuilder builder,
            string namespace_,
            GetPlatformEntitlementConfigPlatform platform
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platform"] = platform.Value;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetPlatformEntitlementConfig(
            string namespace_,
            GetPlatformEntitlementConfigPlatform platform
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platform"] = platform.Value;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/platforms/{platform}/entitlement/config";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.EntitlementPlatformConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.EntitlementPlatformConfigInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.EntitlementPlatformConfigInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

    public class GetPlatformEntitlementConfigPlatform : StringEnum<GetPlatformEntitlementConfigPlatform>
    {
        public static readonly GetPlatformEntitlementConfigPlatform Epic
            = new GetPlatformEntitlementConfigPlatform("Epic");

        public static readonly GetPlatformEntitlementConfigPlatform GooglePlay
            = new GetPlatformEntitlementConfigPlatform("GooglePlay");

        public static readonly GetPlatformEntitlementConfigPlatform IOS
            = new GetPlatformEntitlementConfigPlatform("IOS");

        public static readonly GetPlatformEntitlementConfigPlatform Nintendo
            = new GetPlatformEntitlementConfigPlatform("Nintendo");

        public static readonly GetPlatformEntitlementConfigPlatform Oculus
            = new GetPlatformEntitlementConfigPlatform("Oculus");

        public static readonly GetPlatformEntitlementConfigPlatform Other
            = new GetPlatformEntitlementConfigPlatform("Other");

        public static readonly GetPlatformEntitlementConfigPlatform Playstation
            = new GetPlatformEntitlementConfigPlatform("Playstation");

        public static readonly GetPlatformEntitlementConfigPlatform Steam
            = new GetPlatformEntitlementConfigPlatform("Steam");

        public static readonly GetPlatformEntitlementConfigPlatform Xbox
            = new GetPlatformEntitlementConfigPlatform("Xbox");


        public static implicit operator GetPlatformEntitlementConfigPlatform(string value)
        {
            return NewValue(value);
        }

        public GetPlatformEntitlementConfigPlatform(string enumValue)
            : base(enumValue)
        {

        }
    }

}