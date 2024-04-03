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

using AccelByte.Sdk.Api.Seasonpass.Model;

namespace AccelByte.Sdk.Api.Seasonpass.Operation
{
    /// <summary>
    /// existsAnyPassByPassCodes
    ///
    /// [SERVICE COMMUNICATION ONLY]This API is used to get ownership for any pass codes, season only located in non-publisher namespace.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:SEASONPASS", action=2 (READ)
    ///   *  Returns : ownership
    /// </summary>
    public class ExistsAnyPassByPassCodes : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ExistsAnyPassByPassCodesBuilder Builder { get => new ExistsAnyPassByPassCodesBuilder(); }

        public class ExistsAnyPassByPassCodesBuilder
            : OperationBuilder<ExistsAnyPassByPassCodesBuilder>
        {

            public List<string>? PassCodes { get; set; }





            internal ExistsAnyPassByPassCodesBuilder() { }

            internal ExistsAnyPassByPassCodesBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public ExistsAnyPassByPassCodesBuilder SetPassCodes(List<string> _passCodes)
            {
                PassCodes = _passCodes;
                return this;
            }





            public ExistsAnyPassByPassCodes Build(
                string namespace_,
                string userId
            )
            {
                ExistsAnyPassByPassCodes op = new ExistsAnyPassByPassCodes(this,
                    namespace_,
                    userId
                );

                op.SetBaseFields<ExistsAnyPassByPassCodesBuilder>(this);
                return op;
            }

            public Model.Ownership? Execute(
                string namespace_,
                string userId
            )
            {
                ExistsAnyPassByPassCodes op = Build(
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
            public async Task<Model.Ownership?> ExecuteAsync(
                string namespace_,
                string userId
            )
            {
                ExistsAnyPassByPassCodes op = Build(
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

        private ExistsAnyPassByPassCodes(ExistsAnyPassByPassCodesBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (builder.PassCodes is not null) QueryParams["passCodes"] = builder.PassCodes;



            CollectionFormatMap["passCodes"] = "multi";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ExistsAnyPassByPassCodes(
            string namespace_,
            string userId,
            List<string>? passCodes
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (passCodes is not null) QueryParams["passCodes"] = passCodes;



            CollectionFormatMap["passCodes"] = "multi";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/seasonpass/admin/namespaces/{namespace}/users/{userId}/seasons/current/passes/ownership/any";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.Ownership? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.Ownership>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.Ownership>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}