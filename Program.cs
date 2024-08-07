using System;

namespace HelloName 
{
    class Program
    {
        static void Main(string[] args)
        {
            // Yêu cầu người dùng nhập tên
            Console.WriteLine("Enter your name: ");
            
            // Đọc tên từ bàn phím
            string yourName = Console.ReadLine();
            
            // Hiển thị lời chào kèm tên
            Console.WriteLine("Hello: " + yourName);
        }
    }
}