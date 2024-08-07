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

using AccelByte.Sdk.Api.Group.Model;

namespace AccelByte.Sdk.Api.Group.Operation
{
    /// <summary>
    /// GetMyGroupJoinRequestV2
    ///
    /// Required valid user authentication
    /// 
    /// This endpoint is used to Get My Join Request To The Groups
    /// 
    /// Get My Join Request To The Groups for the user calling this endpoint. It will check any join request group for this user
    /// 
    /// Action Code: 73502
    /// </summary>
    public class GetMyGroupJoinRequestV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetMyGroupJoinRequestV2Builder Builder { get => new GetMyGroupJoinRequestV2Builder(); }

        public class GetMyGroupJoinRequestV2Builder
            : OperationBuilder<GetMyGroupJoinRequestV2Builder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }





            internal GetMyGroupJoinRequestV2Builder() { }

            internal GetMyGroupJoinRequestV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public GetMyGroupJoinRequestV2Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetMyGroupJoinRequestV2Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public GetMyGroupJoinRequestV2 Build(
                string namespace_
            )
            {
                GetMyGroupJoinRequestV2 op = new GetMyGroupJoinRequestV2(this,
                    namespace_
                );

                op.SetBaseFields<GetMyGroupJoinRequestV2Builder>(this);
                return op;
            }

            public Model.ModelsGetMemberRequestsListResponseV1? Execute(
                string namespace_
            )
            {
                GetMyGroupJoinRequestV2 op = Build(
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
            public async Task<Model.ModelsGetMemberRequestsListResponseV1?> ExecuteAsync(
                string namespace_
            )
            {
                GetMyGroupJoinRequestV2 op = Build(
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

        private GetMyGroupJoinRequestV2(GetMyGroupJoinRequestV2Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetMyGroupJoinRequestV2(
            string namespace_,
            long? limit,
            long? offset
        )
        {
            PathParams["namespace"] = namespace_;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/group/v2/public/namespaces/{namespace}/users/me/join/request";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsGetMemberRequestsListResponseV1? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetMemberRequestsListResponseV1>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetMemberRequestsListResponseV1>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}