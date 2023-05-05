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
    /// deleteDLCItemConfig
    ///
    /// delete a DLC item config.
    /// Other detail info:
    /// 
    ///   * Required permission : resource= "ADMIN:NAMESPACE:{namespace}:DLC:CONFIG" , action=8 (DELETE)
    /// </summary>
    public class DeleteDLCItemConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteDLCItemConfigBuilder Builder { get => new DeleteDLCItemConfigBuilder(); }

        public class DeleteDLCItemConfigBuilder
            : OperationBuilder<DeleteDLCItemConfigBuilder>
        {





            internal DeleteDLCItemConfigBuilder() { }

            internal DeleteDLCItemConfigBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteDLCItemConfig Build(
                string namespace_
            )
            {
                DeleteDLCItemConfig op = new DeleteDLCItemConfig(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public void Execute(
                string namespace_
            )
            {
                DeleteDLCItemConfig op = Build(
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

        private DeleteDLCItemConfig(DeleteDLCItemConfigBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteDLCItemConfig(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/dlc/config/item";

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