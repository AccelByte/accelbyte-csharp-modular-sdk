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

using AccelByte.Sdk.Api.Ams.Model;

namespace AccelByte.Sdk.Api.Ams.Operation
{
    /// <summary>
    /// LocalWatchdogConnect
    ///
    /// This is to support local ds development scenarios
    /// 
    /// Required Permission: NAMESPACE:{namespace}:AMS:LOCALDS [CREATE]
    /// </summary>
    public class LocalWatchdogConnect : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static LocalWatchdogConnectBuilder Builder { get => new LocalWatchdogConnectBuilder(); }

        public class LocalWatchdogConnectBuilder
            : OperationBuilder<LocalWatchdogConnectBuilder>
        {





            internal LocalWatchdogConnectBuilder() { }

            internal LocalWatchdogConnectBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public LocalWatchdogConnect Build(
                string namespace_,
                string watchdogID
            )
            {
                LocalWatchdogConnect op = new LocalWatchdogConnect(this,
                    namespace_,
                    watchdogID
                );

                op.SetBaseFields<LocalWatchdogConnectBuilder>(this);
                return op;
            }

            public void Execute(
                string namespace_,
                string watchdogID
            )
            {
                LocalWatchdogConnect op = Build(
                    namespace_,
                    watchdogID
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

        private LocalWatchdogConnect(LocalWatchdogConnectBuilder builder,
            string namespace_,
            string watchdogID
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["watchdogID"] = watchdogID;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public LocalWatchdogConnect(
            string namespace_,
            string watchdogID
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["watchdogID"] = watchdogID;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ams/v1/namespaces/{namespace}/local/{watchdogID}/connect";

        public override HttpMethod Method => HttpMethod.Get;

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