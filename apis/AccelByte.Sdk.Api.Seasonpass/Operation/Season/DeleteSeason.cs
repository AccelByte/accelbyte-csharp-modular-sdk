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
    /// deleteSeason
    ///
    /// This API is used to delete a season permanently, only draft season can be deleted.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:SEASONPASS", action=8 (DELETE)
    /// </summary>
    public class DeleteSeason : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteSeasonBuilder Builder { get => new DeleteSeasonBuilder(); }

        public class DeleteSeasonBuilder
            : OperationBuilder<DeleteSeasonBuilder>
        {





            internal DeleteSeasonBuilder() { }

            internal DeleteSeasonBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteSeason Build(
                string namespace_,
                string seasonId
            )
            {
                DeleteSeason op = new DeleteSeason(this,
                    namespace_,
                    seasonId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
                string namespace_,
                string seasonId
            )
            {
                DeleteSeason op = Build(
                    namespace_,
                    seasonId
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

        private DeleteSeason(DeleteSeasonBuilder builder,
            string namespace_,
            string seasonId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["seasonId"] = seasonId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteSeason(
            string namespace_,
            string seasonId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["seasonId"] = seasonId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

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