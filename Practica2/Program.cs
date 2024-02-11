using Usuario;
usuario User=new usuario();
System.Console.WriteLine("Welcome, do you want to sing up?");
String Input=Console.ReadLine();
if(Input!="no")
{
    bool nameaccept=false;
    bool passAccept=false;
    while(nameaccept!=true)
    {
        try
        {
            System.Console.WriteLine("Please put your name");
            User.setNombre(Console.ReadLine());
            nameaccept=true;
            
        }catch(Exception e){ System.Console.WriteLine(e.Message); nameaccept=false;}
    }
    while(passAccept!=true)
    {
        try
        {
            System.Console.WriteLine("Put your pass.");
            User.setPass(Int32.Parse(Console.ReadLine()));
            passAccept=true;
        }catch(Exception e){System.Console.WriteLine(e.Message); passAccept=false;}


    }
}
else
    System.Console.WriteLine("closed");
System.Console.WriteLine($"Hello {User.getNombre()}");

System.Console.WriteLine("Do you want to change your pass?");
String respuesta=Console.ReadLine();
if(respuesta!="no")
{
    try{
    System.Console.WriteLine("Put your old password");
    int checkOldPass=int.Parse(Console.ReadLine());
    if(checkOldPass!=User.getPass())
    {
        System.Console.WriteLine("Denied acces, wrong password");
    }else if(checkOldPass==User.getPass()){
        User.changePass();
    }
    }catch(Exception e){System.Console.WriteLine(e.Message);}
}

System.Console.WriteLine("Succesful");
