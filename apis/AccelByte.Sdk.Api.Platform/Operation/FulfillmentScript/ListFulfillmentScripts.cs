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
    /// listFulfillmentScripts
    ///
    /// [Not Supported Yet In Starter] List all fulfillment scripts.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:FULFILLMENT", action=2 (READ)
    /// </summary>
    public class ListFulfillmentScripts : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ListFulfillmentScriptsBuilder Builder { get => new ListFulfillmentScriptsBuilder(); }

        public class ListFulfillmentScriptsBuilder
            : OperationBuilder<ListFulfillmentScriptsBuilder>
        {





            internal ListFulfillmentScriptsBuilder() { }

            internal ListFulfillmentScriptsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public ListFulfillmentScripts Build(
            )
            {
                ListFulfillmentScripts op = new ListFulfillmentScripts(this
                );

                op.SetBaseFields<ListFulfillmentScriptsBuilder>(this);
                return op;
            }

            public List<Model.FulfillmentScriptInfo>? Execute(
            )
            {
                ListFulfillmentScripts op = Build(
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

        private ListFulfillmentScripts(ListFulfillmentScriptsBuilder builder
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ListFulfillmentScripts(
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/fulfillment/scripts";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { };

        public List<Model.FulfillmentScriptInfo>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.FulfillmentScriptInfo>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.FulfillmentScriptInfo>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}