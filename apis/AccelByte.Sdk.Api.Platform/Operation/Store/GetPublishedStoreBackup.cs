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
    /// getPublishedStoreBackup
    ///
    /// This API is used to get a store's backup.
    /// 
    /// Other detail info:
    /// 
    ///   * Returns : store backup info
    /// </summary>
    public class GetPublishedStoreBackup : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetPublishedStoreBackupBuilder Builder { get => new GetPublishedStoreBackupBuilder(); }

        public class GetPublishedStoreBackupBuilder
            : OperationBuilder<GetPublishedStoreBackupBuilder>
        {





            internal GetPublishedStoreBackupBuilder() { }

            internal GetPublishedStoreBackupBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetPublishedStoreBackup Build(
                string namespace_
            )
            {
                GetPublishedStoreBackup op = new GetPublishedStoreBackup(this,
                    namespace_
                );

                op.SetBaseFields<GetPublishedStoreBackupBuilder>(this);
                return op;
            }

            public GetPublishedStoreBackup.Response Execute(
                string namespace_
            )
            {
                GetPublishedStoreBackup op = Build(
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
            public async Task<GetPublishedStoreBackup.Response> ExecuteAsync(
                string namespace_
            )
            {
                GetPublishedStoreBackup op = Build(
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

        private GetPublishedStoreBackup(GetPublishedStoreBackupBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.StoreBackupInfo>
        {

            public ErrorEntity? Error404 { get; set; } = null;


            protected override string GetFullOperationId() => "Platform::Store::GetPublishedStoreBackup";
        }

        #endregion

        public GetPublishedStoreBackup(
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/stores/published/backup";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public GetPublishedStoreBackup.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new GetPublishedStoreBackup.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.StoreBackupInfo>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)404)
            {
                response.Error404 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error404!.TranslateToApiError();
            }

            return response;
        }
    }

}