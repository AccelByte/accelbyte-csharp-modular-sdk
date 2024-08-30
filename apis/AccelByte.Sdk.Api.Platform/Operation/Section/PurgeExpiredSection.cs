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
    /// purgeExpiredSection
    ///
    /// This API is used to purge expired section.
    /// </summary>
    public class PurgeExpiredSection : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PurgeExpiredSectionBuilder Builder { get => new PurgeExpiredSectionBuilder(); }

        public class PurgeExpiredSectionBuilder
            : OperationBuilder<PurgeExpiredSectionBuilder>
        {





            internal PurgeExpiredSectionBuilder() { }

            internal PurgeExpiredSectionBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public PurgeExpiredSection Build(
                string namespace_,
                string storeId
            )
            {
                PurgeExpiredSection op = new PurgeExpiredSection(this,
                    namespace_,                    
                    storeId                    
                );

                op.SetBaseFields<PurgeExpiredSectionBuilder>(this);
                return op;
            }

            public void Execute(
                string namespace_,
                string storeId
            )
            {
                PurgeExpiredSection op = Build(
                    namespace_,
                    storeId
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
                string namespace_,
                string storeId
            )
            {
                PurgeExpiredSection op = Build(
                    namespace_,
                    storeId
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

        private PurgeExpiredSection(PurgeExpiredSectionBuilder builder,
            string namespace_,
            string storeId
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (storeId is not null) QueryParams["storeId"] = storeId;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PurgeExpiredSection(
            string namespace_,            
            string storeId            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (storeId is not null) QueryParams["storeId"] = storeId;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/sections/purge/expired";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() {  };

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