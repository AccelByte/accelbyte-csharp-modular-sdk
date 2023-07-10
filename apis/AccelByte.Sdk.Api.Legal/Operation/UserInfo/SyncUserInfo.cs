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

using AccelByte.Sdk.Api.Legal.Model;

namespace AccelByte.Sdk.Api.Legal.Operation
{
    /// <summary>
    /// syncUserInfo
    ///
    ///  Important: GOING TO DEPRECATE
    /// 
    /// Sync user info cache in agreement service with iam service.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:*:LEGAL", action=4 (UPDATE)
    /// </summary>
    public class SyncUserInfo : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SyncUserInfoBuilder Builder { get => new SyncUserInfoBuilder(); }

        public class SyncUserInfoBuilder
            : OperationBuilder<SyncUserInfoBuilder>
        {





            internal SyncUserInfoBuilder() { }

            internal SyncUserInfoBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public SyncUserInfo Build(
                string namespace_
            )
            {
                SyncUserInfo op = new SyncUserInfo(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
                string namespace_
            )
            {
                SyncUserInfo op = Build(
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private SyncUserInfo(SyncUserInfoBuilder builder,
            string namespace_
        )
        {

            if (namespace_ is not null) QueryParams["namespace"] = namespace_;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public SyncUserInfo(
            string namespace_
        )
        {

            if (namespace_ is not null) QueryParams["namespace"] = namespace_;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/userInfo";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return;
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}