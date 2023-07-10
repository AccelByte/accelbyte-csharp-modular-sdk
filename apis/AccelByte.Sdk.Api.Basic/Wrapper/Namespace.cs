// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Api.Basic.Operation;

namespace AccelByte.Sdk.Api.Basic.Wrapper
{
    public class Namespace
    {
        private readonly IAccelByteSdk _sdk;

        public Namespace(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetNamespaces.GetNamespacesBuilder GetNamespacesOp
        {
            get { return new Operation.GetNamespaces.GetNamespacesBuilder(_sdk); }
        }
        public CreateNamespace.CreateNamespaceBuilder CreateNamespaceOp
        {
            get { return new Operation.CreateNamespace.CreateNamespaceBuilder(_sdk); }
        }
        public GetNamespace.GetNamespaceBuilder GetNamespaceOp
        {
            get { return new Operation.GetNamespace.GetNamespaceBuilder(_sdk); }
        }
        public DeleteNamespace.DeleteNamespaceBuilder DeleteNamespaceOp
        {
            get { return new Operation.DeleteNamespace.DeleteNamespaceBuilder(_sdk); }
        }
        public UpdateNamespace.UpdateNamespaceBuilder UpdateNamespaceOp
        {
            get { return new Operation.UpdateNamespace.UpdateNamespaceBuilder(_sdk); }
        }
        public GetGameNamespaces.GetGameNamespacesBuilder GetGameNamespacesOp
        {
            get { return new Operation.GetGameNamespaces.GetGameNamespacesBuilder(_sdk); }
        }
        public GetNamespacePublisher.GetNamespacePublisherBuilder GetNamespacePublisherOp
        {
            get { return new Operation.GetNamespacePublisher.GetNamespacePublisherBuilder(_sdk); }
        }
        public ChangeNamespaceStatus.ChangeNamespaceStatusBuilder ChangeNamespaceStatusOp
        {
            get { return new Operation.ChangeNamespaceStatus.ChangeNamespaceStatusBuilder(_sdk); }
        }
        public PublicGetNamespaces.PublicGetNamespacesBuilder PublicGetNamespacesOp
        {
            get { return new Operation.PublicGetNamespaces.PublicGetNamespacesBuilder(_sdk); }
        }
        public PublicGetNamespacePublisher.PublicGetNamespacePublisherBuilder PublicGetNamespacePublisherOp
        {
            get { return new Operation.PublicGetNamespacePublisher.PublicGetNamespacePublisherBuilder(_sdk); }
        }
        #endregion

        public List<Model.NamespaceInfo>? GetNamespaces(GetNamespaces input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.NamespaceInfo? CreateNamespace(CreateNamespace input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.NamespaceInfo? GetNamespace(GetNamespace input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.NamespaceInfo? DeleteNamespace(DeleteNamespace input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.NamespaceInfo? UpdateNamespace(UpdateNamespace input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.NamespaceInfo>? GetGameNamespaces(GetGameNamespaces input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.NamespacePublisherInfo? GetNamespacePublisher(GetNamespacePublisher input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.NamespaceInfo? ChangeNamespaceStatus(ChangeNamespaceStatus input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.NamespaceInfo>? PublicGetNamespaces(PublicGetNamespaces input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.NamespacePublisherInfo? PublicGetNamespacePublisher(PublicGetNamespacePublisher input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}