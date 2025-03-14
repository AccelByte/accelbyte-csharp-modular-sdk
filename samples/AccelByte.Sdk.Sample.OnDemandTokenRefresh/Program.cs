﻿// Copyright (c) 2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Threading;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Net.Http;
using AccelByte.Sdk.Core.Repository;
using AccelByte.Sdk.Api;
using AccelByte.Sdk.Api.Legal.Model;

namespace AccelByte.Sdk.Sample.OnDemandTokenRefresh
{
    internal class Program
    {
        static int Main(string[] args)
        {
            DefaultTokenRepository tokenRepo = new DefaultTokenRepository();

            using IAccelByteSdk sdk = AccelByteSdk.Builder
                .UseDefaultHttpClient()
                .UseDefaultConfigRepository()
                .SetTokenRepository(tokenRepo)
                .UseDefaultCredentialRepository()
                .SetOnAfterLoginEventHandler((loginType, authAction, token, sdk) =>
                {
                    tokenRepo.SetTokenExpiry(5); //force token expire in 5s for testing purpose.
                    Console.WriteLine($"-> {loginType} login, action: {authAction}");
                })
                .Build();

            int loop = 0;
            int maxLoop = 100;

            while (loop < maxLoop)
            {
                bool login = sdk.LoginUser();
                if (!login)
                {
                    Console.WriteLine("Login failed");
                    return 1;
                }

                try
                {
                    List<RetrieveAcceptedAgreementResponse>? response = sdk.GetLegalApi().Agreement.RetrieveAgreementsPublicOp.Execute().EnsureSuccess();

                    foreach (var aggreement in response)
                        Console.WriteLine(aggreement.PolicyName);
                }
                catch (HttpResponseException e)
                {
                    Console.WriteLine(e.Message);
                    return 2;
                }

                Thread.Sleep(2000); //wait for 2s.
                loop++;
            }

            bool logout = sdk.Logout();
            if (!logout)
            {
                Console.WriteLine("Logout failed");
                return 1;
            }

            return 0;
        }
    }
}