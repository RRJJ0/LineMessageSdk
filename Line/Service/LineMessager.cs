using Line.Model;
using Line.Model.Send.Body;
using Line.Model.Send.Message;
using Newtonsoft.Json; 
using System.Net.Http.Headers;
using System.Text; 

namespace Line.Service
{
    public class LineMessager
    {
        private const string lineBaseApi = "https://api.line.me/v2/bot/message";
        private HttpClient client;


        public LineMessager(string channelToken)
        { 
            client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", channelToken);

        }

        public async void Push(List<Message> messages, string to, bool notificationDisabled = false)
        {
            var body = new PushBody()
            {
                messages = messages,
                notificationDisabled = notificationDisabled,
                to = to
            }; 
            var response = await Send(body, BodyType.push);
            Console.WriteLine($"{BodyType.push} Response:  {await response.Content.ReadAsStringAsync()}");
        }

        public async void Multicast(List<Message> messages, List<string> userList,  bool notificationDisabled = false)
        {

            var body = new MulticastBody()
            {
                messages = messages,
                notificationDisabled = notificationDisabled,
                to = userList
            };
            var response = await Send(body, BodyType.multicast);
            Console.WriteLine($"{BodyType.multicast} Response:  {await response.Content.ReadAsStringAsync()}");
        }

        public async void Broadcast(List<Message> messages, bool notificationDisabled = false)
        {
            var body = new Body()
            {
                messages = messages,
                notificationDisabled = notificationDisabled,
            }; 

            var response = await Send(body, BodyType.broadcast);
            Console.WriteLine($"{BodyType.broadcast} Response:  {await response.Content.ReadAsStringAsync()}");
        }

        private async Task<HttpResponseMessage> Send(Body body, string path) 
        {
            var requestMessage = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{lineBaseApi}/{path}"),
                Content = new StringContent(body.ToString(), Encoding.UTF8, "application/json")
            };

            return await client.SendAsync(requestMessage);
        }
    }
}
