namespace RoleplayGame
{
    public class Armadura: IObjeto
    {
        public int valorDefensa 
        {
            get
            {
                return 20;
            } 
        }
        public int valorAtaque
        {
            get
            {
                return 0; //La armadura no tiene daño de ataque 
            }
        }
    }
}
