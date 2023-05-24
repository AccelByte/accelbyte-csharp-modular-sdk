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

using AccelByte.Sdk.Api.Social.Model;

namespace AccelByte.Sdk.Api.Social.Operation
{
    /// <summary>
    /// updateStat
    ///
    /// Update stat.
    /// Other detail info:
    ///         *  Required permission : resource="ADMIN:NAMESPACE:{namespace}:STAT", action=4 (UPDATE)
    ///         *  Returns : updated stat
    /// </summary>
    public class UpdateStat : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateStatBuilder Builder { get => new UpdateStatBuilder(); }

        public class UpdateStatBuilder
            : OperationBuilder<UpdateStatBuilder>
        {


            public Model.StatUpdate? Body { get; set; }




            internal UpdateStatBuilder() { }

            internal UpdateStatBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public UpdateStatBuilder SetBody(Model.StatUpdate _body)
            {
                Body = _body;
                return this;
            }




            public UpdateStat Build(
                string namespace_,
                string statCode
            )
            {
                UpdateStat op = new UpdateStat(this,
                    namespace_,
                    statCode
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.StatInfo? Execute(
                string namespace_,
                string statCode
            )
            {
                UpdateStat op = Build(
                    namespace_,
                    statCode
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

        private UpdateStat(UpdateStatBuilder builder,
            string namespace_,
            string statCode
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["statCode"] = statCode;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateStat(
            string namespace_,
            string statCode,
            Model.StatUpdate body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["statCode"] = statCode;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/v1/admin/namespaces/{namespace}/stats/{statCode}";

        public override HttpMethod Method => HttpMethod.Patch;

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
                return JsonSerializer.Deserialize<Model.StatInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.StatInfo>(payload);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}