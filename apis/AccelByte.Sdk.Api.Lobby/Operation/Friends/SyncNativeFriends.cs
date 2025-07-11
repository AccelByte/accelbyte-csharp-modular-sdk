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

using AccelByte.Sdk.Api.Lobby.Model;

namespace AccelByte.Sdk.Api.Lobby.Operation
{
    /// <summary>
    /// syncNativeFriends
    ///
    /// Sync friends using server to server call to native first party server.
    /// Supported platforms:
    /// steam: The platform_tokenâs value is the binary ticket returned by Steam.
    /// If this ticket was generated by Steam GetAuthTicketForWebApi with version >= 1.57, then platform token should use this style: {identity}:{ticket}
    /// the {identity} was the parameter to call GetAuthTicketForWebApi when the ticket was created. Note: Do not contain : in this {identity}
    /// ps4: The platform_tokenâs value is the authorization code returned by Sony OAuth.
    /// ps5: The platform_tokenâs value is the authorization code returned by Sony OAuth.
    /// pspc: The platform_tokenâs value is the authorization code returned by Sony OAuth.
    /// </summary>
    public class SyncNativeFriends : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SyncNativeFriendsBuilder Builder { get => new SyncNativeFriendsBuilder(); }

        public class SyncNativeFriendsBuilder
            : OperationBuilder<SyncNativeFriendsBuilder>
        {





            internal SyncNativeFriendsBuilder() { }

            internal SyncNativeFriendsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public SyncNativeFriends Build(
                List<ModelNativeFriendRequest> body,
                string namespace_
            )
            {
                SyncNativeFriends op = new SyncNativeFriends(this,
                    body,                    
                    namespace_                    
                );

                op.SetBaseFields<SyncNativeFriendsBuilder>(this);
                return op;
            }

            public SyncNativeFriends.Response Execute(
                List<ModelNativeFriendRequest> body,
                string namespace_
            )
            {
                SyncNativeFriends op = Build(
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
            public async Task<SyncNativeFriends.Response> ExecuteAsync(
                List<ModelNativeFriendRequest> body,
                string namespace_
            )
            {
                SyncNativeFriends op = Build(
                    body,
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
        }

        private SyncNativeFriends(SyncNativeFriendsBuilder builder,
            List<ModelNativeFriendRequest> body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<List<Model.ModelNativeFriendSyncResponse>>
        {

            public RestapiErrorResponseV1? Error400 { get; set; } = null;

            public RestapiErrorResponseV1? Error401 { get; set; } = null;

            public RestapiErrorResponseV1? Error403 { get; set; } = null;

            public RestapiErrorResponseV1? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Lobby::Friends::SyncNativeFriends";
        }

        #endregion

        public SyncNativeFriends(
            string namespace_,            
            List<Model.ModelNativeFriendRequest> body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/friends/sync/namespaces/{namespace}/me";

        public override HttpMethod Method => HttpMethod.Patch;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public SyncNativeFriends.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new SyncNativeFriends.Response()
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
                response.Data = JsonSerializer.Deserialize<List<Model.ModelNativeFriendSyncResponse>>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<RestapiErrorResponseV1>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<RestapiErrorResponseV1>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<RestapiErrorResponseV1>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<RestapiErrorResponseV1>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}