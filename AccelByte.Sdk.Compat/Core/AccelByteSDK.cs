﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using AccelByte.Sdk.Api;
using AccelByte.Sdk.Api.Achievement;
using AccelByte.Sdk.Api.Ams;
using AccelByte.Sdk.Api.Basic;
using AccelByte.Sdk.Api.Chat;
using AccelByte.Sdk.Api.Cloudsave;
using AccelByte.Sdk.Api.Gametelemetry;
using AccelByte.Sdk.Api.Gdpr;
using AccelByte.Sdk.Api.Group;
using AccelByte.Sdk.Api.Iam;
using AccelByte.Sdk.Api.Inventory;
using AccelByte.Sdk.Api.Leaderboard;
using AccelByte.Sdk.Api.Legal;
using AccelByte.Sdk.Api.Lobby;
using AccelByte.Sdk.Api.Match2;
using AccelByte.Sdk.Api.Platform;
using AccelByte.Sdk.Api.Reporting;
using AccelByte.Sdk.Api.Seasonpass;
using AccelByte.Sdk.Api.Session;
using AccelByte.Sdk.Api.Social;
using AccelByte.Sdk.Api.Ugc;
using AccelByte.Sdk.Authentication;
using AccelByte.Sdk.Core.Repository;

namespace AccelByte.Sdk.Core
{
    public class AccelByteSDK : AccelByteSdk
    {
        public static new IAccelByteSdkBuilder<AccelByteSDK> Builder { get => new AccelByteSdkBuilder<AccelByteSDK>(); }

        #region Api Fluent Properties
        public AchievementApi Achievement { get => ((IAccelByteSdk)this).GetAchievementApi(); }
        public AmsApi Ams { get => ((IAccelByteSdk)this).GetAmsApi(); }
        public BasicApi Basic { get => ((IAccelByteSdk)this).GetBasicApi(); }
        public ChatApi Chat { get => ((IAccelByteSdk)this).GetChatApi(); }
        public CloudsaveApi Cloudsave { get => ((IAccelByteSdk)this).GetCloudsaveApi(); }
        public GametelemetryApi Gametelemetry { get => ((IAccelByteSdk)this).GetGametelemetryApi(); }
        public GdprApi Gdpr { get => ((IAccelByteSdk)this).GetGdprApi(); }
        public GroupApi Group { get => ((IAccelByteSdk)this).GetGroupApi(); }
        public IamApi Iam { get => ((IAccelByteSdk)this).GetIamApi(); }
        public InventoryApi Inventory { get => ((IAccelByteSdk)this).GetInventoryApi(); }
        public LeaderboardApi Leaderboard { get => ((IAccelByteSdk)this).GetLeaderboardApi(); }
        public LegalApi Legal { get => ((IAccelByteSdk)this).GetLegalApi(); }
        public LobbyApi Lobby { get => ((IAccelByteSdk)this).GetLobbyApi(); }
        public Match2Api Match2 { get => ((IAccelByteSdk)this).GetMatch2Api(); }
        public PlatformApi Platform { get => ((IAccelByteSdk)this).GetPlatformApi(); }
        public ReportingApi Reporting { get => ((IAccelByteSdk)this).GetReportingApi(); }
        public SeasonpassApi Seasonpass { get => ((IAccelByteSdk)this).GetSeasonpassApi(); }
        public SessionApi Session { get => ((IAccelByteSdk)this).GetSessionApi(); }
        public SocialApi Social { get => ((IAccelByteSdk)this).GetSocialApi(); }
        public UgcApi Ugc { get => ((IAccelByteSdk)this).GetUgcApi(); }
        #endregion

        public AccelByteSDK(IAccelByteConfig config)
            : base(config)
        {

        }

        public AccelByteSDK(IAccelByteConfig config, ISdkEvents events)
            : base(config, events)
        {

        }

        public AccelByteSDK(IAccelByteConfig config, List<ISdkService> services)
            : base(config, services)
        {

        }

        public AccelByteSDK(IAccelByteConfig config, ISdkEvents events, List<ISdkService> services)
            : base(config, events, services)
        {

        }
    }

    public static class AccelByteSDKBuilder_Exts
    {
        public static IAccelByteSdkBuilder<AccelByteSDK> UseDefaultHttpClient(this IAccelByteSdkBuilder<AccelByteSDK> builder)
        {
            return builder.SetHttpClient(new AccelByte.Sdk.Core.Client.DefaultHttpClient());
        }

        public static IAccelByteSdkBuilder<AccelByteSDK> UseDefaultTokenRepository(this IAccelByteSdkBuilder<AccelByteSDK> builder)
        {
            return builder.SetTokenRepository(new DefaultTokenRepository());
        }

        public static IAccelByteSdkBuilder<AccelByteSDK> UseSharedTokenRepository(this IAccelByteSdkBuilder<AccelByteSDK> builder)
        {
            return builder.SetTokenRepository(new SharedTokenRepository());
        }

        public static IAccelByteSdkBuilder<AccelByteSDK> UseDefaultConfigRepository(this IAccelByteSdkBuilder<AccelByteSDK> builder)
        {
            return builder.SetConfigRepository(new DefaultConfigRepository());
        }

        public static IAccelByteSdkBuilder<AccelByteSDK> UseDefaultCredentialRepository(this IAccelByteSdkBuilder<AccelByteSDK> builder)
        {
            return builder.SetCredentialRepository(new DefaultCredentialRepository());
        }

        public static IAccelByteSdkBuilder<AccelByteSDK> UseDefaultTokenValidator(this IAccelByteSdkBuilder<AccelByteSDK> builder)
        {
            return builder.SetTokenValidator(new DefaultTokenValidator());
        }
    }
}
