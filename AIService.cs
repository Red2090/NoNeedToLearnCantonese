using System;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace NoNeedToLearnCantonese
{
    public class AIService
    {
        private string apiKey;
        private string baseUrl;
        private string targetLanguage;
        private string content;
        private string modelName;

        public AIService(string modelName, string apiKey, string apiUrl, string targetLanguage, string content)
        {
            this.modelName = modelName;
            this.apiKey = apiKey;
            this.targetLanguage = targetLanguage;
            this.content = content.Trim();
            baseUrl = apiUrl;
        }

        public string AskAI()
        {
            if (string.IsNullOrEmpty(content))
            {
                return null;
            }

            // 使用对象构建请求体（自动处理转义）
            var requestBody = new
            {
                model = modelName,
                messages = new[]
                {
                    new
                    {
                        role = "system",
                        content = $"你是一个多语言翻译助手，请你将给定的语言翻译成{targetLanguage}，要遵循原句的标点符号。你只需要返回翻译后的句子，不需要返回其他内容。"
                    },
                    new
                    {
                        role = "user",
                        content = content
                    }
                },
                temperature = 0.3
            };

            // 序列化为 JSON（自动处理转义）
            string jsonData = JsonConvert.SerializeObject(requestBody);

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");
                client.DefaultRequestHeaders.Add("Accept", "application/json");

                StringContent httpContent = new StringContent(jsonData, Encoding.UTF8, "application/json");

                try
                {
                    HttpResponseMessage response = client.PostAsync(baseUrl, httpContent).Result;
                    response.EnsureSuccessStatusCode();

                    string responseBody = response.Content.ReadAsStringAsync().Result;
                    return ExtractContent(responseBody);
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine($"Request error: {e.Message}");
                    return e.Message;
                }
            }
        }

        public string ExtractContent(string jsonResponse)
        {
            try
            {
                JObject parsedResponse = JObject.Parse(jsonResponse);
                return (string)parsedResponse["choices"][0]["message"]["content"];
            }
            catch (Exception ex)
            {
                Console.WriteLine("解析错误: " + ex.Message);
                return null;
            }
        }
    }
}
