using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceStudentFinal
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private List<Student> _list = new List<Student>();
        public Service1()
        {
            Student student1 = new Student("Jonas", "F3", 3);
            Student student2 = new Student("kasper", "F3", 5);
            Student student3 = new Student("Ian", "F3", 3);
        }

        public void AddStudent(string navn, string klassenavn, int rum)
        {
            _list.Add(new Student(navn, klassenavn, rum));
        }

        public Student FindStudents(string name)
        {
            Student FoundStudent = _list.Find(x => x.Name.Equals(name));

            return FoundStudent;
        }

        public List<Student> GetAllStudent()
        {
            return _list;
        }

        public void RemoveStudent(string navn)
        {
            _list.Remove(FindStudents(navn));
        }

        public void EditStudent(string navn, string klassenavn, int rum)
        {
            RemoveStudent(navn);
            AddStudent(navn, klassenavn, rum);

        }
    }
}
