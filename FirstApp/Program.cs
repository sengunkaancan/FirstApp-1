namespace FirstApp
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            // Ctrl + R + G     (gereksiz usingleri siler)
            // Ctrl + K + D     (kodları düzenler)
            // Ctrl + K + C     (seçili kodları, yorum satırına alır)
            // Ctrl + K + U     (seçili kodları, yorum satırından çıkartır)
            // Ctrl + R + W     (wordwrap)
            // Ctrl + Shift + B (build etme - derleme)


            //Console.WriteLine("Hello World");
            //Console.ReadKey(); // basılan tuşu teslim eder.
            //Console.ReadLine(); // ekrana yazılan değeri teslim eder.


            Console.WriteLine("Lütfen Adınızı  Giriniz : ");
            Console.WriteLine("Giriş yapan kullanıcı : " + Console.ReadLine());
            Console.WriteLine("Lütfen Telefon Numaranızı Giriniz : ");
            Console.WriteLine("Telefon Numaranız : " + Console.ReadLine());
            Console.Read();
        }
    }
} 