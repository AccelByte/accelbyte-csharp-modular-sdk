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

using AccelByte.Sdk.Api.Chat.Model;

namespace AccelByte.Sdk.Api.Chat.Operation
{
    /// <summary>
    /// adminUpdateInboxCategory
    ///
    /// Update inbox category
    /// </summary>
    public class AdminUpdateInboxCategory : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateInboxCategoryBuilder Builder { get => new AdminUpdateInboxCategoryBuilder(); }

        public class AdminUpdateInboxCategoryBuilder
            : OperationBuilder<AdminUpdateInboxCategoryBuilder>
        {





            internal AdminUpdateInboxCategoryBuilder() { }

            internal AdminUpdateInboxCategoryBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminUpdateInboxCategory Build(
                ModelsUpdateInboxCategoryRequest body,
                string category,
                string namespace_
            )
            {
                AdminUpdateInboxCategory op = new AdminUpdateInboxCategory(this,
                    body,
                    category,
                    namespace_
                );

                op.SetBaseFields<AdminUpdateInboxCategoryBuilder>(this);
                return op;
            }

            public void Execute(
                ModelsUpdateInboxCategoryRequest body,
                string category,
                string namespace_
            )
            {
                AdminUpdateInboxCategory op = Build(
                    body,
                    category,
                    namespace_
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
                ModelsUpdateInboxCategoryRequest body,
                string category,
                string namespace_
            )
            {
                AdminUpdateInboxCategory op = Build(
                    body,
                    category,
                    namespace_
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

        private AdminUpdateInboxCategory(AdminUpdateInboxCategoryBuilder builder,
            ModelsUpdateInboxCategoryRequest body,
            string category,
            string namespace_
        )
        {
            PathParams["category"] = category;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminUpdateInboxCategory(
            string category,
            string namespace_,
            Model.ModelsUpdateInboxCategoryRequest body
        )
        {
            PathParams["category"] = category;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/chat/v1/admin/inbox/namespaces/{namespace}/categories/{category}";

        public override HttpMethod Method => HttpMethod.Patch;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return;
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}