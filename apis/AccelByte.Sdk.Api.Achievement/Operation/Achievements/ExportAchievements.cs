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

using AccelByte.Sdk.Api.Achievement.Model;

namespace AccelByte.Sdk.Api.Achievement.Operation
{
    /// <summary>
    /// ExportAchievements
    ///
    /// 
    /// 
    /// 
    /// Required permission `ADMIN:NAMESPACE:{namespace}:ACHIEVEMENT [READ]`
    /// 
    /// Required Scope: `social`
    /// 
    /// Successful response header will contain: `content-disposition: attachment; filename=achievement__config.json`
    /// </summary>
    public class ExportAchievements : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ExportAchievementsBuilder Builder { get => new ExportAchievementsBuilder(); }

        public class ExportAchievementsBuilder
            : OperationBuilder<ExportAchievementsBuilder>
        {

            public List<string>? Tags { get; set; }





            internal ExportAchievementsBuilder() { }

            internal ExportAchievementsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public ExportAchievementsBuilder SetTags(List<string> _tags)
            {
                Tags = _tags;
                return this;
            }





            public ExportAchievements Build(
                string namespace_
            )
            {
                ExportAchievements op = new ExportAchievements(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Stream? Execute(
                string namespace_
            )
            {
                ExportAchievements op = Build(
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
        }

        private ExportAchievements(ExportAchievementsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Tags is not null) QueryParams["tags"] = builder.Tags;



            CollectionFormatMap["tags"] = "csv";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ExportAchievements(
            string namespace_,
            List<string>? tags
        )
        {
            PathParams["namespace"] = namespace_;

            if (tags is not null) QueryParams["tags"] = tags;



            CollectionFormatMap["tags"] = "csv";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/achievement/v1/admin/namespaces/{namespace}/achievements/export";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Stream? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return payload;
            }
            else if (code == (HttpStatusCode)200)
            {
                return payload;
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}