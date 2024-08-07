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
    /// AdminBulkCheckValidUserIDV4
    ///
    /// Use this endpoint to check if userID exists or not
    /// Maximum number of userID to be checked is 50
    /// </summary>
    public class AdminBulkCheckValidUserIDV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminBulkCheckValidUserIDV4Builder Builder { get => new AdminBulkCheckValidUserIDV4Builder(); }

        public class AdminBulkCheckValidUserIDV4Builder
            : OperationBuilder<AdminBulkCheckValidUserIDV4Builder>
        {





            internal AdminBulkCheckValidUserIDV4Builder() { }

            internal AdminBulkCheckValidUserIDV4Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminBulkCheckValidUserIDV4 Build(
                ModelCheckValidUserIDRequestV4 body,
                string namespace_
            )
            {
                AdminBulkCheckValidUserIDV4 op = new AdminBulkCheckValidUserIDV4(this,
                    body,
                    namespace_
                );

                op.SetBaseFields<AdminBulkCheckValidUserIDV4Builder>(this);
                return op;
            }

            public Model.ModelListValidUserIDResponseV4? Execute(
                ModelCheckValidUserIDRequestV4 body,
                string namespace_
            )
            {
                AdminBulkCheckValidUserIDV4 op = Build(
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
            public async Task<Model.ModelListValidUserIDResponseV4?> ExecuteAsync(
                ModelCheckValidUserIDRequestV4 body,
                string namespace_
            )
            {
                AdminBulkCheckValidUserIDV4 op = Build(
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

        private AdminBulkCheckValidUserIDV4(AdminBulkCheckValidUserIDV4Builder builder,
            ModelCheckValidUserIDRequestV4 body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminBulkCheckValidUserIDV4(
            string namespace_,
            Model.ModelCheckValidUserIDRequestV4 body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/admin/namespaces/{namespace}/users/bulk/validate";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelListValidUserIDResponseV4? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelListValidUserIDResponseV4>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelListValidUserIDResponseV4>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}