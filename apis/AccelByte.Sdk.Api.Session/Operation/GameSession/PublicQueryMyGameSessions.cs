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

using AccelByte.Sdk.Api.Session.Model;

namespace AccelByte.Sdk.Api.Session.Operation
{
    /// <summary>
    /// publicQueryMyGameSessions
    ///
    /// Query user's game sessions.
    /// By default, API will return a list of user's active game sessions (INVITED,JOINED,CONNECTED).
    /// 
    /// Session service has several DSInformation status to track DS request to DSMC:
    /// - NEED_TO_REQUEST: number of active players hasn't reached session's minPlayers therefore DS has not yet requested.
    /// - REQUESTED: DS is being requested to DSMC.
    /// - AVAILABLE: DS is ready to use. The DSMC status for this DS is either READY/BUSY.
    /// - FAILED_TO_REQUEST: DSMC fails to create the DS.
    /// </summary>
    public class PublicQueryMyGameSessions : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicQueryMyGameSessionsBuilder Builder { get => new PublicQueryMyGameSessionsBuilder(); }

        public class PublicQueryMyGameSessionsBuilder
            : OperationBuilder<PublicQueryMyGameSessionsBuilder>
        {

            public string? Order { get; set; }

            public string? OrderBy { get; set; }

            public string? Status { get; set; }





            internal PublicQueryMyGameSessionsBuilder() { }

            internal PublicQueryMyGameSessionsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public PublicQueryMyGameSessionsBuilder SetOrder(string _order)
            {
                Order = _order;
                return this;
            }

            public PublicQueryMyGameSessionsBuilder SetOrderBy(string _orderBy)
            {
                OrderBy = _orderBy;
                return this;
            }

            public PublicQueryMyGameSessionsBuilder SetStatus(string _status)
            {
                Status = _status;
                return this;
            }





            public PublicQueryMyGameSessions Build(
                string namespace_
            )
            {
                PublicQueryMyGameSessions op = new PublicQueryMyGameSessions(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ApimodelsGameSessionQueryResponse? Execute(
                string namespace_
            )
            {
                PublicQueryMyGameSessions op = Build(
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

        private PublicQueryMyGameSessions(PublicQueryMyGameSessionsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.Order is not null) QueryParams["order"] = builder.Order;
            if (builder.OrderBy is not null) QueryParams["orderBy"] = builder.OrderBy;
            if (builder.Status is not null) QueryParams["status"] = builder.Status;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicQueryMyGameSessions(
            string namespace_,            
            string? order,            
            string? orderBy,            
            string? status            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (order is not null) QueryParams["order"] = order;
            if (orderBy is not null) QueryParams["orderBy"] = orderBy;
            if (status is not null) QueryParams["status"] = status;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/public/namespaces/{namespace}/users/me/gamesessions";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.ApimodelsGameSessionQueryResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsGameSessionQueryResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsGameSessionQueryResponse>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}