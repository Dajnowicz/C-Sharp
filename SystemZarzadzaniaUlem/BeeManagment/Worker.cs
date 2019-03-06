using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeManagment
{
    class Worker : Bee
    {
        private string[] jobsICanDo;
        private int shiftsToWork;
        private int shiftsWorked;
        public int ShiftsLeft{ get { return shiftsToWork - shiftsWorked; } }

        private string currentJob = "";

        public string CurrentJob { get { return currentJob; } }

        public Worker(string[] jobsICanDo, double weightMg)
            : base (weightMg)
        {
            this.jobsICanDo = jobsICanDo;
        }

        const double HoneyUnitsConsumenedPerShift = .65;

            public override double HoneyConsumptionRate()
        {

            double consumption = base.HoneyConsumptionRate() * .65;
            consumption = shiftsWorked * HoneyUnitsConsumenedPerShift;
            return consumption;
        }

        public bool DoThisJob(string Job, int Shift)
        {
            if (!String.IsNullOrEmpty(CurrentJob))
            {
                return false;
            }
            else
                for (int i = 0; i < jobsICanDo.Length; i++)
                {
                    if (jobsICanDo[i] == Job)
                    {
                        currentJob = Job;
                        this.shiftsToWork = Shift;
                        shiftsWorked = 0;
                        return true;
                    }
                }
            return false;

        }
        public bool DidYouFinish()
        {
            if (string.IsNullOrEmpty(currentJob))
            {
                return false;
            }
            shiftsWorked++;
            if (shiftsWorked > shiftsToWork)
            {
                shiftsWorked = 0;
                shiftsToWork = 0;
                currentJob = "";
                return true;
            }
            else
                return false;
        }
    }
}
