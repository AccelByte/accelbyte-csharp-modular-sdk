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
    /// uploadSectionPluginConfigCert
    ///
    /// Upload section plugin custom config tls cert.Other detail info:
    ///   * Returns : updated service plugin config
    /// </summary>
    public class UploadSectionPluginConfigCert : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UploadSectionPluginConfigCertBuilder Builder { get => new UploadSectionPluginConfigCertBuilder(); }

        public class UploadSectionPluginConfigCertBuilder
            : OperationBuilder<UploadSectionPluginConfigCertBuilder>
        {



            public Stream? File { get; set; }



            internal UploadSectionPluginConfigCertBuilder() { }

            internal UploadSectionPluginConfigCertBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }




            public UploadSectionPluginConfigCertBuilder SetFile(Stream _file)
            {
                File = _file;
                return this;
            }



            public UploadSectionPluginConfigCert Build(
                string namespace_
            )
            {
                UploadSectionPluginConfigCert op = new UploadSectionPluginConfigCert(this,
                    namespace_                    
                );

                op.SetBaseFields<UploadSectionPluginConfigCertBuilder>(this);
                return op;
            }

            public UploadSectionPluginConfigCert.Response Execute(
                string namespace_
            )
            {
                UploadSectionPluginConfigCert op = Build(
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
            public async Task<UploadSectionPluginConfigCert.Response> ExecuteAsync(
                string namespace_
            )
            {
                UploadSectionPluginConfigCert op = Build(
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

        private UploadSectionPluginConfigCert(UploadSectionPluginConfigCertBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            if (builder.File is not null) FormParams["file"] = builder.File;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.SectionPluginConfigInfo>
        {

            public ValidationErrorEntity? Error422 { get; set; } = null;


            protected override string GetFullOperationId() => "Platform::ServicePluginConfig::UploadSectionPluginConfigCert";
        }

        #endregion

        public UploadSectionPluginConfigCert(
            string namespace_,            
            Stream? file            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            if (file is not null) FormParams["file"] = file;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/catalog/plugins/section/customConfig/cert";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "multipart/form-data" };

        public override List<string> Produces => new() { "application/json" };
        
        public UploadSectionPluginConfigCert.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new UploadSectionPluginConfigCert.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.SectionPluginConfigInfo>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)422)
            {
                response.Error422 = JsonSerializer.Deserialize<ValidationErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error422!.TranslateToApiError();
            }

            return response;
        }
    }

}