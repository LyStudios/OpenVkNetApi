namespace OpenVkNetApi.Models
{
    /// <summary>
    /// Represents a newsfeed collection, which includes a 'next_from' value for pagination.
    /// </summary>
    /// <typeparam name="T">The type of items in the newsfeed.</typeparam>
    public class NewsfeedCollection<T> : ExtendedCollection<T> where T : class
    {
    }
}
