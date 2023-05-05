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

using AccelByte.Sdk.Api.Eventlog.Model;

namespace AccelByte.Sdk.Api.Eventlog.Operation
{
    /// <summary>
    /// SpecificUXDescriptionHandler
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class SpecificUXDescriptionHandler : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SpecificUXDescriptionHandlerBuilder Builder { get => new SpecificUXDescriptionHandlerBuilder(); }

        public class SpecificUXDescriptionHandlerBuilder
            : OperationBuilder<SpecificUXDescriptionHandlerBuilder>
        {

            public string? Ux { get; set; }





            internal SpecificUXDescriptionHandlerBuilder() { }

            internal SpecificUXDescriptionHandlerBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public SpecificUXDescriptionHandlerBuilder SetUx(string _ux)
            {
                Ux = _ux;
                return this;
            }





            public SpecificUXDescriptionHandler Build(
            )
            {
                SpecificUXDescriptionHandler op = new SpecificUXDescriptionHandler(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
            public Model.ModelsMultipleUX? Execute(
            )
            {
                SpecificUXDescriptionHandler op = Build(
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

        private SpecificUXDescriptionHandler(SpecificUXDescriptionHandlerBuilder builder
        )
        {
            
            if (builder.Ux is not null) QueryParams["ux"] = builder.Ux;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public SpecificUXDescriptionHandler(
            string? ux            
        )
        {
            
            if (ux is not null) QueryParams["ux"] = ux;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/event/descriptions/ux/listByUx";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.ModelsMultipleUX? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsMultipleUX>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsMultipleUX>(payload);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}