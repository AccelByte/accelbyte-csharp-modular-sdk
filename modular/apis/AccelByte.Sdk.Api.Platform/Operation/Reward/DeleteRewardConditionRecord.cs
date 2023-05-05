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

using AccelByte.Sdk.Api.Platform.Model;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// deleteRewardConditionRecord
    ///
    ///  [TEST FACILITY ONLY] Forbidden in live environment. This API is used to delete a reward condition record by reward Id and condition Name (optional).
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:REWARD", action=8 (DELETE)
    ///   *  Returns : 204 No Content
    /// </summary>
    public class DeleteRewardConditionRecord : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteRewardConditionRecordBuilder Builder { get => new DeleteRewardConditionRecordBuilder(); }

        public class DeleteRewardConditionRecordBuilder
            : OperationBuilder<DeleteRewardConditionRecordBuilder>
        {


            public Model.DeleteRewardConditionRequest? Body { get; set; }




            internal DeleteRewardConditionRecordBuilder() { }

            internal DeleteRewardConditionRecordBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public DeleteRewardConditionRecordBuilder SetBody(Model.DeleteRewardConditionRequest _body)
            {
                Body = _body;
                return this;
            }




            public DeleteRewardConditionRecord Build(
                string namespace_,
                string rewardId
            )
            {
                DeleteRewardConditionRecord op = new DeleteRewardConditionRecord(this,
                    namespace_,                    
                    rewardId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public void Execute(
                string namespace_,
                string rewardId
            )
            {
                DeleteRewardConditionRecord op = Build(
                    namespace_,
                    rewardId
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

        private DeleteRewardConditionRecord(DeleteRewardConditionRecordBuilder builder,
            string namespace_,
            string rewardId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["rewardId"] = rewardId;
            
            

            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteRewardConditionRecord(
            string namespace_,            
            string rewardId,            
            Model.DeleteRewardConditionRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["rewardId"] = rewardId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/rewards/{rewardId}/record";

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