using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Class1
    {
        int Score1;
        string name;

        public Class1(int score1, string name)
        {
            Score1 = score1;
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }
        public int Getscore()
        {
            return Score1;
        }


    }
    
}
