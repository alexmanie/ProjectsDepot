using System;
using Amazon.Runtime;
using Amazon.SQS;
using Amazon.SQS.Model;

namespace AWSQueueSend
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            try
            {
				string myQueueURL = "https://sqs.eu-west-1.amazonaws.com/028670304332/etiquetaworten-create";

				//AmazonSQSConfig sqsConfig = new AmazonSQSConfig();
				//sqsConfig.ServiceURL = "http://sqs.eu-west-1.amazonaws.com";

				Environment.SetEnvironmentVariable("AWS_ACCESS_KEY_ID", "<KEY_ID>");
				Environment.SetEnvironmentVariable("AWS_SECRET_ACCESS_KEY", "<ACCESS_KEY>");
				Environment.SetEnvironmentVariable("AWS_REGION", "eu-west-1");

                var x = new EnvironmentVariablesAWSCredentials();
                AmazonSQSClient sqsClient = new AmazonSQSClient(x);

				SendMessageRequest sendMessageRequest = new SendMessageRequest();
				sendMessageRequest.QueueUrl = myQueueURL;
				sendMessageRequest.MessageBody = "Hello World!";

                SendMessageResponse sendMessageResponse = sqsClient.SendMessage(sendMessageRequest);

                if (sendMessageResponse.HttpStatusCode.Equals(System.Net.HttpStatusCode.OK))
                {
                    // custom logic on success
                }
                else
                {
                    // custom logic on Error
                }
			
                Console.WriteLine(sendMessageResponse.HttpStatusCode);
			}
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
