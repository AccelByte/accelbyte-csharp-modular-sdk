// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.IO;

namespace AccelByte.Sdk.Core.Net
{
    public class FileUploadStream : FileStream, IUploadStream
    {
        public FileUploadStream(string path, FileMode mode)
            : base(path, mode)
        {
            FileName = Path.GetFileName(path);

        }

        public FileUploadStream(string path, FileStreamOptions options)
            : base(path, options)
        {
            FileName = Path.GetFileName(path);

        }

        public FileUploadStream(string path, FileMode mode, FileAccess access)
            : base(path, mode, access)
        {
            FileName = Path.GetFileName(path);
        }

        public FileUploadStream(string path, FileMode mode, FileAccess access, FileShare share)
            : base(path, mode, access, share)
        {
            FileName = Path.GetFileName(path);

        }

        public FileUploadStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize)
            : base(path, mode, access, share, bufferSize)
        {
            FileName = Path.GetFileName(path);

        }

        public FileUploadStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool useAsync)
            : base(path, mode, access, share, bufferSize, useAsync)
        {
            FileName = Path.GetFileName(path);

        }

        public FileUploadStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options)
            : base(path, mode, access, share, bufferSize, options)
        {
            FileName = Path.GetFileName(path);
        }

        public string FileName { get; set; } = String.Empty;

        public string MimeType { get; set; } = "application/octet-stream";
    }
}