namespace StudentsManager.Mvc.Domain.Views
{
    public class QuestionOptionView
    {
        /// <summary>
        ///     Question Option ID.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        ///     Question Option Description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        ///     Test Question Number
        /// </summary>
        public int QuestionNumber { get; set; }

        /// <summary>
        ///     Test Result Value
        /// </summary>
        public string ResultValue { get; set; }

        /// <summary>
        ///     Is Text Question Option
        /// </summary>
        public bool IsTextOnly { get; set; }

        /// <summary>
        ///     Option Image Binary Data (Base64 string)
        /// </summary>
        /// <remarks>
        ///     If <see cref="IsTextOnly" /> is equal to true,
        ///     this must be NULL.
        /// </remarks>
        public string? Base64Image { get; set; }
    }
}