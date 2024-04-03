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
    /// AdminUpdateMyUserV4
    ///
    /// This Endpoint support update user based on given data. **Single request can update single field or multi fields.**
    /// Supported field {country, displayName, languageTag, dateOfBirth, avatarUrl, userName}
    /// Country use ISO3166-1 alpha-2 two letter, e.g. US.
    /// Date of Birth format : YYYY-MM-DD, e.g. 2019-04-29.
    /// 
    /// action code : 10103
    /// </summary>
    public class AdminUpdateMyUserV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateMyUserV4Builder Builder { get => new AdminUpdateMyUserV4Builder(); }

        public class AdminUpdateMyUserV4Builder
            : OperationBuilder<AdminUpdateMyUserV4Builder>
        {





            internal AdminUpdateMyUserV4Builder() { }

            internal AdminUpdateMyUserV4Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminUpdateMyUserV4 Build(
                ModelUserUpdateRequestV3 body
            )
            {
                AdminUpdateMyUserV4 op = new AdminUpdateMyUserV4(this,
                    body
                );

                op.SetBaseFields<AdminUpdateMyUserV4Builder>(this);
                return op;
            }

            public Model.ModelUserResponseV3? Execute(
                ModelUserUpdateRequestV3 body
            )
            {
                AdminUpdateMyUserV4 op = Build(
                    body
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.ModelUserResponseV3?> ExecuteAsync(
                ModelUserUpdateRequestV3 body
            )
            {
                AdminUpdateMyUserV4 op = Build(
                    body
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

        private AdminUpdateMyUserV4(AdminUpdateMyUserV4Builder builder,
            ModelUserUpdateRequestV3 body
        )
        {





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminUpdateMyUserV4(
            Model.ModelUserUpdateRequestV3 body
        )
        {





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/admin/users/me";

        public override HttpMethod Method => HttpMethod.Patch;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelUserResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelUserResponseV3>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelUserResponseV3>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}