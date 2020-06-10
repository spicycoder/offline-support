using System;

namespace Domain.Models
{
    /// <summary>
    /// Defines the <see cref="MailSupport" />.
    /// </summary>
    public class MailSupport
    {
        /// <summary>
        /// Gets or sets the `Email`.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the `Subject`.
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Gets or sets the `Content`.
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Gets or sets the `Time`.
        /// </summary>
        public DateTime Time { get; set; }
    }
}
