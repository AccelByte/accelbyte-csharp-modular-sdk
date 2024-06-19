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

using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// PlatformTokenGrantV3
    ///
    /// Platform token grant specifically used for performing token grant using platform, e.g. Steam, Justice, etc. The endpoint automatically create an account if the account associated with the platform is not exists yet.
    /// This endpoint requires all requests to have Authorization header set with Basic access authentication
    /// constructed from client id and client secret. For publisher-game namespace schema : Specify only either platform_token or device_id. Device token grant
    /// should be requested along with device_id parameter against game namespace. Another 3rd party platform token grant should be requested
    /// along with platform_token parameter against publisher namespace.
    /// ## 2FA remember device
    /// To remember device for 2FA, should provide cookie: device_token or header: Device-Token
    /// ## Supported platforms:
    /// - **steam**: The platform_tokenâs value is the binary ticket returned by Steam.
    /// If this ticket was generated by Steam GetAuthTicketForWebApi with version >= 1.57, then platform token should use this style: `{identity}:{ticket}`, the `{identity}` was the parameter to call GetAuthTicketForWebApi when the ticket was created. Note: Do not contain `:` in this `{identity}`.
    /// - **steamopenid**: Steam's user authentication method using OpenID 2.0. The platform_token's value is URL generated by Steam on web authentication
    /// - **facebook**: The platform_tokenâs value is the authorization code returned by Facebook OAuth
    /// - **google**: The platform_tokenâs value is the authorization code or idToken returned by Google OAuth
    /// - **googleplaygames**: The platform_tokenâs value is the authorization code or idToken returned by Google play games OAuth
    /// - **oculus**: The platform_tokenâs value is a string composed of Oculus's user ID and the nonce separated by a colon (:).
    /// - **twitch**: The platform_tokenâs value is the authorization code returned by Twitch OAuth.
    /// - **discord**: The platform_tokenâs value is the authorization code returned by Discord OAuth
    /// - **android**: The device_id is the Androidâs device ID
    /// - **ios**: The device_id is the iOSâs device ID.
    /// - **apple**: The platform_tokenâs value is the authorization code or idToken returned by Apple OAuth.(We will use this code to generate APP token)
    /// - **device**: Every device that doesânt run Android and iOS is categorized as a device. The device_id is the deviceâs ID.
    /// - **justice**: The platform_tokenâs value is the designated userâs access token.
    /// - **epicgames**: The platform_tokenâs value is an access-token or authorization code obtained from Epicgames EOS Account Service.
    /// - **ps4**: The platform_tokenâs value is the authorization code returned by Sony OAuth.
    /// - **ps5**: The platform_tokenâs value is the authorization code returned by Sony OAuth.
    /// - **nintendo**: The platform_tokenâs value is the id_token returned by Nintendo OAuth.
    /// - **awscognito**: The platform_tokenâs value is the aws cognito access token or id token (JWT).
    /// - **live**: The platform_tokenâs value is xbox XSTS token
    /// - **xblweb**: The platform_tokenâs value is code returned by xbox after login
    /// - **netflix**: The platform_tokenâs value is GAT (Gamer Access Token) returned by Netflix backend
    /// - **snapchat**: The platform_tokenâs value is the authorization code returned by Snapchat OAuth.
    /// - **for specific generic oauth (OIDC)**: The platform_tokenâs value should be the same type as created OIDC auth type whether it is auth code, idToken or bearerToken.
    /// 
    /// ## Account Group
    /// Several platforms are grouped under account groups. The accounts on these platforms have the same platform user id.
    /// Login using one of these platform will returns the same IAM user.
    /// Following is the current registered account grouping:
    /// - Steam group(steamnetwork):
    /// - steam
    /// - steamopenid
    /// - PSN group(psn)
    /// - ps4web
    /// - ps4
    /// - ps5
    /// - XBOX group(xbox)
    /// - live
    /// - xblweb
    /// - Oculus group(oculusgroup)
    /// - oculus
    /// - oculusweb
    /// 
    /// ## Access Token Content
    /// Following is the access tokenâs content:
    /// - **namespace**. It is the namespace the token was generated from.
    /// - **display_name**. The display name of the sub. It is empty if the token is generated from the client credential
    /// - **roles**. The subâs roles. It is empty if the token is generated from the client credential
    /// - **namespace_roles**. The subâs roles scoped to namespace. Improvement from roles, which make the role scoped to specific namespace instead of global to publisher namespace
    /// - **permissions**. The sub or audâ permissions
    /// - **bans**. The subâs list of bans. It is used by the IAM client for validating the token.
    /// - **jflgs**. It stands for Justice Flags. It is a special flag used for storing additional status information regarding the sub. It is implemented as a bit mask. Following explains what each bit represents:
    /// - 1: Email Address Verified
    /// - 2: Phone Number Verified
    /// - 4: Anonymous
    /// - 8: Suspicious Login
    /// - **aud**. The aud is the client ID.
    /// - **iat**. The time the token issues at. It is in Epoch time format
    /// - **exp**. The time the token expires. It is in Epoch time format
    /// - **sub**. The UserID. The sub is omitted if the token is generated from client credential
    /// 
    /// ## Bans
    /// The JWT contains user's active bans with its expiry date. List of ban types can be obtained from /bans.
    /// 
    /// action code : 10704
    /// </summary>
    public class PlatformTokenGrantV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PlatformTokenGrantV3Builder Builder { get => new PlatformTokenGrantV3Builder(); }

        public class PlatformTokenGrantV3Builder
            : OperationBuilder<PlatformTokenGrantV3Builder>
        {



            public string? AdditionalData { get; set; }

            public string? ClientId { get; set; }

            public bool? CreateHeadless { get; set; }

            public string? DeviceId { get; set; }

            public string? MacAddress { get; set; }

            public string? PlatformToken { get; set; }

            public double? ServiceLabel { get; set; }

            public bool? SkipSetCookie { get; set; }



            internal PlatformTokenGrantV3Builder() { }

            internal PlatformTokenGrantV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }




            public PlatformTokenGrantV3Builder SetAdditionalData(string _additionalData)
            {
                AdditionalData = _additionalData;
                return this;
            }

            public PlatformTokenGrantV3Builder SetClientId(string _clientId)
            {
                ClientId = _clientId;
                return this;
            }

            public PlatformTokenGrantV3Builder SetCreateHeadless(bool _createHeadless)
            {
                CreateHeadless = _createHeadless;
                return this;
            }

            public PlatformTokenGrantV3Builder SetDeviceId(string _deviceId)
            {
                DeviceId = _deviceId;
                return this;
            }

            public PlatformTokenGrantV3Builder SetMacAddress(string _macAddress)
            {
                MacAddress = _macAddress;
                return this;
            }

            public PlatformTokenGrantV3Builder SetPlatformToken(string _platformToken)
            {
                PlatformToken = _platformToken;
                return this;
            }

            public PlatformTokenGrantV3Builder SetServiceLabel(double _serviceLabel)
            {
                ServiceLabel = _serviceLabel;
                return this;
            }

            public PlatformTokenGrantV3Builder SetSkipSetCookie(bool _skipSetCookie)
            {
                SkipSetCookie = _skipSetCookie;
                return this;
            }



            public PlatformTokenGrantV3 Build(
                string platformId
            )
            {
                PlatformTokenGrantV3 op = new PlatformTokenGrantV3(this,
                    platformId
                );

                op.SetBaseFields<PlatformTokenGrantV3Builder>(this);
                return op;
            }

            public Model.OauthmodelTokenResponse? Execute(
                string platformId
            )
            {
                PlatformTokenGrantV3 op = Build(
                    platformId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.OauthmodelTokenResponse?> ExecuteAsync(
                string platformId
            )
            {
                PlatformTokenGrantV3 op = Build(
                    platformId
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

        private PlatformTokenGrantV3(PlatformTokenGrantV3Builder builder,
            string platformId
        )
        {
            PathParams["platformId"] = platformId;


            if (builder.AdditionalData is not null) FormParams["additionalData"] = builder.AdditionalData;
            if (builder.ClientId is not null) FormParams["client_id"] = builder.ClientId;
            if (builder.CreateHeadless != null) FormParams["createHeadless"] = Convert.ToString(builder.CreateHeadless)!;
            if (builder.DeviceId is not null) FormParams["device_id"] = builder.DeviceId;
            if (builder.MacAddress is not null) FormParams["macAddress"] = builder.MacAddress;
            if (builder.PlatformToken is not null) FormParams["platform_token"] = builder.PlatformToken;
            if (builder.ServiceLabel != null) FormParams["serviceLabel"] = Convert.ToString(builder.ServiceLabel)!;
            if (builder.SkipSetCookie != null) FormParams["skipSetCookie"] = Convert.ToString(builder.SkipSetCookie)!;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BASIC);
        }
        #endregion

        public PlatformTokenGrantV3(
            string platformId,
            string? additionalData,
            string? clientId,
            bool? createHeadless,
            string? deviceId,
            string? macAddress,
            string? platformToken,
            double? serviceLabel,
            bool? skipSetCookie
        )
        {
            PathParams["platformId"] = platformId;


            if (additionalData is not null) FormParams["additionalData"] = additionalData;
            if (clientId is not null) FormParams["client_id"] = clientId;
            if (createHeadless != null) FormParams["createHeadless"] = Convert.ToString(createHeadless)!;
            if (deviceId is not null) FormParams["device_id"] = deviceId;
            if (macAddress is not null) FormParams["macAddress"] = macAddress;
            if (platformToken is not null) FormParams["platform_token"] = platformToken;
            if (serviceLabel != null) FormParams["serviceLabel"] = Convert.ToString(serviceLabel)!;
            if (skipSetCookie != null) FormParams["skipSetCookie"] = Convert.ToString(skipSetCookie)!;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BASIC);
        }

        public override string Path => "/iam/v3/oauth/platforms/{platformId}/token";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/x-www-form-urlencoded" };

        public override List<string> Produces => new() { "application/json" };

        public Model.OauthmodelTokenResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.OauthmodelTokenResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.OauthmodelTokenResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}