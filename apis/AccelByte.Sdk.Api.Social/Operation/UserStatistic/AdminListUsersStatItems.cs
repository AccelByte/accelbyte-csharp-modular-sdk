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
    /// AdminListUsersStatItems
    ///
    /// Admin list all statItems of user
    /// NOTE:
    ///           * If stat code does not exist, will ignore this stat code.
    ///           * If stat item does not exist, will return default value
    /// Other detail info:+ *Required permission*: resource=ADMIN:NAMESPACE:{namespace}:STATITEM, action=2 (READ)
    /// 
    ///           *  Returns : stat items
    /// </summary>
    public class AdminListUsersStatItems : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminListUsersStatItemsBuilder Builder { get => new AdminListUsersStatItemsBuilder(); }

        public class AdminListUsersStatItemsBuilder
            : OperationBuilder<AdminListUsersStatItemsBuilder>
        {

            public string? AdditionalKey { get; set; }

            public List<string>? StatCodes { get; set; }

            public List<string>? Tags { get; set; }





            internal AdminListUsersStatItemsBuilder() { }

            internal AdminListUsersStatItemsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminListUsersStatItemsBuilder SetAdditionalKey(string _additionalKey)
            {
                AdditionalKey = _additionalKey;
                return this;
            }

            public AdminListUsersStatItemsBuilder SetStatCodes(List<string> _statCodes)
            {
                StatCodes = _statCodes;
                return this;
            }

            public AdminListUsersStatItemsBuilder SetTags(List<string> _tags)
            {
                Tags = _tags;
                return this;
            }





            public AdminListUsersStatItems Build(
                string namespace_,
                string userId
            )
            {
                AdminListUsersStatItems op = new AdminListUsersStatItems(this,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public List<Model.ADTOObjectForUserStatItemValue>? Execute(
                string namespace_,
                string userId
            )
            {
                AdminListUsersStatItems op = Build(
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
        }

        private AdminListUsersStatItems(AdminListUsersStatItemsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (builder.AdditionalKey is not null) QueryParams["additionalKey"] = builder.AdditionalKey;
            if (builder.StatCodes is not null) QueryParams["statCodes"] = builder.StatCodes;
            if (builder.Tags is not null) QueryParams["tags"] = builder.Tags;



            CollectionFormatMap["statCodes"] = "multi";
            CollectionFormatMap["tags"] = "multi";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminListUsersStatItems(
            string namespace_,
            string userId,
            string? additionalKey,
            List<string>? statCodes,
            List<string>? tags
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (additionalKey is not null) QueryParams["additionalKey"] = additionalKey;
            if (statCodes is not null) QueryParams["statCodes"] = statCodes;
            if (tags is not null) QueryParams["tags"] = tags;



            CollectionFormatMap["statCodes"] = "multi";
            CollectionFormatMap["tags"] = "multi";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/v2/admin/namespaces/{namespace}/users/{userId}/statitems/value/bulk";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public List<Model.ADTOObjectForUserStatItemValue>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ADTOObjectForUserStatItemValue>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ADTOObjectForUserStatItemValue>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}