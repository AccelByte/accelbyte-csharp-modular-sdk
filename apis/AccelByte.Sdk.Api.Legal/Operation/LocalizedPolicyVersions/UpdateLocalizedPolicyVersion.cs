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
    /// updateLocalizedPolicyVersion
    ///
    /// Update a version of a particular country-specific policy.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:*:LEGAL", action=4 (UPDATE)
    /// </summary>
    public class UpdateLocalizedPolicyVersion : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateLocalizedPolicyVersionBuilder Builder { get => new UpdateLocalizedPolicyVersionBuilder(); }

        public class UpdateLocalizedPolicyVersionBuilder
            : OperationBuilder<UpdateLocalizedPolicyVersionBuilder>
        {


            public Model.UpdateLocalizedPolicyVersionRequest? Body { get; set; }




            internal UpdateLocalizedPolicyVersionBuilder() { }

            internal UpdateLocalizedPolicyVersionBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }



            public UpdateLocalizedPolicyVersionBuilder SetBody(Model.UpdateLocalizedPolicyVersionRequest _body)
            {
                Body = _body;
                return this;
            }




            public UpdateLocalizedPolicyVersion Build(
                string localizedPolicyVersionId
            )
            {
                UpdateLocalizedPolicyVersion op = new UpdateLocalizedPolicyVersion(this,
                    localizedPolicyVersionId
                );

                op.SetBaseFields<UpdateLocalizedPolicyVersionBuilder>(this);
                return op;
            }

            public Model.UpdateLocalizedPolicyVersionResponse? Execute(
                string localizedPolicyVersionId
            )
            {
                UpdateLocalizedPolicyVersion op = Build(
                    localizedPolicyVersionId
                );

                if (_Sdk == null)
                    throw IncompleteComponentException.NoSdkObject;

                var response = _Sdk.RunRequest(op);
                return op.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
            }
            public async Task<Model.UpdateLocalizedPolicyVersionResponse?> ExecuteAsync(
                string localizedPolicyVersionId
            )
            {
                UpdateLocalizedPolicyVersion op = Build(
                    localizedPolicyVersionId
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

        private UpdateLocalizedPolicyVersion(UpdateLocalizedPolicyVersionBuilder builder,
            string localizedPolicyVersionId
        )
        {
            PathParams["localizedPolicyVersionId"] = localizedPolicyVersionId;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateLocalizedPolicyVersion(
            string localizedPolicyVersionId,
            Model.UpdateLocalizedPolicyVersionRequest body
        )
        {
            PathParams["localizedPolicyVersionId"] = localizedPolicyVersionId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/localized-policy-versions/{localizedPolicyVersionId}";

        public override HttpMethod Method => HttpMethod.Put;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public Model.UpdateLocalizedPolicyVersionResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.UpdateLocalizedPolicyVersionResponse>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.UpdateLocalizedPolicyVersionResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}