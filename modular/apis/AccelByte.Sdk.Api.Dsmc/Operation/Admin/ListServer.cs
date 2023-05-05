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

using AccelByte.Sdk.Api.Dsmc.Model;

namespace AccelByte.Sdk.Api.Dsmc.Operation
{
    /// <summary>
    /// ListServer
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSM:SERVER [READ]
    /// 
    /// Required scope: social
    /// 
    /// This endpoint lists all of dedicated servers in a namespace managed by this service.
    /// 
    /// Parameter Offset and Count is Required
    /// </summary>
    public class ListServer : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ListServerBuilder Builder { get => new ListServerBuilder(); }

        public class ListServerBuilder
            : OperationBuilder<ListServerBuilder>
        {

            public string? Region { get; set; }





            internal ListServerBuilder() { }

            internal ListServerBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public ListServerBuilder SetRegion(string _region)
            {
                Region = _region;
                return this;
            }





            public ListServer Build(
                string namespace_,
                long count,
                long offset
            )
            {
                ListServer op = new ListServer(this,
                    namespace_,                    
                    count,                    
                    offset                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public Model.ModelsListServerResponse? Execute(
                string namespace_,
                long count,
                long offset
            )
            {
                ListServer op = Build(
                    namespace_,
                    count,
                    offset
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

        private ListServer(ListServerBuilder builder,
            string namespace_,
            long count,
            long offset
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.Region is not null) QueryParams["region"] = builder.Region;
            QueryParams["count"] = Convert.ToString(count)!;
            QueryParams["offset"] = Convert.ToString(offset)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ListServer(
            string namespace_,            
            string? region,            
            long count,            
            long offset            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (region is not null) QueryParams["region"] = region;
            QueryParams["count"] = Convert.ToString(count)!;
            QueryParams["offset"] = Convert.ToString(offset)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsmcontroller/admin/namespaces/{namespace}/servers";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.ModelsListServerResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsListServerResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsListServerResponse>(payload);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}