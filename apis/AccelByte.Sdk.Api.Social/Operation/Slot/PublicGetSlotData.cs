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
    /// publicGetSlotData
    ///
    /// 
    /// 
    /// ## The endpoint is going to be deprecated
    /// 
    /// 
    /// Get slot data.
    /// Other detail info:
    ///         *  Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:SLOTDATA", action=2 (READ)
    ///         *  Returns : slot data
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class PublicGetSlotData : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetSlotDataBuilder Builder { get => new PublicGetSlotDataBuilder(); }

        public class PublicGetSlotDataBuilder
            : OperationBuilder<PublicGetSlotDataBuilder>
        {





            internal PublicGetSlotDataBuilder() { }

            internal PublicGetSlotDataBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicGetSlotData Build(
                string namespace_,
                string slotId,
                string userId
            )
            {
                PublicGetSlotData op = new PublicGetSlotData(this,
                    namespace_,
                    slotId,
                    userId
                );

                op.SetBaseFields<PublicGetSlotDataBuilder>(this);
                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public byte[]? Execute(
                string namespace_,
                string slotId,
                string userId
            )
            {
                PublicGetSlotData op = Build(
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
        }

        private PublicGetSlotData(PublicGetSlotDataBuilder builder,
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

        public PublicGetSlotData(
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

        public override string Path => "/social/public/namespaces/{namespace}/users/{userId}/slots/{slotId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/octet-stream" };

        public byte[]? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    payload.CopyTo(ms);
                    return ms.ToArray();
                }
            }
            else if (code == (HttpStatusCode)200)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    payload.CopyTo(ms);
                    return ms.ToArray();
                }
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}