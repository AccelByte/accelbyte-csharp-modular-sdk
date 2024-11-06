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
    /// getGameNamespaces
    ///
    /// Get game namespaces.
    /// In multi tenant mode, a given super admin namespace will return all game namespaces of studio namespaces
    /// Other detail info:
    /// 
    ///   * Action code : 11308
    ///   *  Returns : list of namespaces
    /// </summary>
    public class GetGameNamespaces : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetGameNamespacesBuilder Builder { get => new GetGameNamespacesBuilder(); }

        public class GetGameNamespacesBuilder
            : OperationBuilder<GetGameNamespacesBuilder>
        {

            public bool? ActiveOnly { get; set; }





            internal GetGameNamespacesBuilder() { }

            internal GetGameNamespacesBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetGameNamespacesBuilder SetActiveOnly(bool _activeOnly)
            {
                ActiveOnly = _activeOnly;
                return this;
            }





            public GetGameNamespaces Build(
                string namespace_
            )
            {
                GetGameNamespaces op = new GetGameNamespaces(this,
                    namespace_                    
                );

                op.SetBaseFields<GetGameNamespacesBuilder>(this);
                return op;
            }

            public GetGameNamespaces.Response Execute(
                string namespace_
            )
            {
                GetGameNamespaces op = Build(
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
            public async Task<GetGameNamespaces.Response> ExecuteAsync(
                string namespace_
            )
            {
                GetGameNamespaces op = Build(
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

        private GetGameNamespaces(GetGameNamespacesBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.ActiveOnly != null) QueryParams["activeOnly"] = Convert.ToString(builder.ActiveOnly)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<List<Model.NamespaceInfo>>
        {

            public ErrorEntity? Error401 { get; set; } = null;

            public ErrorEntity? Error403 { get; set; } = null;


            protected override string GetFullOperationId() => "Basic::Namespace::GetGameNamespaces";
        }

        #endregion

        public GetGameNamespaces(
            string namespace_,            
            bool? activeOnly            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (activeOnly != null) QueryParams["activeOnly"] = Convert.ToString(activeOnly)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/basic/v1/admin/namespaces/{namespace}/game";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public GetGameNamespaces.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetGameNamespaces.Response()
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
                response.Data = JsonSerializer.Deserialize<List<Model.NamespaceInfo>>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
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

            return response;
        }
    }

}