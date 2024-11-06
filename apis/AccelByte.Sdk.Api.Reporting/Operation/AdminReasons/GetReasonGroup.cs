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

using AccelByte.Sdk.Api.Reporting.Model;

namespace AccelByte.Sdk.Api.Reporting.Operation
{
    /// <summary>
    /// getReasonGroup
    /// </summary>
    public class GetReasonGroup : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetReasonGroupBuilder Builder { get => new GetReasonGroupBuilder(); }

        public class GetReasonGroupBuilder
            : OperationBuilder<GetReasonGroupBuilder>
        {





            internal GetReasonGroupBuilder() { }

            internal GetReasonGroupBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetReasonGroup Build(
                string groupId,
                string namespace_
            )
            {
                GetReasonGroup op = new GetReasonGroup(this,
                    groupId,                    
                    namespace_                    
                );

                op.SetBaseFields<GetReasonGroupBuilder>(this);
                return op;
            }

            public GetReasonGroup.Response Execute(
                string groupId,
                string namespace_
            )
            {
                GetReasonGroup op = Build(
                    groupId,
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
            public async Task<GetReasonGroup.Response> ExecuteAsync(
                string groupId,
                string namespace_
            )
            {
                GetReasonGroup op = Build(
                    groupId,
                    namespace_
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

        private GetReasonGroup(GetReasonGroupBuilder builder,
            string groupId,
            string namespace_
        )
        {
            PathParams["groupId"] = groupId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.RestapiReasonGroupResponse>
        {

            public RestapiErrorResponse? Error404 { get; set; } = null;

            public RestapiErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Reporting::AdminReasons::GetReasonGroup";
        }

        #endregion

        public GetReasonGroup(
            string groupId,            
            string namespace_            
        )
        {
            PathParams["groupId"] = groupId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/reporting/v1/admin/namespaces/{namespace}/reasonGroups/{groupId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public GetReasonGroup.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetReasonGroup.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.RestapiReasonGroupResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<RestapiErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<RestapiErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}