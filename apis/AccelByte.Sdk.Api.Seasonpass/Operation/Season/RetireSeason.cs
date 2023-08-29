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
    /// retireSeason
    ///
    /// This API is used to retire a published season, if the season has not ended it will report error except with force.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:SEASONPASS", action=4 (UPDATE)
    ///   *  Returns : season info
    /// </summary>
    public class RetireSeason : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RetireSeasonBuilder Builder { get => new RetireSeasonBuilder(); }

        public class RetireSeasonBuilder
            : OperationBuilder<RetireSeasonBuilder>
        {

            public bool? Force { get; set; }





            internal RetireSeasonBuilder() { }

            internal RetireSeasonBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public RetireSeasonBuilder SetForce(bool _force)
            {
                Force = _force;
                return this;
            }





            public RetireSeason Build(
                string namespace_,
                string seasonId
            )
            {
                RetireSeason op = new RetireSeason(this,
                    namespace_,
                    seasonId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.SeasonInfo? Execute(
                string namespace_,
                string seasonId
            )
            {
                RetireSeason op = Build(
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
        }

        private RetireSeason(RetireSeasonBuilder builder,
            string namespace_,
            string seasonId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["seasonId"] = seasonId;

            if (builder.Force != null) QueryParams["force"] = Convert.ToString(builder.Force)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public RetireSeason(
            string namespace_,
            string seasonId,
            bool? force
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["seasonId"] = seasonId;

            if (force != null) QueryParams["force"] = Convert.ToString(force)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/retire";

        public override HttpMethod Method => HttpMethod.Put;

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