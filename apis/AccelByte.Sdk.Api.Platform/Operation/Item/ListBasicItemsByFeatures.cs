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
    /// listBasicItemsByFeatures
    ///
    ///  [SERVICE COMMUNICATION ONLY] This API is used to list basic items by features.
    /// 
    /// Other detail info:
    /// 
    ///   * Returns : the list of basic items
    /// </summary>
    public class ListBasicItemsByFeatures : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ListBasicItemsByFeaturesBuilder Builder { get => new ListBasicItemsByFeaturesBuilder(); }

        public class ListBasicItemsByFeaturesBuilder
            : OperationBuilder<ListBasicItemsByFeaturesBuilder>
        {

            public bool? ActiveOnly { get; set; }

            public List<string>? Features { get; set; }





            internal ListBasicItemsByFeaturesBuilder() { }

            internal ListBasicItemsByFeaturesBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public ListBasicItemsByFeaturesBuilder SetActiveOnly(bool _activeOnly)
            {
                ActiveOnly = _activeOnly;
                return this;
            }

            public ListBasicItemsByFeaturesBuilder SetFeatures(List<string> _features)
            {
                Features = _features;
                return this;
            }





            public ListBasicItemsByFeatures Build(
                string namespace_
            )
            {
                ListBasicItemsByFeatures op = new ListBasicItemsByFeatures(this,
                    namespace_                    
                );

                op.SetBaseFields<ListBasicItemsByFeaturesBuilder>(this);
                return op;
            }

            public ListBasicItemsByFeatures.Response Execute(
                string namespace_
            )
            {
                ListBasicItemsByFeatures op = Build(
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
            public async Task<ListBasicItemsByFeatures.Response> ExecuteAsync(
                string namespace_
            )
            {
                ListBasicItemsByFeatures op = Build(
                    namespace_
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

        private ListBasicItemsByFeatures(ListBasicItemsByFeaturesBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.ActiveOnly != null) QueryParams["activeOnly"] = Convert.ToString(builder.ActiveOnly)!;
            if (builder.Features is not null) QueryParams["features"] = builder.Features;
            

            
            CollectionFormatMap["features"] = "multi";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<List<Model.BasicItem>>
        {


            protected override string GetFullOperationId() => "Platform::Item::ListBasicItemsByFeatures";
        }

        #endregion

        public ListBasicItemsByFeatures(
            string namespace_,            
            bool? activeOnly,            
            List<string>? features            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (activeOnly != null) QueryParams["activeOnly"] = Convert.ToString(activeOnly)!;
            if (features is not null) QueryParams["features"] = features;
            

            
            CollectionFormatMap["features"] = "multi";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/items/byFeatures/basic";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public ListBasicItemsByFeatures.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new ListBasicItemsByFeatures.Response()
            {
                StatusCode = code,
                ContentType = contentType
            };

            if (code == (HttpStatusCode)204)
            {
                response.IsSuccess = true;
            }
            else if ((code == (HttpStatusCode)201) || (code == (HttpStatusCode)202) || (code == (HttpStatusCode)200))
            {
                response.Data = JsonSerializer.Deserialize<List<Model.BasicItem>>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }

            return response;
        }
    }

}