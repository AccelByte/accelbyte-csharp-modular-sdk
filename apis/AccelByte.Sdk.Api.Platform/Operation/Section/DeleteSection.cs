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
    /// deleteSection
    ///
    /// This API is used to delete s section.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:STORE", action=8 (DELETE)
    /// </summary>
    public class DeleteSection : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteSectionBuilder Builder { get => new DeleteSectionBuilder(); }

        public class DeleteSectionBuilder
            : OperationBuilder<DeleteSectionBuilder>
        {





            internal DeleteSectionBuilder() { }

            internal DeleteSectionBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteSection Build(
                string namespace_,
                string sectionId,
                string storeId
            )
            {
                DeleteSection op = new DeleteSection(this,
                    namespace_,
                    sectionId,
                    storeId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
                string namespace_,
                string sectionId,
                string storeId
            )
            {
                DeleteSection op = Build(
                    namespace_,
                    sectionId,
                    storeId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private DeleteSection(DeleteSectionBuilder builder,
            string namespace_,
            string sectionId,
            string storeId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sectionId"] = sectionId;

            if (storeId is not null) QueryParams["storeId"] = storeId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteSection(
            string namespace_,
            string sectionId,
            string storeId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sectionId"] = sectionId;

            if (storeId is not null) QueryParams["storeId"] = storeId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/sections/{sectionId}";

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