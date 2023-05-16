using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AccelByte.Sdk.Core.Net.Http
{
    public interface IHttpResponse
    {
        HttpStatusCode Code { get; }

        string ContentType { get; }

        Stream Payload { get; }
    }
}
