// Copyright (c) 2024-2026 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccelByte.Sdk.Core.Security
{
    public enum NamespaceType
    {
        Unknown,
        Publisher,
        Studio,
        Game
    }

    public class LocalNamespaceContext
    {
        public static LocalNamespaceContext CreateGameNS(string gameNamespace, string studioNamespace)
        {
            return new LocalNamespaceContext()
            {
                Namespace = gameNamespace,
                StudioNamespace = studioNamespace,
                Type = NamespaceType.Game
            };
        }

        public string Namespace { get; set; } = "";

        public NamespaceType Type { get; set; } = NamespaceType.Unknown;

        public string PublisherNamespace { get; set; } = "";

        public string StudioNamespace { get; set; } = "";

        public bool IsError { get; set; } = false;

        public string ErrorMessage { get; set; } = "";

        public LocalNamespaceContext() { }

        public LocalNamespaceContext(string errorMessage)
        {
            IsError = true;
            ErrorMessage = errorMessage;
        }
    }
}
