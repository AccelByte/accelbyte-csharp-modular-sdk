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

using AccelByte.Sdk.Api.Legal.Model;

namespace AccelByte.Sdk.Api.Legal.Operation
{
    /// <summary>
    /// publishPolicyVersion
    ///
    /// Manually publish a version of a particular country-specific policy.
    /// </summary>
    public class PublishPolicyVersion : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublishPolicyVersionBuilder Builder { get => new PublishPolicyVersionBuilder(); }

        public class PublishPolicyVersionBuilder
            : OperationBuilder<PublishPolicyVersionBuilder>
        {

            public bool? ShouldNotify { get; set; }





            internal PublishPolicyVersionBuilder() { }

            internal PublishPolicyVersionBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public PublishPolicyVersionBuilder SetShouldNotify(bool _shouldNotify)
            {
                ShouldNotify = _shouldNotify;
                return this;
            }





            public PublishPolicyVersion Build(
                string policyVersionId
            )
            {
                PublishPolicyVersion op = new PublishPolicyVersion(this,
                    policyVersionId
                );

                op.SetBaseFields<PublishPolicyVersionBuilder>(this);
                return op;
            }

            public void Execute(
                string policyVersionId
            )
            {
                PublishPolicyVersion op = Build(
                    policyVersionId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task ExecuteAsync(
                string policyVersionId
            )
            {
                PublishPolicyVersion op = Build(
                    policyVersionId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private PublishPolicyVersion(PublishPolicyVersionBuilder builder,
            string policyVersionId
        )
        {
            PathParams["policyVersionId"] = policyVersionId;

            if (builder.ShouldNotify != null) QueryParams["shouldNotify"] = Convert.ToString(builder.ShouldNotify)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublishPolicyVersion(
            string policyVersionId,
            bool? shouldNotify
        )
        {
            PathParams["policyVersionId"] = policyVersionId;

            if (shouldNotify != null) QueryParams["shouldNotify"] = Convert.ToString(shouldNotify)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/policies/versions/{policyVersionId}/latest";

        public override HttpMethod Method => HttpMethod.Patch;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return;
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}