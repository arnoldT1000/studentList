using studentList.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace studentList.ViewModel
{
    public class StudentViewModel
    {
        // We are using ObservableCollection because:
        // When an object is added to or removed from an observable collection, the UI is automatically updated.
        private List<Student> items;
        public List<Student> Items
        {
            get { return items; }
            set
            {
                items = value;
            }
        }

        public StudentViewModel()
        {

            // Here you can have your data form db or something else,
            // some data that you already have to put in the list
            
            List<Student> unsortStudents=new List<Student>() {new Student()
                {
                    studentId = 1,
                    Name = "Kate Beckinsale",
                    Age = 35
                },
                  new Student()
                {
                    studentId = 2,
                    Name = "Maria Ho",
                    Age = 31
                },
                  new Student()
                {
                    studentId = 3,
                    Name = "Gal Gadot",
                    Age = 32
                }, };
            List<Student> sortedStudents = unsortStudents.OrderBy(Student => Student.Name).ToList();
            Items = sortedStudents;
        }
    }
}


