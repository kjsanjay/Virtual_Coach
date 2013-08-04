using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Virtual_Coach
{
    public class Prescription
    {
        public List<PrescribedExercise> prescription = null;

        public Prescription()
        {
            prescription = new List<PrescribedExercise>();
        }

        public void add(PrescribedExercise pe)
        {
            prescription.Add(pe);
        }

        public int size()
        {
            return prescription.Count();
        }

        public PrescribedExercise getExerciseAtLocation(int location)
        {
            return prescription.ElementAt(location);
        } 
    }
}
