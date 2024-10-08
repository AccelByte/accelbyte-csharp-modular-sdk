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

using AccelByte.Sdk.Api.Challenge.Model;

namespace AccelByte.Sdk.Api.Challenge.Operation
{
    /// <summary>
    /// adminGetAssignmentPlugin
    ///
    /// 
    ///     * Required permission: ADMIN:NAMESPACE:{namespace}:CHALLENGE:PLUGIN [READ]
    /// </summary>
    public class AdminGetAssignmentPlugin : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetAssignmentPluginBuilder Builder { get => new AdminGetAssignmentPluginBuilder(); }

        public class AdminGetAssignmentPluginBuilder
            : OperationBuilder<AdminGetAssignmentPluginBuilder>
        {





            internal AdminGetAssignmentPluginBuilder() { }

            internal AdminGetAssignmentPluginBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminGetAssignmentPlugin Build(
                string namespace_
            )
            {
                AdminGetAssignmentPlugin op = new AdminGetAssignmentPlugin(this,
                    namespace_
                );

                op.SetBaseFields<AdminGetAssignmentPluginBuilder>(this);
                return op;
            }

            public Model.ModelPluginAssignmentResponse? Execute(
                string namespace_
            )
            {
                AdminGetAssignmentPlugin op = Build(
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
            public async Task<Model.ModelPluginAssignmentResponse?> ExecuteAsync(
                string namespace_
            )
            {
                AdminGetAssignmentPlugin op = Build(
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

        private AdminGetAssignmentPlugin(AdminGetAssignmentPluginBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetAssignmentPlugin(
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/challenge/v1/admin/namespaces/{namespace}/plugins/assignment";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public Model.ModelPluginAssignmentResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelPluginAssignmentResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelPluginAssignmentResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}