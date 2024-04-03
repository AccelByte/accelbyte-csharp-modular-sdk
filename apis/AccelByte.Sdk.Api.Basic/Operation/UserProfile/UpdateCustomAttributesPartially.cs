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

using AccelByte.Sdk.Api.Basic.Model;

namespace AccelByte.Sdk.Api.Basic.Operation
{
    /// <summary>
    /// updateCustomAttributesPartially
    ///
    /// Update partially custom attributes tied to the user id.
    /// Other detail info:
    /// 
    ///   * Required permission : resource= "ADMIN:NAMESPACE:{namespace}:USER:{userId}:PROFILE" , action=4 (UPDATE)
    ///   *  Action code : 11402
    ///   *  Request body : allowed format: JSON object
    ///   *  Returns : Updated custom attributes
    /// </summary>
    public class UpdateCustomAttributesPartially : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateCustomAttributesPartiallyBuilder Builder { get => new UpdateCustomAttributesPartiallyBuilder(); }

        public class UpdateCustomAttributesPartiallyBuilder
            : OperationBuilder<UpdateCustomAttributesPartiallyBuilder>
        {


            public Dictionary<string, object>? Body { get; set; }




            internal UpdateCustomAttributesPartiallyBuilder() { }

            internal UpdateCustomAttributesPartiallyBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public UpdateCustomAttributesPartiallyBuilder SetBody(Dictionary<string, object> _body)
            {
                Body = _body;
                return this;
            }




            public UpdateCustomAttributesPartially Build(
                string namespace_,
                string userId
            )
            {
                UpdateCustomAttributesPartially op = new UpdateCustomAttributesPartially(this,
                    namespace_,
                    userId
                );

                op.SetBaseFields<UpdateCustomAttributesPartiallyBuilder>(this);
                return op;
            }

            public Dictionary<string, object>? Execute(
                string namespace_,
                string userId
            )
            {
                UpdateCustomAttributesPartially op = Build(
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
            public async Task<Dictionary<string, object>?> ExecuteAsync(
                string namespace_,
                string userId
            )
            {
                UpdateCustomAttributesPartially op = Build(
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

        private UpdateCustomAttributesPartially(UpdateCustomAttributesPartiallyBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateCustomAttributesPartially(
            string namespace_,
            string userId,
            Dictionary<string, object> body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/basic/v1/admin/namespaces/{namespace}/users/{userId}/profiles/customAttributes";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Dictionary<string, object>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Dictionary<string, object>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Dictionary<string, object>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}