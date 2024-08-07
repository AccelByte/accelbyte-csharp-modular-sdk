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
    /// updateStatCycle
    ///
    /// Update stat cycle.
    /// Other detail info:
    ///         *  Returns : updated stat cycle
    /// </summary>
    public class UpdateStatCycle : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateStatCycleBuilder Builder { get => new UpdateStatCycleBuilder(); }

        public class UpdateStatCycleBuilder
            : OperationBuilder<UpdateStatCycleBuilder>
        {


            public Model.StatCycleUpdate? Body { get; set; }




            internal UpdateStatCycleBuilder() { }

            internal UpdateStatCycleBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public UpdateStatCycleBuilder SetBody(Model.StatCycleUpdate _body)
            {
                Body = _body;
                return this;
            }




            public UpdateStatCycle Build(
                string cycleId,
                string namespace_
            )
            {
                UpdateStatCycle op = new UpdateStatCycle(this,
                    cycleId,
                    namespace_
                );

                op.SetBaseFields<UpdateStatCycleBuilder>(this);
                return op;
            }

            public Model.StatCycleInfo? Execute(
                string cycleId,
                string namespace_
            )
            {
                UpdateStatCycle op = Build(
                    cycleId,
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
            public async Task<Model.StatCycleInfo?> ExecuteAsync(
                string cycleId,
                string namespace_
            )
            {
                UpdateStatCycle op = Build(
                    cycleId,
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

        private UpdateStatCycle(UpdateStatCycleBuilder builder,
            string cycleId,
            string namespace_
        )
        {
            PathParams["cycleId"] = cycleId;
            PathParams["namespace"] = namespace_;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateStatCycle(
            string cycleId,
            string namespace_,
            Model.StatCycleUpdate body
        )
        {
            PathParams["cycleId"] = cycleId;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/v1/admin/namespaces/{namespace}/statCycles/{cycleId}";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.StatCycleInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.StatCycleInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.StatCycleInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}