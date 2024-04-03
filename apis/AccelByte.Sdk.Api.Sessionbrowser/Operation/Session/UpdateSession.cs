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

using AccelByte.Sdk.Api.Sessionbrowser.Model;

namespace AccelByte.Sdk.Api.Sessionbrowser.Operation
{
    /// <summary>
    /// UpdateSession
    ///
    /// Update game session, used to update the current player
    /// </summary>
    public class UpdateSession : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateSessionBuilder Builder { get => new UpdateSessionBuilder(); }

        public class UpdateSessionBuilder
            : OperationBuilder<UpdateSessionBuilder>
        {





            internal UpdateSessionBuilder() { }

            internal UpdateSessionBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdateSession Build(
                ModelsUpdateSessionRequest body,
                string namespace_,
                string sessionID
            )
            {
                UpdateSession op = new UpdateSession(this,
                    body,
                    namespace_,
                    sessionID
                );

                op.SetBaseFields<UpdateSessionBuilder>(this);
                return op;
            }

            public Model.ModelsSessionResponse? Execute(
                ModelsUpdateSessionRequest body,
                string namespace_,
                string sessionID
            )
            {
                UpdateSession op = Build(
                    body,
                    namespace_,
                    sessionID
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.ModelsSessionResponse?> ExecuteAsync(
                ModelsUpdateSessionRequest body,
                string namespace_,
                string sessionID
            )
            {
                UpdateSession op = Build(
                    body,
                    namespace_,
                    sessionID
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

        private UpdateSession(UpdateSessionBuilder builder,
            ModelsUpdateSessionRequest body,
            string namespace_,
            string sessionID
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sessionID"] = sessionID;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateSession(
            string namespace_,
            string sessionID,
            Model.ModelsUpdateSessionRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sessionID"] = sessionID;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/sessionbrowser/namespaces/{namespace}/gamesession/{sessionID}";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsSessionResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsSessionResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsSessionResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}