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
    /// AdminGetInputValidations
    ///
    /// 
    /// 
    /// Required permission 'ADMIN:CONFIGURATION'[READ]
    /// 
    /// 
    /// 
    /// 
    /// This endpoint is to get list of input validation configuration.
    /// 
    /// 
    /// 
    /// 
    /// `regex` parameter will be returned if `isCustomRegex` is true. Otherwise, it will be empty.
    /// </summary>
    public class AdminGetInputValidations : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetInputValidationsBuilder Builder { get => new AdminGetInputValidationsBuilder(); }

        public class AdminGetInputValidationsBuilder
            : OperationBuilder<AdminGetInputValidationsBuilder>
        {





            internal AdminGetInputValidationsBuilder() { }

            internal AdminGetInputValidationsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminGetInputValidations Build(
            )
            {
                AdminGetInputValidations op = new AdminGetInputValidations(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.ModelInputValidationsResponse? Execute(
            )
            {
                AdminGetInputValidations op = Build(
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

        private AdminGetInputValidations(AdminGetInputValidationsBuilder builder
        )
        {
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetInputValidations(
        )
        {
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/inputValidations";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.ModelInputValidationsResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelInputValidationsResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelInputValidationsResponse>(payload);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}