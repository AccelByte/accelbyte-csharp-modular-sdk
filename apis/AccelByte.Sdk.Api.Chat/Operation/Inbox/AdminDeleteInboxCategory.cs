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

using AccelByte.Sdk.Api.Chat.Model;

namespace AccelByte.Sdk.Api.Chat.Operation
{
    /// <summary>
    /// adminDeleteInboxCategory
    ///
    /// Delete inbox category
    /// </summary>
    public class AdminDeleteInboxCategory : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeleteInboxCategoryBuilder Builder { get => new AdminDeleteInboxCategoryBuilder(); }

        public class AdminDeleteInboxCategoryBuilder
            : OperationBuilder<AdminDeleteInboxCategoryBuilder>
        {





            internal AdminDeleteInboxCategoryBuilder() { }

            internal AdminDeleteInboxCategoryBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminDeleteInboxCategory Build(
                string category,
                string namespace_
            )
            {
                AdminDeleteInboxCategory op = new AdminDeleteInboxCategory(this,
                    category,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public void Execute(
                string category,
                string namespace_
            )
            {
                AdminDeleteInboxCategory op = Build(
                    category,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
        }

        private AdminDeleteInboxCategory(AdminDeleteInboxCategoryBuilder builder,
            string category,
            string namespace_
        )
        {
            PathParams["category"] = category;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminDeleteInboxCategory(
            string category,            
            string namespace_            
        )
        {
            PathParams["category"] = category;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/chat/v1/admin/inbox/namespaces/{namespace}/categories/{category}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return;
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}