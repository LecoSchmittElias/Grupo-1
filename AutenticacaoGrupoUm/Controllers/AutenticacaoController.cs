using AutenticacaoGrupoUm.Dto;
using AutenticacaoGrupoUm.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace AutenticacaoGrupoUm.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AutenticacaoController: ControllerBase
    {
        private readonly IAutenticacaoService _AutenticacaoService;

        public AutenticacaoController(IAutenticacaoService autenticacaoService)
        {
            _AutenticacaoService = autenticacaoService;
        }


        //[EnableCors("_AllowAnyOrigin")]
        [HttpPost(Name = "AutenticacaoPost")]
        public IActionResult Post(InputDto inputDto)
        {
           var retornoDto = _AutenticacaoService.ValidarEntrada(inputDto);

            if (retornoDto.StatusCode == 200)
            return Ok(retornoDto);

            return BadRequest(retornoDto);
        }
    }
}