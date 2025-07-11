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
    /// mockXblClawbackEvent
    ///
    /// Mock Sync XBox Clawback event.
    /// </summary>
    public class MockXblClawbackEvent : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static MockXblClawbackEventBuilder Builder { get => new MockXblClawbackEventBuilder(); }

        public class MockXblClawbackEventBuilder
            : OperationBuilder<MockXblClawbackEventBuilder>
        {


            public Model.XblClawbackEvent? Body { get; set; }




            internal MockXblClawbackEventBuilder() { }

            internal MockXblClawbackEventBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public MockXblClawbackEventBuilder SetBody(Model.XblClawbackEvent _body)
            {
                Body = _body;
                return this;
            }




            public MockXblClawbackEvent Build(
                string namespace_
            )
            {
                MockXblClawbackEvent op = new MockXblClawbackEvent(this,
                    namespace_                    
                );

                op.SetBaseFields<MockXblClawbackEventBuilder>(this);
                return op;
            }

            public MockXblClawbackEvent.Response Execute(
                string namespace_
            )
            {
                MockXblClawbackEvent op = Build(
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
            public async Task<MockXblClawbackEvent.Response> ExecuteAsync(
                string namespace_
            )
            {
                MockXblClawbackEvent op = Build(
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

            public MockXblClawbackEvent.Response<T1, T2> Execute<T1, T2>(
                string namespace_
            )
            {
                MockXblClawbackEvent op = Build(
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
            public async Task<MockXblClawbackEvent.Response<T1, T2>> ExecuteAsync<T1, T2>(
                string namespace_
            )
            {
                MockXblClawbackEvent op = Build(
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

        private MockXblClawbackEvent(MockXblClawbackEventBuilder builder,
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


            protected override string GetFullOperationId() => "Platform::Clawback::MockXblClawbackEvent";
        }

        public class Response<T1, T2> : ApiResponse<Model.ClawbackInfo<T1, T2>>
        {

            protected override string GetFullOperationId() => "Platform::Clawback::MockXblClawbackEvent";
        }
        #endregion

        public MockXblClawbackEvent(
            string namespace_,            
            Model.XblClawbackEvent body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/iap/clawback/xbl/mock";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public MockXblClawbackEvent.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new MockXblClawbackEvent.Response()
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

        public MockXblClawbackEvent.Response<T1, T2> ParseResponse<T1, T2>(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new MockXblClawbackEvent.Response<T1, T2>()
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