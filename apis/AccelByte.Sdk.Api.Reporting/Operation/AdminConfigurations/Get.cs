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

using AccelByte.Sdk.Api.Reporting.Model;

namespace AccelByte.Sdk.Api.Reporting.Operation
{
    /// <summary>
    /// Get
    ///
    /// TimeInterval is in nanoseconds.
    /// When there's no configuration set, the response is the default value (configurable through envar).
    /// </summary>
    public class Get : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetBuilder Builder { get => new GetBuilder(); }

        public class GetBuilder
            : OperationBuilder<GetBuilder>
        {

            public GetCategory? Category { get; set; }





            internal GetBuilder() { }

            internal GetBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetBuilder SetCategory(GetCategory _category)
            {
                Category = _category;
                return this;
            }





            public Get Build(
                string namespace_
            )
            {
                Get op = new Get(this,
                    namespace_                    
                );

                op.SetBaseFields<GetBuilder>(this);
                return op;
            }

            public Get.Response Execute(
                string namespace_
            )
            {
                Get op = Build(
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
            public async Task<Get.Response> ExecuteAsync(
                string namespace_
            )
            {
                Get op = Build(
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

        private Get(GetBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.Category is not null) QueryParams["category"] = builder.Category.Value;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.RestapiConfigResponse>
        {

            public RestapiErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Reporting::AdminConfigurations::Get";
        }

        #endregion

        public Get(
            string namespace_,            
            GetCategory? category            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (category is not null) QueryParams["category"] = category.Value;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/reporting/v1/admin/namespaces/{namespace}/configurations";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public Get.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new Get.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.RestapiConfigResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<RestapiErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

    public class GetCategory : StringEnum<GetCategory>
    {
        public static readonly GetCategory All
            = new GetCategory("all");

        public static readonly GetCategory Extension
            = new GetCategory("extension");


        public static implicit operator GetCategory(string value)
        {
            return NewValue(value);
        }

        public GetCategory(string enumValue)
            : base(enumValue)
        {

        }
    }

}