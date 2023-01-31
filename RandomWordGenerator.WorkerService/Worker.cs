using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RandomWordGenerator.WorkerService
{
    public class Worker : BackgroundService
    {

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                Console.WriteLine($"Date time now: {DateTime.Now.ToLongTimeString()}");
                var response = CreateWord();
                Console.WriteLine(response);

                await Task.Delay(4*1000, stoppingToken);
            }
        }
        public string CreateWord()
        {
            string wordTotal = "";
            char[] lowerCase = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] upperCase = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            ArrayList word = new ArrayList();
            Random rnd = new Random();
            int firstLetterIndex = rnd.Next(0, 2);
            if (firstLetterIndex == 0)
            {
                for (int i = 0; i < 5; i++)
                {
                    word.Add(lowerCase[rnd.Next(0, 28)]);
                    word.Add(upperCase[rnd.Next(0, 28)]);
                }

            }
            else if (firstLetterIndex == 1)
            {
                for (int i = 0; i < 5; i++)
                {
                    word.Add(upperCase[rnd.Next(0, 28)]);
                    word.Add(lowerCase[rnd.Next(0, 28)]);
                }
            }
            for (int i = 0; i < word.Count; i++)
            {
                wordTotal = wordTotal + word[i];
            }
            return wordTotal;
        }
    }
}
