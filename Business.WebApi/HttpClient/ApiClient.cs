using System.IO;
using System.Net;
using System.Text;
using Common;
using Common.Helper;
using Common.Response;

namespace Business.WebApi.HttpClient
{
    public class ApiClient
    {

        /// <summary>
        /// gets the bet program data from default site
        /// </summary>
        /// <returns></returns>
        public HttpClientResponse<string> GetBetProgramData(string url)
        {
            var resp = new HttpClientResponse<string>();

            // Create a 'HttpWebRequest' object. 

            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);

            webRequest.Referer = Statics.GetConfigKey(ConfigKeys.BetProgramReferer);
            // Assign the response object of 'HttpWebRequest' to a 'HttpWebResponse' variable.
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)webRequest.GetResponse();
            // Display the contents of the page to the console.
            Stream streamResponse = myHttpWebResponse.GetResponseStream();

            if (streamResponse != null)
            {
                StreamReader streamRead = new StreamReader(streamResponse);
                char[] readBuffer = new char[256];
                int count = streamRead.Read(readBuffer, 0, 256);
                while (count > 0)
                {
                    var outputData = new string(readBuffer, 0, count);
                    resp.ResponseData += outputData;
                    count = streamRead.Read(readBuffer, 0, 256);
                }
                //resp.ResponseData += string.Format("\nHTTP Request  Headers :\n\n{0}", myHttpWebRequest.Headers);
                //resp.ResponseData += string.Format("\nHTTP Response Headers :\n\n{0}", myHttpWebResponse.Headers);

                resp.HttpStatusCode = HttpStatusCode.OK;

                streamRead.Close();
                streamResponse.Close();
            }
            else
            {
                resp.HttpStatusCode = HttpStatusCode.BadRequest;
                resp.ResponseMessage = HttpClientResponseMessage.ContentNoFound;
            }

            // Release the response object resources.
            myHttpWebResponse.Close();
            //resp.ResponseData += string.Format("Referer to the site is:{0}", myHttpWebRequest.Referer);

            return resp;
        }

        /// <summary>
        /// default http client
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public HttpClientResponse<string> GetWebResponse(string url)
        {
            var resp = new HttpClientResponse<string>();

            // Create a 'HttpWebRequest' object. 

            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);

            // Assign the response object of 'HttpWebRequest' to a 'HttpWebResponse' variable.
            HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse();
            // Display the contents of the page to the console.
            Stream receiveStream = webResponse.GetResponseStream();

            if (receiveStream != null)
            {
                StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);

                resp.ResponseData = readStream.ReadToEnd();
                resp.HttpStatusCode = HttpStatusCode.OK;

                readStream.Close();
                receiveStream.Close();
            }
            else
            {
                resp.HttpStatusCode = HttpStatusCode.BadRequest;
                resp.ResponseMessage = HttpClientResponseMessage.ContentNoFound;
            }

            // Release the response object resources.
            webResponse.Close();
            //resp.ResponseData += string.Format("Referer to the site is:{0}", myHttpWebRequest.Referer);

            return resp;
        }

    }
}