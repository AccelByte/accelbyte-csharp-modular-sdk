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
    /// updateEpicGamesIAPConfig
    ///
    /// Update epic games iap config. Other detail info:
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:IAP:CONFIG", action=4 (UPDATE)
    ///   *  Returns : updated epic games iap config
    /// </summary>
    public class UpdateEpicGamesIAPConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateEpicGamesIAPConfigBuilder Builder { get => new UpdateEpicGamesIAPConfigBuilder(); }

        public class UpdateEpicGamesIAPConfigBuilder
            : OperationBuilder<UpdateEpicGamesIAPConfigBuilder>
        {


            public Model.EpicGamesIAPConfigRequest? Body { get; set; }




            internal UpdateEpicGamesIAPConfigBuilder() { }

            internal UpdateEpicGamesIAPConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public UpdateEpicGamesIAPConfigBuilder SetBody(Model.EpicGamesIAPConfigRequest _body)
            {
                Body = _body;
                return this;
            }




            public UpdateEpicGamesIAPConfig Build(
                string namespace_
            )
            {
                UpdateEpicGamesIAPConfig op = new UpdateEpicGamesIAPConfig(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.EpicGamesIAPConfigInfo? Execute(
                string namespace_
            )
            {
                UpdateEpicGamesIAPConfig op = Build(
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

        private UpdateEpicGamesIAPConfig(UpdateEpicGamesIAPConfigBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateEpicGamesIAPConfig(
            string namespace_,            
            Model.EpicGamesIAPConfigRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/iap/config/epicgames";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.EpicGamesIAPConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.EpicGamesIAPConfigInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.EpicGamesIAPConfigInfo>(payload);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}