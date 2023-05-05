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

using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// GetCountryLocationV3
    ///
    /// 
    /// 
    /// This endpoint get country location based on the request.
    /// </summary>
    public class GetCountryLocationV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetCountryLocationV3Builder Builder { get => new GetCountryLocationV3Builder(); }

        public class GetCountryLocationV3Builder
            : OperationBuilder<GetCountryLocationV3Builder>
        {





            internal GetCountryLocationV3Builder() { }

            internal GetCountryLocationV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetCountryLocationV3 Build(
            )
            {
                GetCountryLocationV3 op = new GetCountryLocationV3(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.OauthmodelCountryLocationResponse? Execute(
            )
            {
                GetCountryLocationV3 op = Build(
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

        private GetCountryLocationV3(GetCountryLocationV3Builder builder
        )
        {
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetCountryLocationV3(
        )
        {
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/location/country";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.OauthmodelCountryLocationResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.OauthmodelCountryLocationResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.OauthmodelCountryLocationResponse>(payload);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}