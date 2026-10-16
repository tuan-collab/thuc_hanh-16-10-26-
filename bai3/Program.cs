using System;
using System.Windows.Forms;

namespace RepairServiceTracker
{
    static class Program
    {
        /// <summary>
        /// Điểm khởi chạy chính của ứng dụng Quản lý đơn sửa chữa.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Khởi chạy Form chính của Bài 3
            Application.Run(new FormRepairTracker());
        }
    }
}