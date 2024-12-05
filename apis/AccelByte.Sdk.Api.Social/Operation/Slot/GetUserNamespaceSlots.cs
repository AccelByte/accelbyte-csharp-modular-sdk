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
    /// getUserNamespaceSlots
    ///
    /// 
    /// 
    /// ## The endpoint is going to be deprecated
    /// 
    /// 
    /// Get slots for a given user.
    /// Other detail info:
    ///         *  Returns : list of slots
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class GetUserNamespaceSlots : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserNamespaceSlotsBuilder Builder { get => new GetUserNamespaceSlotsBuilder(); }

        public class GetUserNamespaceSlotsBuilder
            : OperationBuilder<GetUserNamespaceSlotsBuilder>
        {





            internal GetUserNamespaceSlotsBuilder() { }

            internal GetUserNamespaceSlotsBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetUserNamespaceSlots Build(
                string namespace_,
                string userId
            )
            {
                GetUserNamespaceSlots op = new GetUserNamespaceSlots(this,
                    namespace_,
                    userId
                );

                op.SetBaseFields<GetUserNamespaceSlotsBuilder>(this);
                return op;
            }

            [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
            public GetUserNamespaceSlots.Response Execute(
                string namespace_,
                string userId
            )
            {
                GetUserNamespaceSlots op = Build(
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
            public async Task<GetUserNamespaceSlots.Response> ExecuteAsync(
                string namespace_,
                string userId
            )
            {
                GetUserNamespaceSlots op = Build(
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

        private GetUserNamespaceSlots(GetUserNamespaceSlotsBuilder builder,
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
        public class Response : ApiResponse<List<Model.SlotInfo>>
        {


            protected override string GetFullOperationId() => "Social::Slot::GetUserNamespaceSlots";
        }

        #endregion

        public GetUserNamespaceSlots(
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/admin/namespaces/{namespace}/users/{userId}/slots";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public GetUserNamespaceSlots.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetUserNamespaceSlots.Response()
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
                response.Data = JsonSerializer.Deserialize<List<Model.SlotInfo>>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }

            return response;
        }
    }

}