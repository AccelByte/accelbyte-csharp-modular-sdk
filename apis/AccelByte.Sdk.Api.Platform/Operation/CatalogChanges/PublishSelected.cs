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

using AccelByte.Sdk.Api.Platform.Model;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// publishSelected
    ///
    /// This API is used to publish selected unpublished changes.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:STORE", action=1 (CREATE)
    ///   *  Returns : no content
    /// </summary>
    public class PublishSelected : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublishSelectedBuilder Builder { get => new PublishSelectedBuilder(); }

        public class PublishSelectedBuilder
            : OperationBuilder<PublishSelectedBuilder>
        {





            internal PublishSelectedBuilder() { }

            internal PublishSelectedBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublishSelected Build(
                string namespace_,
                string storeId
            )
            {
                PublishSelected op = new PublishSelected(this,
                    namespace_,                    
                    storeId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.StoreInfo? Execute(
                string namespace_,
                string storeId
            )
            {
                PublishSelected op = Build(
                    namespace_,
                    storeId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
        }

        private PublishSelected(PublishSelectedBuilder builder,
            string namespace_,
            string storeId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["storeId"] = storeId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublishSelected(
            string namespace_,            
            string storeId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["storeId"] = storeId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/stores/{storeId}/catalogChanges/publishSelected";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.StoreInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.StoreInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.StoreInfo>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}