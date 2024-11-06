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

using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// AdminGetCountryListV3
    ///
    /// Admin get country list
    /// </summary>
    public class AdminGetCountryListV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetCountryListV3Builder Builder { get => new AdminGetCountryListV3Builder(); }

        public class AdminGetCountryListV3Builder
            : OperationBuilder<AdminGetCountryListV3Builder>
        {

            public bool? FilterBlacklist { get; set; }





            internal AdminGetCountryListV3Builder() { }

            internal AdminGetCountryListV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminGetCountryListV3Builder SetFilterBlacklist(bool _filterBlacklist)
            {
                FilterBlacklist = _filterBlacklist;
                return this;
            }





            public AdminGetCountryListV3 Build(
                string namespace_
            )
            {
                AdminGetCountryListV3 op = new AdminGetCountryListV3(this,
                    namespace_                    
                );

                op.SetBaseFields<AdminGetCountryListV3Builder>(this);
                return op;
            }

            public AdminGetCountryListV3.Response Execute(
                string namespace_
            )
            {
                AdminGetCountryListV3 op = Build(
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
            public async Task<AdminGetCountryListV3.Response> ExecuteAsync(
                string namespace_
            )
            {
                AdminGetCountryListV3 op = Build(
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

        private AdminGetCountryListV3(AdminGetCountryListV3Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.FilterBlacklist != null) QueryParams["filterBlacklist"] = Convert.ToString(builder.FilterBlacklist)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<List<Model.ModelCountryResponse>>
        {

            public RestErrorResponse? Error401 { get; set; } = null;

            public RestErrorResponse? Error403 { get; set; } = null;

            public RestErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Iam::Country::AdminGetCountryListV3";
        }

        #endregion

        public AdminGetCountryListV3(
            string namespace_,            
            bool? filterBlacklist            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (filterBlacklist != null) QueryParams["filterBlacklist"] = Convert.ToString(filterBlacklist)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/countries";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminGetCountryListV3.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminGetCountryListV3.Response()
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
                response.Data = JsonSerializer.Deserialize<List<Model.ModelCountryResponse>>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}