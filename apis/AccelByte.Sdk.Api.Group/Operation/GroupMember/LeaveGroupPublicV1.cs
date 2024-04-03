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

using AccelByte.Sdk.Api.Group.Model;

namespace AccelByte.Sdk.Api.Group.Operation
{
    /// <summary>
    /// leaveGroupPublicV1
    ///
    /// 
    /// 
    /// Required valid user authentication
    /// 
    /// 
    /// 
    /// 
    /// This endpoint is used to leave from group.
    /// 
    /// 
    /// 
    /// 
    /// leave from group. Admin is not allowed to leave the group. This endpoint will also give response if the user does not belong to any group.
    /// 
    /// 
    /// 
    /// 
    /// Action Code: 73404
    /// </summary>
    public class LeaveGroupPublicV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static LeaveGroupPublicV1Builder Builder { get => new LeaveGroupPublicV1Builder(); }

        public class LeaveGroupPublicV1Builder
            : OperationBuilder<LeaveGroupPublicV1Builder>
        {





            internal LeaveGroupPublicV1Builder() { }

            internal LeaveGroupPublicV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public LeaveGroupPublicV1 Build(
                string namespace_
            )
            {
                LeaveGroupPublicV1 op = new LeaveGroupPublicV1(this,
                    namespace_
                );

                op.SetBaseFields<LeaveGroupPublicV1Builder>(this);
                return op;
            }

            public Model.ModelsLeaveGroupResponseV1? Execute(
                string namespace_
            )
            {
                LeaveGroupPublicV1 op = Build(
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
            public async Task<Model.ModelsLeaveGroupResponseV1?> ExecuteAsync(
                string namespace_
            )
            {
                LeaveGroupPublicV1 op = Build(
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

        private LeaveGroupPublicV1(LeaveGroupPublicV1Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public LeaveGroupPublicV1(
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/group/v1/public/namespaces/{namespace}/leave";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsLeaveGroupResponseV1? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsLeaveGroupResponseV1>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsLeaveGroupResponseV1>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}