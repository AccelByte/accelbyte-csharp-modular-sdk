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
    /// publicGetUserNamespaceSlots
    ///
    /// 
    /// 
    /// ## The endpoint is going to be deprecated
    /// 
    /// 
    /// Get list of slots for a given user in namespace.
    /// Other detail info:
    ///         *  Returns : list of slots
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class PublicGetUserNamespaceSlots : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetUserNamespaceSlotsBuilder Builder { get => new PublicGetUserNamespaceSlotsBuilder(); }

        public class PublicGetUserNamespaceSlotsBuilder
            : OperationBuilder<PublicGetUserNamespaceSlotsBuilder>
        {





            internal PublicGetUserNamespaceSlotsBuilder() { }

            internal PublicGetUserNamespaceSlotsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicGetUserNamespaceSlots Build(
                string namespace_,
                string userId
            )
            {
                PublicGetUserNamespaceSlots op = new PublicGetUserNamespaceSlots(this,
                    namespace_,
                    userId
                );

                op.SetBaseFields<PublicGetUserNamespaceSlotsBuilder>(this);
                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public List<Model.SlotInfo>? Execute(
                string namespace_,
                string userId
            )
            {
                PublicGetUserNamespaceSlots op = Build(
                    namespace_,
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
            public async Task<List<Model.SlotInfo>?> ExecuteAsync(
                string namespace_,
                string userId
            )
            {
                PublicGetUserNamespaceSlots op = Build(
                    namespace_,
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

        private PublicGetUserNamespaceSlots(PublicGetUserNamespaceSlotsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetUserNamespaceSlots(
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/public/namespaces/{namespace}/users/{userId}/slots";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public List<Model.SlotInfo>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.SlotInfo>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.SlotInfo>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}