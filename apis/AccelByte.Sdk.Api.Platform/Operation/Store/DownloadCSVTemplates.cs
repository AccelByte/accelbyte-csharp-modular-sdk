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
    /// downloadCSVTemplates
    ///
    /// This API is used to download store csv templates for store importing by CSV feature
    /// </summary>
    public class DownloadCSVTemplates : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DownloadCSVTemplatesBuilder Builder { get => new DownloadCSVTemplatesBuilder(); }

        public class DownloadCSVTemplatesBuilder
            : OperationBuilder<DownloadCSVTemplatesBuilder>
        {





            internal DownloadCSVTemplatesBuilder() { }

            internal DownloadCSVTemplatesBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DownloadCSVTemplates Build(
                string namespace_
            )
            {
                DownloadCSVTemplates op = new DownloadCSVTemplates(this,
                    namespace_                    
                );

                op.SetBaseFields<DownloadCSVTemplatesBuilder>(this);
                return op;
            }

            public DownloadCSVTemplates.Response Execute(
                string namespace_
            )
            {
                DownloadCSVTemplates op = Build(
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
            public async Task<DownloadCSVTemplates.Response> ExecuteAsync(
                string namespace_
            )
            {
                DownloadCSVTemplates op = Build(
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

        private DownloadCSVTemplates(DownloadCSVTemplatesBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Stream>
        {


            protected override string GetFullOperationId() => "Platform::Store::DownloadCSVTemplates";
        }

        #endregion

        public DownloadCSVTemplates(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/stores/downloadCSVTemplates";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/zip" };
        
        public DownloadCSVTemplates.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new DownloadCSVTemplates.Response()
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
                response.Data = payload;
                response.IsSuccess = true;
            }

            return response;
        }
    }

}