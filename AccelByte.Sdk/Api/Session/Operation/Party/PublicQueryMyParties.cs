// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Session.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Session.Operation
{
    /// <summary>
    /// publicQueryMyParties
    ///
    /// Query user's parties. By default, API will return a list of user's active parties.
    /// </summary>
    public class PublicQueryMyParties : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicQueryMyPartiesBuilder Builder { get => new PublicQueryMyPartiesBuilder(); }

        public class PublicQueryMyPartiesBuilder
            : OperationBuilder<PublicQueryMyPartiesBuilder>
        {

            public string? Order { get; set; }

            public string? OrderBy { get; set; }

            public string? Status { get; set; }





            internal PublicQueryMyPartiesBuilder() { }


            public PublicQueryMyPartiesBuilder SetOrder(string _order)
            {
                Order = _order;
                return this;
            }

            public PublicQueryMyPartiesBuilder SetOrderBy(string _orderBy)
            {
                OrderBy = _orderBy;
                return this;
            }

            public PublicQueryMyPartiesBuilder SetStatus(string _status)
            {
                Status = _status;
                return this;
            }





            public PublicQueryMyParties Build(
                string namespace_
            )
            {
                PublicQueryMyParties op = new PublicQueryMyParties(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicQueryMyParties(PublicQueryMyPartiesBuilder builder,
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

        public PublicQueryMyParties(
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

        public override string Path => "/session/v1/public/namespaces/{namespace}/users/me/parties";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public List<Model.ApimodelsPartySessionResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ApimodelsPartySessionResponse>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ApimodelsPartySessionResponse>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }

        public List<Model.ApimodelsPartySessionResponse<T1>>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }            
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ApimodelsPartySessionResponse<T1>>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ApimodelsPartySessionResponse<T1>>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);            
            throw new HttpResponseException(code, payloadString);
        }
    }

}