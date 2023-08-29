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
    /// adminGetProfanityListFiltersV1
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:PROFANITY [READ]` with scope `social`
    /// 
    /// get the list of filters inside the list.
    /// </summary>
    public class AdminGetProfanityListFiltersV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetProfanityListFiltersV1Builder Builder { get => new AdminGetProfanityListFiltersV1Builder(); }

        public class AdminGetProfanityListFiltersV1Builder
            : OperationBuilder<AdminGetProfanityListFiltersV1Builder>
        {





            internal AdminGetProfanityListFiltersV1Builder() { }

            internal AdminGetProfanityListFiltersV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminGetProfanityListFiltersV1 Build(
                string list,
                string namespace_
            )
            {
                AdminGetProfanityListFiltersV1 op = new AdminGetProfanityListFiltersV1(this,
                    list,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelsAdminGetProfanityListFiltersV1Response? Execute(
                string list,
                string namespace_
            )
            {
                AdminGetProfanityListFiltersV1 op = Build(
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

        private AdminGetProfanityListFiltersV1(AdminGetProfanityListFiltersV1Builder builder,
            string list,
            string namespace_
        )
        {
            PathParams["list"] = list;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetProfanityListFiltersV1(
            string list,            
            string namespace_            
        )
        {
            PathParams["list"] = list;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/admin/profanity/namespaces/{namespace}/list/{list}/filters";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.ModelsAdminGetProfanityListFiltersV1Response? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsAdminGetProfanityListFiltersV1Response>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsAdminGetProfanityListFiltersV1Response>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}