using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class HAAB
    {
        public int tiempo, mes, año;
        public HAAB(int x, String y, int z)
        {
            if (y.Equals("uayet") && x > 4)
            {
                Console.WriteLine("Uayet no tiene mas de 4 dias");
            }else if (x > 19)
            {
                Console.WriteLine("Los meses no puede tener mas de 19 dias");
            }
            else
            {
                mes = Meses(y);
                tiempo = x + mes;
                año = z;

            }
                

        }

        public String Convertir()
        {
            Tzolkin x = new Tzolkin(tiempo);
            return x.Con() + " " + año;
        }

        public int Meses(String x)
        {
            x = x.ToLower();
            if (x.Equals("pop"))
            {
                return (0);
            }
            else
            {
                if (x.Equals("no"))
                {
                    return (20);
                }
                else
                {
                    if (x.Equals("zip"))
                    {
                        return (40);
                    }
                    else
                    {
                        if (x.Equals("zotz"))
                        {
                            return (60);
                        }
                        else
                        {
                            if (x.Equals("tzec"))
                            {
                                return (80);
                            }
                            else
                            {
                                if (x.Equals("xul"))
                                {
                                    return (100);
                                }
                                else
                                {
                                    if (x.Equals("yoxkin"))
                                    {
                                        return (120);
                                    }
                                    else
                                    {
                                        if (x.Equals("mol"))
                                        {
                                            return (140);
                                        }
                                        else
                                        {
                                            if (x.Equals("chen"))
                                            {
                                                return (160);
                                            }
                                            else
                                            {
                                                if (x.Equals("yax"))
                                                {
                                                    return (180);
                                                }
                                                else
                                                {
                                                    if (x.Equals("zac"))
                                                    {
                                                        return (200);
                                                    }
                                                    else
                                                    {
                                                        if (x.Equals("ceh"))
                                                        {
                                                            return (220);
                                                        }
                                                        else
                                                        {
                                                            if (x.Equals("mac"))
                                                            {
                                                                return (240);
                                                            }
                                                            else
                                                            {
                                                                if (x.Equals("kankin"))
                                                                {
                                                                    return (260);
                                                                }
                                                                else
                                                                {
                                                                    if (x.Equals("muan"))
                                                                    {
                                                                        return (280);
                                                                    }
                                                                    else
                                                                    {
                                                                        if (x.Equals("pax"))
                                                                        {
                                                                            return (300);
                                                                        }
                                                                        else
                                                                        {
                                                                            if (x.Equals("koyab"))
                                                                            {
                                                                                return (320);
                                                                            }
                                                                            else
                                                                            {
                                                                                if (x.Equals("cumhu"))
                                                                                {
                                                                                    return (340);
                                                                                }
                                                                                else
                                                                                {
                                                                                    if (x.Equals("uayet"))
                                                                                    {
                                                                                        return (360);
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return 0;
        }
    }
}
