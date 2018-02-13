﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceStudentFinal
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        void AddStudent(string navn, string klassenavn, int rum);


        [OperationContract]
        List<Student> FindStudents(string name);


        [OperationContract]
        List<Student> GetAllStudent();


        [OperationContract]
        void RemoveStudent(int telefonKey);


        [OperationContract]
        List<Student> EditStudent(string name);
    }
}
