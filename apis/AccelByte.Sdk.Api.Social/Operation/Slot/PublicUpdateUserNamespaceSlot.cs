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
    /// publicUpdateUserNamespaceSlot
    ///
    /// 
    /// 
    /// ## The endpoint is going to be deprecated
    /// 
    /// 
    /// Updates a slot.
    /// Other detail info:
    ///         *  Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:SLOTDATA", action=4 (UPDATE)
    ///         *  Returns : updated slot
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class PublicUpdateUserNamespaceSlot : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicUpdateUserNamespaceSlotBuilder Builder { get => new PublicUpdateUserNamespaceSlotBuilder(); }

        public class PublicUpdateUserNamespaceSlotBuilder
            : OperationBuilder<PublicUpdateUserNamespaceSlotBuilder>
        {

            public string? Label { get; set; }

            public List<string>? Tags { get; set; }



            public string? Checksum { get; set; }

            public string? CustomAttribute { get; set; }

            public Stream? File { get; set; }



            internal PublicUpdateUserNamespaceSlotBuilder() { }

            internal PublicUpdateUserNamespaceSlotBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public PublicUpdateUserNamespaceSlotBuilder SetLabel(string _label)
            {
                Label = _label;
                return this;
            }

            public PublicUpdateUserNamespaceSlotBuilder SetTags(List<string> _tags)
            {
                Tags = _tags;
                return this;
            }



            public PublicUpdateUserNamespaceSlotBuilder SetChecksum(string _checksum)
            {
                Checksum = _checksum;
                return this;
            }

            public PublicUpdateUserNamespaceSlotBuilder SetCustomAttribute(string _customAttribute)
            {
                CustomAttribute = _customAttribute;
                return this;
            }

            public PublicUpdateUserNamespaceSlotBuilder SetFile(Stream _file)
            {
                File = _file;
                return this;
            }



            public PublicUpdateUserNamespaceSlot Build(
                string namespace_,
                string slotId,
                string userId
            )
            {
                PublicUpdateUserNamespaceSlot op = new PublicUpdateUserNamespaceSlot(this,
                    namespace_,
                    slotId,
                    userId
                );

                op.SetBaseFields<PublicUpdateUserNamespaceSlotBuilder>(this);
                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public Model.SlotInfo? Execute(
                string namespace_,
                string slotId,
                string userId
            )
            {
                PublicUpdateUserNamespaceSlot op = Build(
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
            public async Task<Model.SlotInfo?> ExecuteAsync(
                string namespace_,
                string slotId,
                string userId
            )
            {
                PublicUpdateUserNamespaceSlot op = Build(
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

        private PublicUpdateUserNamespaceSlot(PublicUpdateUserNamespaceSlotBuilder builder,
            string namespace_,
            string slotId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["slotId"] = slotId;
            PathParams["userId"] = userId;

            if (builder.Label is not null) QueryParams["label"] = builder.Label;
            if (builder.Tags is not null) QueryParams["tags"] = builder.Tags;

            if (builder.Checksum is not null) FormParams["checksum"] = builder.Checksum;
            if (builder.CustomAttribute is not null) FormParams["customAttribute"] = builder.CustomAttribute;
            if (builder.File is not null) FormParams["file"] = builder.File;


            CollectionFormatMap["tags"] = "multi";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicUpdateUserNamespaceSlot(
            string namespace_,
            string slotId,
            string userId,
            string? label,
            List<string>? tags,
            string? checksum,
            string? customAttribute,
            Stream? file
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["slotId"] = slotId;
            PathParams["userId"] = userId;

            if (label is not null) QueryParams["label"] = label;
            if (tags is not null) QueryParams["tags"] = tags;

            if (checksum is not null) FormParams["checksum"] = checksum;
            if (customAttribute is not null) FormParams["customAttribute"] = customAttribute;
            if (file is not null) FormParams["file"] = file;


            CollectionFormatMap["tags"] = "multi";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/public/namespaces/{namespace}/users/{userId}/slots/{slotId}";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "multipart/form-data" };

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