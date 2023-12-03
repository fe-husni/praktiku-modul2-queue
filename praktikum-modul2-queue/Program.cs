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
        
        public class BankQueueManager
	{
            // Variabel static untuk menyimpan Nomor antrian Teller & CS
            // yang nantinya akan di increment agar nomor antrian yang sudah diambil tidak dapat diambil kembali
	    private static int tellerQueueNumber = 1;
            private static int csQueueNumber = 1;
	
	    private QueueLinkedList tellerQueue;
            private QueueLinkedList csQueue;
	
	    public BankQueueManager()
	    {
                tellerQueue = new QueueLinkedList();
	        csQueue = new QueueLinkedList();
	    }
	
	    public void TakeQueue()
	    {
                Console.WriteLine("===================");
                Console.WriteLine("Menu ambil antrian:");
                Console.WriteLine("a. Antrian Teller");
                Console.WriteLine("b. Antrian CS");
                Console.Write("Pilih antrian: ");
                string input = Console.ReadLine();
                Console.WriteLine();
	
                switch (input.ToLower())
                {
                    case "a":
                        tellerQueue.Enqueue(tellerQueueNumber);
                        Console.WriteLine("Nomor antrian Teller T-" + tellerQueueNumber);
                        Console.WriteLine("Tersisa " + tellerQueue.Size() + " antrian lagi.");
                        tellerQueueNumber++; //Increment nomor antrian Teller agar tidak mengulang nomor antrian yang sama
                        Console.Write("Press any key to continue . . . ");
                        Console.ReadKey(true);
                        Console.Clear();
                        break;
                    case "b":
	                csQueue.Enqueue(csQueueNumber);
	                Console.WriteLine("Nomor antrian CS CS-" + csQueueNumber);
	                Console.WriteLine("Tersisa " + csQueue.Size() + " antrian lagi.");
	                csQueueNumber++; //Increment nomor antrian CS agar tidak mengulang nomor antrian yang sama
	                Console.Write("Press any key to continue . . . ");
	                Console.ReadKey(true);
	                Console.Clear();
	                break;
	            default:
	                Console.WriteLine("Pilihan tidak valid.");
	                Console.Write("Press any key to continue . . . ");
	                Console.ReadKey(true);
	                Console.Clear();
	                break;
	        }
	    }
	
	    public void CallQueue()
	    {
	        Console.WriteLine("=====================");
	        Console.WriteLine("Menu panggil antrian:");
	        Console.WriteLine("a. Antrian Teller");
	        Console.WriteLine("b. Antrian CS");
	        Console.Write("Pilih antrian: ");
	        string input = Console.ReadLine();
	        Console.WriteLine();
	
	        switch (input.ToLower())
	        {
	            case "a":
	                if (!tellerQueue.IsEmpty())
	                {
	                    int tellerQueueNumber = tellerQueue.Dequeue();
	                    Console.WriteLine("Panggilan untuk nomor antrian T-" + tellerQueueNumber + " silakan ke teller.");
	                    Console.Write("Press any key to continue . . . ");
	                    Console.ReadKey(true);
	                    Console.Clear();
	                }
	                else
	                {
	                    Console.WriteLine("Antrian Teller sudah kosong.");
	                    Console.Write("Press any key to continue . . . ");
	                    Console.ReadKey(true);
	                    Console.Clear();
	                }
	                break;
	            case "b":
	                if (!csQueue.IsEmpty())
	                {
	                    int csQueueNumber = csQueue.Dequeue();
	                    Console.WriteLine("Panggilan untuk nomor antrian CS-" + csQueueNumber + " silakan ke customer service.");
	                    Console.Write("Press any key to continue . . . ");
	                    Console.ReadKey(true);
	                    Console.Clear();
	                }
	                else
	                {
	                    Console.WriteLine("Antrian CS sudah kosong.");
	                    Console.Write("Press any key to continue . . . ");
	                    Console.ReadKey(true);
	                    Console.Clear();
	                }
	                break;
	            default:
	                    Console.WriteLine("Pilihan tidak valid.");
	                    Console.Write("Press any key to continue . . . ");
	                    Console.ReadKey(true);
	                    Console.Clear();
	                    break;
	        }
	    }
	}
    }
}
