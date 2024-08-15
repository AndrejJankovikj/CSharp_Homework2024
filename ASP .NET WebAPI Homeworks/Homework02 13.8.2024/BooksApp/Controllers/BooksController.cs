using BooksApp.Model;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;
//Create new WEB API project

//Add new BooksController
namespace BooksApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [HttpGet]
        //Add GET method that returns all books
        public ActionResult<List<Book>> GetAll()
        {
            return StatusCode(StatusCodes.Status202Accepted, StaticDb.Books);
        }
        //Add GET method that returns one book by sending index in the query string
        [HttpGet("IndexQuery")]
        public ActionResult<Book> GetByIndex([FromQuery] int index)
        {
            try
            {
                if (index > StaticDb.Books.Count)
                {
                    return StatusCode(StatusCodes.Status406NotAcceptable, "Index cannot be bigger than the list!");
                }
                if (index < 1)
                {
                    return StatusCode(StatusCodes.Status405MethodNotAllowed, "Index cannot be negative/Less than 1!");
                }
                return StatusCode(StatusCodes.Status200OK, StaticDb.Books[index]);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status404NotFound, ex.Message);
            }
        }
        //Add GET method that returns one book by filtering by author and title (use query string parameters)
        [HttpGet("GetByAuthorAndTitle")]
        public ActionResult<Book> GetByAuthorAndTitle([FromQuery] string? author, [FromQuery] string? title)
        {
            try
            {
                if (string.IsNullOrEmpty(author) && string.IsNullOrEmpty(title))
                {
                    return StatusCode(StatusCodes.Status200OK, StaticDb.Books);
                }
                if (string.IsNullOrEmpty(author))
                {
                    List<Book> filteredBooks = StaticDb.Books.Where(x => x.Title == title).ToList();
                    return Ok(filteredBooks);
                }
                if (string.IsNullOrEmpty(title))
                {
                    List<Book> filteredBooks = StaticDb.Books.Where(x => x.Author == author).ToList();
                    return Ok(filteredBooks);
                }

                List<Book> filteredNotesList = StaticDb.Books.Where(x => x.Title.ToLower().Contains(title.ToLower()) && x.Title.ToLower().Contains(title.ToLower())).ToList();
                return Ok(filteredNotesList);
            }

            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
            //Add POST method that adds new book to the list of books (use the FromBody attribute)
        }
        [HttpPost]
        public ActionResult CreateBook([FromBody] Book book)
        {
            try
            {
                if (string.IsNullOrEmpty(book.Author))
                {
                    return StatusCode(StatusCodes.Status400BadRequest, "Book Author cannot be empty!");
                }
                if (string.IsNullOrEmpty(book.Title))
                {
                    return StatusCode(StatusCodes.Status400BadRequest, "Book Title cannot be empty!");
                }
                StaticDb.Books.Add(book);
                return StatusCode(StatusCodes.Status201Created, "Book was created!");


            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        //Bonus
        //Add POST method that accepts list of books from the body of the request and returns their titles as a list of strings.
        [HttpPost("postBookList")]
        public ActionResult<List<string>> AddBookList([FromBody] List<Book> booksList)
        {
            try

            {
                List<string> stringList = new List<string>();
                foreach (var book in booksList)
                {
                    if (string.IsNullOrEmpty(book.Author))
                    {
                        return StatusCode(StatusCodes.Status400BadRequest, "Book Author cannot be empty!");
                    }
                    if (string.IsNullOrEmpty(book.Title))
                    {
                        return StatusCode(StatusCodes.Status400BadRequest, "Book Title cannot be empty!");
                    }
                    stringList.Add(book.Title);
                }
                return stringList;
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }

    }

    //Try out PostMan and Swagger
}
