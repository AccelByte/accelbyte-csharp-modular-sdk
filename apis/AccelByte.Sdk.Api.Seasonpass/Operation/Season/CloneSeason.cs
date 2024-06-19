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

using AccelByte.Sdk.Api.Seasonpass.Model;

namespace AccelByte.Sdk.Api.Seasonpass.Operation
{
    /// <summary>
    /// cloneSeason
    ///
    /// This API is used to clone a season.
    /// 
    /// Other detail info:
    /// 
    ///   * Returns : cloned season info
    /// </summary>
    public class CloneSeason : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CloneSeasonBuilder Builder { get => new CloneSeasonBuilder(); }

        public class CloneSeasonBuilder
            : OperationBuilder<CloneSeasonBuilder>
        {


            public Model.SeasonCloneRequest? Body { get; set; }




            internal CloneSeasonBuilder() { }

            internal CloneSeasonBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public CloneSeasonBuilder SetBody(Model.SeasonCloneRequest _body)
            {
                Body = _body;
                return this;
            }




            public CloneSeason Build(
                string namespace_,
                string seasonId
            )
            {
                CloneSeason op = new CloneSeason(this,
                    namespace_,
                    seasonId
                );

                op.SetBaseFields<CloneSeasonBuilder>(this);
                return op;
            }

            public Model.SeasonInfo? Execute(
                string namespace_,
                string seasonId
            )
            {
                CloneSeason op = Build(
                    namespace_,
                    seasonId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.SeasonInfo?> ExecuteAsync(
                string namespace_,
                string seasonId
            )
            {
                CloneSeason op = Build(
                    namespace_,
                    seasonId
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

        private CloneSeason(CloneSeasonBuilder builder,
            string namespace_,
            string seasonId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["seasonId"] = seasonId;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CloneSeason(
            string namespace_,
            string seasonId,
            Model.SeasonCloneRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["seasonId"] = seasonId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/clone";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.SeasonInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.SeasonInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.SeasonInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}