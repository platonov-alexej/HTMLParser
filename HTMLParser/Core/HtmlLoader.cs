﻿using System.Net.Http;
using System.Net;
using System.Threading.Tasks;

namespace HTMLParser.Core
{
    class HtmlLoader
    {
        readonly HttpClient client;
        readonly string url;

        public HtmlLoader(IParserSettings settings)
        {
            client = new HttpClient();
            url = $"{settings.BaseURL}";/*{settings.Prefix}*/
        }

        public async Task<string> GetSourceByPageId(int id)
        {
            var currentUrl = url.Replace("{currentId}", id.ToString());
            var response = await client.GetAsync(currentUrl);

            string source = null;

            if(response != null && response.StatusCode == HttpStatusCode.OK)
            {
                source = await response.Content.ReadAsStringAsync();
            }
            return source;
        }
    }
}
