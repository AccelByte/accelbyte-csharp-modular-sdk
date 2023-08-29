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

using AccelByte.Sdk.Api.Ugc.Model;

namespace AccelByte.Sdk.Api.Ugc.Operation
{
    /// <summary>
    /// UpdateContentLikeStatus
    ///
    /// Requires valid user token
    /// </summary>
    public class UpdateContentLikeStatus : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateContentLikeStatusBuilder Builder { get => new UpdateContentLikeStatusBuilder(); }

        public class UpdateContentLikeStatusBuilder
            : OperationBuilder<UpdateContentLikeStatusBuilder>
        {





            internal UpdateContentLikeStatusBuilder() { }

            internal UpdateContentLikeStatusBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdateContentLikeStatus Build(
                ModelsContentLikeRequest body,
                string contentId,
                string namespace_
            )
            {
                UpdateContentLikeStatus op = new UpdateContentLikeStatus(this,
                    body,                    
                    contentId,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelsContentLikeResponse? Execute(
                ModelsContentLikeRequest body,
                string contentId,
                string namespace_
            )
            {
                UpdateContentLikeStatus op = Build(
                    body,
                    contentId,
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
        }

        private UpdateContentLikeStatus(UpdateContentLikeStatusBuilder builder,
            ModelsContentLikeRequest body,
            string contentId,
            string namespace_
        )
        {
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateContentLikeStatus(
            string contentId,            
            string namespace_,            
            Model.ModelsContentLikeRequest body            
        )
        {
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v1/public/namespaces/{namespace}/contents/{contentId}/like";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json","application/octet-stream" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.ModelsContentLikeResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsContentLikeResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsContentLikeResponse>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}