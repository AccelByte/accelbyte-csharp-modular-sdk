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
    /// createNewGroupPublicV1
    ///
    /// Required valid user authentication
    /// 
    /// This endpoint is used to create new group
    /// 
    /// There are some fields that needs to be fulfilled
    /// 
    /// * **groupDescription**: the description of the group (optional)
    /// * **groupIcon**: group icon URL link (optional)
    /// * **groupName**: name of the group
    /// * **groupRegion**: region of the group
    /// * **groupRules**: rules for specific group. It consists of groupCustomRule that can be used to save custom rule, and groupPredefinedRules that has similar usage with configuration, but this rule only works in specific group
    /// * **allowedAction**: available action in group service. It consist of joinGroup and inviteGroup
    /// * **ruleAttribute**: attribute of the player that needs to be checked
    /// * **ruleCriteria**: criteria of the value. The value will be in enum of EQUAL, MINIMUM, MAXIMUM
    /// * **ruleValue**: value that needs to be checked
    /// * **customAttributes**: additional custom group attributes (optional)
    /// 
    /// Action Code: 73304
    /// </summary>
    public class CreateNewGroupPublicV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateNewGroupPublicV1Builder Builder { get => new CreateNewGroupPublicV1Builder(); }

        public class CreateNewGroupPublicV1Builder
            : OperationBuilder<CreateNewGroupPublicV1Builder>
        {





            internal CreateNewGroupPublicV1Builder() { }

            internal CreateNewGroupPublicV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public CreateNewGroupPublicV1 Build(
                ModelsPublicCreateNewGroupRequestV1 body,
                string namespace_
            )
            {
                CreateNewGroupPublicV1 op = new CreateNewGroupPublicV1(this,
                    body,
                    namespace_
                );

                op.SetBaseFields<CreateNewGroupPublicV1Builder>(this);
                return op;
            }

            public Model.ModelsGroupResponseV1? Execute(
                ModelsPublicCreateNewGroupRequestV1 body,
                string namespace_
            )
            {
                CreateNewGroupPublicV1 op = Build(
                    body,
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
            public async Task<Model.ModelsGroupResponseV1?> ExecuteAsync(
                ModelsPublicCreateNewGroupRequestV1 body,
                string namespace_
            )
            {
                CreateNewGroupPublicV1 op = Build(
                    body,
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

            public Model.ModelsGroupResponseV1<T1>? Execute<T1>(
                ModelsPublicCreateNewGroupRequestV1 body,
                string namespace_
            )
            {
                CreateNewGroupPublicV1 op = Build(
                    body,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.ModelsGroupResponseV1<T1>?> ExecuteAsync<T1>(
                ModelsPublicCreateNewGroupRequestV1 body,
                string namespace_
            )
            {
                CreateNewGroupPublicV1 op = Build(
                    body,
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                return op.ParseResponse<T1>(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private CreateNewGroupPublicV1(CreateNewGroupPublicV1Builder builder,
            ModelsPublicCreateNewGroupRequestV1 body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreateNewGroupPublicV1(
            string namespace_,
            Model.ModelsPublicCreateNewGroupRequestV1 body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/group/v1/public/namespaces/{namespace}/groups";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsGroupResponseV1? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsGroupResponseV1>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGroupResponseV1>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }

        public Model.ModelsGroupResponseV1<T1>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsGroupResponseV1<T1>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGroupResponseV1<T1>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();
            throw new HttpResponseException(code, payloadString);
        }
    }

}