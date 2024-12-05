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
    /// updateFulfillmentScript
    ///
    ///  [Not supported yet in AGS Shared Cloud] Update fulfillment script.
    /// </summary>
    public class UpdateFulfillmentScript : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateFulfillmentScriptBuilder Builder { get => new UpdateFulfillmentScriptBuilder(); }

        public class UpdateFulfillmentScriptBuilder
            : OperationBuilder<UpdateFulfillmentScriptBuilder>
        {


            public Model.FulfillmentScriptUpdate? Body { get; set; }




            internal UpdateFulfillmentScriptBuilder() { }

            internal UpdateFulfillmentScriptBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public UpdateFulfillmentScriptBuilder SetBody(Model.FulfillmentScriptUpdate _body)
            {
                Body = _body;
                return this;
            }




            public UpdateFulfillmentScript Build(
                string id
            )
            {
                UpdateFulfillmentScript op = new UpdateFulfillmentScript(this,
                    id
                );

                op.SetBaseFields<UpdateFulfillmentScriptBuilder>(this);
                return op;
            }

            public UpdateFulfillmentScript.Response Execute(
                string id
            )
            {
                UpdateFulfillmentScript op = Build(
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
            public async Task<UpdateFulfillmentScript.Response> ExecuteAsync(
                string id
            )
            {
                UpdateFulfillmentScript op = Build(
                    id
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

        private UpdateFulfillmentScript(UpdateFulfillmentScriptBuilder builder,
            string id
        )
        {
            PathParams["id"] = id;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.FulfillmentScriptInfo>
        {

            public ErrorEntity? Error400 { get; set; } = null;


            protected override string GetFullOperationId() => "Platform::FulfillmentScript::UpdateFulfillmentScript";
        }

        #endregion

        public UpdateFulfillmentScript(
            string id,
            Model.FulfillmentScriptUpdate body
        )
        {
            PathParams["id"] = id;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/fulfillment/scripts/{id}";

        public override HttpMethod Method => HttpMethod.Patch;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { };

        public UpdateFulfillmentScript.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new UpdateFulfillmentScript.Response()
            {
                StatusCode = code,
                ContentType = contentType
            };

            if (code == (HttpStatusCode)204)
            {
                response.IsSuccess = true;
            }
            else if ((code == (HttpStatusCode)201) || (code == (HttpStatusCode)202) || (code == (HttpStatusCode)200))
            {
                response.Data = JsonSerializer.Deserialize<Model.FulfillmentScriptInfo>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }

            return response;
        }
    }

}