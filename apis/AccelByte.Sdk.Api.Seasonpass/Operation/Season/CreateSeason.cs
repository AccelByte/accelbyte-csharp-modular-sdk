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

using AccelByte.Sdk.Api.Seasonpass.Model;

namespace AccelByte.Sdk.Api.Seasonpass.Operation
{
    /// <summary>
    /// createSeason
    ///
    /// This API is used to create a season, season only allowed in non-publisher namespace.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:SEASONPASS", action=1 (CREATE)
    ///   *  Returns : created season
    /// </summary>
    public class CreateSeason : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateSeasonBuilder Builder { get => new CreateSeasonBuilder(); }

        public class CreateSeasonBuilder
            : OperationBuilder<CreateSeasonBuilder>
        {


            public Model.SeasonCreate? Body { get; set; }




            internal CreateSeasonBuilder() { }

            internal CreateSeasonBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public CreateSeasonBuilder SetBody(Model.SeasonCreate _body)
            {
                Body = _body;
                return this;
            }




            public CreateSeason Build(
                string namespace_
            )
            {
                CreateSeason op = new CreateSeason(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.SeasonInfo? Execute(
                string namespace_
            )
            {
                CreateSeason op = Build(
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

        private CreateSeason(CreateSeasonBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreateSeason(
            string namespace_,
            Model.SeasonCreate body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/seasonpass/admin/namespaces/{namespace}/seasons";

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
                return JsonSerializer.Deserialize<Model.SeasonInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.SeasonInfo>(payload);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}