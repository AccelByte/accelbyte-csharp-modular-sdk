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
    /// resetUserStatItemValue_1
    ///
    /// Reset user's statitem value for a given namespace and user.
    /// User's statitem value will be reset to the default value defined in the statistic configuration.
    /// 
    /// Other detail info:
    /// + *Returns*: updated user's statItem
    /// </summary>
    public class ResetUserStatItemValue1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ResetUserStatItemValue1Builder Builder { get => new ResetUserStatItemValue1Builder(); }

        public class ResetUserStatItemValue1Builder
            : OperationBuilder<ResetUserStatItemValue1Builder>
        {





            internal ResetUserStatItemValue1Builder() { }

            internal ResetUserStatItemValue1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public ResetUserStatItemValue1 Build(
                string namespace_,
                string statCode,
                string userId
            )
            {
                ResetUserStatItemValue1 op = new ResetUserStatItemValue1(this,
                    namespace_,
                    statCode,
                    userId
                );

                op.SetBaseFields<ResetUserStatItemValue1Builder>(this);
                return op;
            }

            public Model.StatItemIncResult? Execute(
                string namespace_,
                string statCode,
                string userId
            )
            {
                ResetUserStatItemValue1 op = Build(
                    namespace_,
                    statCode,
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
            public async Task<Model.StatItemIncResult?> ExecuteAsync(
                string namespace_,
                string statCode,
                string userId
            )
            {
                ResetUserStatItemValue1 op = Build(
                    namespace_,
                    statCode,
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

        private ResetUserStatItemValue1(ResetUserStatItemValue1Builder builder,
            string namespace_,
            string statCode,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["statCode"] = statCode;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ResetUserStatItemValue1(
            string namespace_,
            string statCode,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["statCode"] = statCode;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/v1/public/namespaces/{namespace}/users/{userId}/stats/{statCode}/statitems/value/reset";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.StatItemIncResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.StatItemIncResult>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.StatItemIncResult>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}