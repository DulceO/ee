using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicación_serie_IV
{
    class Program
    {
        static void Main(string[] args)
        {
            double salmin = 0;
            char op = 's';
            int OP;
            double DescEm;
            double CuotaP;
            double CuotaL;
            double Sueldo;
            

            while (op!='n')
            {
                Console.WriteLine("Ingrese su salario minímo: ");
                salmin = double.Parse(Console.ReadLine());

                Console.WriteLine("Trabaja en una identidad lucrativa: n1./ Si n2./ No");
                OP = int.Parse(Console.ReadLine());
                if (OP == 1)
                {
                    int o;
                    Console.Clear();
                    Console.WriteLine("Tiene otro descuento de la empresa: n1./ Si n2./ No");
                    o = int.Parse(Console.ReadLine());

                    if(o==1)
                    {
                        
                        Console.WriteLine("Ingrese el valor del descuento de la empresa: ");
                        DescEm = double.Parse(Console.ReadLine());
                        DescEm = DescEm / 100;
                        CuotaP = salmin * 0.1267;
                        CuotaL = salmin * 0.0483;
                        Sueldo = salmin - CuotaP - CuotaL - DescEm;
                        Console.WriteLine("El sueldo del trabajador es: " + Math.Round(Sueldo, 2));
                    }
                    else if(o==2)
                    {
                        CuotaP = salmin * 0.1267;
                        CuotaL = salmin * 0.0483;
                        Sueldo = salmin - CuotaP - CuotaL;
                        Console.WriteLine("El sueldo del trabajador es: " + Math.Round(Sueldo, 2));

                    }
                    

                }
                else if(OP==2)
                {
                    int o;
                    Console.Clear();
                    Console.WriteLine("Tiene otro descuento de la empresa: n1./ Si n2./ No");
                    o = int.Parse(Console.ReadLine());

                    if (o == 1)
                    {

                        Console.WriteLine("Ingrese el valor del descuento de la empresa: ");
                        DescEm = double.Parse(Console.ReadLine());
                        DescEm = DescEm / 100;
                        CuotaP = salmin * 0.1167;
                        CuotaL = salmin * 0.0483;
                        Sueldo = salmin - CuotaP - CuotaL - DescEm;
                        Console.WriteLine("El sueldo del trabajador es: " + Math.Round(Sueldo, 2));
                    }
                    else if (o == 2)
                    {
                        CuotaP = salmin * 0.1167;
                        CuotaL = salmin * 0.0483;
                        Sueldo = salmin - CuotaP - CuotaL;
                        Console.WriteLine("El sueldo del trabajador es: " + Math.Round(Sueldo, 2));

                    }

                }
                Console.WriteLine("Desea ingresar otro trabajador: [s/n]");
                op = char.Parse(Console.ReadLine());
                Console.Clear();
            }

        }
    }
}
