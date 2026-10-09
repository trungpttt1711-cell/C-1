using System;
using System.Windows.Forms;
using StudentSubjectManagement;

namespace StudentManagement.WinForms
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new StudentManagementForm());
        }
    }
}