using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;

namespace Funcion_Base
{
    class Program
    {
        static void Main(string[] args)
            //IMPORTANTE!!!! HAY QUE AGREGAR SI O SI: using System.Collections; y using System.Threading;
        {
            Random valores = new Random(); //Para mostrar valores aleatorios.
            //Lista de la cual obtendremos los valores aleatorios. 
            string[] ganadores = { "BOCA", "RIVER", "INDEPENDIENTE", "PEÑAROL", "ESTUDIANTES", "GREMIO", "NACIONAL", "OLIMPIA", "SAN PABLO", "SANTOS", "ATLETICO NACIONAL", "CRUZEIRO", "FLAMENGO", "INTERNACIONAL", "ARGENTINOS", "ATLETICO MINEIRO", "COLO COLO", "CORINTHIANS", "ONCE CALDAS", "LIGA DE QUITO", "PALMEIRAS", "RACING", "SAN LORENZO", "VASCO DA GAMA", "VELEZ" };
            ArrayList equipos = new ArrayList(); //Donde vamos a guardar los valores aleatorios obtenidos.
            List<string> jugador = new List<string>(); //Donde vamos a guardar los equipos ingresados por el usuario. 
            string elemento; //El dato que va a ingresar el usuario. 
            int puntos = 0; //Contador de puntos. 
            int i = equipos.Count; //Contador de elementos de una lista
            int x = jugador.Count;
            int opcion;
            
            Console.WriteLine("El puntaje obtenido es: " + niveles());
            Console.ReadLine();


            int niveles()
            {
                Console.WriteLine("Ingrese el nivel que desea jugar: 1, 2, 3 o 4");
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                int puntaje= juego_base(opcion);
                return puntaje;
            }



            int juego_base(int nivel)
            {
                //Dependiendo el parámetro que le pasamos a la función, vamos a jugar con cierta cantidad de equipos.
                //El usuario ingresa el NIVEL que es tomado como parámetro. 
                //Nviel 1- juega con 4 equipos. 
                //Nivel 2 juega con 6 equipos.
                //Nivel 3 juega con 8 equipos.
                //Nivel 4 juega con 10 equipos.
                int a =0;

                if (nivel == 1)
                {
                    a = a+4;
                }
                if (nivel==2)
                {
                    a = a + 6;
                }
                if (nivel == 3)
                {
                    a = a + 8;
                }
                if (nivel ==4)
                {
                    a = a + 10;
                }
                do
                {
             
                    int aIndex = valores.Next(ganadores.Length);//Guardamos en una variable y obtenemos un valor aleatorio de la lista ganadores
                    Console.WriteLine("Equipo: {0}", ganadores[aIndex]);//Mostramos en pantalla el valor obtenido aleatoriamente.

                    equipos.Add(ganadores[aIndex]);//Agregamos a la lista de los datos que se fueron mostrando en pantalla. 
                    i++;
                    Thread.Sleep(350); //Frenamos la ejecución de la próxima linea. 
                    Console.Clear(); //limpiamos la pantalla para que no se vea el Equipo random.

                    Console.WriteLine("Ingresá: ");//Solicitamos al usuario que ingrese un dato

                    elemento = Convert.ToString(Console.ReadLine());//Casteamos el dato en un String y lo agregamos a la lista de sus datos ingresador por el user.
                    jugador.Add(elemento);

                    if (ganadores[aIndex] == elemento)
                    {
                        puntos = puntos + 10; //Si el dato ingresado por el user es igual al dato arrojado por el programa, se suman 10 puntos. 
                    }
                    Console.Clear();

                } while (i < a);
                //Para mostrar los elementos ingresados
                Console.WriteLine("Los equipos mostrados en pantalla:");
                foreach (string dato in equipos)
                    Console.WriteLine("{0}", dato);
                Console.WriteLine("Los equipos ingresados por el usuario:");
                foreach (string datoUser in jugador)
                    Console.WriteLine("{0}", datoUser);
                Console.ReadLine();
                return puntos;
            }

            
        }
    }
}
