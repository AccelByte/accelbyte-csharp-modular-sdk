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

using AccelByte.Sdk.Api.Sessionbrowser.Model;

namespace AccelByte.Sdk.Api.Sessionbrowser.Operation
{
    /// <summary>
    /// DeleteSessionLocalDS
    ///
    /// Required permission: NAMESPACE:{namespace}:SESSIONBROWSER:SESSION [DELETE]
    /// 
    /// Required scope: social
    /// 
    /// Only use for local DS entry, will error when calling non local DS entry
    /// </summary>
    public class DeleteSessionLocalDS : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteSessionLocalDSBuilder Builder { get => new DeleteSessionLocalDSBuilder(); }

        public class DeleteSessionLocalDSBuilder
            : OperationBuilder<DeleteSessionLocalDSBuilder>
        {





            internal DeleteSessionLocalDSBuilder() { }

            internal DeleteSessionLocalDSBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteSessionLocalDS Build(
                string namespace_,
                string sessionID
            )
            {
                DeleteSessionLocalDS op = new DeleteSessionLocalDS(this,
                    namespace_,
                    sessionID
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelsSessionResponse? Execute(
                string namespace_,
                string sessionID
            )
            {
                DeleteSessionLocalDS op = Build(
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
        }

        private DeleteSessionLocalDS(DeleteSessionLocalDSBuilder builder,
            string namespace_,
            string sessionID
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sessionID"] = sessionID;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteSessionLocalDS(
            string namespace_,
            string sessionID
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sessionID"] = sessionID;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/sessionbrowser/namespaces/{namespace}/gamesession/{sessionID}/localds";

        public override HttpMethod Method => HttpMethod.Delete;

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