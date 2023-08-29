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

using AccelByte.Sdk.Api.Platform.Model;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// deleteCategory
    ///
    /// This API is used to delete category by category path.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:CATEGORY", action=8 (DELETE)
    ///   *  Returns : the deleted category data
    /// </summary>
    public class DeleteCategory : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteCategoryBuilder Builder { get => new DeleteCategoryBuilder(); }

        public class DeleteCategoryBuilder
            : OperationBuilder<DeleteCategoryBuilder>
        {





            internal DeleteCategoryBuilder() { }

            internal DeleteCategoryBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteCategory Build(
                string categoryPath,
                string namespace_,
                string storeId
            )
            {
                DeleteCategory op = new DeleteCategory(this,
                    categoryPath,
                    namespace_,
                    storeId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.FullCategoryInfo? Execute(
                string categoryPath,
                string namespace_,
                string storeId
            )
            {
                DeleteCategory op = Build(
                    categoryPath,
                    namespace_,
                    storeId
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

        private DeleteCategory(DeleteCategoryBuilder builder,
            string categoryPath,
            string namespace_,
            string storeId
        )
        {
            PathParams["categoryPath"] = categoryPath;
            PathParams["namespace"] = namespace_;

            if (storeId is not null) QueryParams["storeId"] = storeId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteCategory(
            string categoryPath,
            string namespace_,
            string storeId
        )
        {
            PathParams["categoryPath"] = categoryPath;
            PathParams["namespace"] = namespace_;

            if (storeId is not null) QueryParams["storeId"] = storeId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/categories/{categoryPath}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.FullCategoryInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.FullCategoryInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.FullCategoryInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}