using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Virtual_Coach
{
    public class Patient
    {
        public string patient_name = "";
        public string doctor_name= "";
        public Prescription patient_prescription = null;
        //public List<Prescription> past_prescriptions;

        public Patient(string pname, string dname, Prescription p)
        {
            patient_name = pname;
            doctor_name = dname;
            patient_prescription = p;
        }
    }
}
