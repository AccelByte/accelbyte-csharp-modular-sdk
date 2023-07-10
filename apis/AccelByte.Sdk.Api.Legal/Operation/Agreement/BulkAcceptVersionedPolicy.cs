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

using AccelByte.Sdk.Api.Legal.Model;

namespace AccelByte.Sdk.Api.Legal.Operation
{
    /// <summary>
    /// bulkAcceptVersionedPolicy
    ///
    /// Accepts many legal policy versions all at once. Supply with localized version policy id to accept an agreement.
    /// Other detail info:
    /// 
    ///   * Required permission : login user
    /// </summary>
    public class BulkAcceptVersionedPolicy : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static BulkAcceptVersionedPolicyBuilder Builder { get => new BulkAcceptVersionedPolicyBuilder(); }

        public class BulkAcceptVersionedPolicyBuilder
            : OperationBuilder<BulkAcceptVersionedPolicyBuilder>
        {


            public List<Model.AcceptAgreementRequest>? Body { get; set; }




            internal BulkAcceptVersionedPolicyBuilder() { }

            internal BulkAcceptVersionedPolicyBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public BulkAcceptVersionedPolicyBuilder SetBody(List<Model.AcceptAgreementRequest> _body)
            {
                Body = _body;
                return this;
            }




            public BulkAcceptVersionedPolicy Build(
            )
            {
                BulkAcceptVersionedPolicy op = new BulkAcceptVersionedPolicy(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.AcceptAgreementResponse? Execute(
            )
            {
                BulkAcceptVersionedPolicy op = Build(
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }

            public Model.AcceptAgreementResponse<T1>? Execute<T1>(
            )
            {
                BulkAcceptVersionedPolicy op = Build(
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private BulkAcceptVersionedPolicy(BulkAcceptVersionedPolicyBuilder builder
        )
        {





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public BulkAcceptVersionedPolicy(
            List<Model.AcceptAgreementRequest> body
        )
        {





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/public/agreements/policies";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.AcceptAgreementResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.AcceptAgreementResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.AcceptAgreementResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }

        public Model.AcceptAgreementResponse<T1>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.AcceptAgreementResponse<T1>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.AcceptAgreementResponse<T1>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}