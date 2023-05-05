// Copyright (c) 2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Api.Match2;

namespace AccelByte.Sdk.Api.Match2
{
    public class Match2Api : ISdkApi
    {
        private IAccelByteSdk _Sdk;

        public Wrapper.Operations Operations
        {
            get
            {
                if (_Operations == null)
                    _Operations = new Wrapper.Operations(_Sdk);
                return _Operations;
            }
        }
        private Wrapper.Operations? _Operations = null;

        public Wrapper.Backfill Backfill
        {
            get
            {
                if (_Backfill == null)
                    _Backfill = new Wrapper.Backfill(_Sdk);
                return _Backfill;
            }
        }
        private Wrapper.Backfill? _Backfill = null;

        public Wrapper.MatchFunctions MatchFunctions
        {
            get
            {
                if (_MatchFunctions == null)
                    _MatchFunctions = new Wrapper.MatchFunctions(_Sdk);
                return _MatchFunctions;
            }
        }
        private Wrapper.MatchFunctions? _MatchFunctions = null;

        public Wrapper.MatchPools MatchPools
        {
            get
            {
                if (_MatchPools == null)
                    _MatchPools = new Wrapper.MatchPools(_Sdk);
                return _MatchPools;
            }
        }
        private Wrapper.MatchPools? _MatchPools = null;

        public Wrapper.MatchTickets MatchTickets
        {
            get
            {
                if (_MatchTickets == null)
                    _MatchTickets = new Wrapper.MatchTickets(_Sdk);
                return _MatchTickets;
            }
        }
        private Wrapper.MatchTickets? _MatchTickets = null;

        public Wrapper.RuleSets RuleSets
        {
            get
            {
                if (_RuleSets == null)
                    _RuleSets = new Wrapper.RuleSets(_Sdk);
                return _RuleSets;
            }
        }
        private Wrapper.RuleSets? _RuleSets = null;

        internal Match2Api(IAccelByteSdk sdk)
        {
            _Sdk = sdk;
        }
    }
}

namespace AccelByte.Sdk.Api
{
    public static class Match2Api_SdkExts
    {
        public static Match2Api GetMatch2Api(this IAccelByteSdk sdk)
        {
            return sdk.GetApi<Match2Api>("match2", () =>
            {
                return new Match2Api(sdk);
            });            
        }
    }
}