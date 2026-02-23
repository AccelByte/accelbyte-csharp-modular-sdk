using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using AccelByte.Sdk.Authentication;
using AccelByte.Sdk.Core.Repository;
using AccelByte.Sdk.Core.Security;
using AccelByte.Sdk.Feature.AutoTokenRefresh;

namespace AccelByte.Sdk.Core
{
    public partial class AccelByteSDK : AccelByteSdk
    {
        public static new IAccelByteSdkBuilder<AccelByteSDK> Builder
        {
            //Monolithic version use default token validator by default.
            get => (new AccelByteSdkBuilder<AccelByteSDK>()).UseDefaultTokenValidator();
        }

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

        #region Authentication

        #endregion
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

        public static IAccelByteSdkBuilder<AccelByteSDK> UseRefreshIfPossible(this IAccelByteSdkBuilder<AccelByteSDK> builder)
            => builder;

        public static IAccelByteSdkBuilder<AccelByteSDK> SetOnAfterLoginAction(this IAccelByteSdkBuilder<AccelByteSDK> builder, Action<LoginType, AuthActionType, ITokenResponse?, IAccelByteSdk> action)
        {
            return builder.RegisterEvent(Auth_SdkExtensions.ON_AFTER_LOGIN_EVENT_KEY, action);
        }
    }
}
