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
    /// deleteUserSlotConfig
    ///
    /// 
    /// 
    /// ## The endpoint is going to be deprecated
    /// 
    /// 
    /// Deletes a user slot configuration in given namespace, the namespace slot configuration will be returned after delete.
    /// Other detail info:
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class DeleteUserSlotConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteUserSlotConfigBuilder Builder { get => new DeleteUserSlotConfigBuilder(); }

        public class DeleteUserSlotConfigBuilder
            : OperationBuilder<DeleteUserSlotConfigBuilder>
        {





            internal DeleteUserSlotConfigBuilder() { }

            internal DeleteUserSlotConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteUserSlotConfig Build(
                string namespace_,
                string userId
            )
            {
                DeleteUserSlotConfig op = new DeleteUserSlotConfig(this,
                    namespace_,
                    userId
                );

                op.SetBaseFields<DeleteUserSlotConfigBuilder>(this);
                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public DeleteUserSlotConfig.Response Execute(
                string namespace_,
                string userId
            )
            {
                DeleteUserSlotConfig op = Build(
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
            public async Task<DeleteUserSlotConfig.Response> ExecuteAsync(
                string namespace_,
                string userId
            )
            {
                DeleteUserSlotConfig op = Build(
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

        private DeleteUserSlotConfig(DeleteUserSlotConfigBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {


            protected override string GetFullOperationId() => "Social::SlotConfig::DeleteUserSlotConfig";
        }

        #endregion

        public DeleteUserSlotConfig(
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/admin/namespaces/{namespace}/users/{userId}/config";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { };

        public DeleteUserSlotConfig.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new DeleteUserSlotConfig.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };


            return response;
        }
    }

}