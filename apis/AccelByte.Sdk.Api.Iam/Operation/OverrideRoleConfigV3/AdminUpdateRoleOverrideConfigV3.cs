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
    /// AdminUpdateRoleOverrideConfigV3
    ///
    /// This API is for updating role override config.
    /// Note:
    /// This API has upsert behavior, if there is no config yet, it will create a new one first.
    /// </summary>
    public class AdminUpdateRoleOverrideConfigV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateRoleOverrideConfigV3Builder Builder { get => new AdminUpdateRoleOverrideConfigV3Builder(); }

        public class AdminUpdateRoleOverrideConfigV3Builder
            : OperationBuilder<AdminUpdateRoleOverrideConfigV3Builder>
        {





            internal AdminUpdateRoleOverrideConfigV3Builder() { }

            internal AdminUpdateRoleOverrideConfigV3Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminUpdateRoleOverrideConfigV3 Build(
                ModelRoleOverrideUpdateRequest body,
                string namespace_,
                AdminUpdateRoleOverrideConfigV3Identity identity
            )
            {
                AdminUpdateRoleOverrideConfigV3 op = new AdminUpdateRoleOverrideConfigV3(this,
                    body,                    
                    namespace_,                    
                    identity                    
                );

                op.SetBaseFields<AdminUpdateRoleOverrideConfigV3Builder>(this);
                return op;
            }

            public AdminUpdateRoleOverrideConfigV3.Response Execute(
                ModelRoleOverrideUpdateRequest body,
                string namespace_,
                string identity
            )
            {
                AdminUpdateRoleOverrideConfigV3 op = Build(
                    body,
                    namespace_,
                    identity
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<AdminUpdateRoleOverrideConfigV3.Response> ExecuteAsync(
                ModelRoleOverrideUpdateRequest body,
                string namespace_,
                string identity
            )
            {
                AdminUpdateRoleOverrideConfigV3 op = Build(
                    body,
                    namespace_,
                    identity
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

        private AdminUpdateRoleOverrideConfigV3(AdminUpdateRoleOverrideConfigV3Builder builder,
            ModelRoleOverrideUpdateRequest body,
            string namespace_,
            AdminUpdateRoleOverrideConfigV3Identity identity
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (identity is not null) QueryParams["identity"] = identity.Value;
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelRoleOverrideResponse>
        {

            public RestErrorResponse? Error400 { get; set; } = null;

            public RestErrorResponse? Error401 { get; set; } = null;

            public RestErrorResponse? Error403 { get; set; } = null;

            public RestErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Iam::OverrideRoleConfigV3::AdminUpdateRoleOverrideConfigV3";
        }

        #endregion

        public AdminUpdateRoleOverrideConfigV3(
            string namespace_,            
            AdminUpdateRoleOverrideConfigV3Identity identity,            
            Model.ModelRoleOverrideUpdateRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (identity is not null) QueryParams["identity"] = identity.Value;
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/roleoverride";

        public override HttpMethod Method => HttpMethod.Patch;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public AdminUpdateRoleOverrideConfigV3.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new AdminUpdateRoleOverrideConfigV3.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelRoleOverrideResponse>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<RestErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }
    }

    public class AdminUpdateRoleOverrideConfigV3Identity : StringEnum<AdminUpdateRoleOverrideConfigV3Identity>
    {
        public static readonly AdminUpdateRoleOverrideConfigV3Identity GAMEADMIN
            = new AdminUpdateRoleOverrideConfigV3Identity("GAME_ADMIN");

        public static readonly AdminUpdateRoleOverrideConfigV3Identity USER
            = new AdminUpdateRoleOverrideConfigV3Identity("USER");

        public static readonly AdminUpdateRoleOverrideConfigV3Identity VIEWONLY
            = new AdminUpdateRoleOverrideConfigV3Identity("VIEW_ONLY");


        public static implicit operator AdminUpdateRoleOverrideConfigV3Identity(string value)
        {
            return NewValue(value);
        }

        public AdminUpdateRoleOverrideConfigV3Identity(string enumValue)
            : base(enumValue)
        {

        }
    }

}