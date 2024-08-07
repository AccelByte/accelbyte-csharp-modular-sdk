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
    /// getDLCItemConfig
    ///
    /// Get DLC item config.
    /// </summary>
    public class GetDLCItemConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetDLCItemConfigBuilder Builder { get => new GetDLCItemConfigBuilder(); }

        public class GetDLCItemConfigBuilder
            : OperationBuilder<GetDLCItemConfigBuilder>
        {





            internal GetDLCItemConfigBuilder() { }

            internal GetDLCItemConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetDLCItemConfig Build(
                string namespace_
            )
            {
                GetDLCItemConfig op = new GetDLCItemConfig(this,
                    namespace_
                );

                op.SetBaseFields<GetDLCItemConfigBuilder>(this);
                return op;
            }

            public Model.DLCItemConfigInfo? Execute(
                string namespace_
            )
            {
                GetDLCItemConfig op = Build(
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
            public async Task<Model.DLCItemConfigInfo?> ExecuteAsync(
                string namespace_
            )
            {
                GetDLCItemConfig op = Build(
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

        private GetDLCItemConfig(GetDLCItemConfigBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetDLCItemConfig(
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/dlc/config/item";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { };

        public Model.DLCItemConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.DLCItemConfigInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.DLCItemConfigInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}