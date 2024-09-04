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

using AccelByte.Sdk.Api.Session.Model;

namespace AccelByte.Sdk.Api.Session.Operation
{
    /// <summary>
    /// threadcreateHandler
    /// </summary>
    public class ThreadcreateHandler : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ThreadcreateHandlerBuilder Builder { get => new ThreadcreateHandlerBuilder(); }

        public class ThreadcreateHandlerBuilder
            : OperationBuilder<ThreadcreateHandlerBuilder>
        {





            internal ThreadcreateHandlerBuilder() { }

            internal ThreadcreateHandlerBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public ThreadcreateHandler Build(
            )
            {
                ThreadcreateHandler op = new ThreadcreateHandler(this
                );

                op.SetBaseFields<ThreadcreateHandlerBuilder>(this);
                return op;
            }

            public void Execute(
            )
            {
                ThreadcreateHandler op = Build(
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
                ThreadcreateHandler op = Build(
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

        private ThreadcreateHandler(ThreadcreateHandlerBuilder builder
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ThreadcreateHandler(
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/admin/internal/pprof/threadcreate";

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