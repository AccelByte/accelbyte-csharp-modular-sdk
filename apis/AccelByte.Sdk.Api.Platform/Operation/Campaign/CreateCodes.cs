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
    /// createCodes
    ///
    /// This API is used to create campaign codes, it will increase the batch No. based on last creation.
    /// Other detail info:
    /// 
    ///   * Returns : number of codes created
    /// </summary>
    public class CreateCodes : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateCodesBuilder Builder { get => new CreateCodesBuilder(); }

        public class CreateCodesBuilder
            : OperationBuilder<CreateCodesBuilder>
        {





            internal CreateCodesBuilder() { }

            internal CreateCodesBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }






            public CreateCodes Build(
                CodeCreate body,
                string campaignId,
                string namespace_
            )
            {
                CreateCodes op = new CreateCodes(this,
                    body,
                    campaignId,
                    namespace_
                );

                op.SetBaseFields<CreateCodesBuilder>(this);
                return op;
            }

            public Model.CodeCreateResult? Execute(
                CodeCreate body,
                string campaignId,
                string namespace_
            )
            {
                CreateCodes op = Build(
                    body,
                    campaignId,
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
            public async Task<Model.CodeCreateResult?> ExecuteAsync(
                CodeCreate body,
                string campaignId,
                string namespace_
            )
            {
                CreateCodes op = Build(
                    body,
                    campaignId,
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

        private CreateCodes(CreateCodesBuilder builder,
            CodeCreate body,
            string campaignId,
            string namespace_
        )
        {
            PathParams["campaignId"] = campaignId;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreateCodes(
            string campaignId,
            string namespace_,
            Model.CodeCreate body
        )
        {
            PathParams["campaignId"] = campaignId;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/codes/campaigns/{campaignId}";

        public override HttpMethod Method => HttpMethod.Post;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { };

        public Model.CodeCreateResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.CodeCreateResult>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.CodeCreateResult>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}