using System;

namespace WindowsFormsApp1
{
    public class MainScen
    {
        private int problem;
        private Boolean solved;
        private Random rand;

        public MainScen()
        {
            rand = new Random();
            problem = rand.Next(0, 13);             // a random problem to solve the technician
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
        public void solveProblem()
        {
            solved = true;
        }
    }
}
