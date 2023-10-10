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

using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// AdminGetDeviceBansV4
    ///
    /// 
    /// 
    /// This is the endpoint for an admin to get device ban list.
    /// 
    /// 
    /// 
    /// Required permission
    /// 
    ///                                                                         'ADMIN:NAMESPACE:{namespace}:DEVICE [READ]'
    /// </summary>
    public class AdminGetDeviceBansV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetDeviceBansV4Builder Builder { get => new AdminGetDeviceBansV4Builder(); }

        public class AdminGetDeviceBansV4Builder
            : OperationBuilder<AdminGetDeviceBansV4Builder>
        {





            internal AdminGetDeviceBansV4Builder() { }

            internal AdminGetDeviceBansV4Builder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminGetDeviceBansV4 Build(
                string deviceId,
                string namespace_
            )
            {
                AdminGetDeviceBansV4 op = new AdminGetDeviceBansV4(this,
                    deviceId,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public Model.ModelDeviceBansResponseV4? Execute(
                string deviceId,
                string namespace_
            )
            {
                AdminGetDeviceBansV4 op = Build(
                    deviceId,
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

        private AdminGetDeviceBansV4(AdminGetDeviceBansV4Builder builder,
            string deviceId,
            string namespace_
        )
        {
            PathParams["deviceId"] = deviceId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetDeviceBansV4(
            string deviceId,
            string namespace_
        )
        {
            PathParams["deviceId"] = deviceId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/admin/namespaces/{namespace}/devices/{deviceId}/bans";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelDeviceBansResponseV4? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelDeviceBansResponseV4>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelDeviceBansResponseV4>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}