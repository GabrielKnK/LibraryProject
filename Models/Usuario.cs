namespace Biblioteca.Models 
{

    public class Usuario 
    {

        public static int ADMIN = 0;
        public static int PADRAO = 1;

        public int Id {set; get;}
        public string Nome {set; get;}
        public string Login {set; get;}
        public string Senha {set; get;}
        public int Tipo {set; get;}
    }
}