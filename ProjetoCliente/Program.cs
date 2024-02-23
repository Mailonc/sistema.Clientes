using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Globalization;
using System.Reflection.PortableExecutable;

namespace ProjetoCliente {
    internal class Program {
        static void Main(string[] args) {

            int gasolina = 0;
            int alcool = 0;
            int disel = 0;

            int tipo = int.Parse(Console.ReadLine());

            while (tipo != 4) {
                if (tipo == 1) {
                    alcool = alcool + 1;
                }
                else if (tipo == 2) {
                    gasolina = gasolina + 1;
                }
                else if (tipo == 3) {
                    disel = disel + 1;

                }
                tipo = int.Parse((Console.ReadLine()));
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Disel: " + disel);


        } 

        }
    }

