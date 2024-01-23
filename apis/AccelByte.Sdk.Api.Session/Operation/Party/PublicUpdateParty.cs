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

using AccelByte.Sdk.Api.Session.Model;

namespace AccelByte.Sdk.Api.Session.Operation
{
    /// <summary>
    /// publicUpdateParty
    ///
    /// Updates party blob, this endpoint will override stored party data.
    /// 
    /// Join type can only be updated by the party's leader.
    /// To update only specified fields, please use following endpoint:
    /// method : PATCH
    /// API : /session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}
    /// 
    /// Reserved attributes key:
    /// 1. preference: used to store preference of the leader and it is non-replaceable to keep the initial behavior of
    /// the session regardless the leader changes.
    /// 2. NATIVESESSIONTITLE: used for session sync, to define name of session displayed on PlayStation system UI.
    /// </summary>
    public class PublicUpdateParty : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicUpdatePartyBuilder Builder { get => new PublicUpdatePartyBuilder(); }

        public class PublicUpdatePartyBuilder
            : OperationBuilder<PublicUpdatePartyBuilder>
        {





            internal PublicUpdatePartyBuilder() { }

            internal PublicUpdatePartyBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicUpdateParty Build(
                ApimodelsUpdatePartyRequest body,
                string namespace_,
                string partyId
            )
            {
                PublicUpdateParty op = new PublicUpdateParty(this,
                    body,
                    namespace_,
                    partyId
                );

                op.SetBaseFields<PublicUpdatePartyBuilder>(this);
                return op;
            }

            public Model.ApimodelsPartySessionResponse? Execute(
                ApimodelsUpdatePartyRequest body,
                string namespace_,
                string partyId
            )
            {
                PublicUpdateParty op = Build(
                    body,
                    namespace_,
                    partyId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }

            public Model.ApimodelsPartySessionResponse<T1, T2>? Execute<T1, T2>(
                ApimodelsUpdatePartyRequest body,
                string namespace_,
                string partyId
            )
            {
                PublicUpdateParty op = Build(
                    body,
                    namespace_,
                    partyId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private PublicUpdateParty(PublicUpdatePartyBuilder builder,
            ApimodelsUpdatePartyRequest body,
            string namespace_,
            string partyId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["partyId"] = partyId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicUpdateParty(
            string namespace_,
            string partyId,
            Model.ApimodelsUpdatePartyRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["partyId"] = partyId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/public/namespaces/{namespace}/parties/{partyId}";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ApimodelsPartySessionResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsPartySessionResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsPartySessionResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }

        public Model.ApimodelsPartySessionResponse<T1, T2>? ParseResponse<T1, T2>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsPartySessionResponse<T1, T2>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsPartySessionResponse<T1, T2>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}