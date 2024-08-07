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
    /// retrieveAllLegalPolicies
    ///
    /// Retrieve all base policies.
    /// </summary>
    public class RetrieveAllLegalPolicies : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RetrieveAllLegalPoliciesBuilder Builder { get => new RetrieveAllLegalPoliciesBuilder(); }

        public class RetrieveAllLegalPoliciesBuilder
            : OperationBuilder<RetrieveAllLegalPoliciesBuilder>
        {

            public bool? VisibleOnly { get; set; }





            internal RetrieveAllLegalPoliciesBuilder() { }

            internal RetrieveAllLegalPoliciesBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public RetrieveAllLegalPoliciesBuilder SetVisibleOnly(bool _visibleOnly)
            {
                VisibleOnly = _visibleOnly;
                return this;
            }





            public RetrieveAllLegalPolicies Build(
            )
            {
                RetrieveAllLegalPolicies op = new RetrieveAllLegalPolicies(this
                );

                op.SetBaseFields<RetrieveAllLegalPoliciesBuilder>(this);
                return op;
            }

            public List<Model.RetrieveBasePolicyResponse>? Execute(
            )
            {
                RetrieveAllLegalPolicies op = Build(
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<List<Model.RetrieveBasePolicyResponse>?> ExecuteAsync(
            )
            {
                RetrieveAllLegalPolicies op = Build(
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

        private RetrieveAllLegalPolicies(RetrieveAllLegalPoliciesBuilder builder
        )
        {

            if (builder.VisibleOnly != null) QueryParams["visibleOnly"] = Convert.ToString(builder.VisibleOnly)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public RetrieveAllLegalPolicies(
            bool? visibleOnly
        )
        {

            if (visibleOnly != null) QueryParams["visibleOnly"] = Convert.ToString(visibleOnly)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/base-policies";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public List<Model.RetrieveBasePolicyResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.RetrieveBasePolicyResponse>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.RetrieveBasePolicyResponse>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}