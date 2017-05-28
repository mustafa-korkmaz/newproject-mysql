using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Business.WebApi.Logging;
using Common.Helper;

namespace WebApi.Filters
{
    public abstract class MessageHandler : DelegatingHandler
    {
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            //var corrId = string.Format("{0}{1}", DateTime.Now.Ticks, Thread.CurrentThread.ManagedThreadId);
            // var requestInfo = string.Format("{0} {1}", request.Method, request.RequestUri);

            var requestContent = await request.Content.ReadAsStringAsync();

            //await IncommingMessageAsync(corrId, requestInfo, requestMessage);

            //WebMethodType methodType = WebMethodType.Null;

            //switch (request.Method.Method.ToLower())
            //{
            //    case "post":
            //        methodType = WebMethodType.Post;
            //        break;
            //    case "get":
            //        methodType = WebMethodType.Get;
            //        break;
            //}

            var response = await base.SendAsync(request, cancellationToken);

            string pathAndQuery = request.RequestUri.PathAndQuery;
            var url = pathAndQuery.Length >= 49 ? pathAndQuery.Substring(0, 49) : pathAndQuery;

            this.ProcessMessageAsync((int)response.StatusCode, requestContent, url);

            //byte[] responseMessage;

            //if (response.IsSuccessStatusCode)
            //    responseMessage = await response.Content.ReadAsByteArrayAsync();
            //else
            //    responseMessage = Encoding.UTF8.GetBytes(response.ReasonPhrase);

            //await OutgoingMessageAsync(corrId, requestInfo, responseMessage);

            return response;
        }

        protected abstract void ProcessMessageAsync(int responseStatusCode, string requestContent, string absolutePath);
        //protected abstract Task IncommingMessageAsync(string correlationId, string requestInfo, byte[] message);
        //protected abstract Task OutgoingMessageAsync(string correlationId, string requestInfo, byte[] message);
    }

    /// <summary>
    /// 
    /// </summary>
    public class MessageLoggingHandler : MessageHandler
    {
        /// <summary>
        /// saves req and resp async
        /// </summary>
        /// <param name="responseStatusCode"></param>
        /// <param name="requestContent"></param>
        /// <param name="url"></param>
        protected override void ProcessMessageAsync(int responseStatusCode, string requestContent, string url)
        {
            //trim requestContent as max 500 char variable
            var content = string.IsNullOrEmpty(requestContent)
                ? null
                : requestContent.Length >= 500 ? requestContent.Substring(0, 500) : requestContent;

            var requestLog = new DTO.RequestLog
            {
                Ip = Statics.GetIp(),
                HttpResponseCode = responseStatusCode,
                RequestContent = content,
                Uri = url,
                CreatedAt = Statics.GetTurkeyCurrentDateTime()
            };

            var loggingBusiness = new LoggingBusiness();

            loggingBusiness.LogRequestAsync(requestLog);
        }

        //protected override async Task IncommingMessageAsync(string correlationId, string requestInfo, byte[] message)
        //{
        //    await Task.Run(() =>
        //        Debug.WriteLine(string.Format("{0} - Request: {1}\r\n{2}", correlationId, requestInfo, Encoding.UTF8.GetString(message))));
        //}


        //protected override async Task OutgoingMessageAsync(string correlationId, string requestInfo, byte[] message)
        //{
        //    await Task.Run(() =>
        //        Debug.WriteLine(string.Format("{0} - Response: {1}\r\n{2}", correlationId, requestInfo, Encoding.UTF8.GetString(message))));
        //}
    }
}