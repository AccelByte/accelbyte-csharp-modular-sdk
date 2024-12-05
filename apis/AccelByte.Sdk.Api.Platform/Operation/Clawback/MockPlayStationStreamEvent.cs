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

using AccelByte.Sdk.Api.Platform.Model;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// mockPlayStationStreamEvent
    ///
    /// Mock Sync PlayStation Clawback event..
    /// </summary>
    public class MockPlayStationStreamEvent : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static MockPlayStationStreamEventBuilder Builder { get => new MockPlayStationStreamEventBuilder(); }

        public class MockPlayStationStreamEventBuilder
            : OperationBuilder<MockPlayStationStreamEventBuilder>
        {


            public Model.StreamEvent? Body { get; set; }




            internal MockPlayStationStreamEventBuilder() { }

            internal MockPlayStationStreamEventBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public MockPlayStationStreamEventBuilder SetBody(Model.StreamEvent _body)
            {
                Body = _body;
                return this;
            }




            public MockPlayStationStreamEvent Build(
                string namespace_
            )
            {
                MockPlayStationStreamEvent op = new MockPlayStationStreamEvent(this,
                    namespace_
                );

                op.SetBaseFields<MockPlayStationStreamEventBuilder>(this);
                return op;
            }

            public MockPlayStationStreamEvent.Response Execute(
                string namespace_
            )
            {
                MockPlayStationStreamEvent op = Build(
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
            public async Task<MockPlayStationStreamEvent.Response> ExecuteAsync(
                string namespace_
            )
            {
                MockPlayStationStreamEvent op = Build(
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

            public MockPlayStationStreamEvent.Response<T1, T2> Execute<T1, T2>(
                string namespace_
            )
            {
                MockPlayStationStreamEvent op = Build(
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<MockPlayStationStreamEvent.Response<T1, T2>> ExecuteAsync<T1, T2>(
                string namespace_
            )
            {
                MockPlayStationStreamEvent op = Build(
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse<T1, T2>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private MockPlayStationStreamEvent(MockPlayStationStreamEventBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ClawbackInfo>
        {


            protected override string GetFullOperationId() => "Platform::Clawback::MockPlayStationStreamEvent";
        }

        public class Response<T1, T2> : ApiResponse<Model.ClawbackInfo<T1, T2>>
        {

            protected override string GetFullOperationId() => "Platform::Clawback::MockPlayStationStreamEvent";
        }
        #endregion

        public MockPlayStationStreamEvent(
            string namespace_,
            Model.StreamEvent body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/iap/clawback/playstation/mock";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public MockPlayStationStreamEvent.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new MockPlayStationStreamEvent.Response()
            {
                StatusCode = code,
                ContentType = contentType
            };

            if (code == (HttpStatusCode)204)
            {
                response.IsSuccess = true;
            }
            else if ((code == (HttpStatusCode)201) || (code == (HttpStatusCode)202) || (code == (HttpStatusCode)200))
            {
                response.Data = JsonSerializer.Deserialize<Model.ClawbackInfo>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }

            return response;
        }

        public MockPlayStationStreamEvent.Response<T1, T2> ParseResponse<T1, T2>(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new MockPlayStationStreamEvent.Response<T1, T2>()
            {
                StatusCode = code,
                ContentType = contentType
            };

            if (code == (HttpStatusCode)204)
            {
                response.IsSuccess = true;
            }
            else if ((code == (HttpStatusCode)201) || (code == (HttpStatusCode)202) || (code == (HttpStatusCode)200))
            {
                response.Data = JsonSerializer.Deserialize<Model.ClawbackInfo<T1, T2>>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }

            return response;
        }
    }

}