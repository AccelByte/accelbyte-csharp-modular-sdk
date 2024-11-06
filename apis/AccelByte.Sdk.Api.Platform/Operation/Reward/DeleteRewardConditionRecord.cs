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
    ///   * Returns : 204 No Content
    /// </summary>
    public class DeleteRewardConditionRecord : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteRewardConditionRecordBuilder Builder { get => new DeleteRewardConditionRecordBuilder(); }

        public class DeleteRewardConditionRecordBuilder
            : OperationBuilder<DeleteRewardConditionRecordBuilder>
        {





            internal DeleteRewardConditionRecordBuilder() { }

            internal DeleteRewardConditionRecordBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteRewardConditionRecord Build(
                DeleteRewardConditionRequest body,
                string namespace_,
                string rewardId
            )
            {
                DeleteRewardConditionRecord op = new DeleteRewardConditionRecord(this,
                    body,                    
                    namespace_,                    
                    rewardId                    
                );

                op.SetBaseFields<DeleteRewardConditionRecordBuilder>(this);
                return op;
            }

            public DeleteRewardConditionRecord.Response Execute(
                DeleteRewardConditionRequest body,
                string namespace_,
                string rewardId
            )
            {
                DeleteRewardConditionRecord op = Build(
                    body,
                    namespace_,
                    rewardId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<DeleteRewardConditionRecord.Response> ExecuteAsync(
                DeleteRewardConditionRequest body,
                string namespace_,
                string rewardId
            )
            {
                DeleteRewardConditionRecord op = Build(
                    body,
                    namespace_,
                    rewardId
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

        private DeleteRewardConditionRecord(DeleteRewardConditionRecordBuilder builder,
            DeleteRewardConditionRequest body,
            string namespace_,
            string rewardId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["rewardId"] = rewardId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse
        {


            protected override string GetFullOperationId() => "Platform::Reward::DeleteRewardConditionRecord";
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
        
        public DeleteRewardConditionRecord.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new DeleteRewardConditionRecord.Response()
            {
                StatusCode = code,
                ContentType = contentType,
                IsSuccess = true
            };


            return response;
        }
    }

}