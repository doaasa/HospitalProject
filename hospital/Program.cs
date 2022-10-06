using hospital.Models;
using System;
using System.Linq;
using System.Collections.Generic;

namespace hospital
{
    class Program
    {
        static void Main(string[] args)
        {

            HospitalContext HC = new HospitalContext();
            var list = HC.Doctors.ToList();
            var ans = from li in list
                      select li.Lname;


            //foreach(var item in HC.Doctors)
            //{
            //    Console.WriteLine(item.Fname);
            //}
            //foreach (var item in ans)
            //{
            //    Console.WriteLine(item);
            //}

            //  var ans2 = list.OrderByDescending(s=> s.Salary).OrderBy(s=>s.Fname).ToList();


            //var ans2 = list.OrderByDescending(s => s.Salary).Take(2).ToList();
            //int i = 0;
            IEnumerable<IGrouping<double?,Doctor>> ans2 = list.OrderBy(s => s.Salary).GroupBy(s => s.Salary).ToList();

            //foreach (var item in ans2)
            //{
            //    Console.WriteLine(item.Key);
              
            //    foreach(var s in item)
            //    {
            //        Console.WriteLine(s.Fname);
            //    }
            //}

            var list2 = HC.Patients.ToList();
            var patient = from s in list
                          join x in list2
                          on s.Ssn equals x.DocSsn
                          select new
                          {
                              patientname = x.Fname,
                              Doctorname = s.Fname
                          };
            var p = list2.Join(list, pa => pa.DocSsn, doc => doc.Ssn, (doc, pa) => new
            {
                patientname =pa.Fname,
                Doctorname = doc.Fname
            });

            foreach(var item in patient)
            {
                Console.WriteLine("PatientName = {0}",item.patientname);
                Console.WriteLine("DoctorName = {0}", item.Doctorname);
                
            }


        }
    }
}
