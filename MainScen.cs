using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class MainScen
    {
        public int problem;
        public Boolean solved;
        public Random rand;

        public MainScen()
        {
            rand = new Random();
            problem = rand.Next(0, 2);             // a random problem to solve the technician
            solved = false;
        }
        public int getProblem()
        {
            return problem;
        }
        public bool problemSolved()
        {
            return solved;
        }
    }
}
