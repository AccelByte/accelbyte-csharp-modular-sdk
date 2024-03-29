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
    /// publicCreateParty
    ///
    /// A join code will be autogenerated if the party is joinable.
    /// Creator will be removed from previous party (if any) and automatically join into the created party as a leader.
    /// Party members will be sent invitation to join the party.
    /// Session configuration name is optional.
    /// Default configuration name if empty:
    /// {
    /// "name": "default",
    /// "type": "NONE",
    /// "joinability": "OPEN",
    /// "minPlayers": 1,
    /// "maxPlayers": 8,
    /// "inviteTimeout": 60,
    /// "inactiveTimeout": 60,
    /// "textChat": false
    /// }
    /// 
    /// Supported platforms:
    /// 1. STEAM
    /// 2. PSN
    /// 3. XBOX
    /// 
    /// Reserved attributes key:
    /// 1. preference: used to store preference of the leader and it is non-replaceable to keep the initial behavior of
    /// the session regardless the leader changes.
    /// 2. NATIVESESSIONTITLE: used for session sync, to define name of session displayed on PlayStation system UI.
    /// </summary>
    public class PublicCreateParty : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicCreatePartyBuilder Builder { get => new PublicCreatePartyBuilder(); }

        public class PublicCreatePartyBuilder
            : OperationBuilder<PublicCreatePartyBuilder>
        {





            internal PublicCreatePartyBuilder() { }

            internal PublicCreatePartyBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicCreateParty Build(
                ApimodelsCreatePartyRequest body,
                string namespace_
            )
            {
                PublicCreateParty op = new PublicCreateParty(this,
                    body,
                    namespace_
                );

                op.SetBaseFields<PublicCreatePartyBuilder>(this);
                return op;
            }

            public Model.ApimodelsPartySessionResponse? Execute(
                ApimodelsCreatePartyRequest body,
                string namespace_
            )
            {
                PublicCreateParty op = Build(
                    body,
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

            public Model.ApimodelsPartySessionResponse<T1, T2>? Execute<T1, T2>(
                ApimodelsCreatePartyRequest body,
                string namespace_
            )
            {
                PublicCreateParty op = Build(
                    body,
                    namespace_
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

        private PublicCreateParty(PublicCreatePartyBuilder builder,
            ApimodelsCreatePartyRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicCreateParty(
            string namespace_,
            Model.ApimodelsCreatePartyRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/public/namespaces/{namespace}/party";

        public override HttpMethod Method => HttpMethod.Post;

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