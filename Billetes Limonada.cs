using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructuras_dinámicas_líneales___Luis_Borrayo
{
    public class Billetes_Limonada
    {
        public static bool PuestoLimonada (int[] cambios)
        {
            int Billete5 = 0;
            int Billete10 = 0;

            foreach (int cambio in cambios)
            {
                if (cambio == 5) 
                { 
                    Billete5++;
                }
                else if (cambio == 10)
                    {
                        if (Billete5 == 0)
                            return false;
                        Billete5--;
                        Billete10++;
                            
                    }
                else if (cambio == 20)
                {
                    if (Billete10 > 0 && Billete5 > 0)
                    {
                        Billete10--;
                        Billete5--;
                    }
                    else if (Billete5 >= 3)
                    {
                        Billete5 -= 3;
                    }
                    else { return false; }
                }
                
            }
            return true;
        }
    }
}
