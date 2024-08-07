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
    /// disableCode
    ///
    /// Disable code.
    /// 
    /// Disable an active code, the code can't be disabled if it has already been redeemed.
    /// Other detail info:
    /// 
    ///   * Returns : disabled code
    /// </summary>
    public class DisableCode : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DisableCodeBuilder Builder { get => new DisableCodeBuilder(); }

        public class DisableCodeBuilder
            : OperationBuilder<DisableCodeBuilder>
        {





            internal DisableCodeBuilder() { }

            internal DisableCodeBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DisableCode Build(
                string code,
                string namespace_
            )
            {
                DisableCode op = new DisableCode(this,
                    code,
                    namespace_
                );

                op.SetBaseFields<DisableCodeBuilder>(this);
                return op;
            }

            public Model.CodeInfo? Execute(
                string code,
                string namespace_
            )
            {
                DisableCode op = Build(
                    code,
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
            public async Task<Model.CodeInfo?> ExecuteAsync(
                string code,
                string namespace_
            )
            {
                DisableCode op = Build(
                    code,
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

        private DisableCode(DisableCodeBuilder builder,
            string code,
            string namespace_
        )
        {
            PathParams["code"] = code;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DisableCode(
            string code,
            string namespace_
        )
        {
            PathParams["code"] = code;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/codes/{code}/disable";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.CodeInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.CodeInfo>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.CodeInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}