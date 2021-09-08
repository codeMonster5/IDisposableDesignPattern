using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace IDisposableDesignPattern
{
    public class ServiceProxy :IDisposable
    {
        public readonly HttpClient httpClient;


        private bool disposed;
        public  ServiceProxy()
        {
            this.httpClient = new HttpClient();
        }

        ~ServiceProxy()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
            {
                return;
            }

            if (disposing)
            {
                httpClient.Dispose();
            }

            disposed = true;

        }

        public void Get(string obj)
        {
            httpClient.GetAsync(obj);
        }

        public void Post(string obj,string request)
        {
            httpClient.PostAsync(obj, new StringContent(request));
        }
    }
}
