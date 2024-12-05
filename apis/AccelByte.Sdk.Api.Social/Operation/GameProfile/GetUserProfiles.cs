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

using AccelByte.Sdk.Api.Social.Model;

namespace AccelByte.Sdk.Api.Social.Operation
{
    /// <summary>
    /// getUserProfiles
    ///
    /// Returns all profiles' header for a user.
    /// Other detail info:
    ///         *  Returns : list of profiles
    /// </summary>
    public class GetUserProfiles : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserProfilesBuilder Builder { get => new GetUserProfilesBuilder(); }

        public class GetUserProfilesBuilder
            : OperationBuilder<GetUserProfilesBuilder>
        {





            internal GetUserProfilesBuilder() { }

            internal GetUserProfilesBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetUserProfiles Build(
                string namespace_,
                string userId
            )
            {
                GetUserProfiles op = new GetUserProfiles(this,
                    namespace_,
                    userId
                );

                op.SetBaseFields<GetUserProfilesBuilder>(this);
                return op;
            }

            public GetUserProfiles.Response Execute(
                string namespace_,
                string userId
            )
            {
                GetUserProfiles op = Build(
                    namespace_,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<GetUserProfiles.Response> ExecuteAsync(
                string namespace_,
                string userId
            )
            {
                GetUserProfiles op = Build(
                    namespace_,
                    userId
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

        private GetUserProfiles(GetUserProfilesBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<List<Model.GameProfileHeader>>
        {

            public ErrorEntity? Error401 { get; set; } = null;

            public ErrorEntity? Error403 { get; set; } = null;

            public ErrorEntity? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Social::GameProfile::GetUserProfiles";
        }

        #endregion

        public GetUserProfiles(
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/admin/namespaces/{namespace}/users/{userId}/profiles";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public GetUserProfiles.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetUserProfiles.Response()
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
                response.Data = JsonSerializer.Deserialize<List<Model.GameProfileHeader>>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}