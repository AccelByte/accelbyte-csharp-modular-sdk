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
    /// AdminListUserIDByPlatformUserIDsV3
    ///
    /// Admin List User ID By Platform User ID
    /// This endpoint intended to list game user ID from the given namespace
    /// This endpoint return list of user ID by given platform ID and list of platform user ID
    /// 
    /// Supported platform:
    /// - steam
    /// - steamopenid
    /// - ps4web
    /// - ps4
    /// - ps5
    /// - live
    /// - xblweb
    /// - oculus
    /// - oculusweb
    /// - facebook
    /// - google
    /// - googleplaygames
    /// - twitch
    /// - discord
    /// - android
    /// - ios
    /// - apple
    /// - device
    /// - justice
    /// - epicgames
    /// - nintendo
    /// - awscognito
    /// - netflix
    /// - snapchat
    /// - oidc platform id
    /// 
    /// Note:
    /// **nintendo platform user ID**: NSA ID need to be appended with Environment ID using colon as separator. e.g kmzwa8awaa:dd1
    /// </summary>
    public class AdminListUserIDByPlatformUserIDsV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminListUserIDByPlatformUserIDsV3Builder Builder { get => new AdminListUserIDByPlatformUserIDsV3Builder(); }

        public class AdminListUserIDByPlatformUserIDsV3Builder
            : OperationBuilder<AdminListUserIDByPlatformUserIDsV3Builder>
        {

            public bool? RawPID { get; set; }

            public bool? RawPUID { get; set; }





            internal AdminListUserIDByPlatformUserIDsV3Builder() { }

            internal AdminListUserIDByPlatformUserIDsV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminListUserIDByPlatformUserIDsV3Builder SetRawPID(bool _rawPID)
            {
                RawPID = _rawPID;
                return this;
            }

            public AdminListUserIDByPlatformUserIDsV3Builder SetRawPUID(bool _rawPUID)
            {
                RawPUID = _rawPUID;
                return this;
            }





            public AdminListUserIDByPlatformUserIDsV3 Build(
                ModelPlatformUserIDRequest body,
                string namespace_,
                string platformId
            )
            {
                AdminListUserIDByPlatformUserIDsV3 op = new AdminListUserIDByPlatformUserIDsV3(this,
                    body,                    
                    namespace_,                    
                    platformId                    
                );

                op.SetBaseFields<AdminListUserIDByPlatformUserIDsV3Builder>(this);
                return op;
            }

            public AdminListUserIDByPlatformUserIDsV3.Response Execute(
                ModelPlatformUserIDRequest body,
                string namespace_,
                string platformId
            )
            {
                AdminListUserIDByPlatformUserIDsV3 op = Build(
                    body,
                    namespace_,
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
            public async Task<AdminListUserIDByPlatformUserIDsV3.Response> ExecuteAsync(
                ModelPlatformUserIDRequest body,
                string namespace_,
                string platformId
            )
            {
                AdminListUserIDByPlatformUserIDsV3 op = Build(
                    body,
                    namespace_,
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

        private AdminListUserIDByPlatformUserIDsV3(AdminListUserIDByPlatformUserIDsV3Builder builder,
            ModelPlatformUserIDRequest body,
            string namespace_,
            string platformId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            
            if (builder.RawPID != null) QueryParams["rawPID"] = Convert.ToString(builder.RawPID)!;
            if (builder.RawPUID != null) QueryParams["rawPUID"] = Convert.ToString(builder.RawPUID)!;
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.AccountcommonUserPlatforms>
        {

            public RestErrorResponse? Error400 { get; set; } = null;

            public RestErrorResponse? Error401 { get; set; } = null;

            public RestErrorResponse? Error403 { get; set; } = null;

            public RestErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Iam::Users::AdminListUserIDByPlatformUserIDsV3";
        }

        #endregion

        public AdminListUserIDByPlatformUserIDsV3(
            string namespace_,            
            string platformId,            
            bool? rawPID,            
            bool? rawPUID,            
            Model.ModelPlatformUserIDRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            
            if (rawPID != null) QueryParams["rawPID"] = Convert.ToString(rawPID)!;
            if (rawPUID != null) QueryParams["rawPUID"] = Convert.ToString(rawPUID)!;
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/platforms/{platformId}/users";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminListUserIDByPlatformUserIDsV3.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminListUserIDByPlatformUserIDsV3.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.AccountcommonUserPlatforms>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}