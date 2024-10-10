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
    /// getAppleConfigVersion
    ///
    /// Get apple config version.
    /// </summary>
    public class GetAppleConfigVersion : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetAppleConfigVersionBuilder Builder { get => new GetAppleConfigVersionBuilder(); }

        public class GetAppleConfigVersionBuilder
            : OperationBuilder<GetAppleConfigVersionBuilder>
        {





            internal GetAppleConfigVersionBuilder() { }

            internal GetAppleConfigVersionBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetAppleConfigVersion Build(
                string namespace_
            )
            {
                GetAppleConfigVersion op = new GetAppleConfigVersion(this,
                    namespace_
                );

                op.SetBaseFields<GetAppleConfigVersionBuilder>(this);
                return op;
            }

            public Model.AppleIAPConfigVersionInfo? Execute(
                string namespace_
            )
            {
                GetAppleConfigVersion op = Build(
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
            public async Task<Model.AppleIAPConfigVersionInfo?> ExecuteAsync(
                string namespace_
            )
            {
                GetAppleConfigVersion op = Build(
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

        private GetAppleConfigVersion(GetAppleConfigVersionBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetAppleConfigVersion(
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/iap/apple/config/version";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { };

        public Model.AppleIAPConfigVersionInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.AppleIAPConfigVersionInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.AppleIAPConfigVersionInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}