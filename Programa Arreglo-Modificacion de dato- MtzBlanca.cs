using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGRAMA_1_POO
{
    //MARTINEZ NAVA BLANCA YESSENIA
    //NO. CONTROL: 21211990
    class Program
    {
        //CLASE DATOS ALUMNO
        class Alumno
        {
            public string FirstName, LastName, Email;
            public Alumno(string FirstName, string LastName, string Email)
            {
                this.FirstName = FirstName;
                this.LastName = LastName;
                this.Email = Email;

            }

            public void DesplegarDatos()
            {
                Console.WriteLine("DATOS DEL ALUMNO" +
                    "\nApellidos " + LastName +  " Nombre: " +FirstName +
                    "\nEmail: " + Email);

                
            }
            


            public void CapturaMaterias()
            {
                //DECLARACION DEL ARREGLO DE MATERIAS
                string[] Materias;
                int numeroMaterias;

                //declaracion del ciclo While para indicar el numero de materias a asignar valor para el arreglo de materias
                do
                {
                    Console.WriteLine("Capture el NÚMERO DE MATERIAS a ingresar: ");
                    numeroMaterias = int.Parse(Console.ReadLine());
                }
                while (numeroMaterias <= 0);

                //creacion del arreglo de materias
                Materias = new string[numeroMaterias];

                for (int i = 0; i < numeroMaterias; i++)
                {
                    Console.Write(" Escribe el nombre de la materia ");
                    Materias[i] = Console.ReadLine();
                }
                Console.WriteLine(" Se han capturado " + numeroMaterias);

                for (int i = 0; i < numeroMaterias; i++)
                {
                    Console.WriteLine(" Posicion: " + i + " : " + Materias[i]);
                }
                
                string buscarMateria = " ";

                Console.Write(" Sí desdea modificar el nombre de alguna materia, escriba el nombre de la materia que se va a modificar: ");
                
                buscarMateria = Console.ReadLine();

                foreach(string busqueda in Materias)
                {
                    if(busqueda == buscarMateria)
                    {
                        Console.WriteLine("\nSe ha seleccionado " + busqueda + " para su modificacion");
                    }

                    else
                    {
                        Console.WriteLine("OPCION NO VALIDA O ESCRIBIO INCORRECTAMENTE EL NOMBRE DE LA MATERIA, su eleccion " +busqueda);
                    }
                }


                string newNameMateria = "";
                Console.Write("\nEscriba el NUEVO de la materia a modificar: ");
                newNameMateria = Console.ReadLine();

                for(int i = 0; i <3; i++)
                {
                    if(Materias[i] == buscarMateria)
                    {
                        Materias[i] = newNameMateria;
                        Console.WriteLine("\nEl nuevo nombre de la materia es: " + newNameMateria + " Se modifico a partir de: " +buscarMateria);
                    }
                }

                Console.ReadKey();
            }



            
            ~Alumno()
            { 
                Console.WriteLine("MEMORIA DE LA CLASE ALUMNO LIBERADA");
            }

        }

        static void Main(string[] args)
        {
            Console.Title= "CAPTURA DE DATOS Y CALIFICACIONES DEL ALUMNO";
            //VARIABLES AUXILIARES PARA ASIGNACION DE DATOS DEL ALUMNO
            string Name, lastName, e_mail;

            //CAPTURA DE DATOS Y ASIGNACION DE VALORES A LAS VARIABLES
            Console.Write("Capture los datos que se indican" +
                "\nApellidos: ");
            lastName = Console.ReadLine();
            Console.Write("Nombres: ");
            Name = Console.ReadLine();
            Console.Write("Email: ");
            e_mail = Console.ReadLine();


            
            //CREACION DEL OBJETO DE LA CLASE Y ASGINACION DE LOS VALORES CAPTURADOS
            Alumno Alumno1 = new Alumno(Name, lastName,e_mail);
            //DESPLIEGUE DE DATOS DEL ALUMNO
            Alumno1.DesplegarDatos();
            Alumno1.CapturaMaterias();



        }
    }
}
