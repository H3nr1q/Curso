using CursoDio.API.Filters;
using CursoDio.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace CursoDio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        /// <sumary>
        /// Este serviço permite autenticar um usuário cadastrado e ativo.
        /// </sumary>
        /// <param name="loginViewModelInput"> View model do login</param>
        /// <returns>Retorna status ok, dados do usuário e token em caso de sucesso</returns>
        [SwaggerResponse(statusCode:200, description:"Sucesso ao autenticar", Type = typeof(LoginViewModelInput))]
        [SwaggerResponse(statusCode:400, description:"Campos obrigatórios", Type = typeof(ValidateFieldsViewModelOutput))]
        [SwaggerResponse(statusCode:500, description:"Erro interno", Type = typeof(GenericErrorViewModel))]

        [HttpPost]
        [Route("login")]
        [ValidateModelStateCustom]
        public IActionResult login(LoginViewModelInput loginViewModelInput)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(new ValidateFieldsViewModelOutput(ModelState.SelectMany(sm => sm.Value.Errors).Select(s => s.ErrorMessage)));
            //}
            return Ok(loginViewModelInput);
        }

        [HttpPost]
        [Route("register")]
        public IActionResult register(RegisterViewModelInput registerViewModelInput)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ValidateFieldsViewModelOutput(ModelState.SelectMany(sm => sm.Value.Errors).Select(s => s.ErrorMessage)));
            }
            return Created("", registerViewModelInput);

        }

    }
}
