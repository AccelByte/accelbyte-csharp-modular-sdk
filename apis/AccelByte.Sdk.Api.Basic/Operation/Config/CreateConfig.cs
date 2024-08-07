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

using AccelByte.Sdk.Api.Basic.Model;

namespace AccelByte.Sdk.Api.Basic.Operation
{
    /// <summary>
    /// createConfig
    ///
    /// Create a config.
    /// Other detail info:
    /// 
    ///   * Returns : created config
    /// </summary>
    public class CreateConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateConfigBuilder Builder { get => new CreateConfigBuilder(); }

        public class CreateConfigBuilder
            : OperationBuilder<CreateConfigBuilder>
        {


            public Model.ConfigCreate? Body { get; set; }




            internal CreateConfigBuilder() { }

            internal CreateConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public CreateConfigBuilder SetBody(Model.ConfigCreate _body)
            {
                Body = _body;
                return this;
            }




            public CreateConfig Build(
                string namespace_
            )
            {
                CreateConfig op = new CreateConfig(this,
                    namespace_
                );

                op.SetBaseFields<CreateConfigBuilder>(this);
                return op;
            }

            public Model.ConfigInfo? Execute(
                string namespace_
            )
            {
                CreateConfig op = Build(
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
            public async Task<Model.ConfigInfo?> ExecuteAsync(
                string namespace_
            )
            {
                CreateConfig op = Build(
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

        private CreateConfig(CreateConfigBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreateConfig(
            string namespace_,
            Model.ConfigCreate body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/basic/v1/admin/namespaces/{namespace}/configs";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ConfigInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ConfigInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}