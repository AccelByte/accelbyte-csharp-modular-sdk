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
    /// adminDeleteAssignmentPlugin
    ///
    /// 
    ///     * Required permission: ADMIN:NAMESPACE:{namespace}:CHALLENGE:PLUGIN [DELETE]
    /// </summary>
    public class AdminDeleteAssignmentPlugin : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeleteAssignmentPluginBuilder Builder { get => new AdminDeleteAssignmentPluginBuilder(); }

        public class AdminDeleteAssignmentPluginBuilder
            : OperationBuilder<AdminDeleteAssignmentPluginBuilder>
        {





            internal AdminDeleteAssignmentPluginBuilder() { }

            internal AdminDeleteAssignmentPluginBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AdminDeleteAssignmentPlugin Build(
                string namespace_
            )
            {
                AdminDeleteAssignmentPlugin op = new AdminDeleteAssignmentPlugin(this,
                    namespace_
                );

                op.SetBaseFields<AdminDeleteAssignmentPluginBuilder>(this);
                return op;
            }

            public void Execute(
                string namespace_
            )
            {
                AdminDeleteAssignmentPlugin op = Build(
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task ExecuteAsync(
                string namespace_
            )
            {
                AdminDeleteAssignmentPlugin op = Build(
                    namespace_
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = await _Sdk.RunRequestAsync(op);
                op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
        }

        private AdminDeleteAssignmentPlugin(AdminDeleteAssignmentPluginBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminDeleteAssignmentPlugin(
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/challenge/v1/admin/namespaces/{namespace}/plugins/assignment";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { };

        public override List<string> Produces => new() { "application/json" };

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return;
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}