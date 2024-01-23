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

using AccelByte.Sdk.Api.Matchmaking.Model;

namespace AccelByte.Sdk.Api.Matchmaking.Operation
{
    /// <summary>
    /// GetAllPartyInAllChannel
    ///
    /// Get all parties queueing in all channels.
    /// </summary>
    public class GetAllPartyInAllChannel : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetAllPartyInAllChannelBuilder Builder { get => new GetAllPartyInAllChannelBuilder(); }

        public class GetAllPartyInAllChannelBuilder
            : OperationBuilder<GetAllPartyInAllChannelBuilder>
        {





            internal GetAllPartyInAllChannelBuilder() { }

            internal GetAllPartyInAllChannelBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetAllPartyInAllChannel Build(
                string namespace_
            )
            {
                GetAllPartyInAllChannel op = new GetAllPartyInAllChannel(this,
                    namespace_
                );

                op.SetBaseFields<GetAllPartyInAllChannelBuilder>(this);
                return op;
            }

            public Dictionary<string, List<Model.ModelsMatchingParty>>? Execute(
                string namespace_
            )
            {
                GetAllPartyInAllChannel op = Build(
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

            public Dictionary<string, List<Model.ModelsMatchingParty<T1>>>? Execute<T1>(
                string namespace_
            )
            {
                GetAllPartyInAllChannel op = Build(
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private GetAllPartyInAllChannel(GetAllPartyInAllChannelBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetAllPartyInAllChannel(
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/matchmaking/v1/admin/namespaces/{namespace}/channels/all/parties";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Dictionary<string, List<Model.ModelsMatchingParty>>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Dictionary<string, List<Model.ModelsMatchingParty>>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Dictionary<string, List<Model.ModelsMatchingParty>>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }

        public Dictionary<string, List<Model.ModelsMatchingParty<T1>>>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Dictionary<string, List<Model.ModelsMatchingParty<T1>>>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Dictionary<string, List<Model.ModelsMatchingParty<T1>>>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}