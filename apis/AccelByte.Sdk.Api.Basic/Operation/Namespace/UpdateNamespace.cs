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
    /// updateNamespace
    ///
    /// Update namespace basic info.
    /// displayName rule:
    /// 
    /// 
    ///   * Alphanumeric lowercase and uppercase are allowed
    ///   * Allowed Special Character: ',. -
    ///   * Must start and end with alphanumeric
    ///   * Spaces and special character are allowed but cannot appear twice in a row
    /// 
    /// 
    /// Other detail info:
    /// 
    ///   * Action code : 11302
    ///   *  Returns : updated namespace
    /// </summary>
    public class UpdateNamespace : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateNamespaceBuilder Builder { get => new UpdateNamespaceBuilder(); }

        public class UpdateNamespaceBuilder
            : OperationBuilder<UpdateNamespaceBuilder>
        {


            public Model.NamespaceUpdate? Body { get; set; }




            internal UpdateNamespaceBuilder() { }

            internal UpdateNamespaceBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public UpdateNamespaceBuilder SetBody(Model.NamespaceUpdate _body)
            {
                Body = _body;
                return this;
            }




            public UpdateNamespace Build(
                string namespace_
            )
            {
                UpdateNamespace op = new UpdateNamespace(this,
                    namespace_                    
                );

                op.SetBaseFields<UpdateNamespaceBuilder>(this);
                return op;
            }

            public UpdateNamespace.Response Execute(
                string namespace_
            )
            {
                UpdateNamespace op = Build(
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
            public async Task<UpdateNamespace.Response> ExecuteAsync(
                string namespace_
            )
            {
                UpdateNamespace op = Build(
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

        private UpdateNamespace(UpdateNamespaceBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.NamespaceInfo>
        {

            public ValidationErrorEntity? Error400 { get; set; } = null;

            public ErrorEntity? Error401 { get; set; } = null;

            public ErrorEntity? Error403 { get; set; } = null;

            public ErrorEntity? Error404 { get; set; } = null;

            public ErrorEntity? Error409 { get; set; } = null;


            protected override string GetFullOperationId() => "Basic::Namespace::UpdateNamespace";
        }

        #endregion

        public UpdateNamespace(
            string namespace_,            
            Model.NamespaceUpdate body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/basic/v1/admin/namespaces/{namespace}/basic";

        public override HttpMethod Method => HttpMethod.Patch;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public UpdateNamespace.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new UpdateNamespace.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.NamespaceInfo>(payload, ResponseJsonOptions);
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
            else if (code == (HttpStatusCode)409)
            {
                response.Error409 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error409!.TranslateToApiError();
            }

            return response;
        }
    }

}