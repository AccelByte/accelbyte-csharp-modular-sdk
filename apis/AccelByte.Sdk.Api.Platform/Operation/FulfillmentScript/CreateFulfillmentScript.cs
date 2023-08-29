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
    /// createFulfillmentScript
    ///
    /// Create fulfillment script.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:FULFILLMENT", action=1 (CREATE)
    /// 
    /// Fulfillment scripts are used for adding custom fulfillment logic based on ITEM_TYPE : [MEDIA,INGAMEITEM] for now, and the custom scripts only cover grantDays.
    /// Example for grantDays:
    /// `order && ((order.currency && order.currency.currencyCode) == 'LP' || order.isFree) ? 30 : -1`
    /// </summary>
    public class CreateFulfillmentScript : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateFulfillmentScriptBuilder Builder { get => new CreateFulfillmentScriptBuilder(); }

        public class CreateFulfillmentScriptBuilder
            : OperationBuilder<CreateFulfillmentScriptBuilder>
        {


            public Model.FulfillmentScriptCreate? Body { get; set; }




            internal CreateFulfillmentScriptBuilder() { }

            internal CreateFulfillmentScriptBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public CreateFulfillmentScriptBuilder SetBody(Model.FulfillmentScriptCreate _body)
            {
                Body = _body;
                return this;
            }




            public CreateFulfillmentScript Build(
                string id
            )
            {
                CreateFulfillmentScript op = new CreateFulfillmentScript(this,
                    id                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.FulfillmentScriptInfo? Execute(
                string id
            )
            {
                CreateFulfillmentScript op = Build(
                    id
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

        private CreateFulfillmentScript(CreateFulfillmentScriptBuilder builder,
            string id
        )
        {
            PathParams["id"] = id;
            
            

            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreateFulfillmentScript(
            string id,            
            Model.FulfillmentScriptCreate body            
        )
        {
            PathParams["id"] = id;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/fulfillment/scripts/{id}";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() {  };        
        
        public Model.FulfillmentScriptInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.FulfillmentScriptInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.FulfillmentScriptInfo>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}