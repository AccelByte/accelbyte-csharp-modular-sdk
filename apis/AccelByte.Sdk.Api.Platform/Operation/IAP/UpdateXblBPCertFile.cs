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
    /// updateXblBPCertFile
    ///
    /// Upload xbl business partner cert file.
    /// Other detail info:
    /// 
    ///   * Returns : updated xbl iap config
    /// </summary>
    public class UpdateXblBPCertFile : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateXblBPCertFileBuilder Builder { get => new UpdateXblBPCertFileBuilder(); }

        public class UpdateXblBPCertFileBuilder
            : OperationBuilder<UpdateXblBPCertFileBuilder>
        {



            public Stream? File { get; set; }

            public string? Password { get; set; }



            internal UpdateXblBPCertFileBuilder() { }

            internal UpdateXblBPCertFileBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }




            public UpdateXblBPCertFileBuilder SetFile(Stream _file)
            {
                File = _file;
                return this;
            }

            public UpdateXblBPCertFileBuilder SetPassword(string _password)
            {
                Password = _password;
                return this;
            }



            public UpdateXblBPCertFile Build(
                string namespace_
            )
            {
                UpdateXblBPCertFile op = new UpdateXblBPCertFile(this,
                    namespace_                    
                );

                op.SetBaseFields<UpdateXblBPCertFileBuilder>(this);
                return op;
            }

            public Model.XblIAPConfigInfo? Execute(
                string namespace_
            )
            {
                UpdateXblBPCertFile op = Build(
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
            public async Task<Model.XblIAPConfigInfo?> ExecuteAsync(
                string namespace_
            )
            {
                UpdateXblBPCertFile op = Build(
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

        private UpdateXblBPCertFile(UpdateXblBPCertFileBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            if (builder.File is not null) FormParams["file"] = builder.File;
            if (builder.Password is not null) FormParams["password"] = builder.Password;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateXblBPCertFile(
            string namespace_,            
            Stream? file,            
            string? password            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            if (file is not null) FormParams["file"] = file;
            if (password is not null) FormParams["password"] = password;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/iap/config/xbl/cert";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "multipart/form-data" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.XblIAPConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.XblIAPConfigInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.XblIAPConfigInfo>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}