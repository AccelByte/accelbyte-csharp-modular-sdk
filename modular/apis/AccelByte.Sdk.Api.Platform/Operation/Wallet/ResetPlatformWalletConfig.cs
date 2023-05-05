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

using AccelByte.Sdk.Api.Platform.Model;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// resetPlatformWalletConfig
    ///
    /// Reset platform wallet config to default config.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:WALLET:CONFIG", action=4 (UPDATE)
    ///   *  Returns : platform wallet config
    /// </summary>
    public class ResetPlatformWalletConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ResetPlatformWalletConfigBuilder Builder { get => new ResetPlatformWalletConfigBuilder(); }

        public class ResetPlatformWalletConfigBuilder
            : OperationBuilder<ResetPlatformWalletConfigBuilder>
        {





            internal ResetPlatformWalletConfigBuilder() { }

            internal ResetPlatformWalletConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public ResetPlatformWalletConfig Build(
                string namespace_,
                ResetPlatformWalletConfigPlatform platform
            )
            {
                ResetPlatformWalletConfig op = new ResetPlatformWalletConfig(this,
                    namespace_,                    
                    platform                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.PlatformWalletConfigInfo? Execute(
                string namespace_,
                string platform
            )
            {
                ResetPlatformWalletConfig op = Build(
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
        }

        private ResetPlatformWalletConfig(ResetPlatformWalletConfigBuilder builder,
            string namespace_,
            ResetPlatformWalletConfigPlatform platform
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platform"] = platform.Value;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ResetPlatformWalletConfig(
            string namespace_,            
            ResetPlatformWalletConfigPlatform platform            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platform"] = platform.Value;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/platforms/{platform}/wallet/config/reset";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.PlatformWalletConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.PlatformWalletConfigInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.PlatformWalletConfigInfo>(payload);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

    public class ResetPlatformWalletConfigPlatform : StringEnum<ResetPlatformWalletConfigPlatform>
    {
        public static readonly ResetPlatformWalletConfigPlatform Epic
            = new ResetPlatformWalletConfigPlatform("Epic");

        public static readonly ResetPlatformWalletConfigPlatform GooglePlay
            = new ResetPlatformWalletConfigPlatform("GooglePlay");

        public static readonly ResetPlatformWalletConfigPlatform IOS
            = new ResetPlatformWalletConfigPlatform("IOS");

        public static readonly ResetPlatformWalletConfigPlatform Nintendo
            = new ResetPlatformWalletConfigPlatform("Nintendo");

        public static readonly ResetPlatformWalletConfigPlatform Other
            = new ResetPlatformWalletConfigPlatform("Other");

        public static readonly ResetPlatformWalletConfigPlatform Playstation
            = new ResetPlatformWalletConfigPlatform("Playstation");

        public static readonly ResetPlatformWalletConfigPlatform Steam
            = new ResetPlatformWalletConfigPlatform("Steam");

        public static readonly ResetPlatformWalletConfigPlatform Xbox
            = new ResetPlatformWalletConfigPlatform("Xbox");


        public static implicit operator ResetPlatformWalletConfigPlatform(string value)
        {
            return NewValue(value);
        }

        public ResetPlatformWalletConfigPlatform(string enumValue)
            : base(enumValue)
        {

        }
    }

}