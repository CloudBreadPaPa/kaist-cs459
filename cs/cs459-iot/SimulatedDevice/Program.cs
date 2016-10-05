using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Azure.Devices.Client;
using Newtonsoft.Json;

namespace SimulatedDevice
{
    class Program
    {
        static DeviceClient deviceClient;
        static string iotHubUri = "something.azure-devices.net";
        static string deviceKey = "generated-device-key";

        private static async void SendDeviceToCloudMessagesAsync()
        {
            //double avgWindSpeed = 10; // m/s
            Random rand = new Random();

            while (true)
            {
                //double currentWindSpeed = avgWindSpeed + rand.NextDouble() * 4 - 2;
                int Temperature = rand.Next(0, 100);
                int Pressure = rand.Next(0, 50);
                int resultYN = 0;
                float prediction = 0;

                var telemetryDataPoint = new
                {
                    deviceId = "Sensor-Real",
                    DateTime.Now,
                    Temperature,
                    Pressure,
                    resultYN,
                    prediction
                };
                var messageString = JsonConvert.SerializeObject(telemetryDataPoint);
                var message = new Message(Encoding.ASCII.GetBytes(messageString));

                await deviceClient.SendEventAsync(message);
                Console.WriteLine("{0} > Sending message: {1}", DateTime.Now, messageString);

                Task.Delay(1000).Wait();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Simulated device\n");
            deviceClient = DeviceClient.Create(iotHubUri, new DeviceAuthenticationWithRegistrySymmetricKey("dw-kaist-device00", deviceKey));

            SendDeviceToCloudMessagesAsync();
            Console.ReadLine();
        }
    }
}
