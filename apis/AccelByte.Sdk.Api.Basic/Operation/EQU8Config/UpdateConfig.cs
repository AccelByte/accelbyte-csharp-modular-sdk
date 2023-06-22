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

using AccelByte.Sdk.Api.Basic.Model;

namespace AccelByte.Sdk.Api.Basic.Operation
{
    /// <summary>
    /// updateConfig
    ///
    /// Update equ8 config, create if not exists.
    /// Other detail info:
    /// 
    ///   * Required permission : resource= "ADMIN:NAMESPACE:{namespace}:EQU8CONFIG" , action=4 (UPDATE)
    /// </summary>
    public class UpdateConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateConfigBuilder Builder { get => new UpdateConfigBuilder(); }

        public class UpdateConfigBuilder
            : OperationBuilder<UpdateConfigBuilder>
        {


            public Model.ADTOForUpdateEqu8ConfigAPICall? Body { get; set; }




            internal UpdateConfigBuilder() { }

            internal UpdateConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public UpdateConfigBuilder SetBody(Model.ADTOForUpdateEqu8ConfigAPICall _body)
            {
                Body = _body;
                return this;
            }




            public UpdateConfig Build(
                string namespace_
            )
            {
                UpdateConfig op = new UpdateConfig(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.Equ8Config? Execute(
                string namespace_
            )
            {
                UpdateConfig op = Build(
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

        private UpdateConfig(UpdateConfigBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateConfig(
            string namespace_,
            Model.ADTOForUpdateEqu8ConfigAPICall body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/basic/v1/admin/namespaces/{namespace}/equ8/config";

        public override HttpMethod Method => HttpMethod.Patch;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.Equ8Config? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.Equ8Config>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.Equ8Config>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}