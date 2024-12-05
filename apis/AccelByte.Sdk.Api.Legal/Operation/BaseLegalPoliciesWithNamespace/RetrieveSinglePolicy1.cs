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
    /// retrieveSinglePolicy_1
    ///
    /// Retrieve a base policy.
    /// </summary>
    public class RetrieveSinglePolicy1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RetrieveSinglePolicy1Builder Builder { get => new RetrieveSinglePolicy1Builder(); }

        public class RetrieveSinglePolicy1Builder
            : OperationBuilder<RetrieveSinglePolicy1Builder>
        {





            internal RetrieveSinglePolicy1Builder() { }

            internal RetrieveSinglePolicy1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public RetrieveSinglePolicy1 Build(
                string basePolicyId,
                string namespace_
            )
            {
                RetrieveSinglePolicy1 op = new RetrieveSinglePolicy1(this,
                    basePolicyId,
                    namespace_
                );

                op.SetBaseFields<RetrieveSinglePolicy1Builder>(this);
                return op;
            }

            public RetrieveSinglePolicy1.Response Execute(
                string basePolicyId,
                string namespace_
            )
            {
                RetrieveSinglePolicy1 op = Build(
                    basePolicyId,
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
            public async Task<RetrieveSinglePolicy1.Response> ExecuteAsync(
                string basePolicyId,
                string namespace_
            )
            {
                RetrieveSinglePolicy1 op = Build(
                    basePolicyId,
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

        private RetrieveSinglePolicy1(RetrieveSinglePolicy1Builder builder,
            string basePolicyId,
            string namespace_
        )
        {
            PathParams["basePolicyId"] = basePolicyId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.RetrieveBasePolicyResponse>
        {

            public ErrorEntity? Error404 { get; set; } = null;


            protected override string GetFullOperationId() => "Legal::BaseLegalPoliciesWithNamespace::RetrieveSinglePolicy1";
        }

        #endregion

        public RetrieveSinglePolicy1(
            string basePolicyId,
            string namespace_
        )
        {
            PathParams["basePolicyId"] = basePolicyId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/namespaces/{namespace}/base-policies/{basePolicyId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public RetrieveSinglePolicy1.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new RetrieveSinglePolicy1.Response()
            {
                StatusCode = code,
                ContentType = contentType
            };

            if (code == (HttpStatusCode)204)
            {
                response.IsSuccess = true;
            }
            else if ((code == (HttpStatusCode)201) || (code == (HttpStatusCode)202) || (code == (HttpStatusCode)200))
            {
                response.Data = JsonSerializer.Deserialize<Model.RetrieveBasePolicyResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }

            return response;
        }
    }

}