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
    /// AdminUnbanUserBulkV3
    ///
    /// 
    /// 
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:BAN [UPDATE]'.
    /// 
    /// 
    /// 
    /// 
    /// disable bulk ban user. The maximum limit value is 100
    /// 
    /// 
    /// 
    /// 
    /// action code : 10142
    /// </summary>
    public class AdminUnbanUserBulkV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUnbanUserBulkV3Builder Builder { get => new AdminUnbanUserBulkV3Builder(); }

        public class AdminUnbanUserBulkV3Builder
            : OperationBuilder<AdminUnbanUserBulkV3Builder>
        {





            internal AdminUnbanUserBulkV3Builder() { }

            internal AdminUnbanUserBulkV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminUnbanUserBulkV3 Build(
                ModelBulkUnbanCreateRequestV3 body,
                string namespace_
            )
            {
                AdminUnbanUserBulkV3 op = new AdminUnbanUserBulkV3(this,
                    body,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.ModelListBulkUserBanResponseV3? Execute(
                ModelBulkUnbanCreateRequestV3 body,
                string namespace_
            )
            {
                AdminUnbanUserBulkV3 op = Build(
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

        private AdminUnbanUserBulkV3(AdminUnbanUserBulkV3Builder builder,
            ModelBulkUnbanCreateRequestV3 body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminUnbanUserBulkV3(
            string namespace_,            
            Model.ModelBulkUnbanCreateRequestV3 body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/bans/users/disabled";

        public override HttpMethod Method => HttpMethod.Patch;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.ModelListBulkUserBanResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelListBulkUserBanResponseV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelListBulkUserBanResponseV3>(payload);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}