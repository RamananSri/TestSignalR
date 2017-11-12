using Client.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.ViewModels
{
    class StudentViewModel
    {
        public ObservableCollection<StudentModel> Students { get; set; }

        public void LoadStudents()
        {
            ObservableCollection<StudentModel> students = new ObservableCollection<StudentModel>();

            students.Add(new StudentModel { FirstName = "Hans", LastName = "Hansen"});
            students.Add(new StudentModel { FirstName = "Lars", LastName = "Larsen" });
            students.Add(new StudentModel { FirstName = "Peter", LastName = "Petersen" });

            Students = students;
        }


    }
}
