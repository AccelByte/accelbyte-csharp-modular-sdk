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

using AccelByte.Sdk.Api.Basic.Model;

namespace AccelByte.Sdk.Api.Basic.Operation
{
    /// <summary>
    /// updateCustomAttributesPartially
    ///
    /// Update partially custom attributes tied to the user id.
    /// Other detail info:
    /// 
    ///   * Action code : 11402
    ///   *  Request body : allowed format: JSON object
    ///   *  Returns : Updated custom attributes
    /// </summary>
    public class UpdateCustomAttributesPartially : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateCustomAttributesPartiallyBuilder Builder { get => new UpdateCustomAttributesPartiallyBuilder(); }

        public class UpdateCustomAttributesPartiallyBuilder
            : OperationBuilder<UpdateCustomAttributesPartiallyBuilder>
        {


            public Dictionary<string, object>? Body { get; set; }




            internal UpdateCustomAttributesPartiallyBuilder() { }

            internal UpdateCustomAttributesPartiallyBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public UpdateCustomAttributesPartiallyBuilder SetBody(Dictionary<string, object> _body)
            {
                Body = _body;
                return this;
            }




            public UpdateCustomAttributesPartially Build(
                string namespace_,
                string userId
            )
            {
                UpdateCustomAttributesPartially op = new UpdateCustomAttributesPartially(this,
                    namespace_,                    
                    userId                    
                );

                op.SetBaseFields<UpdateCustomAttributesPartiallyBuilder>(this);
                return op;
            }

            public UpdateCustomAttributesPartially.Response Execute(
                string namespace_,
                string userId
            )
            {
                UpdateCustomAttributesPartially op = Build(
                    namespace_,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<UpdateCustomAttributesPartially.Response> ExecuteAsync(
                string namespace_,
                string userId
            )
            {
                UpdateCustomAttributesPartially op = Build(
                    namespace_,
                    userId
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

        private UpdateCustomAttributesPartially(UpdateCustomAttributesPartiallyBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Dictionary<string, object>>
        {

            public ValidationErrorEntity? Error400 { get; set; } = null;

            public ErrorEntity? Error401 { get; set; } = null;

            public ErrorEntity? Error403 { get; set; } = null;

            public ErrorEntity? Error404 { get; set; } = null;


            protected override string GetFullOperationId() => "Basic::UserProfile::UpdateCustomAttributesPartially";
        }

        #endregion

        public UpdateCustomAttributesPartially(
            string namespace_,            
            string userId,            
            Dictionary<string, object> body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/basic/v1/admin/namespaces/{namespace}/users/{userId}/profiles/customAttributes";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public UpdateCustomAttributesPartially.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new UpdateCustomAttributesPartially.Response()
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
                response.Data = JsonSerializer.Deserialize<Dictionary<string, object>>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ValidationErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }

            return response;
        }
    }

}