using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Tzolkin
    {
        int i = 1, k = 1, par;
        String[,] dia;
        public Tzolkin(int x)
        {
            dia = new String[x, 2];
            par = x;
        }
        public String Con()
        {
            for (int j = 0; j < par; j++)
            {
                if (k == 14)
                {
                    k = 1;
                }
                dia[j, 0] = "" + (k);
                dia[j, 1] = meses();
                k++;
            }
            if(par <= 0)
            {
                return dia[par, 0] + " " + dia[par, 1];
            }
            else
            {
                return dia[par - 1, 0] + " " + dia[par - 1, 1];

            }
        }

        public String meses()
        {
            switch (i)
            {
                case 1:
                    i++;
                    return "imix";
     
                case 2:
                    i++;
                    return "ik";
               
                case 3:
                    i++;
                    return "akbal";
          
                case 4:
                    i++;
                    return "kan";
             
                case 5:
                    i++;
                    return "chicchan";
          
                case 6:
                    i++;
                    return "cimi";
  
                case 7:
                    i++;
                    return "manik";
     
                case 8:
                    i++;
                    return "lamat";
          
                case 9:
                    i++;
                    return "muluk";
            
                case 10:
                    i++;
                    return "ok";
         
                case 11:
                    i++;
                    return "chuen";
          
                case 12:
                    i++;
                    return "eb";
             
                case 13:
                    i++;
                    return "ben";
           
                case 14:
                    i++;
                    return "ix";
             
                case 15:
                    i++;
                    return "mem";
        
                case 16:
                    i++;
                    return "cib";
      
                case 17:
                    i++;
                    return "caban";
    
                case 18:
                    i++;
                    return "eznab";
      
                case 19:
                    i++;
                    return "canac";
     
                case 20:
                    i=1;
                    return "ahau ";
     
            }
            return null;
        }
    }
}
