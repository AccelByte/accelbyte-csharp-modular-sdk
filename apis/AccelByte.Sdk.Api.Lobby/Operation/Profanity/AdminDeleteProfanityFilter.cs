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
    /// adminDeleteProfanityFilter
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:PROFANITY [DELETE]` with scope `social`
    /// 
    /// delete the filter from the list
    /// </summary>
    public class AdminDeleteProfanityFilter : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeleteProfanityFilterBuilder Builder { get => new AdminDeleteProfanityFilterBuilder(); }

        public class AdminDeleteProfanityFilterBuilder
            : OperationBuilder<AdminDeleteProfanityFilterBuilder>
        {





            internal AdminDeleteProfanityFilterBuilder() { }

            internal AdminDeleteProfanityFilterBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminDeleteProfanityFilter Build(
                ModelsAdminDeleteProfanityFilterRequest body,
                string list,
                string namespace_
            )
            {
                AdminDeleteProfanityFilter op = new AdminDeleteProfanityFilter(this,
                    body,                    
                    list,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public List<Model.ModelsProfanityFilter>? Execute(
                ModelsAdminDeleteProfanityFilterRequest body,
                string list,
                string namespace_
            )
            {
                AdminDeleteProfanityFilter op = Build(
                    body,
                    list,
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

        private AdminDeleteProfanityFilter(AdminDeleteProfanityFilterBuilder builder,
            ModelsAdminDeleteProfanityFilterRequest body,
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

        public AdminDeleteProfanityFilter(
            string list,            
            string namespace_,            
            Model.ModelsAdminDeleteProfanityFilterRequest body            
        )
        {
            PathParams["list"] = list;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/admin/profanity/namespaces/{namespace}/list/{list}/filters/delete";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public List<Model.ModelsProfanityFilter>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ModelsProfanityFilter>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ModelsProfanityFilter>>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}