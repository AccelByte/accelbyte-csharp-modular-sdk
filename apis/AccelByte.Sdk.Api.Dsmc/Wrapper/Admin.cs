// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Api.Dsmc.Operation;

namespace AccelByte.Sdk.Api.Dsmc.Wrapper
{
    public class Admin
    {
        private readonly IAccelByteSdk _sdk;

        public Admin(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public ListServer.ListServerBuilder ListServerOp
        {
            get { return new Operation.ListServer.ListServerBuilder(_sdk); }
        }
        public CountServer.CountServerBuilder CountServerOp
        {
            get { return new Operation.CountServer.CountServerBuilder(_sdk); }
        }
        public CountServerDetailed.CountServerDetailedBuilder CountServerDetailedOp
        {
            get { return new Operation.CountServerDetailed.CountServerDetailedBuilder(_sdk); }
        }
        public ListLocalServer.ListLocalServerBuilder ListLocalServerOp
        {
            get { return new Operation.ListLocalServer.ListLocalServerBuilder(_sdk); }
        }
        public DeleteLocalServer.DeleteLocalServerBuilder DeleteLocalServerOp
        {
            get { return new Operation.DeleteLocalServer.DeleteLocalServerBuilder(_sdk); }
        }
        public GetServer.GetServerBuilder GetServerOp
        {
            get { return new Operation.GetServer.GetServerBuilder(_sdk); }
        }
        public DeleteServer.DeleteServerBuilder DeleteServerOp
        {
            get { return new Operation.DeleteServer.DeleteServerBuilder(_sdk); }
        }
        public ListSession.ListSessionBuilder ListSessionOp
        {
            get { return new Operation.ListSession.ListSessionBuilder(_sdk); }
        }
        public CountSession.CountSessionBuilder CountSessionOp
        {
            get { return new Operation.CountSession.CountSessionBuilder(_sdk); }
        }
        public DeleteSession.DeleteSessionBuilder DeleteSessionOp
        {
            get { return new Operation.DeleteSession.DeleteSessionBuilder(_sdk); }
        }
        #endregion

        public Model.ModelsListServerResponse? ListServer(ListServer input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsCountServerResponse? CountServer(CountServer input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsDetailedCountServerResponse? CountServerDetailed(CountServerDetailed input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsListServerResponse? ListLocalServer(ListLocalServer input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteLocalServer(DeleteLocalServer input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsServer? GetServer(GetServer input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteServer(DeleteServer input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsListSessionResponse? ListSession(ListSession input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsCountSessionResponse? CountSession(CountSession input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteSession(DeleteSession input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}