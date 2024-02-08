using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("E04")]
    public class E04Petlje : ControllerBase
    {
        // Ovdje počinje ruta
        [HttpGet]
        [Route("zad1")]
        public int Zad1(int a, int b)
        {           
            {
                int Suma=0;
                for (int i = a + 1; i < b; i++) 
                {
                    if(i% 2== 0)
                    {
                        Suma+=i;
                    }
                }
                return Suma;
            }
        }
        // Ovdje završava ruta
    }
}
