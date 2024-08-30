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
    /// deleteIAPItemConfig
    ///
    /// delete a iap item config.
    /// </summary>
    public class DeleteIAPItemConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteIAPItemConfigBuilder Builder { get => new DeleteIAPItemConfigBuilder(); }

        public class DeleteIAPItemConfigBuilder
            : OperationBuilder<DeleteIAPItemConfigBuilder>
        {





            internal DeleteIAPItemConfigBuilder() { }

            internal DeleteIAPItemConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteIAPItemConfig Build(
                string namespace_
            )
            {
                DeleteIAPItemConfig op = new DeleteIAPItemConfig(this,
                    namespace_                    
                );

                op.SetBaseFields<DeleteIAPItemConfigBuilder>(this);
                return op;
            }

            public void Execute(
                string namespace_
            )
            {
                DeleteIAPItemConfig op = Build(
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
                string namespace_
            )
            {
                DeleteIAPItemConfig op = Build(
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

        private DeleteIAPItemConfig(DeleteIAPItemConfigBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteIAPItemConfig(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/iap/config/item";

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