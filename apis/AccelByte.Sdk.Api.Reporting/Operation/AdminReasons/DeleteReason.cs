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
    /// deleteReason
    ///
    /// This endpoint delete a reason for a namespace with ID.
    /// </summary>
    public class DeleteReason : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteReasonBuilder Builder { get => new DeleteReasonBuilder(); }

        public class DeleteReasonBuilder
            : OperationBuilder<DeleteReasonBuilder>
        {





            internal DeleteReasonBuilder() { }

            internal DeleteReasonBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteReason Build(
                string namespace_,
                string reasonId
            )
            {
                DeleteReason op = new DeleteReason(this,
                    namespace_,                    
                    reasonId                    
                );

                op.SetBaseFields<DeleteReasonBuilder>(this);
                return op;
            }

            public DeleteReason.Response Execute(
                string namespace_,
                string reasonId
            )
            {
                DeleteReason op = Build(
                    namespace_,
                    reasonId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<DeleteReason.Response> ExecuteAsync(
                string namespace_,
                string reasonId
            )
            {
                DeleteReason op = Build(
                    namespace_,
                    reasonId
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

        private DeleteReason(DeleteReasonBuilder builder,
            string namespace_,
            string reasonId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["reasonId"] = reasonId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public RestapiErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Reporting::AdminReasons::DeleteReason";
        }

        #endregion

        public DeleteReason(
            string namespace_,            
            string reasonId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["reasonId"] = reasonId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/reporting/v1/admin/namespaces/{namespace}/reasons/{reasonId}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public DeleteReason.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new DeleteReason.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)500)
            
            {
                response.Error500 = JsonSerializer.Deserialize<RestapiErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}