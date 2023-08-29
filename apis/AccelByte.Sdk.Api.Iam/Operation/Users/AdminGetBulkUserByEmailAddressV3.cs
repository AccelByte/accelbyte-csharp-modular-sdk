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
    /// AdminGetBulkUserByEmailAddressV3
    ///
    /// 
    /// 
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:USER [READ]'
    /// 
    /// 
    /// 
    /// 
    /// This endpoint search user by the list of email addresses
    /// 
    /// 
    /// 
    /// action code : 10132
    /// </summary>
    public class AdminGetBulkUserByEmailAddressV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetBulkUserByEmailAddressV3Builder Builder { get => new AdminGetBulkUserByEmailAddressV3Builder(); }

        public class AdminGetBulkUserByEmailAddressV3Builder
            : OperationBuilder<AdminGetBulkUserByEmailAddressV3Builder>
        {





            internal AdminGetBulkUserByEmailAddressV3Builder() { }

            internal AdminGetBulkUserByEmailAddressV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminGetBulkUserByEmailAddressV3 Build(
                ModelListEmailAddressRequest body,
                string namespace_
            )
            {
                AdminGetBulkUserByEmailAddressV3 op = new AdminGetBulkUserByEmailAddressV3(this,
                    body,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelListUserResponseV3? Execute(
                ModelListEmailAddressRequest body,
                string namespace_
            )
            {
                AdminGetBulkUserByEmailAddressV3 op = Build(
                    body,
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

        private AdminGetBulkUserByEmailAddressV3(AdminGetBulkUserByEmailAddressV3Builder builder,
            ModelListEmailAddressRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetBulkUserByEmailAddressV3(
            string namespace_,            
            Model.ModelListEmailAddressRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/search/bulk";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.ModelListUserResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelListUserResponseV3>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelListUserResponseV3>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}