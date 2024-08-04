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
    /// retrieveAllPolicyTypes
    ///
    /// Retrieve all supported policy types.
    /// </summary>
    public class RetrieveAllPolicyTypes : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RetrieveAllPolicyTypesBuilder Builder { get => new RetrieveAllPolicyTypesBuilder(); }

        public class RetrieveAllPolicyTypesBuilder
            : OperationBuilder<RetrieveAllPolicyTypesBuilder>
        {

            public int? Offset { get; set; }





            internal RetrieveAllPolicyTypesBuilder() { }

            internal RetrieveAllPolicyTypesBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public RetrieveAllPolicyTypesBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }





            public RetrieveAllPolicyTypes Build(
                int limit
            )
            {
                RetrieveAllPolicyTypes op = new RetrieveAllPolicyTypes(this,
                    limit
                );

                op.SetBaseFields<RetrieveAllPolicyTypesBuilder>(this);
                return op;
            }

            public List<Model.RetrievePolicyTypeResponse>? Execute(
                int limit
            )
            {
                RetrieveAllPolicyTypes op = Build(
                    limit
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<List<Model.RetrievePolicyTypeResponse>?> ExecuteAsync(
                int limit
            )
            {
                RetrieveAllPolicyTypes op = Build(
                    limit
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

        private RetrieveAllPolicyTypes(RetrieveAllPolicyTypesBuilder builder,
            int limit
        )
        {

            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;

            QueryParams["limit"] = Convert.ToString(limit)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public RetrieveAllPolicyTypes(
            int? offset,
            int limit
        )
        {

            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;

            QueryParams["limit"] = Convert.ToString(limit)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/policy-types";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public List<Model.RetrievePolicyTypeResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.RetrievePolicyTypeResponse>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.RetrievePolicyTypeResponse>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}