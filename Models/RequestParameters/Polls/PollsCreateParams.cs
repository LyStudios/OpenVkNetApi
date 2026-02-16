using Newtonsoft.Json;

namespace OpenVkNetApi.Models.RequestParameters.Polls
{
    /// <summary>
    /// Parameters for the polls.create method.
    /// </summary>
    public class PollsCreateParams
    {
        /// <summary>
        /// The poll question.
        /// </summary>
        [JsonProperty("question")]
        public string Question { get; set; } = null!;

        /// <summary>
        /// A JSON string representing an array of answer options.
        /// </summary>
        [JsonProperty("add_answers")]
        public string AddAnswers { get; set; } = null!;

        /// <summary>
        /// True to disable unvoting.
        /// </summary>
        [JsonProperty("disable_unvote")]
        public bool DisableUnvote { get; set; } = false;

        /// <summary>
        /// True to make the poll anonymous.
        /// </summary>
        [JsonProperty("is_anonymous")]
        public bool IsAnonymous { get; set; } = false;

        /// <summary>
        /// True to allow multiple answers.
        /// </summary>
        [JsonProperty("is_multiple")]
        public bool IsMultiple { get; set; } = false;

        /// <summary>
        /// The end date of the poll in Unix time, or 0 for no end date.
        /// </summary>
        [JsonProperty("end_date")]
        public int EndDate { get; set; } = 0;
    }
}
