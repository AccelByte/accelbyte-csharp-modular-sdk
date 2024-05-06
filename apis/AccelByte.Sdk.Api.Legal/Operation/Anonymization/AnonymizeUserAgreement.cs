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

using AccelByte.Sdk.Api.Legal.Model;

namespace AccelByte.Sdk.Api.Legal.Operation
{
    /// <summary>
    /// anonymizeUserAgreement
    ///
    /// This API will anonymize agreement record for specified user.
    /// </summary>
    public class AnonymizeUserAgreement : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AnonymizeUserAgreementBuilder Builder { get => new AnonymizeUserAgreementBuilder(); }

        public class AnonymizeUserAgreementBuilder
            : OperationBuilder<AnonymizeUserAgreementBuilder>
        {





            internal AnonymizeUserAgreementBuilder() { }

            internal AnonymizeUserAgreementBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public AnonymizeUserAgreement Build(
                string userId
            )
            {
                AnonymizeUserAgreement op = new AnonymizeUserAgreement(this,
                    userId
                );

                op.SetBaseFields<AnonymizeUserAgreementBuilder>(this);
                return op;
            }

            public void Execute(
                string userId
            )
            {
                AnonymizeUserAgreement op = Build(
                    userId
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
                string userId
            )
            {
                AnonymizeUserAgreement op = Build(
                    userId
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

        private AnonymizeUserAgreement(AnonymizeUserAgreementBuilder builder,
            string userId
        )
        {
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AnonymizeUserAgreement(
            string userId
        )
        {
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/users/{userId}/anonymization/agreements";

        public override HttpMethod Method => HttpMethod.Delete;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}