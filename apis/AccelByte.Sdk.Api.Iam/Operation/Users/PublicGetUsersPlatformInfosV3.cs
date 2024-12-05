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
    /// PublicGetUsersPlatformInfosV3
    ///
    /// Note:
    /// 1. the max count of user ids in the request is 100
    /// 2. if platform id is not empty, the result will only contain the corresponding platform infos
    /// 3. if platform id is empty, the result will contain all the supported platform infos
    /// 
    /// __Supported 3rd platforms:__
    /// 
    /// * __PSN(ps4web, ps4, ps5)__
    /// * account id
    /// * display name
    /// * avatar
    /// * __Xbox(live, xblweb)__
    /// * xuid or pxuid
    /// * display name
    /// * __Steam(steam, steamopenid)__
    /// * steam id
    /// * display name
    /// * avatar
    /// * __EpicGames(epicgames)__
    /// * epic account id
    /// * display name
    /// </summary>
    public class PublicGetUsersPlatformInfosV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetUsersPlatformInfosV3Builder Builder { get => new PublicGetUsersPlatformInfosV3Builder(); }

        public class PublicGetUsersPlatformInfosV3Builder
            : OperationBuilder<PublicGetUsersPlatformInfosV3Builder>
        {





            internal PublicGetUsersPlatformInfosV3Builder() { }

            internal PublicGetUsersPlatformInfosV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicGetUsersPlatformInfosV3 Build(
                ModelUsersPlatformInfosRequestV3 body,
                string namespace_
            )
            {
                PublicGetUsersPlatformInfosV3 op = new PublicGetUsersPlatformInfosV3(this,
                    body,
                    namespace_
                );

                op.SetBaseFields<PublicGetUsersPlatformInfosV3Builder>(this);
                return op;
            }

            public PublicGetUsersPlatformInfosV3.Response Execute(
                ModelUsersPlatformInfosRequestV3 body,
                string namespace_
            )
            {
                PublicGetUsersPlatformInfosV3 op = Build(
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
            public async Task<PublicGetUsersPlatformInfosV3.Response> ExecuteAsync(
                ModelUsersPlatformInfosRequestV3 body,
                string namespace_
            )
            {
                PublicGetUsersPlatformInfosV3 op = Build(
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

        private PublicGetUsersPlatformInfosV3(PublicGetUsersPlatformInfosV3Builder builder,
            ModelUsersPlatformInfosRequestV3 body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelUsersPlatformInfosResponse>
        {

            public RestErrorResponse? Error400 { get; set; } = null;

            public RestErrorResponse? Error401 { get; set; } = null;

            public RestErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Iam::Users::PublicGetUsersPlatformInfosV3";
        }

        #endregion

        public PublicGetUsersPlatformInfosV3(
            string namespace_,
            Model.ModelUsersPlatformInfosRequestV3 body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/users/platforms";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public PublicGetUsersPlatformInfosV3.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new PublicGetUsersPlatformInfosV3.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelUsersPlatformInfosResponse>(payload, ResponseJsonOptions);
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
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}