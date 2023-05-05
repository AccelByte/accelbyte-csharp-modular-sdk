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

using AccelByte.Sdk.Api.Basic.Model;

namespace AccelByte.Sdk.Api.Basic.Operation
{
    /// <summary>
    /// updateCountryGroup
    ///
    /// Update a country groups. The countryGroupCode must be exist beforehand.
    /// Valid update behaviour :
    /// - To update countryGroupName only, do not include countries key or just specify it with empty array.
    /// - To update countries only, do not include countryGroupName key or just specify it with blank value.
    /// Other detail info:
    /// 
    ///   * Required permission : resource = "ADMIN:NAMESPACE:{namespace}:MISC" , action=4 (UPDATE)
    ///   *  Action code : 11202
    ///   *  Returns : updated country group
    /// </summary>
    public class UpdateCountryGroup : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateCountryGroupBuilder Builder { get => new UpdateCountryGroupBuilder(); }

        public class UpdateCountryGroupBuilder
            : OperationBuilder<UpdateCountryGroupBuilder>
        {


            public Model.UpdateCountryGroupRequest? Body { get; set; }




            internal UpdateCountryGroupBuilder() { }

            internal UpdateCountryGroupBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public UpdateCountryGroupBuilder SetBody(Model.UpdateCountryGroupRequest _body)
            {
                Body = _body;
                return this;
            }




            public UpdateCountryGroup Build(
                string countryGroupCode,
                string namespace_
            )
            {
                UpdateCountryGroup op = new UpdateCountryGroup(this,
                    countryGroupCode,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.CountryGroupObject? Execute(
                string countryGroupCode,
                string namespace_
            )
            {
                UpdateCountryGroup op = Build(
                    countryGroupCode,
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

        private UpdateCountryGroup(UpdateCountryGroupBuilder builder,
            string countryGroupCode,
            string namespace_
        )
        {
            PathParams["countryGroupCode"] = countryGroupCode;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateCountryGroup(
            string countryGroupCode,            
            string namespace_,            
            Model.UpdateCountryGroupRequest body            
        )
        {
            PathParams["countryGroupCode"] = countryGroupCode;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/basic/v1/admin/namespaces/{namespace}/misc/countrygroups/{countryGroupCode}";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.CountryGroupObject? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.CountryGroupObject>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.CountryGroupObject>(payload);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}