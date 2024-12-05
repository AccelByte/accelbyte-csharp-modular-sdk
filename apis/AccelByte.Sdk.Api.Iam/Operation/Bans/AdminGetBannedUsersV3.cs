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
    /// AdminGetBannedUsersV3
    ///
    /// Ban type is the code
    /// available for ban assignment. It is applicable globally for any namespace.
    /// action code : 10201
    /// </summary>
    public class AdminGetBannedUsersV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetBannedUsersV3Builder Builder { get => new AdminGetBannedUsersV3Builder(); }

        public class AdminGetBannedUsersV3Builder
            : OperationBuilder<AdminGetBannedUsersV3Builder>
        {

            public bool? ActiveOnly { get; set; }

            public string? BanType { get; set; }

            public long? Limit { get; set; }

            public long? Offset { get; set; }





            internal AdminGetBannedUsersV3Builder() { }

            internal AdminGetBannedUsersV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminGetBannedUsersV3Builder SetActiveOnly(bool _activeOnly)
            {
                ActiveOnly = _activeOnly;
                return this;
            }

            public AdminGetBannedUsersV3Builder SetBanType(string _banType)
            {
                BanType = _banType;
                return this;
            }

            public AdminGetBannedUsersV3Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminGetBannedUsersV3Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public AdminGetBannedUsersV3 Build(
                string namespace_
            )
            {
                AdminGetBannedUsersV3 op = new AdminGetBannedUsersV3(this,
                    namespace_
                );

                op.SetBaseFields<AdminGetBannedUsersV3Builder>(this);
                return op;
            }

            public AdminGetBannedUsersV3.Response Execute(
                string namespace_
            )
            {
                AdminGetBannedUsersV3 op = Build(
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
            public async Task<AdminGetBannedUsersV3.Response> ExecuteAsync(
                string namespace_
            )
            {
                AdminGetBannedUsersV3 op = Build(
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

        private AdminGetBannedUsersV3(AdminGetBannedUsersV3Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.ActiveOnly != null) QueryParams["activeOnly"] = Convert.ToString(builder.ActiveOnly)!;
            if (builder.BanType is not null) QueryParams["banType"] = builder.BanType;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelGetUserBanV3Response>
        {

            public RestErrorResponse? Error401 { get; set; } = null;

            public RestErrorResponse? Error403 { get; set; } = null;

            public RestErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Iam::Bans::AdminGetBannedUsersV3";
        }

        #endregion

        public AdminGetBannedUsersV3(
            string namespace_,
            bool? activeOnly,
            string? banType,
            long? limit,
            long? offset
        )
        {
            PathParams["namespace"] = namespace_;

            if (activeOnly != null) QueryParams["activeOnly"] = Convert.ToString(activeOnly)!;
            if (banType is not null) QueryParams["banType"] = banType;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/bans/users";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public AdminGetBannedUsersV3.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminGetBannedUsersV3.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelGetUserBanV3Response>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
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