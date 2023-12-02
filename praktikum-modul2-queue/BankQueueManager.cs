/*
 * Created by SharpDevelop.
 * User: Husni Mubarok
 * Date: 02/12/2023
 * Time: 16:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace praktikum_modul2_queue
{
	/// <summary>
	/// Description of BankQueueManager.
	/// </summary>
	public class BankQueueManager
    {
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
                    int tellerQueueNumber = tellerQueue.Size() + 1;
					tellerQueue.Enqueue(tellerQueueNumber);
                    Console.WriteLine("Nomor antrian Teller " + tellerQueueNumber);
                    Console.WriteLine("Tersisa " + tellerQueue.Size() + " antrian lagi.");
                    Console.WriteLine("========================");
                    break;
                case "b":
                    int csQueueNumber = csQueue.Size() + 1;
					csQueue.Enqueue(csQueueNumber);
                    Console.WriteLine("Nomor antrian CS " + csQueueNumber);
                    Console.WriteLine("Tersisa " + csQueue.Size() + " antrian lagi.");
                    Console.WriteLine("========================");
                    break;
                default:
                    Console.WriteLine("Pilihan tidak valid.");
                    Console.WriteLine("========================");
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
                        Console.WriteLine("Panggilan untuk nomor antrian " + tellerQueueNumber + " silakan ke teller.");
                        Console.WriteLine("========================");
                    }
                    else
                    {
                        Console.WriteLine("Antrian Teller sudah kosong.");
                        Console.WriteLine("========================");
                    }
                    break;
                case "b":
                    if (!csQueue.IsEmpty())
                    {
                        int csQueueNumber = csQueue.Dequeue();
                        Console.WriteLine("Panggilan untuk nomor antrian " + csQueueNumber + " silakan ke customer service.");
                        Console.WriteLine("========================");
                    }
                    else
                    {
                        Console.WriteLine("Antrian CS sudah kosong.");
                        Console.WriteLine("========================");
                    }
                    break;
                default:
                    Console.WriteLine("Pilihan tidak valid.");
                    Console.WriteLine("========================");
                    break;
            }
        }
    }
}
