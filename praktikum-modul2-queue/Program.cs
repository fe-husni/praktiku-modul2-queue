/*
 * Created by SharpDevelop.
 * User: Husni Mubarok
 * Date: 02/12/2023
 * Time: 16:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace praktikum_modul2_queue
{
	class Program
    {
        static void Main(string[] args)
        {
            BankQueueManager queueManager = new BankQueueManager();

            while (true)
            {
            	Console.WriteLine("=====================");
                Console.WriteLine("Menu utama:");
                Console.WriteLine("1. Ambil Antrian");
                Console.WriteLine("2. Panggil Antrian");
                Console.WriteLine("3. Keluar aplikasi");
                Console.Write("Pilih menu: ");
                string input = Console.ReadLine();
                Console.WriteLine();

                switch (input.ToLower())
                {
                    case "1":
                        queueManager.TakeQueue();
                        break;
                    case "2":
                        queueManager.CallQueue();
                        break;
                    case "3":
                        Console.WriteLine("Sampai jumpa!");
                        Console.Write("Press any key to continue . . . ");
						Console.ReadKey(true);
						return;
                    default:
                        Console.WriteLine("Pilihan tidak valid.");
                        break;
                }
            }
        }
    }
}