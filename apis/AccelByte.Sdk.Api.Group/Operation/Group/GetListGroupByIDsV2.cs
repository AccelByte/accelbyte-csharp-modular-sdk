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

using AccelByte.Sdk.Api.Group.Model;

namespace AccelByte.Sdk.Api.Group.Operation
{
    /// <summary>
    /// getListGroupByIDsV2
    ///
    /// 
    /// 
    /// Required valid user authentication
    /// 
    /// 
    /// 
    /// 
    /// Get list of groups by group Ids.
    /// 
    /// 
    /// 
    /// 
    /// Action Code: 73303
    /// </summary>
    public class GetListGroupByIDsV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetListGroupByIDsV2Builder Builder { get => new GetListGroupByIDsV2Builder(); }

        public class GetListGroupByIDsV2Builder
            : OperationBuilder<GetListGroupByIDsV2Builder>
        {





            internal GetListGroupByIDsV2Builder() { }

            internal GetListGroupByIDsV2Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public GetListGroupByIDsV2 Build(
                ModelsGetGroupListRequestV2 body,
                string namespace_
            )
            {
                GetListGroupByIDsV2 op = new GetListGroupByIDsV2(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelsGetGroupsResponseV1? Execute(
                ModelsGetGroupListRequestV2 body,
                string namespace_
            )
            {
                GetListGroupByIDsV2 op = Build(
                    body,
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
        }

        private GetListGroupByIDsV2(GetListGroupByIDsV2Builder builder,
            ModelsGetGroupListRequestV2 body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetListGroupByIDsV2(
            string namespace_,
            Model.ModelsGetGroupListRequestV2 body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/group/v2/public/namespaces/{namespace}/groups/bulk";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelsGetGroupsResponseV1? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetGroupsResponseV1>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetGroupsResponseV1>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}