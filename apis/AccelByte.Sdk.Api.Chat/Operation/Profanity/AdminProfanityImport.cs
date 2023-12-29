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

using AccelByte.Sdk.Api.Chat.Model;

namespace AccelByte.Sdk.Api.Chat.Operation
{
    /// <summary>
    /// adminProfanityImport
    ///
    /// Import profanity words
    /// </summary>
    public class AdminProfanityImport : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminProfanityImportBuilder Builder { get => new AdminProfanityImportBuilder(); }

        public class AdminProfanityImportBuilder
            : OperationBuilder<AdminProfanityImportBuilder>
        {

            public AdminProfanityImportAction? Action { get; set; }

            public bool? ShowResult { get; set; }





            internal AdminProfanityImportBuilder() { }

            internal AdminProfanityImportBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminProfanityImportBuilder SetAction(AdminProfanityImportAction _action)
            {
                Action = _action;
                return this;
            }

            public AdminProfanityImportBuilder SetShowResult(bool _showResult)
            {
                ShowResult = _showResult;
                return this;
            }





            public AdminProfanityImport Build(
                Stream file,
                string namespace_
            )
            {
                AdminProfanityImport op = new AdminProfanityImport(this,
                    file,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelsDictionaryImportResult? Execute(
                Stream file,
                string namespace_
            )
            {
                AdminProfanityImport op = Build(
                    file,
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

        private AdminProfanityImport(AdminProfanityImportBuilder builder,
            Stream file,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Action is not null) QueryParams["action"] = builder.Action.Value;
            if (builder.ShowResult != null) QueryParams["showResult"] = Convert.ToString(builder.ShowResult)!;

            if (file is not null) FormParams["file"] = file;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminProfanityImport(
            string namespace_,
            AdminProfanityImportAction? action,
            bool? showResult,
            Stream file
        )
        {
            PathParams["namespace"] = namespace_;

            if (action is not null) QueryParams["action"] = action.Value;
            if (showResult != null) QueryParams["showResult"] = Convert.ToString(showResult)!;

            if (file is not null) FormParams["file"] = file;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/chat/v1/admin/profanity/namespaces/{namespace}/dictionary/import";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "multipart/form-data" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsDictionaryImportResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsDictionaryImportResult>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsDictionaryImportResult>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

    public class AdminProfanityImportAction : StringEnum<AdminProfanityImportAction>
    {
        public static readonly AdminProfanityImportAction FULLREPLACE
            = new AdminProfanityImportAction("FULLREPLACE");

        public static readonly AdminProfanityImportAction LEAVEOUT
            = new AdminProfanityImportAction("LEAVEOUT");

        public static readonly AdminProfanityImportAction REPLACE
            = new AdminProfanityImportAction("REPLACE");


        public static implicit operator AdminProfanityImportAction(string value)
        {
            return NewValue(value);
        }

        public AdminProfanityImportAction(string enumValue)
            : base(enumValue)
        {

        }
    }

}