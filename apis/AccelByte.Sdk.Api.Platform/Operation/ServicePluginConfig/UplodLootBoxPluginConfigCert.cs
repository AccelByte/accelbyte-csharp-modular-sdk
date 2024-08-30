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
    /// uplodLootBoxPluginConfigCert
    ///
    /// Upload lootbox plugin custom config tls cert.Other detail info:
    ///   * Returns : updated service plugin config
    /// </summary>
    public class UplodLootBoxPluginConfigCert : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UplodLootBoxPluginConfigCertBuilder Builder { get => new UplodLootBoxPluginConfigCertBuilder(); }

        public class UplodLootBoxPluginConfigCertBuilder
            : OperationBuilder<UplodLootBoxPluginConfigCertBuilder>
        {



            public Stream? File { get; set; }



            internal UplodLootBoxPluginConfigCertBuilder() { }

            internal UplodLootBoxPluginConfigCertBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }




            public UplodLootBoxPluginConfigCertBuilder SetFile(Stream _file)
            {
                File = _file;
                return this;
            }



            public UplodLootBoxPluginConfigCert Build(
                string namespace_
            )
            {
                UplodLootBoxPluginConfigCert op = new UplodLootBoxPluginConfigCert(this,
                    namespace_                    
                );

                op.SetBaseFields<UplodLootBoxPluginConfigCertBuilder>(this);
                return op;
            }

            public Model.LootBoxPluginConfigInfo? Execute(
                string namespace_
            )
            {
                UplodLootBoxPluginConfigCert op = Build(
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
            public async Task<Model.LootBoxPluginConfigInfo?> ExecuteAsync(
                string namespace_
            )
            {
                UplodLootBoxPluginConfigCert op = Build(
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
        }

        private UplodLootBoxPluginConfigCert(UplodLootBoxPluginConfigCertBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            if (builder.File is not null) FormParams["file"] = builder.File;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UplodLootBoxPluginConfigCert(
            string namespace_,            
            Stream? file            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            if (file is not null) FormParams["file"] = file;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/catalog/plugins/lootbox/customConfig/cert";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "multipart/form-data" };

        public override List<string> Produces => new() { "application/json" };        
        
        public Model.LootBoxPluginConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.LootBoxPluginConfigInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.LootBoxPluginConfigInfo>(payload, ResponseJsonOptions);
            }
            
            var payloadString = payload.ReadToString();
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}