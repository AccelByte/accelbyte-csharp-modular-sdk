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

using AccelByte.Sdk.Api.Lobby.Model;

namespace AccelByte.Sdk.Api.Lobby.Operation
{
    /// <summary>
    /// adminPatchUpdateLogConfig
    ///
    /// 
    /// Update Log Configuration
    /// logLevel use for logging in service, the value can use is trace|debug|info|warning|error|fatal|panic
    /// socketLogEnabled is use for enable socket log
    /// logLevelDB use for logging in DB, the value can use is trace|debug|info|warning|error|fatal|panic
    /// slowQueryThreshold use for logging slow threshold in time measure is nano second
    /// </summary>
    public class AdminPatchUpdateLogConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminPatchUpdateLogConfigBuilder Builder { get => new AdminPatchUpdateLogConfigBuilder(); }

        public class AdminPatchUpdateLogConfigBuilder
            : OperationBuilder<AdminPatchUpdateLogConfigBuilder>
        {





            internal AdminPatchUpdateLogConfigBuilder() { }

            internal AdminPatchUpdateLogConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminPatchUpdateLogConfig Build(
                LogconfigConfiguration body
            )
            {
                AdminPatchUpdateLogConfig op = new AdminPatchUpdateLogConfig(this,
                    body
                );

                op.SetBaseFields<AdminPatchUpdateLogConfigBuilder>(this);
                return op;
            }

            public AdminPatchUpdateLogConfig.Response Execute(
                LogconfigConfiguration body
            )
            {
                AdminPatchUpdateLogConfig op = Build(
                    body
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<AdminPatchUpdateLogConfig.Response> ExecuteAsync(
                LogconfigConfiguration body
            )
            {
                AdminPatchUpdateLogConfig op = Build(
                    body
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

        private AdminPatchUpdateLogConfig(AdminPatchUpdateLogConfigBuilder builder,
            LogconfigConfiguration body
        )
        {





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.LogconfigConfiguration>
        {


            protected override string GetFullOperationId() => "Lobby::Config::AdminPatchUpdateLogConfig";
        }

        #endregion

        public AdminPatchUpdateLogConfig(
            Model.LogconfigConfiguration body
        )
        {





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/admin/config/log";

        public override HttpMethod Method => HttpMethod.Patch;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public AdminPatchUpdateLogConfig.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminPatchUpdateLogConfig.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.LogconfigConfiguration>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }

            return response;
        }
    }

}