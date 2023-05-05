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

using AccelByte.Sdk.Api.Lobby.Model;

namespace AccelByte.Sdk.Api.Lobby.Operation
{
    /// <summary>
    /// adminAddProfanityFilterIntoList
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:PROFANITY [CREATE]` with scope `social`
    /// 
    /// add a single filter into the list
    /// </summary>
    public class AdminAddProfanityFilterIntoList : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminAddProfanityFilterIntoListBuilder Builder { get => new AdminAddProfanityFilterIntoListBuilder(); }

        public class AdminAddProfanityFilterIntoListBuilder
            : OperationBuilder<AdminAddProfanityFilterIntoListBuilder>
        {





            internal AdminAddProfanityFilterIntoListBuilder() { }

            internal AdminAddProfanityFilterIntoListBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminAddProfanityFilterIntoList Build(
                ModelsAdminAddProfanityFilterIntoListRequest body,
                string list,
                string namespace_
            )
            {
                AdminAddProfanityFilterIntoList op = new AdminAddProfanityFilterIntoList(this,
                    body,                    
                    list,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public void Execute(
                ModelsAdminAddProfanityFilterIntoListRequest body,
                string list,
                string namespace_
            )
            {
                AdminAddProfanityFilterIntoList op = Build(
                    body,
                    list,
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

        private AdminAddProfanityFilterIntoList(AdminAddProfanityFilterIntoListBuilder builder,
            ModelsAdminAddProfanityFilterIntoListRequest body,
            string list,
            string namespace_
        )
        {
            PathParams["list"] = list;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminAddProfanityFilterIntoList(
            string list,            
            string namespace_,            
            Model.ModelsAdminAddProfanityFilterIntoListRequest body            
        )
        {
            PathParams["list"] = list;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/admin/profanity/namespaces/{namespace}/list/{list}/filters";

        public override HttpMethod Method => HttpMethod.Post;

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