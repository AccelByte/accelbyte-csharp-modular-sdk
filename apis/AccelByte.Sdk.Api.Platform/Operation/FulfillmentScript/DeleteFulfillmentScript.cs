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
    /// deleteFulfillmentScript
    ///
    ///  [Not Supported Yet In Starter] Delete fulfillment script.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:FULFILLMENT", action=8 (DELETE)
    /// </summary>
    public class DeleteFulfillmentScript : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteFulfillmentScriptBuilder Builder { get => new DeleteFulfillmentScriptBuilder(); }

        public class DeleteFulfillmentScriptBuilder
            : OperationBuilder<DeleteFulfillmentScriptBuilder>
        {





            internal DeleteFulfillmentScriptBuilder() { }

            internal DeleteFulfillmentScriptBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteFulfillmentScript Build(
                string id
            )
            {
                DeleteFulfillmentScript op = new DeleteFulfillmentScript(this,
                    id
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
                string id
            )
            {
                DeleteFulfillmentScript op = Build(
                    id
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

        private DeleteFulfillmentScript(DeleteFulfillmentScriptBuilder builder,
            string id
        )
        {
            PathParams["id"] = id;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteFulfillmentScript(
            string id
        )
        {
            PathParams["id"] = id;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/fulfillment/scripts/{id}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { };

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