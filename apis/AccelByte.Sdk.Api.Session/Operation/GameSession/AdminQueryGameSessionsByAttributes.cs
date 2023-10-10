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
    /// adminQueryGameSessionsByAttributes
    ///
    /// Query game sessions by admin.
    /// 
    /// By default, API will return a list of available game sessions (joinability: open).
    /// Session service has several DSInformation status to track DS request to DSMC:
    /// - NEED_TO_REQUEST: number of active players hasn't reached session's minPlayers therefore DS has not yet requested.
    /// - REQUESTED: DS is being requested to DSMC.
    /// - AVAILABLE: DS is ready to use. The DSMC status for this DS is either READY/BUSY.
    /// - FAILED_TO_REQUEST: DSMC fails to create the DS.
    /// 
    /// query parameter "availability" to filter sessions' availability:
    /// all: return all sessions regardless it's full
    /// full: only return active sessions
    /// default behavior (unset or else): return only available sessions (not full)
    /// </summary>
    public class AdminQueryGameSessionsByAttributes : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminQueryGameSessionsByAttributesBuilder Builder { get => new AdminQueryGameSessionsByAttributesBuilder(); }

        public class AdminQueryGameSessionsByAttributesBuilder
            : OperationBuilder<AdminQueryGameSessionsByAttributesBuilder>
        {





            internal AdminQueryGameSessionsByAttributesBuilder() { }

            internal AdminQueryGameSessionsByAttributesBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminQueryGameSessionsByAttributes Build(
                Dictionary<string, object> body,
                string namespace_
            )
            {
                AdminQueryGameSessionsByAttributes op = new AdminQueryGameSessionsByAttributes(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ApimodelsGameSessionQueryResponse? Execute(
                Dictionary<string, object> body,
                string namespace_
            )
            {
                AdminQueryGameSessionsByAttributes op = Build(
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
        }

        private AdminQueryGameSessionsByAttributes(AdminQueryGameSessionsByAttributesBuilder builder,
            Dictionary<string, object> body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminQueryGameSessionsByAttributes(
            string namespace_,
            Dictionary<string, object> body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/admin/namespaces/{namespace}/gamesessions";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ApimodelsGameSessionQueryResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsGameSessionQueryResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsGameSessionQueryResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}