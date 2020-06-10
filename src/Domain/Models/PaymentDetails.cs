namespace Domain.Models
{
    using System;

    /// <summary>
    /// Defines the <see cref="PaymentDetails" />.
    /// </summary>
    public class PaymentDetails
    {
        /// <summary>
        /// Gets or sets the `Creditcard Number`.
        /// </summary>
        public string CreditcardNumber { get; set; }

        /// <summary>
        /// Gets or sets the `Amount`.
        /// </summary>
        public string Amount { get; set; }

        /// <summary>
        /// Gets or sets the `Date`.
        /// </summary>
        public DateTime Date { get; set; }
    }
}
