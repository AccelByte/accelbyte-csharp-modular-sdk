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

using AccelByte.Sdk.Api.Platform.Model;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// publicReconcilePlayStationStore
    ///
    /// Synchronize with entitlements in PSN Store.Other detail info:
    ///   * Returns : result of synchronization
    /// </summary>
    public class PublicReconcilePlayStationStore : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicReconcilePlayStationStoreBuilder Builder { get => new PublicReconcilePlayStationStoreBuilder(); }

        public class PublicReconcilePlayStationStoreBuilder
            : OperationBuilder<PublicReconcilePlayStationStoreBuilder>
        {


            public Model.PlayStationReconcileRequest? Body { get; set; }




            internal PublicReconcilePlayStationStoreBuilder() { }

            internal PublicReconcilePlayStationStoreBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public PublicReconcilePlayStationStoreBuilder SetBody(Model.PlayStationReconcileRequest _body)
            {
                Body = _body;
                return this;
            }




            public PublicReconcilePlayStationStore Build(
                string namespace_,
                string userId
            )
            {
                PublicReconcilePlayStationStore op = new PublicReconcilePlayStationStore(this,
                    namespace_,
                    userId
                );

                op.SetBaseFields<PublicReconcilePlayStationStoreBuilder>(this);
                return op;
            }

            public List<Model.PlayStationReconcileResult>? Execute(
                string namespace_,
                string userId
            )
            {
                PublicReconcilePlayStationStore op = Build(
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
            public async Task<List<Model.PlayStationReconcileResult>?> ExecuteAsync(
                string namespace_,
                string userId
            )
            {
                PublicReconcilePlayStationStore op = Build(
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

        private PublicReconcilePlayStationStore(PublicReconcilePlayStationStoreBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicReconcilePlayStationStore(
            string namespace_,
            string userId,
            Model.PlayStationReconcileRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/iap/psn/sync";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public List<Model.PlayStationReconcileResult>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.PlayStationReconcileResult>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.PlayStationReconcileResult>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}