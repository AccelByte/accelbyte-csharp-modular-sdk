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
    /// updateAppleP8File
    ///
    /// Upload Apple Store p8 file.
    /// Other detail info:
    /// 
    ///   * Returns : updated apple iap config
    /// </summary>
    public class UpdateAppleP8File : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateAppleP8FileBuilder Builder { get => new UpdateAppleP8FileBuilder(); }

        public class UpdateAppleP8FileBuilder
            : OperationBuilder<UpdateAppleP8FileBuilder>
        {



            public Stream? File { get; set; }



            internal UpdateAppleP8FileBuilder() { }

            internal UpdateAppleP8FileBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }




            public UpdateAppleP8FileBuilder SetFile(Stream _file)
            {
                File = _file;
                return this;
            }



            public UpdateAppleP8File Build(
                string namespace_
            )
            {
                UpdateAppleP8File op = new UpdateAppleP8File(this,
                    namespace_                    
                );

                op.SetBaseFields<UpdateAppleP8FileBuilder>(this);
                return op;
            }

            public UpdateAppleP8File.Response Execute(
                string namespace_
            )
            {
                UpdateAppleP8File op = Build(
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
            public async Task<UpdateAppleP8File.Response> ExecuteAsync(
                string namespace_
            )
            {
                UpdateAppleP8File op = Build(
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

        private UpdateAppleP8File(UpdateAppleP8FileBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            if (builder.File is not null) FormParams["file"] = builder.File;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.AppleIAPConfigInfo>
        {


            protected override string GetFullOperationId() => "Platform::IAP::UpdateAppleP8File";
        }

        #endregion

        public UpdateAppleP8File(
            string namespace_,            
            Stream? file            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            if (file is not null) FormParams["file"] = file;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/iap/config/apple/cert";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "multipart/form-data" };

        public override List<string> Produces => new() { "application/json" };
        
        public UpdateAppleP8File.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new UpdateAppleP8File.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.AppleIAPConfigInfo>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }

            return response;
        }
    }

}