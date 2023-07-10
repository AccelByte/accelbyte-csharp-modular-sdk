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

using AccelByte.Sdk.Api.Basic.Model;

namespace AccelByte.Sdk.Api.Basic.Operation
{
    /// <summary>
    /// getConfig_1
    ///
    /// Get a config.
    /// Other detail info:
    /// 
    ///   * Required permission : resource= "ADMIN:NAMESPACE:{namespace}:BASIC:CONFIG" , action=2 (READ)
    ///   *  Returns : config
    /// </summary>
    public class GetConfig1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetConfig1Builder Builder { get => new GetConfig1Builder(); }

        public class GetConfig1Builder
            : OperationBuilder<GetConfig1Builder>
        {





            internal GetConfig1Builder() { }

            internal GetConfig1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetConfig1 Build(
                string configKey,
                string namespace_
            )
            {
                GetConfig1 op = new GetConfig1(this,
                    configKey,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ConfigInfo? Execute(
                string configKey,
                string namespace_
            )
            {
                GetConfig1 op = Build(
                    configKey,
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
        }

        private GetConfig1(GetConfig1Builder builder,
            string configKey,
            string namespace_
        )
        {
            PathParams["configKey"] = configKey;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetConfig1(
            string configKey,
            string namespace_
        )
        {
            PathParams["configKey"] = configKey;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/basic/v1/admin/namespaces/{namespace}/configs/{configKey}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.ConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ConfigInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ConfigInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}