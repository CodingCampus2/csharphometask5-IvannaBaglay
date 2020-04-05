using System;
using System.Dynamic;
using CodingCampusCSharpHomework;
using CodingCampusCSharpHomework.Task1Data;

namespace HomeworkTemplate
{
    class SuperVirus: Task5.Virus
    {
        private readonly Task5 task5;
        public SuperVirus(Task5 task) 
            : base (false)
        {
            task5 = task;
        }
        public override float KillProbability
        {
            get
            {
                float returnKillProbability = task5.KillProbability * 2.0f;
                return (returnKillProbability > 1.0f) ? 1.0f : returnKillProbability;
            }
            set
            {

            }
        }
        public override string Name 
        { 
            get
            {
                string newName = task5.VirusName;
                return newName.Replace("virus", "supervirus");
            }
            set
            {

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
                Task5.Virus virus = new SuperVirus(task);
                return virus;
            };
            Task5.CheckSolver(TaskSolver);
        }
    }
}
