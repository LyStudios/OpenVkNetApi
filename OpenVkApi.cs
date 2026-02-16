using Newtonsoft.Json;
using OpenVkNetApi.Methods;
using OpenVkNetApi.Models;
using OpenVkNetApi.Utils;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace OpenVkNetApi
{
    /// <summary>
    /// The main class for interacting with the OpenVK API.
    /// Encapsulates authentication and HTTP requests to API methods.
    /// </summary>
    public class OpenVkApi
    {
        /// <summary>
        /// The HTTP client for making requests.
        /// </summary>
        internal readonly HttpClient HttpClient;

        /// <summary>
        /// The base URL of the API (e.g., https://ovk.to).
        /// </summary>
        private readonly string _baseUrl;

        /// <summary>
        /// The authorization token used for API requests.
        /// </summary>
        public string? AccessToken { get; private set; }

        /// <summary>
        /// Provides methods for working with audio.
        /// </summary>
        public Audio Audio { get; }

        /// <summary>
        /// Provides methods for working with accounts.
        /// </summary>
        public Account Account { get; }

        /// <summary>
        /// Provides methods for working with board topics.
        /// </summary>
        public Board Board { get; }

        /// <summary>
        /// Provides methods for working with documents.
        /// </summary>
        public Docs Docs { get; }

        /// <summary>
        /// Provides methods for working with friends.
        /// </summary>
        public Friends Friends { get; }

        /// <summary>
        /// Provides methods for working with gifts.
        /// </summary>
        public Gifts Gifts { get; }

        /// <summary>
        /// Provides methods for working with groups.
        /// </summary>
        public Groups Groups { get; }

        /// <summary>
        /// Provides methods for working with likes.
        /// </summary>
        public Likes Likes { get; }

        /// <summary>
        /// Provides methods for working with messages.
        /// </summary>
        public Messages Messages { get; }

        /// <summary>
        /// Provides methods for working with the newsfeed.
        /// </summary>
        public Newsfeed Newsfeed { get; }

        /// <summary>
        /// Provides methods for working with notes.
        /// </summary>
        public Notes Notes { get; }

        /// <summary>
        /// Provides methods for working with notifications.
        /// </summary>
        public Notifications Notifications { get; }

        /// <summary>
        /// Provides methods for working with Ovk-specific features.
        /// </summary>
        public Ovk Ovk { get; }

        /// <summary>
        /// Provides methods for working with payments.
        /// </summary>
        public Pay Pay { get; }

        /// <summary>
        /// Provides methods for working with photos.
        /// </summary>
        public Photos Photos { get; }

        /// <summary>
        /// Provides methods for working with polls.
        /// </summary>
        public Polls Polls { get; }

        /// <summary>
        /// Provides methods for working with reports.
        /// </summary>
        public Reports Reports { get; }

        /// <summary>
        /// Provides methods for working with user statuses.
        /// </summary>
        public Status Status { get; }

        /// <summary>
        /// Provides methods for working with users.
        /// </summary>
        public Users Users { get; }

        /// <summary>
        /// Provides utility methods.
        /// </summary>
        public Methods.Utils Utils { get; }

        /// <summary>
        /// Provides methods for working with videos.
        /// </summary>
        public Video Video { get; }

        /// <summary>
        /// Provides methods for working with wall posts.
        /// </summary>
        public Wall Wall { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenVkApi"/> class.
        /// </summary>
        /// <param name="baseUrl">The base URL of the API.</param>
        /// <param name="httpClient">An optional custom <see cref="HttpClient"/> instance.</param>
        public OpenVkApi(string baseUrl, HttpClient? httpClient = null)
        {
            _baseUrl = baseUrl.TrimEnd('/');
            HttpClient = httpClient ?? new HttpClient();

            Account = new Account(this);
            Audio = new Audio(this);
            Board = new Board(this);
            Docs = new Docs(this);
            Friends = new Friends(this);
            Gifts = new Gifts(this);
            Groups = new Groups(this);
            Likes = new Likes(this);
            Messages = new Messages(this);
            Newsfeed = new Newsfeed(this);
            Notes = new Notes(this);
            Notifications = new Notifications(this);
            Ovk = new Ovk(this);
            Pay = new Pay(this);
            Photos = new Photos(this);
            Polls = new Polls(this);
            Reports = new Reports(this);
            Status = new Status(this);
            Users = new Users(this);
            Utils = new Methods.Utils(this);
            Video = new Video(this);
            Wall = new Wall(this);
        }

        /// <summary>
        /// Sets the access token for subsequent API calls.
        /// </summary>
        /// <param name="token">The access token string.</param>
        /// <exception cref="ArgumentException">Thrown if the token is null or empty.</exception>
        public void SetAccessToken(string token)
        {
            if (string.IsNullOrWhiteSpace(token))
                throw new ArgumentException("Token cannot be null or empty", nameof(token));

            AccessToken = token;
        }

        /// <summary>
        /// Authenticates using a username and password to obtain an <see cref="Auth"/> object.
        /// </summary>
        /// <param name="username">The user's login name.</param>
        /// <param name="password">The user's password.</param>
        /// <param name="clientName">The name of the client application (defaults to "OpenVkNetApi").</param>
        /// <param name="twoFactorCode">The two-factor authentication code, if required.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>An object containing authentication data.</returns>
        /// <exception cref="HttpRequestException">Thrown on request failure.</exception>
        /// <exception cref="OvkApiException">Thrown on API errors or response parsing failures.</exception>
        public async Task<Auth> AuthorizeAsync(
            string username,
            string password,
            string? clientName = "OpenVkNetApi",
            string? twoFactorCode = null,
            CancellationToken ct = default)
        {
            var url = $"{_baseUrl}/token";
            var values = new List<KeyValuePair<string, string?>>
            {
                new KeyValuePair<string, string?>("username", username),
                new KeyValuePair<string, string?>("password", password),
                new KeyValuePair<string, string?>("grant_type", "password"),
                new KeyValuePair<string, string?>("client_name", clientName ?? "OpenVkNetApi")
            };

            if (!string.IsNullOrEmpty(twoFactorCode))
                values.Add(new KeyValuePair<string, string?>("code", twoFactorCode));

            HttpResponseMessage response;

            try
            {
                response = await HttpClient.PostAsync(url, new FormUrlEncodedContent(values), ct);
            }
            catch (OperationCanceledException)
            {
                throw; // Re-throw cancellation
            }
            catch (Exception ex)
            {
                throw new HttpRequestException("Failed to send request", ex);
            }

            string json = await response.Content.ReadAsStringAsync();

            if (string.IsNullOrWhiteSpace(json) || json.TrimStart().StartsWith("<"))
                throw new OvkApiException(-1, "Server returned non-JSON response");

            if (!response.IsSuccessStatusCode)
            {
                var err = TryParseApiError(json);
                throw new OvkApiException(err?.ErrorCode ?? (int)response.StatusCode, err?.ErrorMessage ?? response.ReasonPhrase);
            }

            var apiError = TryParseApiError(json);
            if (apiError != null && apiError.ErrorCode != 0)
                throw new OvkApiException(apiError.ErrorCode, apiError.ErrorMessage ?? "Unknown API error");

            var data = JsonConvert.DeserializeObject<Auth>(json);
            if (data == null || string.IsNullOrEmpty(data.AccessToken))
                throw new OvkApiException(-1, "Server returned empty authorization response");

            AccessToken = data.AccessToken;
            return data;
        }

        /// <summary>
        /// Executes a GET API call.
        /// </summary>
        /// <typeparam name="T">The type of the expected result.</typeparam>
        /// <param name="method">The API method name.</param>
        /// <param name="parameters">Request parameters.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A result of type <typeparamref name="T"/>.</returns>
        internal Task<T> CallApiAsync<T>(string method, Dictionary<string, string>? parameters = null, CancellationToken ct = default)
            => CallApiInternalAsync<T>(HttpMethod.Get, method, parameters, ct);

        /// <summary>
        /// Executes a POST API call.
        /// </summary>
        /// <typeparam name="T">The type of the expected result.</typeparam>
        /// <param name="method">The API method name.</param>
        /// <param name="parameters">Request parameters.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A result of type <typeparamref name="T"/>.</returns>
        internal Task<T> CallApiPostAsync<T>(string method, Dictionary<string, string>? parameters = null, CancellationToken ct = default)
            => CallApiInternalAsync<T>(HttpMethod.Post, method, parameters, ct);

        /// <summary>
        /// Internal mechanism for all API calls.
        /// </summary>
        /// <typeparam name="T">The expected response type.</typeparam>
        /// <param name="httpMethod">The HTTP method (GET or POST).</param>
        /// <param name="method">The API method name.</param>
        /// <param name="parameters">Request parameters.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>The API response, deserialized to the specified type.</returns>
        /// <exception cref="InvalidOperationException">Thrown if the API is not authorized.</exception>
        /// <exception cref="HttpRequestException">Thrown if the request fails to send.</exception>
        /// <exception cref="OvkApiException">Thrown if the server returns an API error or an invalid response.</exception>
        private async Task<T> CallApiInternalAsync<T>(HttpMethod httpMethod, string method, Dictionary<string, string>? parameters, CancellationToken ct)
        {
            if (string.IsNullOrEmpty(AccessToken))
                throw new InvalidOperationException("API is not authorized. Call AuthorizeAsync() first.");

            string url = $"{_baseUrl}/method/{method}?access_token={AccessToken}";
            HttpResponseMessage response;
            string json;

            try
            {
                if (httpMethod == HttpMethod.Get && parameters != null)
                {
                    foreach (var p in parameters)
                        url += $"&{p.Key}={Uri.EscapeDataString(p.Value)}";
                    response = await HttpClient.GetAsync(url, ct);
                }
                else
                {
                    var content = parameters != null ? new FormUrlEncodedContent(parameters) : null;
                    response = await HttpClient.PostAsync(url, content, ct);
                }

                json = await response.Content.ReadAsStringAsync();
            }
            catch (OperationCanceledException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new HttpRequestException($"Failed to send {httpMethod} request", ex);
            }

            if (string.IsNullOrWhiteSpace(json) || json.TrimStart().StartsWith("<"))
                throw new OvkApiException(-1, "Server returned non-JSON response");

            if (!response.IsSuccessStatusCode)
            {
                var err = TryParseApiError(json);
                throw new OvkApiException(err?.ErrorCode ?? (int)response.StatusCode, err?.ErrorMessage ?? response.ReasonPhrase);
            }

            var apiError = TryParseApiError(json);
            if (apiError != null && apiError.ErrorCode != 0)
                throw new OvkApiException(apiError.ErrorCode, apiError.ErrorMessage ?? "Unknown API error");

            var wrapper = JsonConvert.DeserializeObject<ApiResponseWrapper<T>>(json);
            if (wrapper == null || wrapper.Response == null)
                throw new OvkApiException(-1, "Server returned empty response");

            return wrapper.Response;
        }

        /// <summary>
        /// Attempts to deserialize an API error from a JSON string.
        /// </summary>
        /// <param name="json">The JSON response string.</param>
        /// <returns>An <see cref="ApiError"/> object, or null if parsing fails.</returns>
        private static ApiError? TryParseApiError(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<ApiError>(json);
            }
            catch
            {
                return null;
            }
        }
    }
}
