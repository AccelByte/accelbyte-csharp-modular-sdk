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
    /// getSlotData
    ///
    /// 
    /// 
    /// ## The endpoint is going to be deprecated
    /// 
    /// 
    /// Get slot data.
    /// Other detail info:
    ///         *  Returns : slot data
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class GetSlotData : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetSlotDataBuilder Builder { get => new GetSlotDataBuilder(); }

        public class GetSlotDataBuilder
            : OperationBuilder<GetSlotDataBuilder>
        {





            internal GetSlotDataBuilder() { }

            internal GetSlotDataBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetSlotData Build(
                string namespace_,
                string slotId,
                string userId
            )
            {
                GetSlotData op = new GetSlotData(this,
                    namespace_,
                    slotId,
                    userId
                );

                op.SetBaseFields<GetSlotDataBuilder>(this);
                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public GetSlotData.Response Execute(
                string namespace_,
                string slotId,
                string userId
            )
            {
                GetSlotData op = Build(
                    namespace_,
                    slotId,
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
            public async Task<GetSlotData.Response> ExecuteAsync(
                string namespace_,
                string slotId,
                string userId
            )
            {
                GetSlotData op = Build(
                    namespace_,
                    slotId,
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

        private GetSlotData(GetSlotDataBuilder builder,
            string namespace_,
            string slotId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["slotId"] = slotId;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<byte[]>
        {

            public ErrorEntity? Error404 { get; set; } = null;


            protected override string GetFullOperationId() => "Social::Slot::GetSlotData";
        }

        #endregion

        public GetSlotData(
            string namespace_,
            string slotId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["slotId"] = slotId;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/admin/namespaces/{namespace}/users/{userId}/slots/{slotId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/octet-stream" };

        public GetSlotData.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetSlotData.Response()
            {
                StatusCode = code,
                ContentType = contentType
            };

            if (code == (HttpStatusCode)204)
            {
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)201)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    payload.CopyTo(ms);
                    response.Data = ms.ToArray();
                    response.IsSuccess = true;
                }
            }
            else if (code == (HttpStatusCode)200)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    payload.CopyTo(ms);
                    response.Data = ms.ToArray();
                    response.IsSuccess = true;
                }
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }

            return response;
        }
    }

}