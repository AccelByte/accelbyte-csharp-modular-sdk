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

using AccelByte.Sdk.Api.Gdpr.Model;

namespace AccelByte.Sdk.Api.Gdpr.Operation
{
    /// <summary>
    /// AdminRequestDataRetrieval
    ///
    /// Submit user personal data retrieval request.
    /// Scope: account
    /// 
    /// ### Request Header:
    /// - **Content-Type: application/x-www-form-urlencoded**
    /// </summary>
    public class AdminRequestDataRetrieval : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminRequestDataRetrievalBuilder Builder { get => new AdminRequestDataRetrievalBuilder(); }

        public class AdminRequestDataRetrievalBuilder
            : OperationBuilder<AdminRequestDataRetrievalBuilder>
        {



            public string? Password { get; set; }



            internal AdminRequestDataRetrievalBuilder() { }

            internal AdminRequestDataRetrievalBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }




            public AdminRequestDataRetrievalBuilder SetPassword(string _password)
            {
                Password = _password;
                return this;
            }



            public AdminRequestDataRetrieval Build(
                string namespace_,
                string userId
            )
            {
                AdminRequestDataRetrieval op = new AdminRequestDataRetrieval(this,
                    namespace_,
                    userId
                );

                op.SetBaseFields<AdminRequestDataRetrievalBuilder>(this);
                return op;
            }

            public Model.ModelsDataRetrievalResponse? Execute(
                string namespace_,
                string userId
            )
            {
                AdminRequestDataRetrieval op = Build(
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
            public async Task<Model.ModelsDataRetrievalResponse?> ExecuteAsync(
                string namespace_,
                string userId
            )
            {
                AdminRequestDataRetrieval op = Build(
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

        private AdminRequestDataRetrieval(AdminRequestDataRetrievalBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;


            if (builder.Password is not null) FormParams["password"] = builder.Password;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminRequestDataRetrieval(
            string namespace_,
            string userId,
            string? password
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;


            if (password is not null) FormParams["password"] = password;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/gdpr/admin/namespaces/{namespace}/users/{userId}/requests";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/x-www-form-urlencoded" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsDataRetrievalResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsDataRetrievalResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsDataRetrievalResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}