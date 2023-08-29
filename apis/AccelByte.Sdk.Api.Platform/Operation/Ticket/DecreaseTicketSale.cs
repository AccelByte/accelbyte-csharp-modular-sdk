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
    /// decreaseTicketSale
    ///
    ///  [SERVICE COMMUNICATION ONLY] Decrease ticket(code/key) sale if requested orderNo is already increased.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:TICKET", action=4 (UPDATE)
    /// </summary>
    public class DecreaseTicketSale : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DecreaseTicketSaleBuilder Builder { get => new DecreaseTicketSaleBuilder(); }

        public class DecreaseTicketSaleBuilder
            : OperationBuilder<DecreaseTicketSaleBuilder>
        {


            public Model.TicketSaleDecrementRequest? Body { get; set; }




            internal DecreaseTicketSaleBuilder() { }

            internal DecreaseTicketSaleBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public DecreaseTicketSaleBuilder SetBody(Model.TicketSaleDecrementRequest _body)
            {
                Body = _body;
                return this;
            }




            public DecreaseTicketSale Build(
                string boothName,
                string namespace_
            )
            {
                DecreaseTicketSale op = new DecreaseTicketSale(this,
                    boothName,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
                string boothName,
                string namespace_
            )
            {
                DecreaseTicketSale op = Build(
                    boothName,
                    namespace_
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

        private DecreaseTicketSale(DecreaseTicketSaleBuilder builder,
            string boothName,
            string namespace_
        )
        {
            PathParams["boothName"] = boothName;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DecreaseTicketSale(
            string boothName,            
            string namespace_,            
            Model.TicketSaleDecrementRequest body            
        )
        {
            PathParams["boothName"] = boothName;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/tickets/{boothName}/decrement";

        public override HttpMethod Method => HttpMethod.Put;

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