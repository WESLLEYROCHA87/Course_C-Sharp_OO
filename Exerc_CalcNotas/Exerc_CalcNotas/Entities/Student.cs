using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_CalcNotas.Entities
{
    class Student
    {
        public string Name;
        public double Note1, Note2, Note3;

        public double FinalNote()
        {
            return Note1 + Note2 + Note3;
        }

        public bool Approved()
        {
            if (FinalNote() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double RemainingNote()
        {
            if (Approved())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - FinalNote();
            }
        }
    }
}
