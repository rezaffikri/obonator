using System;

namespace Obonator.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Library.ObonCryptography.TripleDes.Encrypt("a2934fa2-6f7e-4ac9-8210-681814ac86c4", "rezaffikri:21122112:355651080329676:20200106123013:v1", false);
            Console.WriteLine("Hello World!");
        }
    }
}
