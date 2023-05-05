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
    /// updateAppleIAPConfig
    ///
    /// Update apple iap config. Other detail info:
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:IAP:CONFIG", action=4 (UPDATE)
    ///   *  Returns : updated apple iap config
    /// </summary>
    public class UpdateAppleIAPConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateAppleIAPConfigBuilder Builder { get => new UpdateAppleIAPConfigBuilder(); }

        public class UpdateAppleIAPConfigBuilder
            : OperationBuilder<UpdateAppleIAPConfigBuilder>
        {


            public Model.AppleIAPConfigRequest? Body { get; set; }




            internal UpdateAppleIAPConfigBuilder() { }

            internal UpdateAppleIAPConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public UpdateAppleIAPConfigBuilder SetBody(Model.AppleIAPConfigRequest _body)
            {
                Body = _body;
                return this;
            }




            public UpdateAppleIAPConfig Build(
                string namespace_
            )
            {
                UpdateAppleIAPConfig op = new UpdateAppleIAPConfig(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.AppleIAPConfigInfo? Execute(
                string namespace_
            )
            {
                UpdateAppleIAPConfig op = Build(
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

        private UpdateAppleIAPConfig(UpdateAppleIAPConfigBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateAppleIAPConfig(
            string namespace_,            
            Model.AppleIAPConfigRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/iap/config/apple";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.AppleIAPConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.AppleIAPConfigInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.AppleIAPConfigInfo>(payload);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}