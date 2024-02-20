using System.Collections.Generic;
namespace Genericos
{
    class Program
    {
        static void Main(String[] args)
        {
            bool creacionClase=false;
            try{
            AlmacenAlumnos Clase = new AlmacenAlumnos();
            while(creacionClase!=true)
            {
                System.Console.WriteLine("Escriba la cantidad de alumnos que quiere en la clase");
                int large=int.Parse(Console.ReadLine());
                String[]clase=new string[large];
                for(int i=0; i <clase.Length;i++)
                {
                    System.Console.WriteLine("Escriba el nombre del alumno en la posicion {0}", i+1 );
                    String NombreAlumno=Console.ReadLine();
                    clase[i]=NombreAlumno;
                }
                foreach(String i in clase)
                {
                    Clase.AgregarAlumno(i);
                }
                creacionClase=true;
            }
            Clase.ObtenerAlumnos();
            }
            catch(Exception e){System.Console.WriteLine(e.GetType());
            creacionClase=false;
            System.Console.WriteLine("Lo intentaremos de nuevo.");
            }
        }
    }
    class AlmacenAlumnos
    {
        private LinkedList<String>ALUMNOS;
        private LinkedListNode<String> NombreAlumno;
        private int Cantidad=0;
        public AlmacenAlumnos()
        {
            this.ALUMNOS=new LinkedList<string>();
        }
        public void AgregarAlumno(String nombre)
        {
            this.NombreAlumno=new LinkedListNode<string>(nombre);
            ALUMNOS.AddLast(NombreAlumno);
            Cantidad++;

        }

        public void EliminarAlumno(String nombre)
        {
            ALUMNOS.Remove(nombre);
        }

        public void ObtenerAlumnos()
        {
            foreach (var item in ALUMNOS)
            {
                System.Console.WriteLine(item);
            }
        }
        public int CantidadAlumnos(){return this.Cantidad;}
    }
}