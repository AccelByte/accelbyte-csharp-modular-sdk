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
    /// updateTwitchIAPConfig
    ///
    /// Update twitch iap config. Other detail info:
    ///   * Returns : updated twitch iap config
    /// </summary>
    public class UpdateTwitchIAPConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateTwitchIAPConfigBuilder Builder { get => new UpdateTwitchIAPConfigBuilder(); }

        public class UpdateTwitchIAPConfigBuilder
            : OperationBuilder<UpdateTwitchIAPConfigBuilder>
        {





            internal UpdateTwitchIAPConfigBuilder() { }

            internal UpdateTwitchIAPConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdateTwitchIAPConfig Build(
                TwitchIAPConfigRequest body,
                string namespace_
            )
            {
                UpdateTwitchIAPConfig op = new UpdateTwitchIAPConfig(this,
                    body,                    
                    namespace_                    
                );

                op.SetBaseFields<UpdateTwitchIAPConfigBuilder>(this);
                return op;
            }

            public Model.TwitchIAPConfigInfo? Execute(
                TwitchIAPConfigRequest body,
                string namespace_
            )
            {
                UpdateTwitchIAPConfig op = Build(
                    body,
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
            public async Task<Model.TwitchIAPConfigInfo?> ExecuteAsync(
                TwitchIAPConfigRequest body,
                string namespace_
            )
            {
                UpdateTwitchIAPConfig op = Build(
                    body,
                    namespace_
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

        private UpdateTwitchIAPConfig(UpdateTwitchIAPConfigBuilder builder,
            TwitchIAPConfigRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateTwitchIAPConfig(
            string namespace_,            
            Model.TwitchIAPConfigRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/iap/config/twitch";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.TwitchIAPConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.TwitchIAPConfigInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.TwitchIAPConfigInfo>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}