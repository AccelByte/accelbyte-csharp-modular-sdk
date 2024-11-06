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
    /// createStatCycle
    ///
    /// Create stat cycle.
    /// Fields:
    ///         * id: Cycle id, consist of alphanumeric characters with a maximum of 32 characters. if not provided will be generated. (optional).
    ///         * name: Cycle name, maximum length is 128 characters. (required).
    ///         * resetTime: Reset time must follow hours:minutes in 24 hours format e.g. 01:30, 23:15. (required)
    ///         * resetDay: Reset Day follows the ISO-8601 standard, from 1 (Monday) to 7 (Sunday). Required when cycleType is WEEKLY.
    ///         * resetDate: Reset Date must be a number 1 - 31. Required when cycleType is MONTHLY or ANNUALLY.
    ///         * resetMonth: Reset Month must be a number 1 - 12. Required when cycleType is ANNUALLY.
    ///         * seasonPeriod: Season period must be a number greater than or equal to 1 (days). Required when cycleType is SEASONAL.
    ///         * start: Start time must follow RFC3339 standard. e.g. 2023-02-24T05:10:24.865Z. (required)
    ///         * end: End time must follow RFC3339 standard. e.g. 2023-02-24T05:10:24.865Z.
    /// Other detail info:
    ///         *  Returns : created stat cycle
    /// </summary>
    public class CreateStatCycle : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateStatCycleBuilder Builder { get => new CreateStatCycleBuilder(); }

        public class CreateStatCycleBuilder
            : OperationBuilder<CreateStatCycleBuilder>
        {


            public Model.StatCycleCreate? Body { get; set; }




            internal CreateStatCycleBuilder() { }

            internal CreateStatCycleBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public CreateStatCycleBuilder SetBody(Model.StatCycleCreate _body)
            {
                Body = _body;
                return this;
            }




            public CreateStatCycle Build(
                string namespace_
            )
            {
                CreateStatCycle op = new CreateStatCycle(this,
                    namespace_                    
                );

                op.SetBaseFields<CreateStatCycleBuilder>(this);
                return op;
            }

            public CreateStatCycle.Response Execute(
                string namespace_
            )
            {
                CreateStatCycle op = Build(
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
            public async Task<CreateStatCycle.Response> ExecuteAsync(
                string namespace_
            )
            {
                CreateStatCycle op = Build(
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

        private CreateStatCycle(CreateStatCycleBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.StatCycleInfo>
        {

            public ErrorEntity? Error400 { get; set; } = null;

            public ErrorEntity? Error401 { get; set; } = null;

            public ErrorEntity? Error403 { get; set; } = null;

            public ErrorEntity? Error409 { get; set; } = null;

            public ValidationErrorEntity? Error422 { get; set; } = null;

            public ErrorEntity? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Social::StatCycleConfiguration::CreateStatCycle";
        }

        #endregion

        public CreateStatCycle(
            string namespace_,            
            Model.StatCycleCreate body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/v1/admin/namespaces/{namespace}/statCycles";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public CreateStatCycle.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new CreateStatCycle.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.StatCycleInfo>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)409)
            {
                response.Error409 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error409!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)422)
            {
                response.Error422 = JsonSerializer.Deserialize<ValidationErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error422!.TranslateToApiError();
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