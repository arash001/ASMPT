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
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;
        private readonly ILogger<BookController> _logger;

        public BookController(IBookService bookService, ILogger<BookController> logger)
        {
            _bookService = bookService;
            _logger = logger;
        }


        [HttpGet]
        [Route("GetBooks")]
        public async Task<ActionResult> GetBooks()
        {
            _logger.LogInformation("start Metohd "  + nameof(GetBooks));
            var model= _bookService.GetAll();
            _logger.LogInformation("return  Metohd " +nameof(GetBooks) ,model);

            return Ok(model);
        }

        [HttpGet]
        [Route("GetModels")]
        public async Task<ActionResult> GetModels()
        {
            _logger.LogInformation("start Metohd " + nameof(GetModels));
            var model = _bookService.GetModels();
            _logger.LogInformation("return  Metohd " + nameof(GetModels), model);

            return Ok(model);
        }



        [Route("create")]
        [HttpPost]
        public async Task<ActionResult> CreateBook([FromBody] BookDto bookDto)
        {
            try
            {
                int? result = _bookService.Add(bookDto);
                if (result.HasValue)
                {
                    return Ok(new { NewId = result.Value, title = "Book Created", message = "Book has been created" });
                }
                else
                {
                    return BadRequest(new { title = "Error", message = "Failed to create Book" });
                }
            }
            catch (Exception ex)
            {
            return Ok((new { bookDto, title = "Book Created", message = "Book has been created" }));
                _logger.LogDebug(ex.Message);
                //throw;
            }
        }
    }
}
