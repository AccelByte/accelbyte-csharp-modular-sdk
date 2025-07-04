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

using AccelByte.Sdk.Api.Seasonpass.Model;

namespace AccelByte.Sdk.Api.Seasonpass.Operation
{
    /// <summary>
    /// exportSeason
    ///
    /// This API is used to export all of season service data files with csv format.
    /// </summary>
    public class ExportSeason : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ExportSeasonBuilder Builder { get => new ExportSeasonBuilder(); }

        public class ExportSeasonBuilder
            : OperationBuilder<ExportSeasonBuilder>
        {





            internal ExportSeasonBuilder() { }

            internal ExportSeasonBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public ExportSeason Build(
                string namespace_
            )
            {
                ExportSeason op = new ExportSeason(this,
                    namespace_                    
                );

                op.SetBaseFields<ExportSeasonBuilder>(this);
                return op;
            }

            public ExportSeason.Response Execute(
                string namespace_
            )
            {
                ExportSeason op = Build(
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
            public async Task<ExportSeason.Response> ExecuteAsync(
                string namespace_
            )
            {
                ExportSeason op = Build(
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

        private ExportSeason(ExportSeasonBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Stream>
        {

            public ErrorEntity? Error400 { get; set; } = null;


            protected override string GetFullOperationId() => "Seasonpass::Export::ExportSeason";
        }

        #endregion

        public ExportSeason(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/seasonpass/admin/namespace/{namespace}/export";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/octet-stream" };
        
        public ExportSeason.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new ExportSeason.Response()
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
                response.Data = payload;
                response.IsSuccess = true;
            }
            else if (code == (HttpStatusCode)400)
            {
                response.Error400 = JsonSerializer.Deserialize<ErrorEntity>(payload, ResponseJsonOptions);
                response.Error = response.Error400!.TranslateToApiError();
            }

            return response;
        }
    }

}