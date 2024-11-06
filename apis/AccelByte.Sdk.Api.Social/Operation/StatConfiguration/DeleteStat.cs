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

using AccelByte.Sdk.Api.Social.Model;

namespace AccelByte.Sdk.Api.Social.Operation
{
    /// <summary>
    /// deleteStat
    ///
    /// Deletes stat template.
    /// </summary>
    public class DeleteStat : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteStatBuilder Builder { get => new DeleteStatBuilder(); }

        public class DeleteStatBuilder
            : OperationBuilder<DeleteStatBuilder>
        {





            internal DeleteStatBuilder() { }

            internal DeleteStatBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteStat Build(
                string namespace_,
                string statCode
            )
            {
                DeleteStat op = new DeleteStat(this,
                    namespace_,                    
                    statCode                    
                );

                op.SetBaseFields<DeleteStatBuilder>(this);
                return op;
            }

            public DeleteStat.Response Execute(
                string namespace_,
                string statCode
            )
            {
                DeleteStat op = Build(
                    namespace_,
                    statCode
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<DeleteStat.Response> ExecuteAsync(
                string namespace_,
                string statCode
            )
            {
                DeleteStat op = Build(
                    namespace_,
                    statCode
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

        private DeleteStat(DeleteStatBuilder builder,
            string namespace_,
            string statCode
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["statCode"] = statCode;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {

            public ErrorEntity? Error401 { get; set; } = null;

            public ErrorEntity? Error403 { get; set; } = null;

            public ErrorEntity? Error404 { get; set; } = null;

            public ErrorEntity? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Social::StatConfiguration::DeleteStat";
        }

        #endregion

        public DeleteStat(
            string namespace_,            
            string statCode            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["statCode"] = statCode;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/v1/admin/namespaces/{namespace}/stats/{statCode}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() {  };
        
        public DeleteStat.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new DeleteStat.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };

            if (code == (HttpStatusCode)401)
            
            {
                response.Error401 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            
            {
                response.Error403 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            
            {
                response.Error404 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            
            {
                response.Error500 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

}