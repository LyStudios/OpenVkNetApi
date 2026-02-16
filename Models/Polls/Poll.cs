using Newtonsoft.Json;
using System.Collections.Generic;

namespace OpenVkNetApi.Models.Polls
{
    /// <summary>
    /// Represents a poll object.
    /// </summary>
    public class Poll
    {
        /// <summary>
        /// Indicates if multiple answer options can be selected.
        /// </summary>
        [JsonProperty("multiple")]
        public bool Multiple { get; set; }

        /// <summary>
        /// The poll's end date in Unix time, or 0 if no end date.
        /// </summary>
        [JsonProperty("end_date")]
        public long EndDate { get; set; }

        /// <summary>
        /// Indicates if the poll is closed.
        /// </summary>
        [JsonProperty("closed")]
        public bool Closed { get; set; }

        /// <summary>
        /// Indicates if the poll is from a board.
        /// </summary>
        [JsonProperty("is_board")]
        public bool IsBoard { get; set; }

        /// <summary>
        /// Indicates if the current user can edit the poll.
        /// </summary>
        [JsonProperty("can_edit")]
        public bool CanEdit { get; set; }

        /// <summary>
        /// Indicates if the current user can vote in the poll.
        /// </summary>
        [JsonProperty("can_vote")]
        public bool CanVote { get; set; }

        /// <summary>
        /// Indicates if the current user can report the poll.
        /// </summary>
        [JsonProperty("can_report")]
        public bool CanReport { get; set; }

        /// <summary>
        /// Indicates if the current user can share the poll.
        /// </summary>
        [JsonProperty("can_share")]
        public bool CanShare { get; set; }

        /// <summary>
        /// The date when the poll was created, in Unix time.
        /// </summary>
        [JsonProperty("created")]
        public long Created { get; set; }

        /// <summary>
        /// The poll ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// The poll owner's ID.
        /// </summary>
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        /// <summary>
        /// The poll question.
        /// </summary>
        [JsonProperty("question")]
        public string? Question { get; set; }

        /// <summary>
        /// The total number of votes in the poll.
        /// </summary>
        [JsonProperty("votes")]
        public int Votes { get; set; }

        /// <summary>
        /// Indicates if unvoting is disabled.
        /// </summary>
        [JsonProperty("disable_unvote")]
        public bool DisableUnvote { get; set; }

        /// <summary>
        /// Indicates if the poll is anonymous.
        /// </summary>
        [JsonProperty("anonymous")]
        public bool Anonymous { get; set; }

        /// <summary>
        /// A list of answer IDs selected by the current user.
        /// </summary>
        [JsonProperty("answer_ids")]
        public List<int>? AnswerIds { get; set; }

        /// <summary>
        /// A list of poll answers.
        /// </summary>
        [JsonProperty("answers")]
        public List<PollAnswer>? Answers { get; set; }

        /// <summary>
        /// The ID of the poll's author.
        /// </summary>
        [JsonProperty("author_id")]
        public int AuthorId { get; set; }
    }
}