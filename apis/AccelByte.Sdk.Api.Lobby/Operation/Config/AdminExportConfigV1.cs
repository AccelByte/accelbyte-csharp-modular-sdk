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

using AccelByte.Sdk.Api.Lobby.Model;

namespace AccelByte.Sdk.Api.Lobby.Operation
{
    /// <summary>
    /// adminExportConfigV1
    ///
    /// 
    /// Required permission ADMIN:NAMESPACE:{namespace}:LOBBY:CONFIG [READ]
    /// 
    /// Required Scope: social
    /// 
    /// Export lobby configuration to a json file. The file can then be imported from the /import endpoint.
    /// 
    /// JSON Schema of the exported file:
    /// {"required":["namespace","entitlementItemID","chatRateLimitDuration","unregisterDelay","generalRateLimitDuration","autoKickOnDisconnectDelay","chatRateLimitBurst","generalRateLimitBurst","maxPartyMember","autoKickOnDisconnect","profanityFilter","enableChat","entitlementCheck","cancelTicketOnDisconnect","concurrentUsersLimit","readyConsentTimeout","disableInvitationOnJoinParty","allowJoinPartyDuringMatchmaking","allowInviteNonConnectedUser","keepPresenceActivityOnDisconnect","maxDSWaitTime","maxFriendsLimit"],"properties":{"allowInviteNonConnectedUser":{"type":"boolean"},"allowJoinPartyDuringMatchmaking":{"type":"boolean"},"autoKickOnDisconnect":{"type":"boolean"},"autoKickOnDisconnectDelay":{"type":"integer","format":"integer"},"cancelTicketOnDisconnect":{"type":"boolean"},"chatRateLimitBurst":{"type":"integer","format":"int32"},"chatRateLimitDuration":{"type":"integer","format":"integer"},"concurrentUsersLimit":{"type":"integer","format":"int32"},"disableInvitationOnJoinParty":{"type":"boolean"},"enableChat":{"type":"boolean"},"entitlementCheck":{"type":"boolean"},"entitlementItemID":{"type":"string"},"generalRateLimitBurst":{"type":"integer","format":"int32"},"generalRateLimitDuration":{"type":"integer","format":"integer"},"keepPresenceActivityOnDisconnect":{"type":"boolean"},"maxDSWaitTime":{"type":"integer","format":"integer"},"maxFriendsLimit":{"type":"integer","format":"int32"},"maxPartyMember":{"type":"integer","format":"int32"},"namespace":{"type":"string"},"profanityFilter":{"type":"boolean"},"readyConsentTimeout":{"type":"integer","format":"integer"},"unregisterDelay":{"type":"integer","format":"integer"}}}
    /// </summary>
    public class AdminExportConfigV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminExportConfigV1Builder Builder { get => new AdminExportConfigV1Builder(); }

        public class AdminExportConfigV1Builder
            : OperationBuilder<AdminExportConfigV1Builder>
        {





            internal AdminExportConfigV1Builder() { }

            internal AdminExportConfigV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminExportConfigV1 Build(
                string namespace_
            )
            {
                AdminExportConfigV1 op = new AdminExportConfigV1(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Stream? Execute(
                string namespace_
            )
            {
                AdminExportConfigV1 op = Build(
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

        private AdminExportConfigV1(AdminExportConfigV1Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminExportConfigV1(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/admin/config/namespaces/{namespace}/export";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };        
        
        public Stream? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return payload;
            }
            else if (code == (HttpStatusCode)200)
            {
                return payload;
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}