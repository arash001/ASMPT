using ASMPT.ApplicationService.Contract;
using ASMPT.Data.Contract;
using ASMPT.Data.Contract.ViewModel;
using ASMPT.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _authorService;
        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }


        [HttpGet]

        public async Task<ActionResult> GetAuthorAll()
        {
            var result = _authorService.GetAll();
            return Ok(result);
        }

        [Route("create")]
        [HttpPost]
        public async Task<ActionResult> CreateAuthor([FromBody] CreateAuthorDto createAuthorDto)
        {
            try
            {
                int? result = _authorService.Add(createAuthorDto);

                if (result.HasValue)
                {
                    return Ok(new { NewId = result.Value, title = "Author Created", message = "Author has been created" });
                }
                else
                {
                    return BadRequest(new { title = "Error", message = "Failed to create author" });
                }
            }
            catch (Exception ex)
            {
                // Log the exception and return an error response
                return StatusCode(500, new { title = "Error", message = "Internal server error" });
            }
        }

    }
}
