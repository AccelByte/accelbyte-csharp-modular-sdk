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

using AccelByte.Sdk.Api.Ams.Model;

namespace AccelByte.Sdk.Api.Ams.Operation
{
    /// <summary>
    /// ArtifactGet
    ///
    /// Required Permission: ADMIN:NAMESPACE:{namespace}:AMS:ARTIFACT [READ]
    /// </summary>
    public class ArtifactGet : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ArtifactGetBuilder Builder { get => new ArtifactGetBuilder(); }

        public class ArtifactGetBuilder
            : OperationBuilder<ArtifactGetBuilder>
        {

            public string? ArtifactType { get; set; }

            public string? EndDate { get; set; }

            public string? FleetID { get; set; }

            public string? ImageID { get; set; }

            public long? MaxSize { get; set; }

            public long? MinSize { get; set; }

            public string? Region { get; set; }

            public string? StartDate { get; set; }

            public string? Status { get; set; }





            internal ArtifactGetBuilder() { }

            internal ArtifactGetBuilder(IAccelByteSdk sdk)
            {
                _Sdk = sdk;
            }


            public ArtifactGetBuilder SetArtifactType(string _artifactType)
            {
                ArtifactType = _artifactType;
                return this;
            }

            public ArtifactGetBuilder SetEndDate(string _endDate)
            {
                EndDate = _endDate;
                return this;
            }

            public ArtifactGetBuilder SetFleetID(string _fleetID)
            {
                FleetID = _fleetID;
                return this;
            }

            public ArtifactGetBuilder SetImageID(string _imageID)
            {
                ImageID = _imageID;
                return this;
            }

            public ArtifactGetBuilder SetMaxSize(long _maxSize)
            {
                MaxSize = _maxSize;
                return this;
            }

            public ArtifactGetBuilder SetMinSize(long _minSize)
            {
                MinSize = _minSize;
                return this;
            }

            public ArtifactGetBuilder SetRegion(string _region)
            {
                Region = _region;
                return this;
            }

            public ArtifactGetBuilder SetStartDate(string _startDate)
            {
                StartDate = _startDate;
                return this;
            }

            public ArtifactGetBuilder SetStatus(string _status)
            {
                Status = _status;
                return this;
            }





            public ArtifactGet Build(
                string namespace_
            )
            {
                ArtifactGet op = new ArtifactGet(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }

            public List<Model.ApiArtifactResponse>? Execute(
                string namespace_
            )
            {
                ArtifactGet op = Build(
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

        private ArtifactGet(ArtifactGetBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.ArtifactType is not null) QueryParams["artifactType"] = builder.ArtifactType;
            if (builder.EndDate is not null) QueryParams["endDate"] = builder.EndDate;
            if (builder.FleetID is not null) QueryParams["fleetID"] = builder.FleetID;
            if (builder.ImageID is not null) QueryParams["imageID"] = builder.ImageID;
            if (builder.MaxSize != null) QueryParams["maxSize"] = Convert.ToString(builder.MaxSize)!;
            if (builder.MinSize != null) QueryParams["minSize"] = Convert.ToString(builder.MinSize)!;
            if (builder.Region is not null) QueryParams["region"] = builder.Region;
            if (builder.StartDate is not null) QueryParams["startDate"] = builder.StartDate;
            if (builder.Status is not null) QueryParams["status"] = builder.Status;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ArtifactGet(
            string namespace_,
            string? artifactType,
            string? endDate,
            string? fleetID,
            string? imageID,
            long? maxSize,
            long? minSize,
            string? region,
            string? startDate,
            string? status
        )
        {
            PathParams["namespace"] = namespace_;

            if (artifactType is not null) QueryParams["artifactType"] = artifactType;
            if (endDate is not null) QueryParams["endDate"] = endDate;
            if (fleetID is not null) QueryParams["fleetID"] = fleetID;
            if (imageID is not null) QueryParams["imageID"] = imageID;
            if (maxSize != null) QueryParams["maxSize"] = Convert.ToString(maxSize)!;
            if (minSize != null) QueryParams["minSize"] = Convert.ToString(minSize)!;
            if (region is not null) QueryParams["region"] = region;
            if (startDate is not null) QueryParams["startDate"] = startDate;
            if (status is not null) QueryParams["status"] = status;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ams/v1/admin/namespaces/{namespace}/artifacts";

        public override HttpMethod Method => HttpMethod.Get;

        public override List<string> Consumes => new() { "application/json" };

        public override List<string> Produces => new() { "application/json" };

        public List<Model.ApiArtifactResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ApiArtifactResponse>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ApiArtifactResponse>>(payload, ResponseJsonOptions);
            }

            var payloadString = payload.ReadToString();

            throw new HttpResponseException(code, payloadString);
        }
    }

}