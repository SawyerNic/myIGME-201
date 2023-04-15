using PeopleAppGlobals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseList
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Globals.AddCoursesSampleData();
            Globals.AddPeopleSampleData();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CourseListForm editCourseListForm = new CourseListForm();
            Application.Run(editCourseListForm);
        }
    }
}
