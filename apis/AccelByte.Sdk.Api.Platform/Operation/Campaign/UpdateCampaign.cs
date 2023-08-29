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
    /// updateCampaign
    ///
    /// Update campaign.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:CAMPAIGN", action=4 (UPDATE)
    ///   *  Returns : updated campaign
    /// </summary>
    public class UpdateCampaign : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateCampaignBuilder Builder { get => new UpdateCampaignBuilder(); }

        public class UpdateCampaignBuilder
            : OperationBuilder<UpdateCampaignBuilder>
        {


            public Model.CampaignUpdate? Body { get; set; }




            internal UpdateCampaignBuilder() { }

            internal UpdateCampaignBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public UpdateCampaignBuilder SetBody(Model.CampaignUpdate _body)
            {
                Body = _body;
                return this;
            }




            public UpdateCampaign Build(
                string campaignId,
                string namespace_
            )
            {
                UpdateCampaign op = new UpdateCampaign(this,
                    campaignId,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.CampaignInfo? Execute(
                string campaignId,
                string namespace_
            )
            {
                UpdateCampaign op = Build(
                    campaignId,
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

        private UpdateCampaign(UpdateCampaignBuilder builder,
            string campaignId,
            string namespace_
        )
        {
            PathParams["campaignId"] = campaignId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateCampaign(
            string campaignId,            
            string namespace_,            
            Model.CampaignUpdate body            
        )
        {
            PathParams["campaignId"] = campaignId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/campaigns/{campaignId}";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.CampaignInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.CampaignInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.CampaignInfo>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}