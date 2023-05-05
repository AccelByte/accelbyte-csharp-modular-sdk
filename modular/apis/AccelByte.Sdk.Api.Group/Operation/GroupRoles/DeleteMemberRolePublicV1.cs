// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
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

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Net.Http;

using AccelByte.Sdk.Api.Group.Model;

namespace AccelByte.Sdk.Api.Group.Operation
{
    /// <summary>
    /// deleteMemberRolePublicV1
    ///
    /// Required Member Role Permission: "GROUP:ROLE [UPDATE]"
    /// 
    /// 
    /// 
    /// 
    /// This endpoint is used to remove role from group member
    /// 
    /// 
    /// 
    /// 
    /// Action Code: 73204
    /// </summary>
    public class DeleteMemberRolePublicV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteMemberRolePublicV1Builder Builder { get => new DeleteMemberRolePublicV1Builder(); }

        public class DeleteMemberRolePublicV1Builder
            : OperationBuilder<DeleteMemberRolePublicV1Builder>
        {





            internal DeleteMemberRolePublicV1Builder() { }

            internal DeleteMemberRolePublicV1Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteMemberRolePublicV1 Build(
                ModelsRemoveRoleFromMemberRequestV1 body,
                string memberRoleId,
                string namespace_
            )
            {
                DeleteMemberRolePublicV1 op = new DeleteMemberRolePublicV1(this,
                    body,                    
                    memberRoleId,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public void Execute(
                ModelsRemoveRoleFromMemberRequestV1 body,
                string memberRoleId,
                string namespace_
            )
            {
                DeleteMemberRolePublicV1 op = Build(
                    body,
                    memberRoleId,
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
        }

        private DeleteMemberRolePublicV1(DeleteMemberRolePublicV1Builder builder,
            ModelsRemoveRoleFromMemberRequestV1 body,
            string memberRoleId,
            string namespace_
        )
        {
            PathParams["memberRoleId"] = memberRoleId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteMemberRolePublicV1(
            string memberRoleId,            
            string namespace_,            
            Model.ModelsRemoveRoleFromMemberRequestV1 body            
        )
        {
            PathParams["memberRoleId"] = memberRoleId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/group/v1/public/namespaces/{namespace}/roles/{memberRoleId}/members";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json" };

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