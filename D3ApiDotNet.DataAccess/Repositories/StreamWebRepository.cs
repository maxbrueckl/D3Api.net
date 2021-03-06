﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using D3ApiDotNet.DataAccess.Helper;

namespace D3ApiDotNet.DataAccess.Repositories
{
    public class StreamWebRepository : IReadonlyRepository<Stream,string>
    {
        private readonly WebProxy _proxy;

        public StreamWebRepository(WebProxy proxy)
        {
            _proxy = proxy;
        }

        public Stream Retrieve(string url)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url.CheckUrl());
            httpWebRequest.Credentials = CredentialCache.DefaultCredentials;
            if(_proxy != null)
                httpWebRequest.Proxy = _proxy;
            var httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            if (httpWebResponse.StatusCode != HttpStatusCode.OK)
                throw new HttpListenerException();
            using (var responseStream = httpWebResponse.GetResponseStream())
            {
                var memStream = new MemoryStream();
                if (responseStream != null) responseStream.CopyTo(memStream);
                memStream.Position = 0;
                return memStream;
            }
        }
    }
}
