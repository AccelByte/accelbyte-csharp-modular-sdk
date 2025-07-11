// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
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
using System.Threading.Tasks;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Net.Http;

using AccelByte.Sdk.Api.Legal.Model;

namespace AccelByte.Sdk.Api.Legal.Operation
{
    /// <summary>
    /// indirectBulkAcceptVersionedPolicy
    ///
    /// Accepts many legal policy versions all at once. Supply with localized version policy id and userId to accept an agreement.
    /// </summary>
    public class IndirectBulkAcceptVersionedPolicy : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static IndirectBulkAcceptVersionedPolicyBuilder Builder { get => new IndirectBulkAcceptVersionedPolicyBuilder(); }

        public class IndirectBulkAcceptVersionedPolicyBuilder
            : OperationBuilder<IndirectBulkAcceptVersionedPolicyBuilder>
        {

            public string? PublisherUserId { get; set; }


            public List<Model.AcceptAgreementRequest>? Body { get; set; }




            internal IndirectBulkAcceptVersionedPolicyBuilder() { }

            internal IndirectBulkAcceptVersionedPolicyBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public IndirectBulkAcceptVersionedPolicyBuilder SetPublisherUserId(string _publisherUserId)
            {
                PublisherUserId = _publisherUserId;
                return this;
            }


            public IndirectBulkAcceptVersionedPolicyBuilder SetBody(List<Model.AcceptAgreementRequest> _body)
            {
                Body = _body;
                return this;
            }




            public IndirectBulkAcceptVersionedPolicy Build(
                string namespace_,
                string userId,
                string clientId,
                string countryCode
            )
            {
                IndirectBulkAcceptVersionedPolicy op = new IndirectBulkAcceptVersionedPolicy(this,
                    namespace_,                    
                    userId,                    
                    clientId,                    
                    countryCode                    
                );

                op.SetBaseFields<IndirectBulkAcceptVersionedPolicyBuilder>(this);
                return op;
            }

            public IndirectBulkAcceptVersionedPolicy.Response Execute(
                string namespace_,
                string userId,
                string clientId,
                string countryCode
            )
            {
                IndirectBulkAcceptVersionedPolicy op = Build(
                    namespace_,
                    userId,
                    clientId,
                    countryCode
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<IndirectBulkAcceptVersionedPolicy.Response> ExecuteAsync(
                string namespace_,
                string userId,
                string clientId,
                string countryCode
            )
            {
                IndirectBulkAcceptVersionedPolicy op = Build(
                    namespace_,
                    userId,
                    clientId,
                    countryCode
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
        }

        private IndirectBulkAcceptVersionedPolicy(IndirectBulkAcceptVersionedPolicyBuilder builder,
            string namespace_,
            string userId,
            string clientId,
            string countryCode
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.PublisherUserId is not null) QueryParams["publisherUserId"] = builder.PublisherUserId;
            if (clientId is not null) QueryParams["clientId"] = clientId;
            if (countryCode is not null) QueryParams["countryCode"] = countryCode;
            

            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.AcceptAgreementResponse>
        {


            protected override string GetFullOperationId() => "Legal::AdminUserAgreement::IndirectBulkAcceptVersionedPolicy";
        }

        #endregion

        public IndirectBulkAcceptVersionedPolicy(
            string namespace_,            
            string userId,            
            string? publisherUserId,            
            string clientId,            
            string countryCode,            
            List<Model.AcceptAgreementRequest> body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (publisherUserId is not null) QueryParams["publisherUserId"] = publisherUserId;
            if (clientId is not null) QueryParams["clientId"] = clientId;
            if (countryCode is not null) QueryParams["countryCode"] = countryCode;
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/namespaces/{namespace}/users/{userId}/agreements/policies";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public IndirectBulkAcceptVersionedPolicy.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new IndirectBulkAcceptVersionedPolicy.Response()
            {
                StatusCode = code,
                ContentType = contentType
            };

            if (code == (HttpStatusCode)204)
            {
                response.IsSuccess = true;
            }
            else if ((code == (HttpStatusCode)201) || (code == (HttpStatusCode)202) || (code == (HttpStatusCode)200))
            {
                response.Data = JsonSerializer.Deserialize<Model.AcceptAgreementResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }

            return response;
        }
    }

}