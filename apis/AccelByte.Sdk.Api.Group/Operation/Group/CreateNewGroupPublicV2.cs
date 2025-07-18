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
    /// createNewGroupPublicV2
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
    public class CreateNewGroupPublicV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateNewGroupPublicV2Builder Builder { get => new CreateNewGroupPublicV2Builder(); }

        public class CreateNewGroupPublicV2Builder
            : OperationBuilder<CreateNewGroupPublicV2Builder>
        {





            internal CreateNewGroupPublicV2Builder() { }

            internal CreateNewGroupPublicV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public CreateNewGroupPublicV2 Build(
                ModelsPublicCreateNewGroupRequestV1 body,
                string namespace_
            )
            {
                CreateNewGroupPublicV2 op = new CreateNewGroupPublicV2(this,
                    body,                    
                    namespace_                    
                );

                op.SetBaseFields<CreateNewGroupPublicV2Builder>(this);
                return op;
            }

            public CreateNewGroupPublicV2.Response Execute(
                ModelsPublicCreateNewGroupRequestV1 body,
                string namespace_
            )
            {
                CreateNewGroupPublicV2 op = Build(
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
            public async Task<CreateNewGroupPublicV2.Response> ExecuteAsync(
                ModelsPublicCreateNewGroupRequestV1 body,
                string namespace_
            )
            {
                CreateNewGroupPublicV2 op = Build(
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

            public CreateNewGroupPublicV2.Response<T1> Execute<T1>(
                ModelsPublicCreateNewGroupRequestV1 body,
                string namespace_
            )
            {
                CreateNewGroupPublicV2 op = Build(
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
            public async Task<CreateNewGroupPublicV2.Response<T1>> ExecuteAsync<T1>(
                ModelsPublicCreateNewGroupRequestV1 body,
                string namespace_
            )
            {
                CreateNewGroupPublicV2 op = Build(
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

        private CreateNewGroupPublicV2(CreateNewGroupPublicV2Builder builder,
            ModelsPublicCreateNewGroupRequestV1 body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.ModelsGroupResponseV1>
        {

            public ResponseErrorResponse? Error400 { get; set; } = null;

            public ResponseErrorResponse? Error401 { get; set; } = null;

            public ResponseErrorResponse? Error403 { get; set; } = null;

            public ResponseErrorResponse? Error409 { get; set; } = null;

            public ResponseErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Group::Group::CreateNewGroupPublicV2";
        }

        public class Response<T1> : ApiResponse<Model.ModelsGroupResponseV1<T1>>
        {
            public ResponseErrorResponse? Error400 { get; set; } = null;

            public ResponseErrorResponse? Error401 { get; set; } = null;

            public ResponseErrorResponse? Error403 { get; set; } = null;

            public ResponseErrorResponse? Error409 { get; set; } = null;

            public ResponseErrorResponse? Error500 { get; set; } = null;


            protected override string GetFullOperationId() => "Group::Group::CreateNewGroupPublicV2";
        }
        #endregion

        public CreateNewGroupPublicV2(
            string namespace_,            
            Model.ModelsPublicCreateNewGroupRequestV1 body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/group/v2/public/namespaces/{namespace}/groups";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };
        
        public CreateNewGroupPublicV2.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new CreateNewGroupPublicV2.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsGroupResponseV1>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)409)
            {
                response.Error409 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error409!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }

            return response;
        }

        public CreateNewGroupPublicV2.Response<T1> ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new CreateNewGroupPublicV2.Response<T1>()
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
                response.Data = JsonSerializer.Deserialize<Model.ModelsGroupResponseV1<T1>>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)401)
            {
                response.Error401 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error401!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)403)
            {
                response.Error403 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error403!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)409)
            {
                response.Error409 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error409!.TranslateToApiError();
            }
            else if (code == (HttpStatusCode)500)
            {
                response.Error500 = JsonSerializer.Deserialize<ResponseErrorResponse>(payload, ResponseJsonOptions);
                response.Error = response.Error500!.TranslateToApiError();
            }
            
            return response;
        }
    }

}