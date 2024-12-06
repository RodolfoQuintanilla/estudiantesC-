using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gestión_de_Estudiantes
{
    internal class Gestion

    {
        String[] nombres;
        float[] cali;


        public void Inicio()
        {

            int opcion = 0;
            do
            {
              
                Console.WriteLine("Menú:");
                Console.WriteLine("1. Iniciar Programa");
                Console.WriteLine("2. Salir");

                 opcion = int.Parse(Console.ReadLine());

             
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Inicio de programa");
                        IngresarDatos();
                        break;
                    case 2:
                       
                        Console.WriteLine("salir");
                        break;
                      
                }
            } while (opcion!=2); 
        }


       public void IngresarDatos()
        {
            Console.WriteLine("Ingresa el Numero de estudiantes: ");  
            String puente = Console.ReadLine();
            int num = int.Parse(puente);

            nombres = new String[num];
            cali = new float[num];

            for (int i = 0; i < cali.Length; i++)
            {
                Console.WriteLine("Ingresa el nombre del estudiante: ");
                nombres[i]= Console.ReadLine();
                Console.WriteLine("Ingresa la Calificacion: ");
                String paso = Console.ReadLine();
                cali[i] = float.Parse(paso);
            }
            CalculosBasicos();
        }

        public void CalculosBasicos() 
        {
            float calificacion = 0;
            for (int i = 0; i < cali.Length; i++) 
            { 
                calificacion += cali[i];
            }

            float resultado = calificacion / cali.Length;

            Console.WriteLine("El promedio de los estudiantes es: " + resultado);
            Calificaciones();
        }


        public void Calificaciones() 
        {
            float mayor = cali[0];
            int pos = 0;

            float baja = cali[0];
            int pis = 0;

            for (int i = 0; i < nombres.Length; i++)
            {
                if (cali[i]>mayor)
                {
                     mayor = cali[i];
                    pos = i;
                }
                else
                {
                if (cali[i]<mayor )
                {
                    baja=cali[i];
                        pis = i;
                }
                }
                
            }


            Console.WriteLine("El promedio mas alto es de: " + nombres[pos]+ " y la calificacion es de: " + mayor);
            Console.WriteLine("El promedio mas baja es de: " + nombres[pis] + " y la calificacion es de: " + baja);
            // Console.WriteLine();
            ResultadosxEstudiante();
        }


        public void ResultadosxEstudiante()
        {
            for (int i = 0; i < nombres.Length; i++)
            {
                string calificacionFinal = "";
                if (cali[i] < 60)
                {
                    calificacionFinal = "Insuficiente";
                }
                else if (cali[i]>=60 && cali[i] <= 74)
                {
                    calificacionFinal = "Suficiente";
                }
                else if (cali[i] >= 75 && cali[i] <= 89)
                {
                    calificacionFinal = "Bueno";
                }
                else 
                {
                    calificacionFinal = "Excelente";
                }
                // Console.Write(nombres[i] + "-" + cali[i]);
                Console.WriteLine("**********************************");
                Console.WriteLine($"{nombres[i]}  La calificación {cali[i]} es considerada: {calificacionFinal}");
            }
            OrdenVector();
        }


        public void OrdenVector()
        {
            for (int i = 0; i < cali.Length - 1; i++)

            {
                for (int j = i + 1; j < cali.Length; j++)
                {
                    float tempCali = cali[i];
                    cali[i] = cali[j];
                    cali[j] = tempCali;

                    String tempNombre = nombres[i];
                    nombres[i] = nombres[j];
                    nombres[j] = tempNombre;
                }

            }
            ImprimirOrdenVector();
        }

        public void ImprimirOrdenVector()
        {
            Console.WriteLine("Vectores ordenados:");

            for (int i = 0; i < cali.Length; i++)
            {
                Console.WriteLine($"{nombres[i]}: {cali[i]}");
            }
            
        }





        static void Main(string[] args)
        {
            Gestion ge= new Gestion();
            ge.Inicio();
            Console.ReadKey();
        }
    }
}
