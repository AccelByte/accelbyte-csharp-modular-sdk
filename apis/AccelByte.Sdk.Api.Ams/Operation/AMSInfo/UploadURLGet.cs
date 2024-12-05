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

using AccelByte.Sdk.Api.Ams.Model;

namespace AccelByte.Sdk.Api.Ams.Operation
{
    /// <summary>
    /// UploadURLGet
    /// </summary>
    public class UploadURLGet : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UploadURLGetBuilder Builder { get => new UploadURLGetBuilder(); }

        public class UploadURLGetBuilder
            : OperationBuilder<UploadURLGetBuilder>
        {





            internal UploadURLGetBuilder() { }

            internal UploadURLGetBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UploadURLGet Build(
            )
            {
                UploadURLGet op = new UploadURLGet(this
                );

                op.SetBaseFields<UploadURLGetBuilder>(this);
                return op;
            }

            public UploadURLGet.Response Execute(
            )
            {
                UploadURLGet op = Build(
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<UploadURLGet.Response> ExecuteAsync(
            )
            {
                UploadURLGet op = Build(
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

        private UploadURLGet(UploadURLGetBuilder builder
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {


            protected override string GetFullOperationId() => "Ams::AMSInfo::UploadURLGet";
        }

        #endregion

        public UploadURLGet(
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ams/v1/upload-url";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public UploadURLGet.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new UploadURLGet.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };


            return response;
        }
    }

}