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
    /// indirectBulkAcceptVersionedPolicyV2
    ///
    /// Accepts many legal policy versions all at once. Supply with localized version policy id, version policy id, policy id, userId, namespace, country code and client id to accept an agreement. This endpoint used by APIGateway during new user registration.
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class IndirectBulkAcceptVersionedPolicyV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static IndirectBulkAcceptVersionedPolicyV2Builder Builder { get => new IndirectBulkAcceptVersionedPolicyV2Builder(); }

        public class IndirectBulkAcceptVersionedPolicyV2Builder
            : OperationBuilder<IndirectBulkAcceptVersionedPolicyV2Builder>
        {


            public List<Model.AcceptAgreementRequest>? Body { get; set; }




            internal IndirectBulkAcceptVersionedPolicyV2Builder() { }

            internal IndirectBulkAcceptVersionedPolicyV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public IndirectBulkAcceptVersionedPolicyV2Builder SetBody(List<Model.AcceptAgreementRequest> _body)
            {
                Body = _body;
                return this;
            }




            public IndirectBulkAcceptVersionedPolicyV2 Build(
                string clientId,
                string countryCode,
                string namespace_,
                string userId
            )
            {
                IndirectBulkAcceptVersionedPolicyV2 op = new IndirectBulkAcceptVersionedPolicyV2(this,
                    clientId,
                    countryCode,
                    namespace_,
                    userId
                );

                op.SetBaseFields<IndirectBulkAcceptVersionedPolicyV2Builder>(this);
                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public IndirectBulkAcceptVersionedPolicyV2.Response Execute(
                string clientId,
                string countryCode,
                string namespace_,
                string userId
            )
            {
                IndirectBulkAcceptVersionedPolicyV2 op = Build(
                    clientId,
                    countryCode,
                    namespace_,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<IndirectBulkAcceptVersionedPolicyV2.Response> ExecuteAsync(
                string clientId,
                string countryCode,
                string namespace_,
                string userId
            )
            {
                IndirectBulkAcceptVersionedPolicyV2 op = Build(
                    clientId,
                    countryCode,
                    namespace_,
                    userId
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

        private IndirectBulkAcceptVersionedPolicyV2(IndirectBulkAcceptVersionedPolicyV2Builder builder,
            string clientId,
            string countryCode,
            string namespace_,
            string userId
        )
        {
            PathParams["clientId"] = clientId;
            PathParams["countryCode"] = countryCode;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.AcceptAgreementResponse>
        {


            protected override string GetFullOperationId() => "Legal::Agreement::IndirectBulkAcceptVersionedPolicyV2";
        }

        #endregion

        public IndirectBulkAcceptVersionedPolicyV2(
            string clientId,
            string countryCode,
            string namespace_,
            string userId,
            List<Model.AcceptAgreementRequest> body
        )
        {
            PathParams["clientId"] = clientId;
            PathParams["countryCode"] = countryCode;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/public/agreements/policies/namespaces/{namespace}/countries/{countryCode}/clients/{clientId}/users/{userId}";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public IndirectBulkAcceptVersionedPolicyV2.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new IndirectBulkAcceptVersionedPolicyV2.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.AcceptAgreementResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }

            return response;
        }
    }

}