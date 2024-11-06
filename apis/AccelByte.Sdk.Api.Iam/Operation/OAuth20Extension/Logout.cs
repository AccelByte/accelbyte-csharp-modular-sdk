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

using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// Logout
    ///
    /// This endpoint is used to remove **access_token**, **refresh_token** from cookie.
    /// </summary>
    public class Logout : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static LogoutBuilder Builder { get => new LogoutBuilder(); }

        public class LogoutBuilder
            : OperationBuilder<LogoutBuilder>
        {





            internal LogoutBuilder() { }

            internal LogoutBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public Logout Build(
            )
            {
                Logout op = new Logout(this
                );

                op.SetBaseFields<LogoutBuilder>(this);
                return op;
            }

            public Logout.Response Execute(
            )
            {
                Logout op = Build(
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Logout.Response> ExecuteAsync(
            )
            {
                Logout op = Build(
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

        private Logout(LogoutBuilder builder
        )
        {
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {


            protected override string GetFullOperationId() => "Iam::OAuth20Extension::Logout";
        }

        #endregion

        public Logout(
        )
        {
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/logout";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "*/*" };

        public override List<string> Produces => new() { "application/json" };
        
        public Logout.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new Logout.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };


            return response;
        }
    }

}