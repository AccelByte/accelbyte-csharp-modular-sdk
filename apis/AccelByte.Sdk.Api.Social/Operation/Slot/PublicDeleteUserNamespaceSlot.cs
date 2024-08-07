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
    /// publicDeleteUserNamespaceSlot
    ///
    /// 
    /// 
    /// ## The endpoint is going to be deprecated
    /// 
    /// 
    /// Deletes the slot.
    /// Other detail info:
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class PublicDeleteUserNamespaceSlot : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicDeleteUserNamespaceSlotBuilder Builder { get => new PublicDeleteUserNamespaceSlotBuilder(); }

        public class PublicDeleteUserNamespaceSlotBuilder
            : OperationBuilder<PublicDeleteUserNamespaceSlotBuilder>
        {





            internal PublicDeleteUserNamespaceSlotBuilder() { }

            internal PublicDeleteUserNamespaceSlotBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PublicDeleteUserNamespaceSlot Build(
                string namespace_,
                string slotId,
                string userId
            )
            {
                PublicDeleteUserNamespaceSlot op = new PublicDeleteUserNamespaceSlot(this,
                    namespace_,
                    slotId,
                    userId
                );

                op.SetBaseFields<PublicDeleteUserNamespaceSlotBuilder>(this);
                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public void Execute(
                string namespace_,
                string slotId,
                string userId
            )
            {
                PublicDeleteUserNamespaceSlot op = Build(
                    namespace_,
                    slotId,
                    userId
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
                string namespace_,
                string slotId,
                string userId
            )
            {
                PublicDeleteUserNamespaceSlot op = Build(
                    namespace_,
                    slotId,
                    userId
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

        private PublicDeleteUserNamespaceSlot(PublicDeleteUserNamespaceSlotBuilder builder,
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

        public PublicDeleteUserNamespaceSlot(
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

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}