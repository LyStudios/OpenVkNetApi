using OpenVkNetApi.Models;

namespace OpenVkNetApi.Utils
{
    /// <summary>
    /// Represents a standardized response for API calls, indicating success or failure.
    /// Used for internal wrapping of API call results.
    /// </summary>
    /// <typeparam name="T">The type of the successful API result.</typeparam>
    public class ApiResponse<T> where T : class
    {
        /// <summary>
        /// Gets a value indicating whether the API call was successful.
        /// </summary>
        public bool IsSuccess { get; }
        
        /// <summary>
        /// Gets the result of the API call if successful, otherwise <c>null</c>.
        /// </summary>
        public T? Result { get; }
        
        /// <summary>
        /// Gets the error information if the API call failed, otherwise <c>null</c>.
        /// </summary>
        public ApiError? Error { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponse{T}"/> class for a successful result.
        /// </summary>
        /// <param name="result">The successful result data.</param>
        private ApiResponse(T? result)
        {
            IsSuccess = true;
            Result = result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponse{T}"/> class for a failed result.
        /// </summary>
        /// <param name="error">The API error details.</param>
        private ApiResponse(ApiError? error)
        {
            IsSuccess = false;
            Error = error;
        }

        /// <summary>
        /// Creates a successful API response.
        /// </summary>
        /// <param name="data">The successful result data.</param>
        /// <returns>A new <see cref="ApiResponse{T}"/> instance representing success.</returns>
        public static ApiResponse<T> Success(T? data) => new ApiResponse<T>(data);
        
        /// <summary>
        /// Creates a failed API response.
        /// </summary>
        /// <param name="error">The API error details.</param>
        /// <returns>A new <see cref="ApiResponse{T}"/> instance representing failure.</returns>
        public static ApiResponse<T> Failure(ApiError? error) => new ApiResponse<T>(error);
    }
}
