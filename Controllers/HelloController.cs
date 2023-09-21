using Microsoft.AspNetCore.Mvc;

namespace helloworld.Controllers
{
    [Route("~/")]
    [ApiController]
    public class HelloController
    {
        [HttpGet]
        public string Hello()
        {
            return "Hello World !!";
        }


        [HttpGet("/bsm")]
        public string Bsms()
        {
            return "Responsabilidade Pessoal, Mentalidade de Crescimento, Orientação ao Futuro, Persistência, Comunicação, Orientação aos Detalhes, Trabalho em Equipe, Proatividade";
                
            
               
        }
        [HttpGet("/objetivosdeaprendizagem")]
        public string ObjetivosdeAprendizagem()
        {
            return "Melhor entendimento no conteúdo prático ";



        }

    }
}
