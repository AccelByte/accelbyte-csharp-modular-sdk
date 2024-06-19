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

using AccelByte.Sdk.Api.Social.Model;

namespace AccelByte.Sdk.Api.Social.Operation
{
    /// <summary>
    /// getNamespaceSlotConfig
    ///
    /// ## The endpoint is going to be deprecated
    /// 
    /// 
    /// Get slot configuration for a given namespace. In case slot configuration is not set, the default will be returned.
    /// Other detail info:
    /// 
    ///   *  Returns : namespace slot config info
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class GetNamespaceSlotConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetNamespaceSlotConfigBuilder Builder { get => new GetNamespaceSlotConfigBuilder(); }

        public class GetNamespaceSlotConfigBuilder
            : OperationBuilder<GetNamespaceSlotConfigBuilder>
        {





            internal GetNamespaceSlotConfigBuilder() { }

            internal GetNamespaceSlotConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetNamespaceSlotConfig Build(
                string namespace_
            )
            {
                GetNamespaceSlotConfig op = new GetNamespaceSlotConfig(this,
                    namespace_
                );

                op.SetBaseFields<GetNamespaceSlotConfigBuilder>(this);
                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public Model.NamespaceSlotConfigInfo? Execute(
                string namespace_
            )
            {
                GetNamespaceSlotConfig op = Build(
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
            public async Task<Model.NamespaceSlotConfigInfo?> ExecuteAsync(
                string namespace_
            )
            {
                GetNamespaceSlotConfig op = Build(
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

        private GetNamespaceSlotConfig(GetNamespaceSlotConfigBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetNamespaceSlotConfig(
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/admin/namespaces/{namespace}/config";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.NamespaceSlotConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.NamespaceSlotConfigInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.NamespaceSlotConfigInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}