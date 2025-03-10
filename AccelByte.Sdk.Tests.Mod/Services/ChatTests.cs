﻿// Copyright (c) 2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;
using AccelByte.Sdk.Core.Net.Http;
using AccelByte.Sdk.Api.Chat.Model;

namespace AccelByte.Sdk.Tests.Mod.Services
{
    [TestFixture(Category = "ServiceIntegration")]
    [Explicit]
    public class ChatTests : BaseServiceTests
    {
        public ChatTests() : base(true) { }

        [Test]
        public void ChatProfanityTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            if (IsUsingAGSStarter())
            {
                Assert.Inconclusive("Test does not apply to AGS Starter environment.");
                return;
            }

            Random random = new Random();
            string profanityWord = $"xsdk{random.GenerateRandomAlphabet(4)}";

            #region Register a new profanity word
            var createResult = _Sdk.GetChatApi().Profanity.AdminProfanityCreateOp
                .Execute(new ModelsDictionaryInsertRequest()
                {
                    Word = profanityWord,
                    WordType = "PROFANITY"
                }, _Sdk.Namespace).EnsureSuccess();
            #endregion
            Assert.AreEqual(profanityWord, createResult.Word);

            #region Query profanity word
            var queryResults = _Sdk.GetChatApi().Profanity.AdminProfanityQueryOp
                .SetIncludeChildren(false)
                .SetWordType("PROFANITY")
                .SetStartWith(profanityWord)
                .Execute(_Sdk.Namespace)
                .EnsureSuccess();
            #endregion

            Assert.IsNotNull(queryResults.Data);
            if (queryResults.Data == null)
                throw new Exception("NULL query result data");

            if (queryResults.Data.Count <= 0)
                Assert.Fail($"Query result does not contain word '{profanityWord}'.");

            ModelsDictionaryWithChildren word = queryResults.Data[0];
            Assert.AreEqual(profanityWord, word.Word);

            string editProfanityWord = $"xsdk{random.GenerateRandomAlphabet(4)}";
            #region Update profanity word
            var updateResponse = _Sdk.GetChatApi().Profanity.AdminProfanityUpdateOp
                .Execute(new ModelsDictionaryUpdateRequest()
                {
                    WordType = "PROFANITY",
                    Word = editProfanityWord
                }, word.Id!, _Sdk.Namespace);
            #endregion
            updateResponse.ThrowExceptionIfError();
            Assert.IsTrue(updateResponse.IsSuccess);

            #region Delete profanity word
            var delResponse = _Sdk.GetChatApi().Profanity.AdminProfanityDeleteOp
                .Execute(word.Id!, _Sdk.Namespace);
            delResponse.ThrowExceptionIfError();
            #endregion
        }

        [Test]
        public void ChatInboxCategoryTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            if (IsUsingAGSStarter())
            {
                Assert.Inconclusive("Test does not apply to AGS Starter environment.");
                return;
            }

            Random random = new Random();
            string inboxName = $"xsdk_{random.GenerateRandomAlphabet(4)}";

            #region Add chat inbox category
            var insertResult = _Sdk.GetChatApi().Inbox.AdminAddInboxCategoryOp
                .Execute(new ModelsAddInboxCategoryRequest()
                {
                    ExpiresIn = 3600000000,
                    Name = inboxName

                }, _Sdk.Namespace).EnsureSuccess();
            #endregion
            Assert.AreEqual(inboxName, insertResult!.Name);

            #region Get chat inbox categories
            var getResult = _Sdk.GetChatApi().Inbox.AdminGetInboxCategoriesOp
                .Execute(_Sdk.Namespace)
                .EnsureSuccess();
            #endregion
            Assert.IsNotNull(getResult);
            if (getResult != null)
            {
                bool found = false;
                foreach (var item in getResult)
                {
                    if (item.Name == inboxName)
                    {
                        found = true;
                        break;
                    }
                }

                if (!found)
                    Assert.Fail($"'{inboxName}' not found.");
            }

            #region Update chat inbox category
            _Sdk.GetChatApi().Inbox.AdminUpdateInboxCategoryOp
                .Execute(new ModelsUpdateInboxCategoryRequest()
                {
                    ExpiresIn = 1800000000
                }, inboxName, _Sdk.Namespace)
                .EnsureSuccess();
            #endregion

            #region Delete chat inbox category
            _Sdk.GetChatApi().Inbox.AdminDeleteInboxCategoryOp
                .Execute(inboxName, _Sdk.Namespace)
                .EnsureSuccess();
            #endregion
        }
    }
}
