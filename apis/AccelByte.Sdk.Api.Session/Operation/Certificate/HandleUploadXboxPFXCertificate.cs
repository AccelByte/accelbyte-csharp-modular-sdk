// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
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

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Net.Http;

using AccelByte.Sdk.Api.Session.Model;

namespace AccelByte.Sdk.Api.Session.Operation
{
    /// <summary>
    /// HandleUploadXboxPFXCertificate
    ///
    /// Upload certificates for xbox. Certificate must be in the valid form of PFX format.
    /// </summary>
    public class HandleUploadXboxPFXCertificate : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static HandleUploadXboxPFXCertificateBuilder Builder { get => new HandleUploadXboxPFXCertificateBuilder(); }

        public class HandleUploadXboxPFXCertificateBuilder
            : OperationBuilder<HandleUploadXboxPFXCertificateBuilder>
        {



            public string? Description { get; set; }



            internal HandleUploadXboxPFXCertificateBuilder() { }

            internal HandleUploadXboxPFXCertificateBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }




            public HandleUploadXboxPFXCertificateBuilder SetDescription(string _description)
            {
                Description = _description;
                return this;
            }



            public HandleUploadXboxPFXCertificate Build(
                string certname,
                Stream file,
                string password,
                string namespace_
            )
            {
                HandleUploadXboxPFXCertificate op = new HandleUploadXboxPFXCertificate(this,
                    certname,
                    file,
                    password,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelsPlatformCredentials? Execute(
                string certname,
                Stream file,
                string password,
                string namespace_
            )
            {
                HandleUploadXboxPFXCertificate op = Build(
                    certname,
                    file,
                    password,
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
        }

        private HandleUploadXboxPFXCertificate(HandleUploadXboxPFXCertificateBuilder builder,
            string certname,
            Stream file,
            string password,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;


            if (builder.Description is not null) FormParams["description"] = builder.Description;
            if (certname is not null) FormParams["certname"] = certname;
            if (file is not null) FormParams["file"] = file;
            if (password is not null) FormParams["password"] = password;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public HandleUploadXboxPFXCertificate(
            string namespace_,
            string? description,
            string certname,
            Stream file,
            string password
        )
        {
            PathParams["namespace"] = namespace_;


            if (description is not null) FormParams["description"] = description;
            if (certname is not null) FormParams["certname"] = certname;
            if (file is not null) FormParams["file"] = file;
            if (password is not null) FormParams["password"] = password;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/admin/namespaces/{namespace}/certificates/pfx/platforms/xbl";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "multipart/form-data" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsPlatformCredentials? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsPlatformCredentials>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsPlatformCredentials>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}