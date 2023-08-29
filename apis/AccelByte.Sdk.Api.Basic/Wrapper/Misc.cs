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
    public class Misc
    {
        private readonly IAccelByteSdk _sdk;

        public Misc(IAccelByteSdk sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetCountries.GetCountriesBuilder GetCountriesOp
        {
            get { return new Operation.GetCountries.GetCountriesBuilder(_sdk); }
        }
        public GetCountryGroups.GetCountryGroupsBuilder GetCountryGroupsOp
        {
            get { return new Operation.GetCountryGroups.GetCountryGroupsBuilder(_sdk); }
        }
        public AddCountryGroup.AddCountryGroupBuilder AddCountryGroupOp
        {
            get { return new Operation.AddCountryGroup.AddCountryGroupBuilder(_sdk); }
        }
        public UpdateCountryGroup.UpdateCountryGroupBuilder UpdateCountryGroupOp
        {
            get { return new Operation.UpdateCountryGroup.UpdateCountryGroupBuilder(_sdk); }
        }
        public DeleteCountryGroup.DeleteCountryGroupBuilder DeleteCountryGroupOp
        {
            get { return new Operation.DeleteCountryGroup.DeleteCountryGroupBuilder(_sdk); }
        }
        public GetLanguages.GetLanguagesBuilder GetLanguagesOp
        {
            get { return new Operation.GetLanguages.GetLanguagesBuilder(_sdk); }
        }
        public GetTimeZones.GetTimeZonesBuilder GetTimeZonesOp
        {
            get { return new Operation.GetTimeZones.GetTimeZonesBuilder(_sdk); }
        }
        public PublicGetTime.PublicGetTimeBuilder PublicGetTimeOp
        {
            get { return new Operation.PublicGetTime.PublicGetTimeBuilder(_sdk); }
        }
        public PublicGetCountries.PublicGetCountriesBuilder PublicGetCountriesOp
        {
            get { return new Operation.PublicGetCountries.PublicGetCountriesBuilder(_sdk); }
        }
        public PublicGetLanguages.PublicGetLanguagesBuilder PublicGetLanguagesOp
        {
            get { return new Operation.PublicGetLanguages.PublicGetLanguagesBuilder(_sdk); }
        }
        public PublicGetTimeZones.PublicGetTimeZonesBuilder PublicGetTimeZonesOp
        {
            get { return new Operation.PublicGetTimeZones.PublicGetTimeZonesBuilder(_sdk); }
        }
        #endregion

        public List<Model.CountryObject>? GetCountries(GetCountries input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.RetrieveCountryGroupResponse>? GetCountryGroups(GetCountryGroups input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.AddCountryGroupResponse? AddCountryGroup(AddCountryGroup input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.CountryGroupObject? UpdateCountryGroup(UpdateCountryGroup input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteCountryGroup(DeleteCountryGroup input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Dictionary<string, object>? GetLanguages(GetLanguages input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<string>? GetTimeZones(GetTimeZones input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.RetrieveTimeResponse? PublicGetTime(PublicGetTime input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.CountryObject>? PublicGetCountries(PublicGetCountries input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Dictionary<string, object>? PublicGetLanguages(PublicGetLanguages input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public List<string>? PublicGetTimeZones(PublicGetTimeZones input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}