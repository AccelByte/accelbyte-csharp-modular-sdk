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
    /// getKeyGroupByBoothName
    ///
    /// Get key group.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:KEYGROUP", action=2 (READ)
    ///   *  Returns : key group info
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class GetKeyGroupByBoothName : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetKeyGroupByBoothNameBuilder Builder { get => new GetKeyGroupByBoothNameBuilder(); }

        public class GetKeyGroupByBoothNameBuilder
            : OperationBuilder<GetKeyGroupByBoothNameBuilder>
        {





            internal GetKeyGroupByBoothNameBuilder() { }

            internal GetKeyGroupByBoothNameBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetKeyGroupByBoothName Build(
                string namespace_,
                string boothName
            )
            {
                GetKeyGroupByBoothName op = new GetKeyGroupByBoothName(this,
                    namespace_,
                    boothName
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public Model.KeyGroupInfo? Execute(
                string namespace_,
                string boothName
            )
            {
                GetKeyGroupByBoothName op = Build(
                    namespace_,
                    boothName
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

        private GetKeyGroupByBoothName(GetKeyGroupByBoothNameBuilder builder,
            string namespace_,
            string boothName
        )
        {
            PathParams["namespace"] = namespace_;

            if (boothName is not null) QueryParams["boothName"] = boothName;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetKeyGroupByBoothName(
            string namespace_,
            string boothName
        )
        {
            PathParams["namespace"] = namespace_;

            if (boothName is not null) QueryParams["boothName"] = boothName;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/keygroups/byBoothName";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.KeyGroupInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.KeyGroupInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.KeyGroupInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}