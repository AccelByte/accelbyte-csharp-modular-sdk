// Copyright (c) 2024-2026 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Text;
using System.Text.Json;
using System.Collections.Generic;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;
using AccelByte.Sdk.Api.Csm.Model;
using AccelByte.Sdk.Core.Net.Http;
using System.Threading;
using System.Diagnostics;
using AccelByte.Sdk.Tests.Mod.Repository;
using AccelByte.Sdk.Tests.Mod.Scenario;


namespace AccelByte.Sdk.Tests.Mod.Services
{
    [TestFixture(Category = "ServiceIntegration")]
    [Explicit]
    public class CsmTests : BaseServiceTests
    {
        public CsmTests() : base(false, IntegrationTestConfigRepository.Extend) { }

        [Test]
        public void AppTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            DisableRetry();
            Random rnd = new Random();

            int checkRetry = 300; //times
            int checkInterval = 1000; //milisecs
            //total waiting time is 5 mins.

            string appName = $"csharpsdk-test-{rnd.GenerateRandomAlphabet(6)}";

            #region Create an Extend app
            var createdApp = _Sdk.GetCsmApi().AppV2.CreateAppV2Op
                .Execute(new ApimodelCreateAppV2Request()
                {
                    Description = "C# Extend SDK integration test app.",
                    Scenario = "function-override"
                }, appName, _Sdk.Namespace)
                .EnsureSuccess();
            #endregion
            Assert.AreEqual(appName, createdApp.AppName!);

            try
            {
                bool isAppReady = false;
                string latestAppStatus = "";

                for (int i = 0; i < checkRetry; i++)
                {
                    #region Get an Extend app
                    var app = _Sdk.GetCsmApi().AppV2.GetAppV2Op
                        .Execute(appName, _Sdk.Namespace)
                        .EnsureSuccess();
                    #endregion
                    latestAppStatus = app.AppStatus!;

                    int checkCount = i + 1;
                    Debug.WriteLine($"[{checkCount:000}/{checkRetry:000}]Checking status [{app.AppName}]: {latestAppStatus}");

                    if (latestAppStatus == "app-undeployed")
                    {
                        //means app is ready
                        isAppReady = true;
                        break;
                    }

                    Thread.Sleep(checkInterval);
                }

                if (!isAppReady)
                {
                    Assert.Fail($"After waiting for {checkInterval * checkInterval}ms, app {appName} is not ready. Last status: {latestAppStatus}.");
                }
                else
                {
                    string envSecretKey = $"AB_CSHARP_TEST_{rnd.GenerateRandomAlphabet(4)}".ToUpper();
                    string envSecretValue = rnd.GenerateRandomId(32);
                    string envSecretValueNew = rnd.GenerateRandomId(32);

                    #region Create new env secret entry
                    var newSecret = _Sdk.GetCsmApi().ConfigurationV2.SaveSecretV2Op
                        .Execute(new ApimodelSaveSecretConfigurationV2Request()
                        {
                            ConfigName = envSecretKey,
                            Description = "",
                            Value = envSecretValue,
                            Source = "plaintext",
                        }, appName, _Sdk.Namespace)
                        .EnsureSuccess();
                    #endregion
                    Assert.AreEqual(envSecretKey, newSecret.ConfigName!);

                    #region Get list of env secrets
                    var getSecrets = _Sdk.GetCsmApi().ConfigurationV2.GetListOfSecretsV2Op
                        .SetOffset(0)
                        .SetLimit(500)
                        .Execute(appName, _Sdk.Namespace)
                        .EnsureSuccess();
                    #endregion

                    string secretId = "";
                    foreach (var secret in getSecrets.Data!)
                    {
                        if (secret.ConfigName! == envSecretKey)
                        {
                            secretId = secret.ConfigId!;
                            break;
                        }
                    }

                    if (secretId == "")
                        Assert.Fail($"Env secret {envSecretKey} is not exists.");

                    #region Update env secret
                    var updateSecret = _Sdk.GetCsmApi().ConfigurationV2.UpdateSecretV2Op
                        .Execute(new ApimodelUpdateSecretConfigurationV2Request()
                        {
                            Value = envSecretValueNew
                        }, appName, secretId, _Sdk.Namespace)
                        .EnsureSuccess();
                    #endregion

                    #region Delete env secret
                    _Sdk.GetCsmApi().ConfigurationV2.DeleteSecretV2Op
                        .Execute(appName, secretId, _Sdk.Namespace)
                        .EnsureSuccess();
                    #endregion


                    string envVariableKey = $"AB_CSHARP_TEST_{rnd.GenerateRandomAlphabet(4)}".ToUpper();
                    string envVariableValue = rnd.GenerateRandomId(32);
                    string envVariableValueNew = rnd.GenerateRandomId(32);

                    #region Create new env variable entry
                    var newVariable = _Sdk.GetCsmApi().ConfigurationV2.SaveVariableV2Op
                        .Execute(new ApimodelSaveConfigurationV2Request()
                        {
                            ConfigName = envVariableKey,
                            Description = "",
                            Value = envVariableValue,
                            Source = "plaintext"
                        }, appName, _Sdk.Namespace)
                        .EnsureSuccess();
                    #endregion
                    Assert.AreEqual(envVariableKey, newVariable.ConfigName!);

                    #region Get list of env variables
                    var getVariables = _Sdk.GetCsmApi().ConfigurationV2.GetListOfVariablesV2Op
                        .SetOffset(0)
                        .SetLimit(500)
                        .Execute(appName, _Sdk.Namespace)
                        .EnsureSuccess();
                    #endregion

                    string variableId = "";
                    foreach (var variable in getVariables.Data!)
                    {
                        if (variable.ConfigName! == envVariableKey)
                        {
                            variableId = variable.ConfigId!;
                            Assert.AreEqual(envVariableValue, variable.Value!);
                            break;
                        }
                    }

                    if (variableId == "")
                        Assert.Fail($"Env variable {envVariableKey} is not exists.");

                    #region Update env variable
                    var updateVariable = _Sdk.GetCsmApi().ConfigurationV2.UpdateVariableV2Op
                        .Execute(new ApimodelUpdateConfigurationV2Request()
                        {
                            Value = envVariableValueNew
                        }, appName, variableId, _Sdk.Namespace)
                        .EnsureSuccess();
                    #endregion
                    Assert.AreEqual(envVariableValueNew, updateVariable.Value!);

                    #region Delete env variable
                    _Sdk.GetCsmApi().ConfigurationV2.DeleteVariableV2Op
                        .Execute(appName, variableId, _Sdk.Namespace)
                        .EnsureSuccess();
                    #endregion
                }
            }
            finally
            {
                // try to get client id information for current extend app

                var getSecrets = _Sdk.GetCsmApi().ConfigurationV2.GetListOfSecretsV2Op
                    .SetOffset(0)
                    .SetLimit(500)
                    .Execute(appName, _Sdk.Namespace)
                    .EnsureSuccess();
                if (getSecrets == null)
                    throw new Exception("NULL result from GetListOfSecretsV2Op");
                if (getSecrets.Data == null)
                    throw new Exception("NULL data from GetListOfSecretsV2Op");

                string appClientId = "";
                foreach (var secret in getSecrets.Data)
                {
                    string secretName = secret.ConfigName!.Trim().ToUpper();
                    if (secretName == "AB_CLIENT_ID")
                    {
                        appClientId = secret.Value!.Trim();
                        break;
                    }
                }

                #region Delete an Extend app
                _Sdk.GetCsmApi().AppV2.DeleteAppV2Op
                    .SetForced("true")
                    .Execute(appName, _Sdk.Namespace)
                    .EnsureSuccess();
                #endregion

                //try to delete IAM client id for current extend app
                if (appClientId != "")
                {
                    //You will need an admin user to delete OAuth client.
                    ExistingTestPlayer adminUser = new ExistingTestPlayer("AB", true);
                    adminUser.Run((sdk, user) =>
                    {
                        sdk.GetIamApi().Clients.AdminDeleteClientV3Op
                            .Execute(appClientId, _Sdk.Namespace)
                            .EnsureSuccess();
                    });
                    adminUser.Logout();
                }
                else
                    Console.WriteLine("Extend app does not have secret for AB_CLIENT_ID.");
            }

            ResetPolicy();
        }
    }
}
