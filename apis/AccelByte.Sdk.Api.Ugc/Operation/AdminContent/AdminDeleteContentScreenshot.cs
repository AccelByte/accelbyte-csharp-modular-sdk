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
    /// AdminDeleteContentScreenshot
    ///
    /// Required permission ADMIN:NAMESPACE:{namespace}:USER:{userId}:CONTENT [DELETE].
    /// </summary>
    public class AdminDeleteContentScreenshot : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeleteContentScreenshotBuilder Builder { get => new AdminDeleteContentScreenshotBuilder(); }

        public class AdminDeleteContentScreenshotBuilder
            : OperationBuilder<AdminDeleteContentScreenshotBuilder>
        {





            internal AdminDeleteContentScreenshotBuilder() { }

            internal AdminDeleteContentScreenshotBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminDeleteContentScreenshot Build(
                string contentId,
                string namespace_,
                string screenshotId
            )
            {
                AdminDeleteContentScreenshot op = new AdminDeleteContentScreenshot(this,
                    contentId,                    
                    namespace_,                    
                    screenshotId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
                string contentId,
                string namespace_,
                string screenshotId
            )
            {
                AdminDeleteContentScreenshot op = Build(
                    contentId,
                    namespace_,
                    screenshotId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
        }

        private AdminDeleteContentScreenshot(AdminDeleteContentScreenshotBuilder builder,
            string contentId,
            string namespace_,
            string screenshotId
        )
        {
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;
            PathParams["screenshotId"] = screenshotId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminDeleteContentScreenshot(
            string contentId,            
            string namespace_,            
            string screenshotId            
        )
        {
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;
            PathParams["screenshotId"] = screenshotId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v1/admin/namespaces/{namespace}/contents/{contentId}/screenshots/{screenshotId}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}