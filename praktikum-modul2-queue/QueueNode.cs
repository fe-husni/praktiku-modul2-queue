/*
 * Created by SharpDevelop.
 * User: Husni Mubarok
 * Date: 02/12/2023
 * Time: 16:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace praktikum_modul2_queue
{
	/// <summary>
	/// Description of QueueNode.
	/// </summary>
	public class QueueNode
    {
        public int Data;           // Data dari node
        public QueueNode Next;     // Mereferensikan ke node berikutnya dalam queue

        // Constructor untuk menginisialisasi node baru dengan data yang diberikan
        public QueueNode(int data)
        {
            Data = data;
            Next = null;
        }
    }
}
