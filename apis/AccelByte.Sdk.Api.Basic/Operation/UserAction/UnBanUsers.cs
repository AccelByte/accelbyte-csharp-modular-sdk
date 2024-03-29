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

using AccelByte.Sdk.Api.Basic.Model;

namespace AccelByte.Sdk.Api.Basic.Operation
{
    /// <summary>
    /// unBanUsers
    ///
    /// Unban user.
    /// Other detail info:
    /// 
    ///   * Required permission : resource= "ADMIN:NAMESPACE:{namespace}:ACTION" , action=4 (UPDATE)
    /// </summary>
    public class UnBanUsers : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UnBanUsersBuilder Builder { get => new UnBanUsersBuilder(); }

        public class UnBanUsersBuilder
            : OperationBuilder<UnBanUsersBuilder>
        {


            public Model.ADTOForUnbanUserAPICall? Body { get; set; }




            internal UnBanUsersBuilder() { }

            internal UnBanUsersBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public UnBanUsersBuilder SetBody(Model.ADTOForUnbanUserAPICall _body)
            {
                Body = _body;
                return this;
            }




            public UnBanUsers Build(
                string namespace_
            )
            {
                UnBanUsers op = new UnBanUsers(this,
                    namespace_
                );

                op.SetBaseFields<UnBanUsersBuilder>(this);
                return op;
            }

            public void Execute(
                string namespace_
            )
            {
                UnBanUsers op = Build(
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
        }

        private UnBanUsers(UnBanUsersBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UnBanUsers(
            string namespace_,
            Model.ADTOForUnbanUserAPICall body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/basic/v1/admin/namespaces/{namespace}/actions/unban";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

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