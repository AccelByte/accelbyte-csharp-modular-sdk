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
    /// retrieveEligibilitiesPublic
    ///
    /// Retrieve the active policies and its conformance status by user.
    /// This process supports cross-namespace checking, that means if the active policy already accepted by the same user in other namespace, then it will be considered as eligible.
    /// </summary>
    public class RetrieveEligibilitiesPublic : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RetrieveEligibilitiesPublicBuilder Builder { get => new RetrieveEligibilitiesPublicBuilder(); }

        public class RetrieveEligibilitiesPublicBuilder
            : OperationBuilder<RetrieveEligibilitiesPublicBuilder>
        {





            internal RetrieveEligibilitiesPublicBuilder() { }

            internal RetrieveEligibilitiesPublicBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public RetrieveEligibilitiesPublic Build(
                string namespace_
            )
            {
                RetrieveEligibilitiesPublic op = new RetrieveEligibilitiesPublic(this,
                    namespace_                    
                );

                op.SetBaseFields<RetrieveEligibilitiesPublicBuilder>(this);
                return op;
            }

            public RetrieveEligibilitiesPublic.Response Execute(
                string namespace_
            )
            {
                RetrieveEligibilitiesPublic op = Build(
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
            public async Task<RetrieveEligibilitiesPublic.Response> ExecuteAsync(
                string namespace_
            )
            {
                RetrieveEligibilitiesPublic op = Build(
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

        private RetrieveEligibilitiesPublic(RetrieveEligibilitiesPublicBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<List<Model.RetrieveUserEligibilitiesResponse>>
        {

            public ErrorEntity? Error400 { get; set; } = null;

            public ErrorEntity? Error404 { get; set; } = null;


            protected override string GetFullOperationId() => "Legal::Eligibilities::RetrieveEligibilitiesPublic";
        }

        #endregion

        public RetrieveEligibilitiesPublic(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/public/eligibilities/namespaces/{namespace}";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public RetrieveEligibilitiesPublic.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new RetrieveEligibilitiesPublic.Response()
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
                response.Data = JsonSerializer.Deserialize<List<Model.RetrieveUserEligibilitiesResponse>>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }

            return response;
        }
    }

}