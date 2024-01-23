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

            internal PublicQueryMyPartiesBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


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

                op.SetBaseFields<PublicQueryMyPartiesBuilder>(this);
                return op;
            }

            public Model.ApimodelsPartyQueryResponse? Execute(
                string namespace_
            )
            {
                PublicQueryMyParties op = Build(
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

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ApimodelsPartyQueryResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsPartyQueryResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsPartyQueryResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}