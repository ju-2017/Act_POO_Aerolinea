# Act_POO_Aerolinea

using System;

namespace Aerolinea
{
    class Operaciones
    {

        //Atributos (Propiedades)

        public string pais_num { set; };
        public string pais_num2 { set; };
        public string pais_num3 { set; };

        public int viajeros_frecuentes { set; };

        public long costo_tiquetes = { set; };

        public int capacidad_aviones = { set; };

        public int numero_empleados = { set; };
        public long sueldo = { set;};

        public string Nombre = { get; set;};
        public int edad_ = { get; set; };
        public int vecesviaj = { get; set;};


        public void pais(string usa, string mex, string esp){

            string pdest = usa,mex,esp;

            Console.WriteLine($"paises a los que llega la aerolinea y los mas visitados: {pdest}");

        
        }

        public void frecuentes_via(int viafre){

            int resultadoviafre =  viafre;

            Console.WriteLine($"Tiene al siguiente numero de viajeros frecuentes: {resultadoviafre}");
   
        }

        public void tiquete(long tiq){

            long resultiq = tiq;

            Console.WriteLine($"Es una aerolinea economica con costo de: {resultiq} por persona");
        }

        public void capaviones(int cavi){

            int resultcavi = cavi;

            Console.WriteLine($"Los aviones tienen una capacidad de:" + {resultcavi} + "sillas");


        }

        public void numempleados(int empl, long salr){

            int resultemple = empl;
            long resultsueldo = salr;

            Console.WriteLine($"La Aerolinea tiene aproximadamente: {resultademple} empleados y su salario es {resultsueldo}");
        }

        public void sistemadeviaje(string nom, int ed, int vreali){

            string resultnom = nom;
            int resulted = ed;
            int resultvreali = vreali;

            int parametro = 18;
            int parametro2 = 10;

            if(edad >= parametro)
            {
                Console.WriteLine($"Tienes una edad adecuada para viajar");

                if(numviajes>= parametro2 )
                {
                    System.Console.WriteLine($"Tienes un descuento del 40%");
               
                    System.Console.WriteLine($"El tiquete te queda en este valor: 1.920.000");
                }
                else
                {
                   System.Console.WriteLine($"Te falta cumplir el numero de viajes para adquirir el descuento");
                }
               
             }
            else
            {
                System.Console.WriteLine($"No tienes descuentos en tu tiquete");
            }
        }

            Console.WriteLine("elija el paquete que mas le gusta");
            System.Console.WriteLine(" paquete 1. Mexico y USA 20% de descuento");
            System.Console.WriteLine("paquete 2. USA Y Espana 10% de descuento");

            int opcion = Convert.ToInt32(Console.ReadLine());

           

            switch (opcion)
            {
                case (1):

                System.Console.WriteLine("El paquete 1 te queda en: 2.560.000");
                break;

                case (2):

                System.Console.WriteLine("El paquete 2 te queda en: 2.880.000");
                break;

                default:
                System.Console.WriteLine("La opcion no esta habilitada aun");
                break;

                
            }



        





        //Funciones (Metodos)

        






    }

}
