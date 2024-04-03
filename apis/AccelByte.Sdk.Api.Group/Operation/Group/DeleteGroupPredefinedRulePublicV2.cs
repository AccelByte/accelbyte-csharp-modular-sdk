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
    /// deleteGroupPredefinedRulePublicV2
    ///
    /// 
    /// 
    /// Required valid user authentication
    /// 
    /// 
    /// 
    /// 
    /// Required Member Role Permission: "GROUP [UPDATE]"
    /// 
    /// 
    /// 
    /// 
    /// Delete group predefined rule based on the allowed action. This endpoint will check the group ID of the user based on the access token
    /// and compare it with the group ID in path parameter. It will also check the member role of the user based on
    /// the access token
    /// 
    /// 
    /// 
    /// 
    /// Action Code: 73309
    /// </summary>
    public class DeleteGroupPredefinedRulePublicV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteGroupPredefinedRulePublicV2Builder Builder { get => new DeleteGroupPredefinedRulePublicV2Builder(); }

        public class DeleteGroupPredefinedRulePublicV2Builder
            : OperationBuilder<DeleteGroupPredefinedRulePublicV2Builder>
        {





            internal DeleteGroupPredefinedRulePublicV2Builder() { }

            internal DeleteGroupPredefinedRulePublicV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteGroupPredefinedRulePublicV2 Build(
                string allowedAction,
                string groupId,
                string namespace_
            )
            {
                DeleteGroupPredefinedRulePublicV2 op = new DeleteGroupPredefinedRulePublicV2(this,
                    allowedAction,
                    groupId,
                    namespace_
                );

                op.SetBaseFields<DeleteGroupPredefinedRulePublicV2Builder>(this);
                return op;
            }

            public void Execute(
                string allowedAction,
                string groupId,
                string namespace_
            )
            {
                DeleteGroupPredefinedRulePublicV2 op = Build(
                    allowedAction,
                    groupId,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task ExecuteAsync(
                string allowedAction,
                string groupId,
                string namespace_
            )
            {
                DeleteGroupPredefinedRulePublicV2 op = Build(
                    allowedAction,
                    groupId,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private DeleteGroupPredefinedRulePublicV2(DeleteGroupPredefinedRulePublicV2Builder builder,
            string allowedAction,
            string groupId,
            string namespace_
        )
        {
            PathParams["allowedAction"] = allowedAction;
            PathParams["groupId"] = groupId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteGroupPredefinedRulePublicV2(
            string allowedAction,
            string groupId,
            string namespace_
        )
        {
            PathParams["allowedAction"] = allowedAction;
            PathParams["groupId"] = groupId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/group/v2/public/namespaces/{namespace}/groups/{groupId}/rules/defined/{allowedAction}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}