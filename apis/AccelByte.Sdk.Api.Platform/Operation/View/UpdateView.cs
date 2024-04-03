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

using AccelByte.Sdk.Api.Platform.Model;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// updateView
    ///
    /// This API is used to update a view.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:STORE", action=4 (UPDATE)
    ///   *  Returns : updated view data
    /// 
    /// 
    /// 
    /// ## Restrictions for localization extension
    /// 
    /// 
    /// 1. Cannot use "." as the key name
    /// -
    /// 
    /// 
    ///     { "data.2": "value" }
    /// 
    /// 
    /// 2. Cannot use "$" as the prefix in key names
    /// -
    /// 
    /// 
    ///     { "$data": "value" }
    /// </summary>
    public class UpdateView : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateViewBuilder Builder { get => new UpdateViewBuilder(); }

        public class UpdateViewBuilder
            : OperationBuilder<UpdateViewBuilder>
        {


            public Model.ViewUpdate? Body { get; set; }




            internal UpdateViewBuilder() { }

            internal UpdateViewBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public UpdateViewBuilder SetBody(Model.ViewUpdate _body)
            {
                Body = _body;
                return this;
            }




            public UpdateView Build(
                string namespace_,
                string viewId,
                string storeId
            )
            {
                UpdateView op = new UpdateView(this,
                    namespace_,
                    viewId,
                    storeId
                );

                op.SetBaseFields<UpdateViewBuilder>(this);
                return op;
            }

            public Model.FullViewInfo? Execute(
                string namespace_,
                string viewId,
                string storeId
            )
            {
                UpdateView op = Build(
                    namespace_,
                    viewId,
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
            public async Task<Model.FullViewInfo?> ExecuteAsync(
                string namespace_,
                string viewId,
                string storeId
            )
            {
                UpdateView op = Build(
                    namespace_,
                    viewId,
                    storeId
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

        private UpdateView(UpdateViewBuilder builder,
            string namespace_,
            string viewId,
            string storeId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["viewId"] = viewId;

            if (storeId is not null) QueryParams["storeId"] = storeId;




            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateView(
            string namespace_,
            string viewId,
            string storeId,
            Model.ViewUpdate body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["viewId"] = viewId;

            if (storeId is not null) QueryParams["storeId"] = storeId;




            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/views/{viewId}";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.FullViewInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.FullViewInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.FullViewInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}