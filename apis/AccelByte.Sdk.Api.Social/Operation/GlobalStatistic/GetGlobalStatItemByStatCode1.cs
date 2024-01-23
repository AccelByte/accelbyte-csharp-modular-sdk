// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
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

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Net.Http;

using AccelByte.Sdk.Api.Social.Model;

namespace AccelByte.Sdk.Api.Social.Operation
{
    /// <summary>
    /// getGlobalStatItemByStatCode_1
    ///
    /// Get global statItem by stat code.
    /// Other detail info:
    ///             *  Required permission : resource="NAMESPACE:{namespace}:STATITEM", action=2 (READ)
    ///             *  Returns : global stat item
    /// </summary>
    public class GetGlobalStatItemByStatCode1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetGlobalStatItemByStatCode1Builder Builder { get => new GetGlobalStatItemByStatCode1Builder(); }

        public class GetGlobalStatItemByStatCode1Builder
            : OperationBuilder<GetGlobalStatItemByStatCode1Builder>
        {





            internal GetGlobalStatItemByStatCode1Builder() { }

            internal GetGlobalStatItemByStatCode1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetGlobalStatItemByStatCode1 Build(
                string namespace_,
                string statCode
            )
            {
                GetGlobalStatItemByStatCode1 op = new GetGlobalStatItemByStatCode1(this,
                    namespace_,
                    statCode
                );

                op.SetBaseFields<GetGlobalStatItemByStatCode1Builder>(this);
                return op;
            }

            public Model.GlobalStatItemInfo? Execute(
                string namespace_,
                string statCode
            )
            {
                GetGlobalStatItemByStatCode1 op = Build(
                    namespace_,
                    statCode
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private GetGlobalStatItemByStatCode1(GetGlobalStatItemByStatCode1Builder builder,
            string namespace_,
            string statCode
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["statCode"] = statCode;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetGlobalStatItemByStatCode1(
            string namespace_,
            string statCode
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["statCode"] = statCode;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/v1/public/namespaces/{namespace}/globalstatitems/{statCode}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.GlobalStatItemInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.GlobalStatItemInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.GlobalStatItemInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}