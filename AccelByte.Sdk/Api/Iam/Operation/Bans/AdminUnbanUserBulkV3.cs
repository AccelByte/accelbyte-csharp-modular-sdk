// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

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

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
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
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}