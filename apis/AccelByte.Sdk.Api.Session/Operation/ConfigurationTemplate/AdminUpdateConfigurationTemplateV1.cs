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

using AccelByte.Sdk.Api.Session.Model;

namespace AccelByte.Sdk.Api.Session.Operation
{
    /// <summary>
    /// adminUpdateConfigurationTemplateV1
    ///
    /// Modify template configuration
    /// Session configuration mandatory :
    /// - name
    /// - joinability. supported values:
    /// - OPEN: user can join or rejoin the session without an invite
    /// - CLOSED: once a CLOSED session is created or a session joinability is updated to CLOSED, any change to session members is not allowed and remaining invites will all be canceled.
    /// - INVITE_ONLY: to join the session, user whether needs to be invited, or have the code (for join by code). when a user is KICKED/LEFT/REJECTED from this session, they will need to be re-invited to join.
    /// - FRIENDS_OF_MEMBERS: only if a user is friend with at least one of the session members, they can join via code.
    /// - FRIENDS_OF_LEADER: only if a user is friend with the session leader, they can join via code.
    /// - FRIENDS_OF_FRIENDS: only friends of the leader OR friends of friends of the leader can join via code.
    /// - autoJoin: when enabled, players will automatically join the initial game session creation. Game session will not send any invite and players dont need to act upon it. default: false (disabled)
    /// - Type (example value : P2P, DS, NONE) if type empty, type will be assign to NONE
    /// - MinPlayers (must greater or equal 0)
    /// - MaxPlayers (must greater than 0)
    /// - InviteTimeout (must greater or equal 0) if InviteTimeout equal 0 will be use default DefaultTimeoutSecond (60s)
    /// - InactiveTimeout (must greater or equal 0) if InactiveTimeout equal 0 will be use default DefaultTimeoutSecond (60s)
    /// - Persistent Flag only can use with type DS (example value true or false)
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
    /// - PSNDisableSystemUIMenu: items whose operation from the PSN system software UI is to be disabled.
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
    /// - TieTeamsSessionLifetime: If it is set to true, the lifetime of any partyId session inside teams attribute will be tied to the game session. Only applies when the teams partyId is game session.
    /// - DisableCodeGeneration (optional, default: false): If it is set to true, code will not be generated for party session automatically.
    /// - DSManualSetReady (optional, default: false): The DS need to call specific end point to flag the DS for game session is ready to accept client connection.
    /// - EnableSecret (optional, default: false): if configuration template is created with TypeDS and EnableSecret is True, A secret will be created.
    /// - ManualRejoin (optional, default: false): indicates if game client will handle manual rejoin upon websocket reconnection when enabled.
    /// - DisableResendInvite (optional, default: false): by default, the service will be sending invites until the user reacts to it. enabling this flag will prohibit the service to send reminder invites'.
    /// - appName (optional, default: empty string). Extend application name that uploaded to AccelByte extends deployment. The application is for custom/external DS management.
    /// - customURLGRPC (optional: default: empty string). Url for grpc server that server custom/external DS management. This value will be ignore when appName is filled. Value formatted as host:port. Example: yourdomain.com:9989
    /// - grpcSessionConfig (optional, default: empty object). Setting for grpc session extends. Session service will calls the grpc when any activity for the game sessions.
    /// - appName (required when customURL is empty) The extends app name that created and uploaded to AccelByte extends deployment.
    /// - customURL (required when appName is empty) The url for grpc server. Format is host:port. Example: mycustomdomain.com:9889. This will be ignore when appName is filled.
    /// - functionFlag (optional, default: -1) Flag to enable which function to calls when any event on the game sessions. The value is bitwise integer.
    /// - 0x1 is for created event. Event is sync, anything return from create event will be overide the final game session.
    /// - 0x2 is for updated event. Event is async. Called when any update on the game session.
    /// - 0x4 is for deleted event. Event is async. Callen when game session got deleted.
    /// Example:
    /// - value 3: enable for created and updated
    /// - value 7: enable for created, updated, and deleted, etc
    /// </summary>
    public class AdminUpdateConfigurationTemplateV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateConfigurationTemplateV1Builder Builder { get => new AdminUpdateConfigurationTemplateV1Builder(); }

        public class AdminUpdateConfigurationTemplateV1Builder
            : OperationBuilder<AdminUpdateConfigurationTemplateV1Builder>
        {





            internal AdminUpdateConfigurationTemplateV1Builder() { }

            internal AdminUpdateConfigurationTemplateV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminUpdateConfigurationTemplateV1 Build(
                ApimodelsUpdateConfigurationTemplateRequest body,
                string name,
                string namespace_
            )
            {
                AdminUpdateConfigurationTemplateV1 op = new AdminUpdateConfigurationTemplateV1(this,
                    body,                    
                    name,                    
                    namespace_                    
                );

                op.SetBaseFields<AdminUpdateConfigurationTemplateV1Builder>(this);
                return op;
            }

            public AdminUpdateConfigurationTemplateV1.Response Execute(
                ApimodelsUpdateConfigurationTemplateRequest body,
                string name,
                string namespace_
            )
            {
                AdminUpdateConfigurationTemplateV1 op = Build(
                    body,
                    name,
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
            public async Task<AdminUpdateConfigurationTemplateV1.Response> ExecuteAsync(
                ApimodelsUpdateConfigurationTemplateRequest body,
                string name,
                string namespace_
            )
            {
                AdminUpdateConfigurationTemplateV1 op = Build(
                    body,
                    name,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }

            public AdminUpdateConfigurationTemplateV1.Response<T1> Execute<T1>(
                ApimodelsUpdateConfigurationTemplateRequest body,
                string name,
                string namespace_
            )
            {
                AdminUpdateConfigurationTemplateV1 op = Build(
                    body,
                    name,
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
            public async Task<AdminUpdateConfigurationTemplateV1.Response<T1>> ExecuteAsync<T1>(
                ApimodelsUpdateConfigurationTemplateRequest body,
                string name,
                string namespace_
            )
            {
                AdminUpdateConfigurationTemplateV1 op = Build(
                    body,
                    name,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse<T1>(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
        }

        private AdminUpdateConfigurationTemplateV1(AdminUpdateConfigurationTemplateV1Builder builder,
            ApimodelsUpdateConfigurationTemplateRequest body,
            string name,
            string namespace_
        )
        {
            PathParams["name"] = name;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ApimodelsConfigurationTemplateResponse>
        {

            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error403 { get; set; } = null;

            public ResponseError? Error404 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Session::ConfigurationTemplate::AdminUpdateConfigurationTemplateV1";
        }

        public class Response<T1> : ApiResponse<Model.ApimodelsConfigurationTemplateResponse<T1>>
        {
            public ResponseError? Error400 { get; set; } = null;

            public ResponseError? Error401 { get; set; } = null;

            public ResponseError? Error403 { get; set; } = null;

            public ResponseError? Error404 { get; set; } = null;

            public ResponseError? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Session::ConfigurationTemplate::AdminUpdateConfigurationTemplateV1";
        }
        #endregion

        public AdminUpdateConfigurationTemplateV1(
            string name,            
            string namespace_,            
            Model.ApimodelsUpdateConfigurationTemplateRequest body            
        )
        {
            PathParams["name"] = name;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/admin/namespaces/{namespace}/configurations/{name}";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminUpdateConfigurationTemplateV1.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminUpdateConfigurationTemplateV1.Response()
            {
                StatusCode = code,
                ContentType = contentType
            };

            if (code == (HttpStatusCode)204)
            {
                response.IsSuccess = true;
            }
            else if ((code == (HttpStatusCode)201) || (code == (HttpStatusCode)202) || (code == (HttpStatusCode)200))
            {
                response.Data = JsonSerializer.Deserialize<Model.ApimodelsConfigurationTemplateResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }

        public AdminUpdateConfigurationTemplateV1.Response<T1> ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminUpdateConfigurationTemplateV1.Response<T1>()
            {
                StatusCode = code,
                ContentType = contentType
            };

            if (code == (HttpStatusCode)204)
            {
                response.IsSuccess = true;
            }            
            else if ((code == (HttpStatusCode)201) || (code == (HttpStatusCode)202) || (code == (HttpStatusCode)200))
            {
                response.Data = JsonSerializer.Deserialize<Model.ApimodelsConfigurationTemplateResponse<T1>>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseError>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }
            
            return response;
        }
    }

}