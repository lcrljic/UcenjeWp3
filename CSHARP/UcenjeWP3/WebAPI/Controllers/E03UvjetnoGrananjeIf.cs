using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("E03")]
    public class E03UvjetnoGrananjeIf : ControllerBase
    {
        // Ovdje počinje ruta
        [HttpGet]
        [Route("zad1")]
        public int Zad1(int a, int b)
        {
            //return (a+b)%2==0 ? a*b : a+b;

            var zbroj = a + b;
            if (zbroj % 2 == 0)
            {
                return a * b;
            }
            else
            {
                return zbroj;
            }
        }
        // Ovdje završava ruta

        // Ovdje počinje ruta
        [HttpGet]
        [Route("zad2")]
        public string Zad2(int ocjena)
        {
            switch (ocjena)
            {
                case 1:
                    return "Nedovoljan";
                    break;
                case 2:
                    return "Dovoljan";
                    break;
                case 3:
                    return "Dobar";
                    break;
                case 4:
                    return "Vrlo dobar";
                    break;
                case 5:
                    return "Odličan";
                    break;
                default:
                    return "Nije ocjena";
                    break;
            }
        }
        // Ovdje završava ruta
    }
}
