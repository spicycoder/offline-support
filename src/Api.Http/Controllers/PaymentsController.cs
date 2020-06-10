namespace Api.Http.Controllers
{
    using Domain.Models;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="PaymentsController" />.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsController : ControllerBase
    {
        /// <summary>
        /// The GetAllPayments.
        /// </summary>
        /// <returns>The <see cref="ActionResult{IEnumerable{PaymentDetails}}"/>.</returns>
        [HttpGet(Name = "info")]
        public ActionResult<IEnumerable<PaymentDetails>> GetAllPayments()
        {
            var paymentInfo = new Bogus.Faker<PaymentDetails>()
                .RuleFor(x => x.Date, x => x.Date.Past())
                .RuleFor(x => x.Amount, x => $"{x.Finance.Amount()} {x.Finance.Currency().Code}")
                .RuleFor(x => x.CreditcardNumber, x => x.Finance.CreditCardNumber())
                .Generate(10);

            return Ok(paymentInfo);
        }
    }
}
