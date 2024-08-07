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
    /// retrieveCountryListWithPolicies
    ///
    /// Retrieve List of Countries that have Active and Visible Legal Policies.
    /// </summary>
    public class RetrieveCountryListWithPolicies : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RetrieveCountryListWithPoliciesBuilder Builder { get => new RetrieveCountryListWithPoliciesBuilder(); }

        public class RetrieveCountryListWithPoliciesBuilder
            : OperationBuilder<RetrieveCountryListWithPoliciesBuilder>
        {





            internal RetrieveCountryListWithPoliciesBuilder() { }

            internal RetrieveCountryListWithPoliciesBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public RetrieveCountryListWithPolicies Build(
            )
            {
                RetrieveCountryListWithPolicies op = new RetrieveCountryListWithPolicies(this
                );

                op.SetBaseFields<RetrieveCountryListWithPoliciesBuilder>(this);
                return op;
            }

            public List<string>? Execute(
            )
            {
                RetrieveCountryListWithPolicies op = Build(
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<List<string>?> ExecuteAsync(
            )
            {
                RetrieveCountryListWithPolicies op = Build(
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

        private RetrieveCountryListWithPolicies(RetrieveCountryListWithPoliciesBuilder builder
        )
        {







        }
        #endregion

        public RetrieveCountryListWithPolicies(
        )
        {







        }

        public override string Path => "/agreement/public/policies/countries/list";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public List<string>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<string>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<string>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}