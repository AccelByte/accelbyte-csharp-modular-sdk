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

using AccelByte.Sdk.Api.Legal.Model;

namespace AccelByte.Sdk.Api.Legal.Operation
{
    /// <summary>
    /// retrieveAcceptedAgreementsForMultiUsers
    ///
    /// This API will return all accepted Legal Agreements for each user, including agreements of game users if publisher user has corresponding game accountOther detail info:
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:LEGAL", action=2 (READ)
    /// </summary>
    public class RetrieveAcceptedAgreementsForMultiUsers : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RetrieveAcceptedAgreementsForMultiUsersBuilder Builder { get => new RetrieveAcceptedAgreementsForMultiUsersBuilder(); }

        public class RetrieveAcceptedAgreementsForMultiUsersBuilder
            : OperationBuilder<RetrieveAcceptedAgreementsForMultiUsersBuilder>
        {


            public Model.UsersAgreementsRequest? Body { get; set; }




            internal RetrieveAcceptedAgreementsForMultiUsersBuilder() { }

            internal RetrieveAcceptedAgreementsForMultiUsersBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public RetrieveAcceptedAgreementsForMultiUsersBuilder SetBody(Model.UsersAgreementsRequest _body)
            {
                Body = _body;
                return this;
            }




            public RetrieveAcceptedAgreementsForMultiUsers Build(
                string namespace_
            )
            {
                RetrieveAcceptedAgreementsForMultiUsers op = new RetrieveAcceptedAgreementsForMultiUsers(this,
                    namespace_
                );

                op.SetBaseFields<RetrieveAcceptedAgreementsForMultiUsersBuilder>(this);
                return op;
            }

            public List<Model.UserAgreementsResponse>? Execute(
                string namespace_
            )
            {
                RetrieveAcceptedAgreementsForMultiUsers op = Build(
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

        private RetrieveAcceptedAgreementsForMultiUsers(RetrieveAcceptedAgreementsForMultiUsersBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public RetrieveAcceptedAgreementsForMultiUsers(
            string namespace_,
            Model.UsersAgreementsRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/namespaces/{namespace}/agreements";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public List<Model.UserAgreementsResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.UserAgreementsResponse>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.UserAgreementsResponse>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}