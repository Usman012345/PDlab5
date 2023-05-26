using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task4.Student_;

namespace task4.Student_
{
    class DegreeProgram
    {
        public string degreeName;
        public float degreeDuration;
        public int totalcredithours = 0;
        public int seats;
        public DegreeProgram(string degreeName, float degreeDuration, int seats,int totalcredithours)
        {
            this.degreeName = degreeName;
            this.degreeDuration = degreeDuration;
            this.seats = seats;
            this.totalcredithours = totalcredithours;
        }
        public DegreeProgram()
        {

        }
        public bool calculateCreditHours(int credithours)
        {
            if (this.totalcredithours + credithours > 20)
            { 
                return false;
            }

            return true;
            
        }
      
    }
}
