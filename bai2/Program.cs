using System;
using System.Windows.Forms;

namespace LabEquipmentCheckout
{
    static class Program
    {
        /// <summary>
        /// Điểm khởi chạy chính của ứng dụng Quản lý mượn trả thiết bị.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Khởi chạy Form chính của Bài 2
            Application.Run(new FormLabCheckout());
        }
    }
}