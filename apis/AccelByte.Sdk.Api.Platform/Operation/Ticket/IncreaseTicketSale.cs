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
    /// increaseTicketSale
    ///
    ///  [SERVICE COMMUNICATION ONLY] increase ticket(code/key) sale.
    /// Other detail info:
    /// 
    ///   * Returns : Ticket sale increment result
    /// </summary>
    public class IncreaseTicketSale : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static IncreaseTicketSaleBuilder Builder { get => new IncreaseTicketSaleBuilder(); }

        public class IncreaseTicketSaleBuilder
            : OperationBuilder<IncreaseTicketSaleBuilder>
        {





            internal IncreaseTicketSaleBuilder() { }

            internal IncreaseTicketSaleBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public IncreaseTicketSale Build(
                TicketSaleIncrementRequest body,
                string boothName,
                string namespace_
            )
            {
                IncreaseTicketSale op = new IncreaseTicketSale(this,
                    body,                    
                    boothName,                    
                    namespace_                    
                );

                op.SetBaseFields<IncreaseTicketSaleBuilder>(this);
                return op;
            }

            public Model.TicketSaleIncrementResult? Execute(
                TicketSaleIncrementRequest body,
                string boothName,
                string namespace_
            )
            {
                IncreaseTicketSale op = Build(
                    body,
                    boothName,
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
            public async Task<Model.TicketSaleIncrementResult?> ExecuteAsync(
                TicketSaleIncrementRequest body,
                string boothName,
                string namespace_
            )
            {
                IncreaseTicketSale op = Build(
                    body,
                    boothName,
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

        private IncreaseTicketSale(IncreaseTicketSaleBuilder builder,
            TicketSaleIncrementRequest body,
            string boothName,
            string namespace_
        )
        {
            PathParams["boothName"] = boothName;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public IncreaseTicketSale(
            string boothName,            
            string namespace_,            
            Model.TicketSaleIncrementRequest body            
        )
        {
            PathParams["boothName"] = boothName;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/tickets/{boothName}/increment";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.TicketSaleIncrementResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.TicketSaleIncrementResult>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.TicketSaleIncrementResult>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}