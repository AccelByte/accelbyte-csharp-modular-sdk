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
    /// publicUpdateUserNamespaceSlotMetadata
    ///
    /// 
    /// 
    /// ## The endpoint is going to be deprecated
    /// 
    /// 
    /// Updates the slot metadata.
    /// Other detail info:
    ///         *  Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:SLOTDATA", action=4 (UPDATE)
    ///         *  Returns : updated slot
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class PublicUpdateUserNamespaceSlotMetadata : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicUpdateUserNamespaceSlotMetadataBuilder Builder { get => new PublicUpdateUserNamespaceSlotMetadataBuilder(); }

        public class PublicUpdateUserNamespaceSlotMetadataBuilder
            : OperationBuilder<PublicUpdateUserNamespaceSlotMetadataBuilder>
        {


            public Model.SlotMetadataUpdate? Body { get; set; }




            internal PublicUpdateUserNamespaceSlotMetadataBuilder() { }

            internal PublicUpdateUserNamespaceSlotMetadataBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public PublicUpdateUserNamespaceSlotMetadataBuilder SetBody(Model.SlotMetadataUpdate _body)
            {
                Body = _body;
                return this;
            }




            public PublicUpdateUserNamespaceSlotMetadata Build(
                string namespace_,
                string slotId,
                string userId
            )
            {
                PublicUpdateUserNamespaceSlotMetadata op = new PublicUpdateUserNamespaceSlotMetadata(this,
                    namespace_,
                    slotId,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public Model.SlotInfo? Execute(
                string namespace_,
                string slotId,
                string userId
            )
            {
                PublicUpdateUserNamespaceSlotMetadata op = Build(
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

        private PublicUpdateUserNamespaceSlotMetadata(PublicUpdateUserNamespaceSlotMetadataBuilder builder,
            string namespace_,
            string slotId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["slotId"] = slotId;
            PathParams["userId"] = userId;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicUpdateUserNamespaceSlotMetadata(
            string namespace_,
            string slotId,
            string userId,
            Model.SlotMetadataUpdate body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["slotId"] = slotId;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/public/namespaces/{namespace}/users/{userId}/slots/{slotId}/metadata";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.SlotInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.SlotInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.SlotInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}