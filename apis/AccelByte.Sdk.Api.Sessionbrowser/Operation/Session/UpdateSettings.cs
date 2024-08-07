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
    /// UpdateSettings
    ///
    /// Update game session, used to update OtherSettings
    /// </summary>
    public class UpdateSettings : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateSettingsBuilder Builder { get => new UpdateSettingsBuilder(); }

        public class UpdateSettingsBuilder
            : OperationBuilder<UpdateSettingsBuilder>
        {





            internal UpdateSettingsBuilder() { }

            internal UpdateSettingsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdateSettings Build(
                ModelsUpdateSettingsRequest body,
                string namespace_,
                string sessionID
            )
            {
                UpdateSettings op = new UpdateSettings(this,
                    body,
                    namespace_,
                    sessionID
                );

                op.SetBaseFields<UpdateSettingsBuilder>(this);
                return op;
            }

            public Model.ModelsSessionResponse? Execute(
                ModelsUpdateSettingsRequest body,
                string namespace_,
                string sessionID
            )
            {
                UpdateSettings op = Build(
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
                ModelsUpdateSettingsRequest body,
                string namespace_,
                string sessionID
            )
            {
                UpdateSettings op = Build(
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

        private UpdateSettings(UpdateSettingsBuilder builder,
            ModelsUpdateSettingsRequest body,
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

        public UpdateSettings(
            string namespace_,
            string sessionID,
            Model.ModelsUpdateSettingsRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sessionID"] = sessionID;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/sessionbrowser/namespaces/{namespace}/gamesession/{sessionID}/settings";

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