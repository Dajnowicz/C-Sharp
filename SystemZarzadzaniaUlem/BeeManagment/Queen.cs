using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeManagment
{
    class Queen : Bee
    {
        private Worker[] workers;
        private int ShiftNumber;

        public Queen(Worker[] workers, double weightMg)
            : base (weightMg)
        {
            this.workers = workers;
        }

        public bool AssignWork(string workToDo, int NumberOfSifts)
        {
            for (int i=0; i<workers.Length; i++)
            {
                if (workers[i].DoThisJob(workToDo,NumberOfSifts))
                {
                    return true;
                }
            }
            return false;
        }

        public string WorkTheNextShift()
        {
            double HoneyConsumend = HoneyConsumptionRate();
            ShiftNumber++;
            string raport = "Raport zmiany numer " + ShiftNumber + "\r\n";
            for (int i = 0; i<workers.Length; i++)
            {
                if (workers[i].DidYouFinish())
                {
                    raport += "Robotnica numer " + (i + 1) + "wlasnie zakonczyla swoje zadanie " + "\r\n";
                }
                if (workers[i].DidYouFinish() == false && String.IsNullOrEmpty(workers[i].CurrentJob))
                {
                    raport += "Robotnica numer " + (i + 1) + " nie pracuje" + "\r\n";
                }
                else
                {
                    if (workers[i].ShiftsLeft > 0)
                    {
                        raport += "Robotnica numer " + (i + 1) + " zajmuje sie " + workers[i].CurrentJob + " jeszcze przez " + workers[i].ShiftsLeft + " zmiany" + "\r\n";
                    }
                    else
                    {
                        raport += "Robotnica numer " + (i + 1) + " zakonczy " + workers[i].CurrentJob + " po tej zmianie" + "\r\n";
                    }
                }
                HoneyConsumend += workers[i].HoneyConsumptionRate();
                
            }
            raport += "calkowite zuzycie miodu : " + HoneyConsumend + " jednostek";
            
            return raport;
        }
    }
}
