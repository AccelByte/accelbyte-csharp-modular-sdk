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
    /// AdminGetClientsByNamespaceV3
    ///
    /// 
    /// 
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:CLIENT [READ]'
    /// 
    /// 
    /// 
    /// 
    /// action code: 10308
    /// </summary>
    public class AdminGetClientsByNamespaceV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetClientsByNamespaceV3Builder Builder { get => new AdminGetClientsByNamespaceV3Builder(); }

        public class AdminGetClientsByNamespaceV3Builder
            : OperationBuilder<AdminGetClientsByNamespaceV3Builder>
        {

            public string? ClientId { get; set; }

            public string? ClientName { get; set; }

            public string? ClientType { get; set; }

            public long? Limit { get; set; }

            public long? Offset { get; set; }





            internal AdminGetClientsByNamespaceV3Builder() { }

            internal AdminGetClientsByNamespaceV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public AdminGetClientsByNamespaceV3Builder SetClientId(string _clientId)
            {
                ClientId = _clientId;
                return this;
            }

            public AdminGetClientsByNamespaceV3Builder SetClientName(string _clientName)
            {
                ClientName = _clientName;
                return this;
            }

            public AdminGetClientsByNamespaceV3Builder SetClientType(string _clientType)
            {
                ClientType = _clientType;
                return this;
            }

            public AdminGetClientsByNamespaceV3Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminGetClientsByNamespaceV3Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public AdminGetClientsByNamespaceV3 Build(
                string namespace_
            )
            {
                AdminGetClientsByNamespaceV3 op = new AdminGetClientsByNamespaceV3(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.ClientmodelClientsV3Response? Execute(
                string namespace_
            )
            {
                AdminGetClientsByNamespaceV3 op = Build(
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

        private AdminGetClientsByNamespaceV3(AdminGetClientsByNamespaceV3Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.ClientId is not null) QueryParams["clientId"] = builder.ClientId;
            if (builder.ClientName is not null) QueryParams["clientName"] = builder.ClientName;
            if (builder.ClientType is not null) QueryParams["clientType"] = builder.ClientType;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetClientsByNamespaceV3(
            string namespace_,            
            string? clientId,            
            string? clientName,            
            string? clientType,            
            long? limit,            
            long? offset            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (clientId is not null) QueryParams["clientId"] = clientId;
            if (clientName is not null) QueryParams["clientName"] = clientName;
            if (clientType is not null) QueryParams["clientType"] = clientType;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/clients";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.ClientmodelClientsV3Response? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ClientmodelClientsV3Response>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ClientmodelClientsV3Response>(payload);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}