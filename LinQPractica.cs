using System.Linq;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace Trabajo_Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creacion de instancias de empleado
            Empleado empleado1 = new Empleado("Alejandro Magno","TL");
            Empleado empleado2 = new Empleado("Emanuel Magallanes","DA");
            Empleado empleado3 = new Empleado("Camila Unanue","PO");
            Empleado empleado4 = new Empleado("Joaquin Lucero","TL");
            Empleado empleado5 = new Empleado("Juan Carranmz","PO");
            Empleado empleado6 = new Empleado("Valentin Gerez","DA");
            //Creacion de arrays donde se almacenan la cantidad de empleados querida(Para minimizar verbosidad a la hora de ingresarlos a la empresa)
            Empleado[] empleados1 = new Empleado[]{empleado1,empleado2,empleado3};
            Empleado[] empleados2 = new Empleado[] { empleado4, empleado5, empleado6};
            Empresa empresa1 = new Empresa("Empresa1");
            Empresa empresa2 = new Empresa("Empresa2");
            //agregando array de empleados a las empresas
            empresa1.SetEmpleado(empleados1);
            empresa2.SetEmpleado(empleados2);
            //utilizacion de la clase para recorrer la empresa1 y escribir en consola sus trabajadores
            PrintEmpleado printer = new PrintEmpleado(empresa1);
            printer.PintEmpleados();

        }
        //En esta clase se define el nombre de la empresa y se le asigna una lista con los empleados correspondientes.
        class Empresa
        {
            private List<Empleado> empleados = new List<Empleado>();
            private String NombreEmpresa;
            public Empresa(String NombreEmpresa)
            {
                this.NombreEmpresa = NombreEmpresa;
            }
            public void SetEmpleado(Empleado[]Empleados)
            {
                empleados.AddRange(Empleados);
            }
            public List<Empleado> GetEmpleados()
            {
                return this.empleados;
            }
        }

        //Esta clase utiliza LINQ para en consola escribir los nombres de las personas(en orden alfabetico) que trabajan en la empresa seleccionada para recorrer
        //pide un unico parametro que es la empresa que busca recorrer, utilizando este parametro ingresa a los parametros y escribe en consola
        //los nombres de los empleados. aunque de quererlo podria mostrar mas datos en pantalla.
        class PrintEmpleado(Empresa empresa)
        {
            private Empresa empresa = empresa;
            public void PintEmpleados()
            {
                IEnumerable<Empleado> empleados= from empleado in empresa.GetEmpleados() orderby empresa.GetEmpleados() select empleado;
                foreach (var i in empleados)
                {
                    String[] Nombres = new string[] { i.GetFullName() };
                    foreach(String Nombre in Nombres)
                    {
                        Console.WriteLine(Nombre);
                    }

                }


            }


        }
        //Clase empleado donde se almacenara los datos de cada empeado

        class Empleado
        {
            private int id;
            public String FullName;
            private String Rol;
            
            public Empleado(String FullName,String Rol)
            {
                this.FullName = FullName;
                this.Rol = Rol;            
                this.id =+1;
            }
            public String GetFullName(){return this.FullName;}
            public String GetRol() {return this.Rol;}
            public int GetId() {return id;}
        }
    }
}
