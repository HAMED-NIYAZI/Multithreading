namespace TaskAsync
{
    internal class Program
    {
        static  void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            //  CallProcess();
            // Console.WriteLine("Main Ends");
            //Console.ReadKey();

            var x = CallProcessNormal();
            Console.WriteLine(x);
            Console.WriteLine("Main Ends");
            Console.ReadKey();
        }

        public static async void CallProcess()
        {
            await LongProcess();
            Console.WriteLine("Long Process finish");
        }

        public static Task LongProcess()
        {
            return Task.Run(() =>
            {
                //System.Threading.Thread.Sleep(5000);
                // Task.Delay(5000);
                for (int i = 0; i < 800; i++)
                {
                    Console.WriteLine($"------------{i}");
                }
            });
        }



        public static async Task<string> CallProcessNormal()
        {
            var r = await LongProcessNormal();
            Console.WriteLine($"Long Process finish {r}");
            return $"return :Long Process finish {r}";
        }
        public static    Task<bool> LongProcessNormal()
        {

            //System.Threading.Thread.Sleep(5000);
            // Task.Delay(5000);

            return Task.Run(() => {
                for (int i = 0; i < 800; i++)
                {
                    Console.WriteLine($"------------{i}");
                }

                return true;
            });

           
        }
    }
}