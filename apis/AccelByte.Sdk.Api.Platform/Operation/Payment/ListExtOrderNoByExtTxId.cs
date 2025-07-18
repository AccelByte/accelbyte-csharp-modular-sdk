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
    /// listExtOrderNoByExtTxId
    ///
    ///  [Not supported yet in AGS Shared Cloud] List external order No by external transaction id.
    /// Other detail info:
    /// 
    ///   * Returns : payment orders
    /// </summary>
    public class ListExtOrderNoByExtTxId : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ListExtOrderNoByExtTxIdBuilder Builder { get => new ListExtOrderNoByExtTxIdBuilder(); }

        public class ListExtOrderNoByExtTxIdBuilder
            : OperationBuilder<ListExtOrderNoByExtTxIdBuilder>
        {





            internal ListExtOrderNoByExtTxIdBuilder() { }

            internal ListExtOrderNoByExtTxIdBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public ListExtOrderNoByExtTxId Build(
                string namespace_,
                string extTxId
            )
            {
                ListExtOrderNoByExtTxId op = new ListExtOrderNoByExtTxId(this,
                    namespace_,                    
                    extTxId                    
                );

                op.SetBaseFields<ListExtOrderNoByExtTxIdBuilder>(this);
                return op;
            }

            public ListExtOrderNoByExtTxId.Response Execute(
                string namespace_,
                string extTxId
            )
            {
                ListExtOrderNoByExtTxId op = Build(
                    namespace_,
                    extTxId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
            }
            public async Task<ListExtOrderNoByExtTxId.Response> ExecuteAsync(
                string namespace_,
                string extTxId
            )
            {
                ListExtOrderNoByExtTxId op = Build(
                    namespace_,
                    extTxId
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

        private ListExtOrderNoByExtTxId(ListExtOrderNoByExtTxIdBuilder builder,
            string namespace_,
            string extTxId
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (extTxId is not null) QueryParams["extTxId"] = extTxId;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<List<string>>
        {


            protected override string GetFullOperationId() => "Platform::Payment::ListExtOrderNoByExtTxId";
        }

        #endregion

        public ListExtOrderNoByExtTxId(
            string namespace_,            
            string extTxId            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (extTxId is not null) QueryParams["extTxId"] = extTxId;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/payment/orders/byExtTxId";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public ListExtOrderNoByExtTxId.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new ListExtOrderNoByExtTxId.Response()
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
                response.Data = JsonSerializer.Deserialize<List<string>>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }

            return response;
        }
    }

}