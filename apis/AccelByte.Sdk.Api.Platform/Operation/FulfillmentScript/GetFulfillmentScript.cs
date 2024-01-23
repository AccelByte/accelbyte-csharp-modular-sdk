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
    /// getFulfillmentScript
    ///
    ///  [Not Supported Yet In Starter] Get fulfillment script by id.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:FULFILLMENT", action=2 (READ)
    ///   *  Returns : get fulfillment script
    /// </summary>
    public class GetFulfillmentScript : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetFulfillmentScriptBuilder Builder { get => new GetFulfillmentScriptBuilder(); }

        public class GetFulfillmentScriptBuilder
            : OperationBuilder<GetFulfillmentScriptBuilder>
        {





            internal GetFulfillmentScriptBuilder() { }

            internal GetFulfillmentScriptBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetFulfillmentScript Build(
                string id
            )
            {
                GetFulfillmentScript op = new GetFulfillmentScript(this,
                    id
                );

                op.SetBaseFields<GetFulfillmentScriptBuilder>(this);
                return op;
            }

            public Model.FulfillmentScriptInfo? Execute(
                string id
            )
            {
                GetFulfillmentScript op = Build(
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

        private GetFulfillmentScript(GetFulfillmentScriptBuilder builder,
            string id
        )
        {
            PathParams["id"] = id;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetFulfillmentScript(
            string id
        )
        {
            PathParams["id"] = id;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/fulfillment/scripts/{id}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

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