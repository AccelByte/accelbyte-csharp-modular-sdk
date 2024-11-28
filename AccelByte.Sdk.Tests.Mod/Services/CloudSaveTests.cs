// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;
using AccelByte.Sdk.Core.Net.Http;
using AccelByte.Sdk.Api.Cloudsave.Model;

using AccelByte.Sdk.Tests.Mod.Model;
using System.Text.Json;

namespace AccelByte.Sdk.Tests.Mod.Services
{
    [TestFixture(Category = "ServiceIntegration")]
    [Explicit]
    public class CloudSaveTests : BaseServiceTests
    {
        public CloudSaveTests() : base(true) { }

        [Test]
        public void CloudSaveServiceTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            #region Create new game record
            ModelsGameRecordRequestForTest gameRecord = new ModelsGameRecordRequestForTest()
            {
                Foo = "bar",
                FooBar = "foo",
                FooValue = 4893
            };

            _Sdk.GetCloudsaveApi().PublicGameRecord.PostGameRecordHandlerV1Op
                .Execute(gameRecord, "foo_bar_record", _Sdk.Namespace)
                .EnsureSuccess();
            #endregion

            Wait();

            #region Get game record
            ModelsGameRecordResponse? gRecord = _Sdk.GetCloudsaveApi().PublicGameRecord.GetGameRecordHandlerV1Op
                .Execute("foo_bar_record", _Sdk.Namespace)
                .EnsureSuccess();
            #endregion
            Assert.IsNotNull(gRecord!.Value);

            Dictionary<string, object> recValue = gRecord.Value!;
            Assert.IsTrue(recValue.ContainsKey("foo_bar"));
            Assert.AreEqual("foo", recValue["foo_bar"].ToString());

            #region Update game record
            ModelsGameRecordRequestForTest updateRecord = new ModelsGameRecordRequestForTest()
            {
                Foo = "bar",
                FooBar = "update",
                FooValue = 4893
            };

            _Sdk.GetCloudsaveApi().PublicGameRecord.PutGameRecordHandlerV1Op
                .Execute(updateRecord, "foo_bar_record", _Sdk.Namespace)
                .EnsureSuccess();
            #endregion

            Wait();

            //re-check updated game record
            gRecord = _Sdk.GetCloudsaveApi().PublicGameRecord.GetGameRecordHandlerV1Op
                .Execute("foo_bar_record", _Sdk.Namespace)
                .EnsureSuccess();
            Assert.IsNotNull(gRecord!.Value);

            recValue = gRecord.Value!;
            Assert.IsTrue(recValue.ContainsKey("foo"));
            Assert.AreEqual("bar", recValue["foo"].ToString());

            Assert.IsTrue(recValue.ContainsKey("foo_bar"));
            Assert.AreEqual("update", recValue["foo_bar"].ToString());

            #region Delete game record
            _Sdk.GetCloudsaveApi().PublicGameRecord.DeleteGameRecordHandlerV1Op
                .Execute("foo_bar_record", _Sdk.Namespace)
                .EnsureSuccess();
            #endregion

            Wait();

            //Finally, recheck if the data is truly deleted.
            Exception? hrx = Assert.Throws<Exception>(() =>
            {
                DisableRetry();
                gRecord = _Sdk.GetCloudsaveApi().PublicGameRecord.GetGameRecordHandlerV1Op
                    .Execute("foo_bar_record", _Sdk.Namespace)
                    .EnsureSuccess();
            });
        }

        [Test]
        public void CloudSavePlayerRecordTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            string userId = _Sdk.Configuration.Credential!.UserId;

            #region Create new player record
            ModelsPlayerRecordRequestForTest playerRecord = new ModelsPlayerRecordRequestForTest()
            {
                Foo = "bar",
                FooBar = "foo",
                FooValue = 4893
            };

            _Sdk.GetCloudsaveApi().PublicPlayerRecord.PostPlayerRecordHandlerV1Op
                .Execute(playerRecord, "foo_bar_record", _Sdk.Namespace, userId)
                .EnsureSuccess();
            #endregion

            Wait();

            #region Get player record
            ModelsPlayerRecordResponse? gRecord = _Sdk.GetCloudsaveApi().PublicPlayerRecord.GetPlayerRecordHandlerV1Op
                .Execute("foo_bar_record", _Sdk.Namespace, userId)
                .EnsureSuccess();
            #endregion
            Assert.IsNotNull(gRecord);
            Assert.IsNotNull(gRecord!.Value);

            Dictionary<string, object> recValue = gRecord.Value!;
            Assert.IsTrue(recValue.ContainsKey("foo_bar"));
            Assert.AreEqual("foo", recValue["foo_bar"].ToString());

            #region Update player record
            ModelsPlayerRecordRequestForTest updateRecord = new ModelsPlayerRecordRequestForTest()
            {
                Foo = "bar",
                FooBar = "update",
                FooValue = 4893
            };

            _Sdk.GetCloudsaveApi().PublicPlayerRecord.PutPlayerRecordHandlerV1Op
                .Execute(updateRecord, "foo_bar_record", _Sdk.Namespace, userId)
                .EnsureSuccess();
            #endregion

            Wait();

            //re-check updated player record
            gRecord = _Sdk.GetCloudsaveApi().PublicPlayerRecord.GetPlayerRecordHandlerV1Op
                .Execute("foo_bar_record", _Sdk.Namespace, userId)
                .EnsureSuccess();
            Assert.IsNotNull(gRecord);
            Assert.IsNotNull(gRecord!.Value);

            recValue = gRecord.Value!;
            Assert.IsTrue(recValue.ContainsKey("foo"));
            Assert.AreEqual("bar", recValue["foo"].ToString());

            Assert.IsTrue(recValue.ContainsKey("foo_bar"));
            Assert.AreEqual("update", recValue["foo_bar"].ToString());

            #region Delete player record
            _Sdk.GetCloudsaveApi().PublicPlayerRecord.DeletePlayerRecordHandlerV1Op
                .Execute("foo_bar_record", _Sdk.Namespace, userId)
                .EnsureSuccess();
            #endregion

            Wait();

            //Finally, recheck if the data is truly deleted.
            Exception? hrx = Assert.Throws<Exception>(() =>
            {
                DisableRetry();
                gRecord = _Sdk.GetCloudsaveApi().PublicPlayerRecord.GetPlayerRecordHandlerV1Op
                    .Execute("foo_bar_record", _Sdk.Namespace, userId)
                    .EnsureSuccess();
            });
        }

        [Test]
        public void CustomResponseJsonOptionsTest()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            DisableRetry();

            Random rand = new Random();
            string recordKey = "another_foo_bar_record_" + rand.GenerateRandomId(4);

            AnotherGameRecordForTest_CC myGameRecord = new()
            {
                FooValue = 400,
                BarValue = "test"
            };

            _Sdk.GetCloudsaveApi().PublicGameRecord.PostGameRecordHandlerV1Op
                .Execute(myGameRecord, recordKey, _Sdk.Namespace)
                .EnsureSuccess();

            Wait();

            var gameRecord = _Sdk.GetCloudsaveApi().PublicGameRecord.GetGameRecordHandlerV1Op
                .SetResponseJsonOptions(new JsonSerializerOptions()
                {
                    DictionaryKeyPolicy = JsonNamingPolicy.CamelCase,
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                })
                .Execute<AnotherGameRecordForTest_PC>(recordKey, _Sdk.Namespace)
                .EnsureSuccess();

            Assert.IsNotNull(gameRecord.Value);
            if (gameRecord.Value != null)
            {
                Assert.AreEqual(400, gameRecord.Value.FooValue);
                Assert.AreEqual("test", gameRecord.Value.BarValue);
            }

            _Sdk.GetCloudsaveApi().PublicGameRecord.DeleteGameRecordHandlerV1Op
                .Execute(recordKey, _Sdk.Namespace)
                .EnsureSuccess();

            ResetPolicy();
        }

        [Test]
        public void CustomRequestJsonOptionsTest()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            DisableRetry();

            Random rand = new Random();
            string recordKey = "another_foo_bar_record_" + rand.GenerateRandomId(4);

            AnotherGameRecordForTest_PC myGameRecord = new()
            {
                FooValue = 400,
                BarValue = "test"
            };

            _Sdk.GetCloudsaveApi().PublicGameRecord.PostGameRecordHandlerV1Op
                .SetRequestJsonOptions(new JsonSerializerOptions()
                {
                    DictionaryKeyPolicy = JsonNamingPolicy.CamelCase,
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                })
                .Execute(myGameRecord, recordKey, _Sdk.Namespace)
                .EnsureSuccess();

            Wait();

            var gameRecord = _Sdk.GetCloudsaveApi().PublicGameRecord.GetGameRecordHandlerV1Op
                .Execute<AnotherGameRecordForTest_CC>(recordKey, _Sdk.Namespace)
                .EnsureSuccess();

            Assert.IsNotNull(gameRecord.Value);
            if (gameRecord.Value != null)
            {
                Assert.AreEqual(400, gameRecord.Value.FooValue);
                Assert.AreEqual("test", gameRecord.Value.BarValue);
            }

            _Sdk.GetCloudsaveApi().PublicGameRecord.DeleteGameRecordHandlerV1Op
                .Execute(recordKey, _Sdk.Namespace)
                .EnsureSuccess();

            ResetPolicy();
        }

        [Test]
        public void UploadAndDownloadTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            DisableRetry();
            Random rand = new Random();

            byte[] sBinary = new byte[32];
            rand.NextBytes(sBinary);

            string dataKey = $"csharksdk-test-{rand.GenerateRandomId(8)}";

            //create binary record request
            var cResponse = _Sdk.GetCloudsaveApi().AdminGameBinaryRecord.AdminPostGameBinaryRecordV1Op
                .Execute(new ModelsGameBinaryRecordCreate()
                {
                    Key = dataKey,
                    FileType = "bin",
                    SetBy = ModelsGameBinaryRecordCreateSetBy.CLIENT
                }, _Sdk.Namespace)
                .EnsureSuccess();

            if (cResponse.Url != null)
            {
                string contentType = "application/octet-stream";
                if (cResponse.ContentType != null)
                    contentType = cResponse.ContentType;

                //upload the binary
                var isSuccess = _Sdk.UploadBinaryData(cResponse.Url, sBinary, contentType);
                Assert.IsTrue(isSuccess);

                if (isSuccess)
                {
                    //update binary record
                    _Sdk.GetCloudsaveApi().AdminGameBinaryRecord.AdminPutGameBinaryRecordV1Op
                        .Execute(new ModelsBinaryRecordRequest()
                        {
                            ContentType = contentType,
                            FileLocation = cResponse.FileLocation
                        }, dataKey, _Sdk.Namespace)
                        .EnsureSuccess();
                }
            }

            //get binary record
            var sResponse = _Sdk.GetCloudsaveApi().AdminGameBinaryRecord.AdminGetGameBinaryRecordV1Op
                .Execute(dataKey, _Sdk.Namespace)
                .EnsureSuccess();
            if (sResponse.BinaryInfo != null && sResponse.BinaryInfo.Url != null)
            {
                //download binary
                string binaryUrl = sResponse.BinaryInfo.Url;
                byte[] downloadedData = _Sdk.DownloadBinaryData(binaryUrl);

                Assert.AreEqual(sBinary, downloadedData);
            }

            //download binary record
            _Sdk.GetCloudsaveApi().AdminGameBinaryRecord.AdminDeleteGameBinaryRecordV1Op
                .Execute(dataKey, _Sdk.Namespace)
                .EnsureSuccess();

            ResetPolicy();
        }
    }
}
