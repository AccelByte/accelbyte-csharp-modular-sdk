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

using AccelByte.Sdk.Api.Group.Model;

namespace AccelByte.Sdk.Api.Group.Operation
{
    /// <summary>
    /// goroutineHandler
    /// </summary>
    public class GoroutineHandler : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GoroutineHandlerBuilder Builder { get => new GoroutineHandlerBuilder(); }

        public class GoroutineHandlerBuilder
            : OperationBuilder<GoroutineHandlerBuilder>
        {





            internal GoroutineHandlerBuilder() { }

            internal GoroutineHandlerBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GoroutineHandler Build(
            )
            {
                GoroutineHandler op = new GoroutineHandler(this
                );

                op.SetBaseFields<GoroutineHandlerBuilder>(this);
                return op;
            }

            public void Execute(
            )
            {
                GoroutineHandler op = Build(
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task ExecuteAsync(
            )
            {
                GoroutineHandler op = Build(
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private GoroutineHandler(GoroutineHandlerBuilder builder
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GoroutineHandler(
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/group/debug/pprof/goroutine";

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