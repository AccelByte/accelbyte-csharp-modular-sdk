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
    /// UpdateUser
    ///
    /// 
    /// 
    /// ## The endpoint is going to be deprecated
    /// 
    /// 
    /// Endpoint migration guide
    /// 
    /// 
    /// 
    /// 
    ///   * Substitute endpoint([PUT]): /iam/v3/public/namespaces/{namespace}/users/me [PUT]
    /// 
    ///   * Substitute endpoint([PATCH]): /iam/v3/public/namespaces/{namespace}/users/me [PATCH]
    /// 
    ///   * Substitute endpoint([PATCH]): /iam/v4/public/namespaces/{namespace}/users/me [PATCH]
    /// 
    /// 
    /// 
    ///   * Note:
    ///     1. Prefer [PATCH] if client support PATCH method
    /// 
    ///     2. Difference in V3/v4 request body, format difference: Pascal case => Camel case
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    /// Required permission 'NAMESPACE:{namespace}:USER:{userId} [UPDATE]'
    /// 
    /// "+
    /// "
    /// 
    /// 
    /// This Endpoint support update user based on given data. Single request can update single field or multi fields.
    /// 
    /// "+
    /// "
    /// 
    /// Supported field {Country, DisplayName, LanguageTag}
    /// 
    /// "+
    /// "
    /// 
    /// Country use ISO3166-1 alpha-2 two letter, e.g. US.
    /// 
    /// "+
    /// "
    ///  Several case of updating email address "+
    /// "
    /// 
    ///   * User want to update email address of which have been verified, NewEmailAddress response field will be filled with new email address.
    /// "+
    /// "
    ///   * User want to update email address of which have not been verified, {LoginId, OldEmailAddress, EmailAddress} response field will be filled with new email address.
    /// "+
    /// "
    ///   * User want to update email address of which have been verified and updated before, {LoginId, OldEmailAddress, EmailAddress} response field will be filled with verified email before. NewEmailAddress response field will be filled with newest email address.
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class UpdateUser : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateUserBuilder Builder { get => new UpdateUserBuilder(); }

        public class UpdateUserBuilder
            : OperationBuilder<UpdateUserBuilder>
        {





            internal UpdateUserBuilder() { }

            internal UpdateUserBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public UpdateUser Build(
                ModelUserUpdateRequest body,
                string namespace_,
                string userId
            )
            {
                UpdateUser op = new UpdateUser(this,
                    body,                    
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
            public Model.ModelUserResponse? Execute(
                ModelUserUpdateRequest body,
                string namespace_,
                string userId
            )
            {
                UpdateUser op = Build(
                    body,
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
        }

        private UpdateUser(UpdateUserBuilder builder,
            ModelUserUpdateRequest body,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateUser(
            string namespace_,            
            string userId,            
            Model.ModelUserUpdateRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/namespaces/{namespace}/users/{userId}";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.ModelUserResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelUserResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelUserResponse>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}