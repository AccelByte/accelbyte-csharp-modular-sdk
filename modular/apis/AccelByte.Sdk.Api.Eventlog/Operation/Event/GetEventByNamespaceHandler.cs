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

using AccelByte.Sdk.Api.Eventlog.Model;

namespace AccelByte.Sdk.Api.Eventlog.Operation
{
    /// <summary>
    /// GetEventByNamespaceHandler
    ///
    /// Required permission `NAMESPACE:{namespace}:EVENT [UPDATE]` and scope `analytics`
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class GetEventByNamespaceHandler : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetEventByNamespaceHandlerBuilder Builder { get => new GetEventByNamespaceHandlerBuilder(); }

        public class GetEventByNamespaceHandlerBuilder
            : OperationBuilder<GetEventByNamespaceHandlerBuilder>
        {

            public long? Offset { get; set; }





            internal GetEventByNamespaceHandlerBuilder() { }

            internal GetEventByNamespaceHandlerBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetEventByNamespaceHandlerBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public GetEventByNamespaceHandler Build(
                string namespace_,
                string endDate,
                long pageSize,
                string startDate
            )
            {
                GetEventByNamespaceHandler op = new GetEventByNamespaceHandler(this,
                    namespace_,                    
                    endDate,                    
                    pageSize,                    
                    startDate                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
            public Model.ModelsEventResponse? Execute(
                string namespace_,
                string endDate,
                long pageSize,
                string startDate
            )
            {
                GetEventByNamespaceHandler op = Build(
                    namespace_,
                    endDate,
                    pageSize,
                    startDate
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

        private GetEventByNamespaceHandler(GetEventByNamespaceHandlerBuilder builder,
            string namespace_,
            string endDate,
            long pageSize,
            string startDate
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (endDate is not null) QueryParams["endDate"] = endDate;
            QueryParams["pageSize"] = Convert.ToString(pageSize)!;
            if (startDate is not null) QueryParams["startDate"] = startDate;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetEventByNamespaceHandler(
            string namespace_,            
            long? offset,            
            string endDate,            
            long pageSize,            
            string startDate            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (endDate is not null) QueryParams["endDate"] = endDate;
            QueryParams["pageSize"] = Convert.ToString(pageSize)!;
            if (startDate is not null) QueryParams["startDate"] = startDate;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/event/namespaces/{namespace}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.ModelsEventResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsEventResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsEventResponse>(payload);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}