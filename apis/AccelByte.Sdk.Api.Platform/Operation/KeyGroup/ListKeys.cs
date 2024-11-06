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
    /// listKeys
    ///
    /// This API is used to list keys of a key group.
    /// Other detail info:
    /// 
    ///   * Returns : keys
    /// </summary>
    public class ListKeys : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ListKeysBuilder Builder { get => new ListKeysBuilder(); }

        public class ListKeysBuilder
            : OperationBuilder<ListKeysBuilder>
        {

            public int? Limit { get; set; }

            public int? Offset { get; set; }

            public ListKeysStatus? Status { get; set; }





            internal ListKeysBuilder() { }

            internal ListKeysBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public ListKeysBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public ListKeysBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public ListKeysBuilder SetStatus(ListKeysStatus _status)
            {
                Status = _status;
                return this;
            }





            public ListKeys Build(
                string keyGroupId,
                string namespace_
            )
            {
                ListKeys op = new ListKeys(this,
                    keyGroupId,                    
                    namespace_                    
                );

                op.SetBaseFields<ListKeysBuilder>(this);
                return op;
            }

            public ListKeys.Response Execute(
                string keyGroupId,
                string namespace_
            )
            {
                ListKeys op = Build(
                    keyGroupId,
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
            public async Task<ListKeys.Response> ExecuteAsync(
                string keyGroupId,
                string namespace_
            )
            {
                ListKeys op = Build(
                    keyGroupId,
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

        private ListKeys(ListKeysBuilder builder,
            string keyGroupId,
            string namespace_
        )
        {
            PathParams["keyGroupId"] = keyGroupId;
            PathParams["namespace"] = namespace_;
            
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Status is not null) QueryParams["status"] = builder.Status.Value;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        #region Response Part        
        public class Response : ApiResponse<Model.KeyPagingSliceResult>
        {


            protected override string GetFullOperationId() => "Platform::KeyGroup::ListKeys";
        }

        #endregion

        public ListKeys(
            string keyGroupId,            
            string namespace_,            
            int? limit,            
            int? offset,            
            ListKeysStatus? status            
        )
        {
            PathParams["keyGroupId"] = keyGroupId;
            PathParams["namespace"] = namespace_;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (status is not null) QueryParams["status"] = status.Value;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/keygroups/{keyGroupId}/keys";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() {  };

        public override List<string> Produces => new() { "application/json" };
        
        public ListKeys.Response ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var response = new ListKeys.Response()
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
                response.Data = JsonSerializer.Deserialize<Model.KeyPagingSliceResult>(payload, ResponseJsonOptions);
                response.IsSuccess = true;
            }

            return response;
        }
    }

    public class ListKeysStatus : StringEnum<ListKeysStatus>
    {
        public static readonly ListKeysStatus ACQUIRED
            = new ListKeysStatus("ACQUIRED");

        public static readonly ListKeysStatus ACTIVE
            = new ListKeysStatus("ACTIVE");


        public static implicit operator ListKeysStatus(string value)
        {
            return NewValue(value);
        }

        public ListKeysStatus(string enumValue)
            : base(enumValue)
        {

        }
    }

}