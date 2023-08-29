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
    /// GetRevocationListV3
    ///
    /// 
    /// 
    /// This endpoint will return a list of revoked users and revoked tokens. List of revoked tokens in bloom filter format.
    /// 
    /// 
    /// 
    /// 
    /// This endpoint requires authorized requests header with valid access token.
    /// 
    /// 
    /// 
    /// 
    /// The bloom filter uses MurmurHash3 algorithm for hashing the values
    /// 
    /// 
    /// 
    /// 
    /// action code : 10708
    /// </summary>
    public class GetRevocationListV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetRevocationListV3Builder Builder { get => new GetRevocationListV3Builder(); }

        public class GetRevocationListV3Builder
            : OperationBuilder<GetRevocationListV3Builder>
        {





            internal GetRevocationListV3Builder() { }

            internal GetRevocationListV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetRevocationListV3 Build(
            )
            {
                GetRevocationListV3 op = new GetRevocationListV3(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.OauthapiRevocationList? Execute(
            )
            {
                GetRevocationListV3 op = Build(
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

        private GetRevocationListV3(GetRevocationListV3Builder builder
        )
        {
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BASIC);
        }
        #endregion

        public GetRevocationListV3(
        )
        {
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BASIC);
        }

        public override string Path => "/iam/v3/oauth/revocationlist";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.OauthapiRevocationList? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.OauthapiRevocationList>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.OauthapiRevocationList>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}