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

using AccelByte.Sdk.Api.Gdpr.Model;

namespace AccelByte.Sdk.Api.Gdpr.Operation
{
    /// <summary>
    /// S2SGetListFinishedAccountDeletionRequest
    ///
    /// Scope: account
    /// 
    /// Get list of finished account deletion requests based on the finished time period.
    /// Unfinished deletion requests will not appear here, i.e. have Status **Request**, **Pending** or **In-Progress**.
    /// 
    /// **Anonymize userId for deleted account:**
    /// For user accounts that have been deleted, the **userId** field in this API will be anonymized automatically after **7 days** from the success deletion.
    /// This measure is implemented to ensure compliance with GDPR regulations. Please make sure to synchronize the data from this API before it undergoes anonymization.
    /// 
    /// ---
    /// ## This API for S2S integration purpose only
    /// </summary>
    public class S2SGetListFinishedAccountDeletionRequest : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static S2SGetListFinishedAccountDeletionRequestBuilder Builder { get => new S2SGetListFinishedAccountDeletionRequestBuilder(); }

        public class S2SGetListFinishedAccountDeletionRequestBuilder
            : OperationBuilder<S2SGetListFinishedAccountDeletionRequestBuilder>
        {





            internal S2SGetListFinishedAccountDeletionRequestBuilder() { }

            internal S2SGetListFinishedAccountDeletionRequestBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public S2SGetListFinishedAccountDeletionRequest Build(
                string namespace_,
                string end,
                string start
            )
            {
                S2SGetListFinishedAccountDeletionRequest op = new S2SGetListFinishedAccountDeletionRequest(this,
                    namespace_,
                    end,
                    start
                );

                op.SetBaseFields<S2SGetListFinishedAccountDeletionRequestBuilder>(this);
                return op;
            }

            public Model.DtoListFinishedDataDeletion? Execute(
                string namespace_,
                string end,
                string start
            )
            {
                S2SGetListFinishedAccountDeletionRequest op = Build(
                    namespace_,
                    end,
                    start
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.DtoListFinishedDataDeletion?> ExecuteAsync(
                string namespace_,
                string end,
                string start
            )
            {
                S2SGetListFinishedAccountDeletionRequest op = Build(
                    namespace_,
                    end,
                    start
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

        private S2SGetListFinishedAccountDeletionRequest(S2SGetListFinishedAccountDeletionRequestBuilder builder,
            string namespace_,
            string end,
            string start
        )
        {
            PathParams["namespace"] = namespace_;

            if (end is not null) QueryParams["end"] = end;
            if (start is not null) QueryParams["start"] = start;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public S2SGetListFinishedAccountDeletionRequest(
            string namespace_,
            string end,
            string start
        )
        {
            PathParams["namespace"] = namespace_;

            if (end is not null) QueryParams["end"] = end;
            if (start is not null) QueryParams["start"] = start;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/gdpr/s2s/namespaces/{namespace}/deletions/finished";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.DtoListFinishedDataDeletion? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.DtoListFinishedDataDeletion>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.DtoListFinishedDataDeletion>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}