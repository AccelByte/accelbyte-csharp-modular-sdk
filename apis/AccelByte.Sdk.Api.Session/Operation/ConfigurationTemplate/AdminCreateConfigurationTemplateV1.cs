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
    /// adminCreateConfigurationTemplateV1
    ///
    /// Create template configuration to be applied across party and session.
    /// Session configuration mandatory :
    /// - name
    /// - joinability (example value : OPEN, CLOSED, INVITE_ONLY)
    /// - autoJoin: when enabled, players will automatically join the initial game session creation. Game session will not send any invite and players dont need to act upon it. default: false (disabled)
    /// - Type (example value : P2P, DS, NONE) if type empty, type will be assign to NONE
    /// - MinPlayers (must greater or equal 0)
    /// - MaxPlayers (must greater than 0)
    /// - InviteTimeout (must greater or equal 0) if InviteTimeout equal 0 will be use default DefaultTimeoutSecond (60s)
    /// - InactiveTimeout (must greater or equal 0) if InactiveTimeout equal 0 will be use default DefaultTimeoutSecond (60s)
    /// - Persistent will only applies to session with type DS (example value true or false, default: false)
    /// - If Persistent True the session always active even DS removing or terminate and Session will be request DS again until DS Ready or Busy.
    /// - To Stop Session Not request again to DS or want Delete Session can Delete Session using endpoint DELETE /session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}
    /// - If Persistent False the session will be inactive if all member left and DS terminate or removing
    /// - nativeSessionSetting:
    /// - XboxSessionTemplateName: the XBox session template name that correspondent to the AB session template, and is needed to define XBox session's joinRestriction and maxMembersCount when doing the session sync.
    /// - XboxServiceConfigID: the XBox service configuration ID.
    /// - PSNServiceLabel: the PSN service label.
    /// - SessionTitle: the session title. In PSN, this will be used to define name of the session thats displayed on PlayStation system UI.
    /// - ShouldSync: to define whether the service needs to do session sync with native platform(s). Default: false (disabled).
    /// - PSNSupportedPlatforms: the PSN supported platforms. In PSN, if ShouldSync true and PSNSupportedPlatforms is empty, then PS5 will be set as default value.
    /// - PSNBaseUrl this is for base URL PSN if not set will be default value https://s2s.sp-int.playstation.net. In a single namespace only 1 PSN Env that can be used. Multiple session template should refers to the same PSN Env as we have in IAM Service.
    /// - https://s2s.sp-int.playstation.net (DEV, need IP Whitelist)
    /// - https://s2s.prod-qa.playstation.net (QA Environment/PSN Certification)
    /// - https://s2s.np.playstation.net (Production)
    /// - localizedSessionName : for localized name and default language
    /// example payload :
    /// "localizedSessionName":{
    /// "defaultLanguage" : "en-US"
    /// "localizedText" :{
    /// "en-US" : "title"
    /// }
    /// }
    /// - if the game client wants to enable push context to PSN, game client will need to store PSN_PUSH_CONTEXT_ID on the player attributes, otherwise Session service will try to populate from the session attributes or auto generate with random UUID if empty.
    /// - TieTeamsSessionLifetime (optional, default: false): If it is set to true, the lifetime of any partyId session inside teams attribute will be tied to the game session. Only applies when the teams partyId is game session.
    /// - DisableCodeGeneration (optional, default: false): If it is set to true, code will not be generated for party session automatically.
    /// - DSManualSetReady (optional, default: false): The DS need to call specific end point to flag the DS for game session is ready to accept client connection.
    /// - EnableSecret (optional, default: false): if configuration template is created with TypeDS and EnableSecret is True, A secret will be created
    /// </summary>
    public class AdminCreateConfigurationTemplateV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminCreateConfigurationTemplateV1Builder Builder { get => new AdminCreateConfigurationTemplateV1Builder(); }

        public class AdminCreateConfigurationTemplateV1Builder
            : OperationBuilder<AdminCreateConfigurationTemplateV1Builder>
        {





            internal AdminCreateConfigurationTemplateV1Builder() { }

            internal AdminCreateConfigurationTemplateV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminCreateConfigurationTemplateV1 Build(
                ApimodelsCreateConfigurationTemplateRequest body,
                string namespace_
            )
            {
                AdminCreateConfigurationTemplateV1 op = new AdminCreateConfigurationTemplateV1(this,
                    body,
                    namespace_
                );

                op.SetBaseFields<AdminCreateConfigurationTemplateV1Builder>(this);
                return op;
            }

            public Model.ApimodelsConfigurationTemplateResponse? Execute(
                ApimodelsCreateConfigurationTemplateRequest body,
                string namespace_
            )
            {
                AdminCreateConfigurationTemplateV1 op = Build(
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

            public Model.ApimodelsConfigurationTemplateResponse<T1>? Execute<T1>(
                ApimodelsCreateConfigurationTemplateRequest body,
                string namespace_
            )
            {
                AdminCreateConfigurationTemplateV1 op = Build(
                    body,
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

        private AdminCreateConfigurationTemplateV1(AdminCreateConfigurationTemplateV1Builder builder,
            ApimodelsCreateConfigurationTemplateRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminCreateConfigurationTemplateV1(
            string namespace_,
            Model.ApimodelsCreateConfigurationTemplateRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/admin/namespaces/{namespace}/configuration";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ApimodelsConfigurationTemplateResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsConfigurationTemplateResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsConfigurationTemplateResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }

        public Model.ApimodelsConfigurationTemplateResponse<T1>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsConfigurationTemplateResponse<T1>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsConfigurationTemplateResponse<T1>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}