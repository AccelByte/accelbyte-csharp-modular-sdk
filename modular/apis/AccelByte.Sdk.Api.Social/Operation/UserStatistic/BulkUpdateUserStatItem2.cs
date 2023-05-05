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

using AccelByte.Sdk.Api.Social.Model;

namespace AccelByte.Sdk.Api.Social.Operation
{
    /// <summary>
    /// bulkUpdateUserStatItem_2
    ///
    /// Public bulk update user's statitems value for given namespace and user with specific update strategy.
    /// There are four supported update strategies:
    /// + *OVERRIDE*: update user statitem with the new value
    /// + *INCREMENT*: increment user statitem with the specified value
    /// + *MAX*: update user statitem with the specified value if it's larger than the existing value
    /// + *MIN*: update user statitem with the specified value if it's lower than the existing value
    /// 
    /// The *additionalKey* parameter will be suffixed to *userId* and is used to support multi level user's statitems, such as character's statitems.
    /// If provided, user's statitems will be saved with key: *userId_additionalKey*
    /// 
    /// Other detail info:
    /// + *Required permission*: resource="NAMESPACE:{namespace}:USER:{userId}:STATITEM", action=4 (UPDATE)
    /// + *Returns*: bulk updated result
    /// </summary>
    public class BulkUpdateUserStatItem2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static BulkUpdateUserStatItem2Builder Builder { get => new BulkUpdateUserStatItem2Builder(); }

        public class BulkUpdateUserStatItem2Builder
            : OperationBuilder<BulkUpdateUserStatItem2Builder>
        {

            public string? AdditionalKey { get; set; }


            public List<Model.BulkStatItemUpdate>? Body { get; set; }




            internal BulkUpdateUserStatItem2Builder() { }

            internal BulkUpdateUserStatItem2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public BulkUpdateUserStatItem2Builder SetAdditionalKey(string _additionalKey)
            {
                AdditionalKey = _additionalKey;
                return this;
            }


            public BulkUpdateUserStatItem2Builder SetBody(List<Model.BulkStatItemUpdate> _body)
            {
                Body = _body;
                return this;
            }




            public BulkUpdateUserStatItem2 Build(
                string namespace_,
                string userId
            )
            {
                BulkUpdateUserStatItem2 op = new BulkUpdateUserStatItem2(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public List<Model.BulkStatOperationResult>? Execute(
                string namespace_,
                string userId
            )
            {
                BulkUpdateUserStatItem2 op = Build(
                    namespace_,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }

            public List<Model.BulkStatOperationResult<T1>>? Execute<T1>(
                string namespace_,
                string userId
            )
            {
                BulkUpdateUserStatItem2 op = Build(
                    namespace_,
                    userId
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

        private BulkUpdateUserStatItem2(BulkUpdateUserStatItem2Builder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.AdditionalKey is not null) QueryParams["additionalKey"] = builder.AdditionalKey;
            

            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public BulkUpdateUserStatItem2(
            string namespace_,            
            string userId,            
            string? additionalKey,            
            List<Model.BulkStatItemUpdate> body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (additionalKey is not null) QueryParams["additionalKey"] = additionalKey;
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/v2/public/namespaces/{namespace}/users/{userId}/statitems/value/bulk";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public List<Model.BulkStatOperationResult>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.BulkStatOperationResult>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.BulkStatOperationResult>>(payload);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }

        public List<Model.BulkStatOperationResult<T1>>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }            
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.BulkStatOperationResult<T1>>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.BulkStatOperationResult<T1>>>(payload);
            }
            
            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}