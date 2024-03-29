using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace Obonator.Library
{
    class ObonWebservices
    {
        private static void SerializeJsonIntoStream(object value, Stream stream)
        {
            using (var jtw = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true }))
            {
                JsonSerializer.Serialize(jtw, value);
                jtw.Flush();
            }
        }

        private static HttpContent CreateHttpContent(object content)
        {
            HttpContent httpContent = null;

            if (content != null)
            {
                var ms = new MemoryStream();
                SerializeJsonIntoStream(content, ms);
                ms.Seek(0, SeekOrigin.Begin);
                httpContent = new StreamContent(ms);
                httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            }

            return httpContent;
        }

        private static async Task SendStreamAsync(HttpMethod method, object content, string url, int timeoutSecond = 30)
        {
            CancellationTokenSource source = new CancellationTokenSource();
            source.CancelAfter(TimeSpan.FromSeconds(timeoutSecond));
            CancellationToken cToken = source.Token;
            using (var client = new HttpClient())
            using (var request = new HttpRequestMessage(method, url))
            using (var httpContent = CreateHttpContent(content))
            {
                request.Content = httpContent;

                using (var response = await client
                    .SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cToken)
                    .ConfigureAwait(false))
                {
                    response.EnsureSuccessStatusCode();
                }
            }
        }
    }
}
