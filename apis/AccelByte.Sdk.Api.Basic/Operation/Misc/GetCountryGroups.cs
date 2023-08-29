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
    /// getCountryGroups
    ///
    /// List country groups. Will return all available country groups if the query param is not specified
    /// Other detail info:
    /// 
    ///   * Required permission : resource = "ADMIN:NAMESPACE:{namespace}:MISC" , action=2 (READ)
    ///   *  Action code : 11203
    ///   *  Returns : list of country groups
    /// </summary>
    public class GetCountryGroups : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetCountryGroupsBuilder Builder { get => new GetCountryGroupsBuilder(); }

        public class GetCountryGroupsBuilder
            : OperationBuilder<GetCountryGroupsBuilder>
        {

            public string? GroupCode { get; set; }





            internal GetCountryGroupsBuilder() { }

            internal GetCountryGroupsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetCountryGroupsBuilder SetGroupCode(string _groupCode)
            {
                GroupCode = _groupCode;
                return this;
            }





            public GetCountryGroups Build(
                string namespace_
            )
            {
                GetCountryGroups op = new GetCountryGroups(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public List<Model.RetrieveCountryGroupResponse>? Execute(
                string namespace_
            )
            {
                GetCountryGroups op = Build(
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

        private GetCountryGroups(GetCountryGroupsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.GroupCode is not null) QueryParams["groupCode"] = builder.GroupCode;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetCountryGroups(
            string namespace_,            
            string? groupCode            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (groupCode is not null) QueryParams["groupCode"] = groupCode;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/basic/v1/admin/namespaces/{namespace}/misc/countrygroups";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };        
        
        public List<Model.RetrieveCountryGroupResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.RetrieveCountryGroupResponse>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.RetrieveCountryGroupResponse>>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}