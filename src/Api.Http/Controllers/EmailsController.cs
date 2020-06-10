namespace Api.Http.Controllers
{
    using Domain.Models;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines the <see cref="EmailsController" />.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class EmailsController : ControllerBase
    {
        /// <summary>
        /// Read incoming mails.
        /// </summary>
        /// <returns>The <see cref="Task{ActionResult{IEnumerable{MailSupport}}}"/>.</returns>
        [HttpPost(Name = "read")]
        public ActionResult<IEnumerable<MailSupport>> ReadMails()
        {
            var mails = new Bogus.Faker<MailSupport>()
                .RuleFor(x => x.Email, x => x.Internet.Email())
                .RuleFor(x => x.Subject, x => x.Lorem.Sentence())
                .RuleFor(x => x.Content, x => x.Lorem.Paragraphs())
                .RuleFor(x => x.Time, x => x.Date.Recent())
                .Generate(10);

            return Ok(mails);
        }
    }
}
