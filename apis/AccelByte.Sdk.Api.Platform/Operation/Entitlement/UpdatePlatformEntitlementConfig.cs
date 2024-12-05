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
    /// updatePlatformEntitlementConfig
    ///
    /// Update platform entitlement config.
    /// Other detail info:
    /// 
    ///   * Returns : platform entitlement config
    /// </summary>
    public class UpdatePlatformEntitlementConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdatePlatformEntitlementConfigBuilder Builder { get => new UpdatePlatformEntitlementConfigBuilder(); }

        public class UpdatePlatformEntitlementConfigBuilder
            : OperationBuilder<UpdatePlatformEntitlementConfigBuilder>
        {





            internal UpdatePlatformEntitlementConfigBuilder() { }

            internal UpdatePlatformEntitlementConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdatePlatformEntitlementConfig Build(
                EntitlementPlatformConfigUpdate body,
                string namespace_,
                UpdatePlatformEntitlementConfigPlatform platform
            )
            {
                UpdatePlatformEntitlementConfig op = new UpdatePlatformEntitlementConfig(this,
                    body,
                    namespace_,
                    platform
                );

                op.SetBaseFields<UpdatePlatformEntitlementConfigBuilder>(this);
                return op;
            }

            public UpdatePlatformEntitlementConfig.Response Execute(
                EntitlementPlatformConfigUpdate body,
                string namespace_,
                string platform
            )
            {
                UpdatePlatformEntitlementConfig op = Build(
                    body,
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
            public async Task<UpdatePlatformEntitlementConfig.Response> ExecuteAsync(
                EntitlementPlatformConfigUpdate body,
                string namespace_,
                string platform
            )
            {
                UpdatePlatformEntitlementConfig op = Build(
                    body,
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

        private UpdatePlatformEntitlementConfig(UpdatePlatformEntitlementConfigBuilder builder,
            EntitlementPlatformConfigUpdate body,
            string namespace_,
            UpdatePlatformEntitlementConfigPlatform platform
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platform"] = platform.Value;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.EntitlementPlatformConfigInfo>
        {

            public ErrorEntity? Error404 { get; set; } = null;


            protected override string GetFullOperationId() => "Platform::Entitlement::UpdatePlatformEntitlementConfig";
        }

        #endregion

        public UpdatePlatformEntitlementConfig(
            string namespace_,
            UpdatePlatformEntitlementConfigPlatform platform,
            Model.EntitlementPlatformConfigUpdate body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platform"] = platform.Value;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/platforms/{platform}/entitlement/config";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public UpdatePlatformEntitlementConfig.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new UpdatePlatformEntitlementConfig.Response()
            {
                StatusCode = code,
                ContentType = contentType
            };

            if (code == (HttpStatusCode)204)
            {
                response.IsSuccess = true;
            }
            else if ((code == (HttpStatusCode)201) || (code == (HttpStatusCode)202) || (code == (HttpStatusCode)200))
            {
                response.Data = JsonSerializer.Deserialize<Model.EntitlementPlatformConfigInfo>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }

            return response;
        }
    }

    public class UpdatePlatformEntitlementConfigPlatform : StringEnum<UpdatePlatformEntitlementConfigPlatform>
    {
        public static readonly UpdatePlatformEntitlementConfigPlatform Epic
            = new UpdatePlatformEntitlementConfigPlatform("Epic");

        public static readonly UpdatePlatformEntitlementConfigPlatform GooglePlay
            = new UpdatePlatformEntitlementConfigPlatform("GooglePlay");

        public static readonly UpdatePlatformEntitlementConfigPlatform IOS
            = new UpdatePlatformEntitlementConfigPlatform("IOS");

        public static readonly UpdatePlatformEntitlementConfigPlatform Nintendo
            = new UpdatePlatformEntitlementConfigPlatform("Nintendo");

        public static readonly UpdatePlatformEntitlementConfigPlatform Oculus
            = new UpdatePlatformEntitlementConfigPlatform("Oculus");

        public static readonly UpdatePlatformEntitlementConfigPlatform Other
            = new UpdatePlatformEntitlementConfigPlatform("Other");

        public static readonly UpdatePlatformEntitlementConfigPlatform Playstation
            = new UpdatePlatformEntitlementConfigPlatform("Playstation");

        public static readonly UpdatePlatformEntitlementConfigPlatform Steam
            = new UpdatePlatformEntitlementConfigPlatform("Steam");

        public static readonly UpdatePlatformEntitlementConfigPlatform Xbox
            = new UpdatePlatformEntitlementConfigPlatform("Xbox");


        public static implicit operator UpdatePlatformEntitlementConfigPlatform(string value)
        {
            return NewValue(value);
        }

        public UpdatePlatformEntitlementConfigPlatform(string enumValue)
            : base(enumValue)
        {

        }
    }

}