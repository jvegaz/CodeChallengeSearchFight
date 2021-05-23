using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;

namespace SearchImplementation.Engines
{
    public class BaseEngine
    {
        #region Public Members
        public BaseEngine() {
            _httpClient = new HttpClient();
        }
        public string GetSecretKey(string key) {
            return ConfigurationManager.AppSettings[key].ToString();
        }
        public string GetResponse(string url) {
            try {
                _httpClient.Timeout = TimeSpan.FromSeconds(5);
                return _httpClient.GetStringAsync(url).Result;
            } catch (Exception ex) {
                throw ex;
            }
        }
        public string GetResponse(string url, KeyValuePair<string,string> headerkey) {
            try
            {
                _httpClient.Timeout = TimeSpan.FromSeconds(5);
                _httpClient.DefaultRequestHeaders.Add(headerkey.Key, headerkey.Value);
                return _httpClient.GetStringAsync(url).Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Protected Members & Properties
        protected readonly HttpClient _httpClient;
        #endregion
    }
}
