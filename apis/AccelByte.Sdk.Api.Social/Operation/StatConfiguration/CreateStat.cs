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

using AccelByte.Sdk.Api.Social.Model;

namespace AccelByte.Sdk.Api.Social.Operation
{
    /// <summary>
    /// createStat
    ///
    /// Create stat.
    /// Other detail info:
    ///         *  Returns : created stat template
    ///         * default minimum value is 0
    ///         * default maximum value is 1.7976931348623157e+308
    ///         * Field globalAggregationMethod will be ignored when setAsGlobal field is false
    /// </summary>
    public class CreateStat : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateStatBuilder Builder { get => new CreateStatBuilder(); }

        public class CreateStatBuilder
            : OperationBuilder<CreateStatBuilder>
        {


            public Model.StatCreate? Body { get; set; }




            internal CreateStatBuilder() { }

            internal CreateStatBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public CreateStatBuilder SetBody(Model.StatCreate _body)
            {
                Body = _body;
                return this;
            }




            public CreateStat Build(
                string namespace_
            )
            {
                CreateStat op = new CreateStat(this,
                    namespace_
                );

                op.SetBaseFields<CreateStatBuilder>(this);
                return op;
            }

            public Model.StatInfo? Execute(
                string namespace_
            )
            {
                CreateStat op = Build(
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
            public async Task<Model.StatInfo?> ExecuteAsync(
                string namespace_
            )
            {
                CreateStat op = Build(
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

        private CreateStat(CreateStatBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreateStat(
            string namespace_,
            Model.StatCreate body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/v1/admin/namespaces/{namespace}/stats";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.StatInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.StatInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.StatInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}