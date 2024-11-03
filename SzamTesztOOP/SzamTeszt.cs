using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzamTesztOOP
{
    internal class SzamTeszt
    {
        private int szam1;
        private int szam2;
        private int eredmeny;

        
        public SzamTeszt() { }

        
        public SzamTeszt(int szam1, int szam2)
        {
            this.szam1 = szam1;
            this.szam2 = szam2;
        }

        
        public void SetSzam1(int szam1)
        {
            this.szam1 = szam1;
        }

        
        public void SetSzam2(int szam2)
        {
            this.szam2 = szam2;
        }

        
        public void SetEredmeny()
        {
            if (szam1 == szam2)
            {
                eredmeny = 0; 
            }
            else if (szam1 > szam2)
            {
                eredmeny = 1; 
            }
            else
            {
                eredmeny = 2; 
            }
        }

        
        public int GetEredmeny()
        {
            return eredmeny;
        }
    }
}
