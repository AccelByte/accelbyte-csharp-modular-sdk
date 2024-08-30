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
    /// processUserOrderNotification
    ///
    ///  [SERVICE COMMUNICATION ONLY] This API is used as a web hook for payment notification from justice payment service.
    /// Other detail info:
    /// 
    ///   * Returns : Process result
    /// </summary>
    public class ProcessUserOrderNotification : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ProcessUserOrderNotificationBuilder Builder { get => new ProcessUserOrderNotificationBuilder(); }

        public class ProcessUserOrderNotificationBuilder
            : OperationBuilder<ProcessUserOrderNotificationBuilder>
        {





            internal ProcessUserOrderNotificationBuilder() { }

            internal ProcessUserOrderNotificationBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public ProcessUserOrderNotification Build(
                TradeNotification body,
                string namespace_,
                string orderNo,
                string userId
            )
            {
                ProcessUserOrderNotification op = new ProcessUserOrderNotification(this,
                    body,                    
                    namespace_,                    
                    orderNo,                    
                    userId                    
                );

                op.SetBaseFields<ProcessUserOrderNotificationBuilder>(this);
                return op;
            }

            public void Execute(
                TradeNotification body,
                string namespace_,
                string orderNo,
                string userId
            )
            {
                ProcessUserOrderNotification op = Build(
                    body,
                    namespace_,
                    orderNo,
                    userId
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
                TradeNotification body,
                string namespace_,
                string orderNo,
                string userId
            )
            {
                ProcessUserOrderNotification op = Build(
                    body,
                    namespace_,
                    orderNo,
                    userId
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

        private ProcessUserOrderNotification(ProcessUserOrderNotificationBuilder builder,
            TradeNotification body,
            string namespace_,
            string orderNo,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["orderNo"] = orderNo;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ProcessUserOrderNotification(
            string namespace_,            
            string orderNo,            
            string userId,            
            Model.TradeNotification body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["orderNo"] = orderNo;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/orders/{orderNo}/notifications";

        public override HttpMethod Method => HttpMethod.Post;

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