using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task10JWT1.Moels.VMs;
using Task10JWT1.Services.IServices;

namespace Task10JWT1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;
        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }
        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromQuery]RegisterVM registerVM)
        {
            if (ModelState.IsValid)
            {
                var result = await _accountService.RegisterNewUser(registerVM);
                if (result == null)
                    return Ok();
                return BadRequest(result);
            }
            return BadRequest(ModelState);
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] LoginVM loginVM)
        {
            if (ModelState.IsValid)
            {
                var result = await _accountService.Login(loginVM);
                if (result != null)
                    return Ok(result);
                return BadRequest("Invalid Login Attempt!");
            }
            return BadRequest(ModelState);
        }
    }
}
