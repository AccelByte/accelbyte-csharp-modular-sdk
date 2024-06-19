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

using AccelByte.Sdk.Api.Inventory.Model;

namespace AccelByte.Sdk.Api.Inventory.Operation
{
    /// <summary>
    /// AdminDeleteTag
    ///
    /// 
    /// This endpoint will delete a tag by tagName in a specified namespace.
    /// If the tagName doesn't exist in a namespace, it'll return not found.
    /// 
    /// Permission: ADMIN:NAMESPACE:{namespace}:INVENTORY:TAG [DELETE]
    /// </summary>
    public class AdminDeleteTag : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeleteTagBuilder Builder { get => new AdminDeleteTagBuilder(); }

        public class AdminDeleteTagBuilder
            : OperationBuilder<AdminDeleteTagBuilder>
        {





            internal AdminDeleteTagBuilder() { }

            internal AdminDeleteTagBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminDeleteTag Build(
                string namespace_,
                string tagName
            )
            {
                AdminDeleteTag op = new AdminDeleteTag(this,
                    namespace_,
                    tagName
                );

                op.SetBaseFields<AdminDeleteTagBuilder>(this);
                return op;
            }

            public void Execute(
                string namespace_,
                string tagName
            )
            {
                AdminDeleteTag op = Build(
                    namespace_,
                    tagName
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
                string tagName
            )
            {
                AdminDeleteTag op = Build(
                    namespace_,
                    tagName
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

        private AdminDeleteTag(AdminDeleteTagBuilder builder,
            string namespace_,
            string tagName
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["tagName"] = tagName;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminDeleteTag(
            string namespace_,
            string tagName
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["tagName"] = tagName;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/inventory/v1/admin/namespaces/{namespace}/tags/{tagName}";

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