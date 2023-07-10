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
    /// exportRewards
    ///
    /// Export reward configurations for a given namespace into file. At current, only JSON file is supported.
    /// 
    /// Other detail info:
    /// 
    ///   *  *Required permission*: resource="ADMIN:NAMESPACE:{namespace}:REWARD", action=2 (READ)
    /// </summary>
    public class ExportRewards : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ExportRewardsBuilder Builder { get => new ExportRewardsBuilder(); }

        public class ExportRewardsBuilder
            : OperationBuilder<ExportRewardsBuilder>
        {





            internal ExportRewardsBuilder() { }

            internal ExportRewardsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public ExportRewards Build(
                string namespace_
            )
            {
                ExportRewards op = new ExportRewards(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Stream? Execute(
                string namespace_
            )
            {
                ExportRewards op = Build(
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

        private ExportRewards(ExportRewardsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ExportRewards(
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/rewards/export";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Stream? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return payload;
            }
            else if (code == (HttpStatusCode)200)
            {
                return payload;
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}