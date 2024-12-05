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

using AccelByte.Sdk.Api.Seasonpass.Model;

namespace AccelByte.Sdk.Api.Seasonpass.Operation
{
    /// <summary>
    /// grantUserExp
    ///
    /// This API is used to grant exp to user, it will auto enroll if there's no user season but active published season exist, season only located in non-publisher namespace, otherwise ignore.
    /// 
    /// Other detail info:
    /// 
    ///   * Returns : user season data
    /// </summary>
    public class GrantUserExp : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GrantUserExpBuilder Builder { get => new GrantUserExpBuilder(); }

        public class GrantUserExpBuilder
            : OperationBuilder<GrantUserExpBuilder>
        {


            public Model.UserExpGrant? Body { get; set; }




            internal GrantUserExpBuilder() { }

            internal GrantUserExpBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public GrantUserExpBuilder SetBody(Model.UserExpGrant _body)
            {
                Body = _body;
                return this;
            }




            public GrantUserExp Build(
                string namespace_,
                string userId
            )
            {
                GrantUserExp op = new GrantUserExp(this,
                    namespace_,
                    userId
                );

                op.SetBaseFields<GrantUserExpBuilder>(this);
                return op;
            }

            public GrantUserExp.Response Execute(
                string namespace_,
                string userId
            )
            {
                GrantUserExp op = Build(
                    namespace_,
                    userId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<GrantUserExp.Response> ExecuteAsync(
                string namespace_,
                string userId
            )
            {
                GrantUserExp op = Build(
                    namespace_,
                    userId
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

        private GrantUserExp(GrantUserExpBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.UserSeasonSummary>
        {

            public ErrorEntity? Error400 { get; set; } = null;


            protected override string GetFullOperationId() => "Seasonpass::Tier::GrantUserExp";
        }

        #endregion

        public GrantUserExp(
            string namespace_,
            string userId,
            Model.UserExpGrant body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/seasonpass/admin/namespaces/{namespace}/users/{userId}/seasons/current/exp";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public GrantUserExp.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GrantUserExp.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.UserSeasonSummary>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }

            return response;
        }
    }

}