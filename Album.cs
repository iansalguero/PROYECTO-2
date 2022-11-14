using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto2_Album
{
    class Album
    {
        static string[] CodigosEspeciales = new string[] { "FWC" };

        static int InicioEspeciales = 0;
        static int FinEspeciales = 30;

        static string[] CodigosSelecciones = new string[] {
            "QAT","ECU","SEN","NED",
            "ENG","IRN","USA","WAL",
            "ARG","KSA","MEX","POL",
            "FRA","AUS","DEN","TUN",
            "ESP","CRC","GER","JPN",
            "BEL","CAN","MAR","CRO",
            "BRA","SRB","SUI","CMR",
            "POR","GHA","URU","KOR"
        };

        static int InicioSelecciones = 1;
        static int FinSelecciones = 20;

        public int TotalEstampas;
        public Estampa[] estampas;

        public Album()
        {
           TotalEstampas = (FinEspeciales - InicioEspeciales) * CodigosEspeciales.Length + (FinSelecciones - InicioSelecciones) * CodigosSelecciones.Length;
            estampas = new Estampa[TotalEstampas];

        int cont = 0;
            for (int i = 0; i < CodigosEspeciales.Length; i++)
            {
                for (int j = InicioEspeciales; j < FinEspeciales; j++)
                {
                    estampas[cont] = new Estampa(CodigosEspeciales[i], j);
                    cont++;
                }
            }

            for (int i = 0; i < CodigosSelecciones.Length; i++)
            {
                for (int j = InicioSelecciones; j < FinSelecciones; j++)
                {
                    estampas[cont] = new Estampa(CodigosSelecciones[i], j);
                    cont++;
                }
            }
        }

        public void Mostrar()
        {
            for (int i = 0; i < TotalEstampas; i++)
            {
                if (estampas[i].Estado > 0)
                {
                    if (estampas[i].Estado == 1)
                    {
                        Console.WriteLine("La estampa " + estampas[i].Codigo + " = ENCONTRADA");
                    }
                    else
                    {
                        Console.WriteLine("La estampa " + estampas[i].Codigo + " = REPETIDA");
                    }
                }
                else
                {
                    Console.WriteLine("La estampa " + estampas[i].Codigo + " = FALTANTE");
                }
            }
        }

        public void Mostrar_Estado(int UnEstado)
        {
            int Cantidad = 0;
            for (int i = 0; i < TotalEstampas; i++)
            {
                if (estampas[i].Estado == UnEstado)
                {
                    Console.WriteLine(estampas[i].Codigo);
                    Cantidad++;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("En total son " + Cantidad);
        }
        public void Mostrar_Categoria(string unCategoria, int UnEstado)
        {
            int Cantidad = 0;
            for (int i = 0; i < TotalEstampas; i++)
            {
                if (estampas[i].Categoria == unCategoria && estampas[i].Estado == UnEstado)
                {
                     Console.WriteLine(estampas[i].Codigo);
                    Cantidad++;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("En total son " + Cantidad);
        }

        public void Mostrar_Rango(string inicioCodigo, string finCodigo, int UnEstado)
        {
            int Cantidad = 0;
            bool verificador = true;
            int i = 0;
            while (verificador == true)
            {
                if (estampas[i].Codigo == inicioCodigo)
                {
                    while (estampas[i].Codigo != finCodigo)
                    {
                        if (estampas[i].Estado == UnEstado) {
                            Console.WriteLine(estampas[i].Codigo);
                            Cantidad++;
                        }
                        i++;
                    }
                    if (estampas[i].Estado == UnEstado)
                    {
                        Console.WriteLine(estampas[i].Codigo);
                        Cantidad++;
                    }
                    verificador = false;
                }
                else
                {
                    i++;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("En total son " + Cantidad);
        }

        public void cambiar_estado(string UnCodigo, int UnEstado)
        {
            for(int i = 0; i < TotalEstampas; i++)
            {
                if (estampas[i].Codigo == UnCodigo)
                {
                    estampas[i].Estado = UnEstado;
                }
            }
        }
    }
}
