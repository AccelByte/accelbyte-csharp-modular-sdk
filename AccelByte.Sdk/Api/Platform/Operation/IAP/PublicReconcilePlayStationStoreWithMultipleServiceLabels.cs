// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// publicReconcilePlayStationStoreWithMultipleServiceLabels
    ///
    /// Synchronize with entitlements in PSN Store with multiple service labels.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:IAP", action=4 (UPDATE)
    ///   *  Returns : result of synchronization
    /// </summary>
    public class PublicReconcilePlayStationStoreWithMultipleServiceLabels : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicReconcilePlayStationStoreWithMultipleServiceLabelsBuilder Builder { get => new PublicReconcilePlayStationStoreWithMultipleServiceLabelsBuilder(); }

        public class PublicReconcilePlayStationStoreWithMultipleServiceLabelsBuilder
            : OperationBuilder<PublicReconcilePlayStationStoreWithMultipleServiceLabelsBuilder>
        {


            public Model.PlayStationMultiServiceLabelsReconcileRequest? Body { get; set; }




            internal PublicReconcilePlayStationStoreWithMultipleServiceLabelsBuilder() { }



            public PublicReconcilePlayStationStoreWithMultipleServiceLabelsBuilder SetBody(Model.PlayStationMultiServiceLabelsReconcileRequest _body)
            {
                Body = _body;
                return this;
            }




            public PublicReconcilePlayStationStoreWithMultipleServiceLabels Build(
                string namespace_,
                string userId
            )
            {
                PublicReconcilePlayStationStoreWithMultipleServiceLabels op = new PublicReconcilePlayStationStoreWithMultipleServiceLabels(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicReconcilePlayStationStoreWithMultipleServiceLabels(PublicReconcilePlayStationStoreWithMultipleServiceLabelsBuilder builder,
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

        public PublicReconcilePlayStationStoreWithMultipleServiceLabels(
            string namespace_,            
            string userId,            
            Model.PlayStationMultiServiceLabelsReconcileRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/iap/psn/sync/multiServiceLabels";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public List<Model.PlayStationReconcileResult>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.PlayStationReconcileResult>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.PlayStationReconcileResult>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}