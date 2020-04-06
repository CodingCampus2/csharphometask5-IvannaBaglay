using System;
using System.Dynamic;
using CodingCampusCSharpHomework;
using CodingCampusCSharpHomework.Task1Data;

namespace HomeworkTemplate
{
    class SuperVirus: Task5.Virus
    {
        private float m_KillProbability = 0;
        private string m_Name = "";
        public SuperVirus() 
            : base (false)
        {
        }
        public override float KillProbability
        {
            get => m_KillProbability;
            set
            {
                m_KillProbability = ( 2.0f * value > 1.0f)? 1.0f: 2.0f * value;
            }
        }
        public override string Name 
        {
            get => m_Name;
            set
            {
                m_Name = value.Replace("virus", "supervirus");
            }
        }

        public override string VictimName { get; set; }
        public override DateTime DateTimeOfCreation 
        { 
            get
            {
                DateTime dateTime = DateTime.Now;
                return dateTime;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Func<Task5, Task5.Virus> TaskSolver = task =>
            {
                Task5.Virus virus = new SuperVirus();
                return virus;
            };
            Task5.CheckSolver(TaskSolver);
        }
    }
}
