using System.Security.Cryptography.X509Certificates;

namespace Usuario{
class usuario
    {
        private int pass;
        private string nombre;

        public void setNombre(String nombre)
        {
            this.nombre=nombre;
        }
        public void setPass(int pass){this.pass=pass;}


        public String getNombre()
        {return nombre;}
        public int getPass(){
            return pass;
        }

        public void changePass()
        {   
            System.Console.WriteLine("put your new pass.");
            bool accept=false;
            while(accept!=true)
            {
            try
            {
                int NewPass=Int32.Parse(Console.ReadLine());
                this.pass=NewPass;
                accept=true;

            }
            catch(Exception e)
            {
                System.Console.WriteLine(e.Message);    
            }
            }
        }
    }
}