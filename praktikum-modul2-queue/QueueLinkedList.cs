/*
 * Created by SharpDevelop.
 * User: Husni Mubarok
 * Date: 02/12/2023
 * Time: 16:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace praktikum_modul2_queue
{
	/// <summary>
	/// Description of QueueLinkedList.
	/// </summary>
	public class QueueLinkedList
    {
        private QueueNode Front;
        // Pointer kedepan queue
        private QueueNode Back;
        // Pointer kebelakang queue

        // Constructor untuk menginisialisasi queue kosong
        public QueueLinkedList()
        {
            Front = Back = null;
        }

        // Cek apakah queue kosong
        public bool IsEmpty()
        {
            return Front == null;
        }

        // Menambahkan elemen ke belakang queue
        public void Enqueue(int data)
        {
            QueueNode newNode = new QueueNode(data);

            // Jika queue kosong, atur front dan back ke 'newNode'
            if (IsEmpty())
            {
                Front = Back = newNode;
            }
            else
            {
                // Sebaliknya, tambahkan node baru ke belakang dan perbarui Back
                Back.Next = newNode;
                Back = Back.Next;
            }
        }

        // Menghapus dan mengembalikan elemen dari depan queue
        public int Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue Masih Kosong");
                return -1;
            }
            else
            {
                int retData = Front.Data;   // Simpan data dari node depan
                Front = Front.Next;         // Pindahkan front ke node berikutnya

                // Jika Front == null, perbarui Back menjadi null juga
                if (Front == null)
                {
                    Back = null;
                }

                return retData;
            }
        }

       // Mengembalikan elemen di depan queue tanpa menghapusnya
        public int First()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue Masih Kosong");
                return -1;
            }
            else
            {
                return Front.Data;  // Return the data of the front node
            }
        }

        // Return the number of elements in the queue
        public int Size()
        {
            int size = -1;
            QueueNode current = Front;

            // Traverse linked list dan hitung jumlah node
            while (current != null)
            {
                size++;
                current = current.Next;
            }

            return size;
        }
    }
}
