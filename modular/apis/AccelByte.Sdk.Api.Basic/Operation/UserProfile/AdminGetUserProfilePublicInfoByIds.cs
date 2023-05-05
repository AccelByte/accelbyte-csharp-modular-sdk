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

using AccelByte.Sdk.Api.Basic.Model;

namespace AccelByte.Sdk.Api.Basic.Operation
{
    /// <summary>
    /// adminGetUserProfilePublicInfoByIds
    ///
    /// Admin get user public profile by ids.
    /// Other detail info:
    /// 
    ///   * Required permission : resource= "ADMIN:NAMESPACE:{namespace}:PROFILE" , action=2 (GET)
    ///   *  Action code : 11405
    ///   *  Returns : user public profiles
    /// </summary>
    public class AdminGetUserProfilePublicInfoByIds : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetUserProfilePublicInfoByIdsBuilder Builder { get => new AdminGetUserProfilePublicInfoByIdsBuilder(); }

        public class AdminGetUserProfilePublicInfoByIdsBuilder
            : OperationBuilder<AdminGetUserProfilePublicInfoByIdsBuilder>
        {


            public Model.UserProfileBulkRequest? Body { get; set; }




            internal AdminGetUserProfilePublicInfoByIdsBuilder() { }

            internal AdminGetUserProfilePublicInfoByIdsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public AdminGetUserProfilePublicInfoByIdsBuilder SetBody(Model.UserProfileBulkRequest _body)
            {
                Body = _body;
                return this;
            }




            public AdminGetUserProfilePublicInfoByIds Build(
                string namespace_
            )
            {
                AdminGetUserProfilePublicInfoByIds op = new AdminGetUserProfilePublicInfoByIds(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public List<Model.UserProfilePublicInfo>? Execute(
                string namespace_
            )
            {
                AdminGetUserProfilePublicInfoByIds op = Build(
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

            public List<Model.UserProfilePublicInfo<T1>>? Execute<T1>(
                string namespace_
            )
            {
                AdminGetUserProfilePublicInfoByIds op = Build(
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse<T1>(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
        }

        private AdminGetUserProfilePublicInfoByIds(AdminGetUserProfilePublicInfoByIdsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetUserProfilePublicInfoByIds(
            string namespace_,            
            Model.UserProfileBulkRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/basic/v1/admin/namespaces/{namespace}/profiles/public";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public List<Model.UserProfilePublicInfo>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.UserProfilePublicInfo>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.UserProfilePublicInfo>>(payload);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }

        public List<Model.UserProfilePublicInfo<T1>>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }            
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.UserProfilePublicInfo<T1>>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.UserProfilePublicInfo<T1>>>(payload);
            }
            
            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}