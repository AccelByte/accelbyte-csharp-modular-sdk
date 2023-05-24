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
    /// deleteCountryGroup
    ///
    /// Delete a country groups by its country group code. This endpoint usually used for testing purpose to cleanup test data.
    /// Other detail info:
    /// 
    ///   * Required permission : resource = "ADMIN:NAMESPACE:{namespace}:MISC" , action=8 (DELETE)
    /// </summary>
    public class DeleteCountryGroup : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteCountryGroupBuilder Builder { get => new DeleteCountryGroupBuilder(); }

        public class DeleteCountryGroupBuilder
            : OperationBuilder<DeleteCountryGroupBuilder>
        {





            internal DeleteCountryGroupBuilder() { }

            internal DeleteCountryGroupBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public DeleteCountryGroup Build(
                string countryGroupCode,
                string namespace_
            )
            {
                DeleteCountryGroup op = new DeleteCountryGroup(this,
                    countryGroupCode,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }

            public void Execute(
                string countryGroupCode,
                string namespace_
            )
            {
                DeleteCountryGroup op = Build(
                    countryGroupCode,
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

        private DeleteCountryGroup(DeleteCountryGroupBuilder builder,
            string countryGroupCode,
            string namespace_
        )
        {
            PathParams["countryGroupCode"] = countryGroupCode;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteCountryGroup(
            string countryGroupCode,
            string namespace_
        )
        {
            PathParams["countryGroupCode"] = countryGroupCode;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/basic/v1/admin/namespaces/{namespace}/misc/countrygroups/{countryGroupCode}";

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