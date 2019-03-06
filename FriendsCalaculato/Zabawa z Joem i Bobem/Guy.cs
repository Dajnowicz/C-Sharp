using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawa_z_Joem_i_Bobem
{
    class Guy
    {
        public string Name;
        public int Cash;
   
    public int GiveCash(int amount)
    {
        if (Cash >= amount && Cash >0)
        {
            Cash -= amount;
            return amount;
        }
        else
        {
            System.Windows.MessageBox.Show(Name + " powiedział ze nie ma wystarczajacych srodkow aby dac " + amount);
                return 0;
        }
    }
    public int GetCash (int amount)
        {
            Cash += amount;
            return amount;
        }
}
}
