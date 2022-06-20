using System;

namespace OpenVkNetApi.Exceptions
{
    class OnRequestErrorException : Exception
    {
        public OnRequestErrorException(string error):base(error)
        {

        }
    }
}
