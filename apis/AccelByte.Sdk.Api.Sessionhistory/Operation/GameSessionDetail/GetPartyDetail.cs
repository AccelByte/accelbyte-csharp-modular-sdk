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

using AccelByte.Sdk.Api.Sessionhistory.Model;

namespace AccelByte.Sdk.Api.Sessionhistory.Operation
{
    /// <summary>
    /// getPartyDetail
    ///
    /// Get party detail.
    /// </summary>
    public class GetPartyDetail : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetPartyDetailBuilder Builder { get => new GetPartyDetailBuilder(); }

        public class GetPartyDetailBuilder
            : OperationBuilder<GetPartyDetailBuilder>
        {





            internal GetPartyDetailBuilder() { }

            internal GetPartyDetailBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetPartyDetail Build(
                string namespace_,
                string sessionId
            )
            {
                GetPartyDetail op = new GetPartyDetail(this,
                    namespace_,
                    sessionId
                );

                op.SetBaseFields<GetPartyDetailBuilder>(this);
                return op;
            }

            public Model.ApimodelsPartyDetail? Execute(
                string namespace_,
                string sessionId
            )
            {
                GetPartyDetail op = Build(
                    namespace_,
                    sessionId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.ApimodelsPartyDetail?> ExecuteAsync(
                string namespace_,
                string sessionId
            )
            {
                GetPartyDetail op = Build(
                    namespace_,
                    sessionId
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

        private GetPartyDetail(GetPartyDetailBuilder builder,
            string namespace_,
            string sessionId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sessionId"] = sessionId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetPartyDetail(
            string namespace_,
            string sessionId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sessionId"] = sessionId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/sessionhistory/v1/admin/namespaces/{namespace}/parties/{sessionId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ApimodelsPartyDetail? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsPartyDetail>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsPartyDetail>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}