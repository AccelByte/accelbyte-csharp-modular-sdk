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
    /// unselectRecord
    ///
    /// Unselect a change, it will not be included when partial publish.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:STORE", action=4 (UPDATE)
    /// </summary>
    public class UnselectRecord : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UnselectRecordBuilder Builder { get => new UnselectRecordBuilder(); }

        public class UnselectRecordBuilder
            : OperationBuilder<UnselectRecordBuilder>
        {





            internal UnselectRecordBuilder() { }

            internal UnselectRecordBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UnselectRecord Build(
                string changeId,
                string namespace_,
                string storeId
            )
            {
                UnselectRecord op = new UnselectRecord(this,
                    changeId,
                    namespace_,
                    storeId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
                string changeId,
                string namespace_,
                string storeId
            )
            {
                UnselectRecord op = Build(
                    changeId,
                    namespace_,
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

        private UnselectRecord(UnselectRecordBuilder builder,
            string changeId,
            string namespace_,
            string storeId
        )
        {
            PathParams["changeId"] = changeId;
            PathParams["namespace"] = namespace_;
            PathParams["storeId"] = storeId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UnselectRecord(
            string changeId,
            string namespace_,
            string storeId
        )
        {
            PathParams["changeId"] = changeId;
            PathParams["namespace"] = namespace_;
            PathParams["storeId"] = storeId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/stores/{storeId}/catalogChanges/{changeId}/unselect";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

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