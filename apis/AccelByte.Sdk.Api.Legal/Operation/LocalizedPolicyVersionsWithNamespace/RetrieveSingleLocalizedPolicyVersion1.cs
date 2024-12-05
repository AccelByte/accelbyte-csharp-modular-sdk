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
    /// retrieveSingleLocalizedPolicyVersion_1
    ///
    /// Retrieve a version of a particular country-specific policy.
    /// </summary>
    public class RetrieveSingleLocalizedPolicyVersion1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RetrieveSingleLocalizedPolicyVersion1Builder Builder { get => new RetrieveSingleLocalizedPolicyVersion1Builder(); }

        public class RetrieveSingleLocalizedPolicyVersion1Builder
            : OperationBuilder<RetrieveSingleLocalizedPolicyVersion1Builder>
        {





            internal RetrieveSingleLocalizedPolicyVersion1Builder() { }

            internal RetrieveSingleLocalizedPolicyVersion1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public RetrieveSingleLocalizedPolicyVersion1 Build(
                string localizedPolicyVersionId,
                string namespace_
            )
            {
                RetrieveSingleLocalizedPolicyVersion1 op = new RetrieveSingleLocalizedPolicyVersion1(this,
                    localizedPolicyVersionId,
                    namespace_
                );

                op.SetBaseFields<RetrieveSingleLocalizedPolicyVersion1Builder>(this);
                return op;
            }

            public RetrieveSingleLocalizedPolicyVersion1.Response Execute(
                string localizedPolicyVersionId,
                string namespace_
            )
            {
                RetrieveSingleLocalizedPolicyVersion1 op = Build(
                    localizedPolicyVersionId,
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
            public async Task<RetrieveSingleLocalizedPolicyVersion1.Response> ExecuteAsync(
                string localizedPolicyVersionId,
                string namespace_
            )
            {
                RetrieveSingleLocalizedPolicyVersion1 op = Build(
                    localizedPolicyVersionId,
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

        private RetrieveSingleLocalizedPolicyVersion1(RetrieveSingleLocalizedPolicyVersion1Builder builder,
            string localizedPolicyVersionId,
            string namespace_
        )
        {
            PathParams["localizedPolicyVersionId"] = localizedPolicyVersionId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.RetrieveLocalizedPolicyVersionResponse>
        {

            public ErrorEntity? Error404 { get; set; } = null;


            protected override string GetFullOperationId() => "Legal::LocalizedPolicyVersionsWithNamespace::RetrieveSingleLocalizedPolicyVersion1";
        }

        #endregion

        public RetrieveSingleLocalizedPolicyVersion1(
            string localizedPolicyVersionId,
            string namespace_
        )
        {
            PathParams["localizedPolicyVersionId"] = localizedPolicyVersionId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/namespaces/{namespace}/localized-policy-versions/{localizedPolicyVersionId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public RetrieveSingleLocalizedPolicyVersion1.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new RetrieveSingleLocalizedPolicyVersion1.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.RetrieveLocalizedPolicyVersionResponse>(payload, ResponseJsonOptions);
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