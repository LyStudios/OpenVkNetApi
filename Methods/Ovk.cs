using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using OpenVkNetApi.Models.Ovk;
using OpenVkNetApi.Utils;
using OpenVkNetApi.Models.Enums;

namespace OpenVkNetApi.Methods
{
    /// <summary>
    /// Provides OpenVK-specific utility methods.
    /// Encapsulates the <c>ovk.*</c> methods of the OpenVK API.
    /// </summary>
    public class Ovk : MethodBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ovk"/> class.
        /// </summary>
        /// <param name="api">An API instance to make requests with.</param>
        public Ovk(OpenVkApi api) : base(api, "ovk") { }

        /// <summary>
        /// Returns the current version of the OpenVK API.
        /// </summary>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>A string representing the API version.</returns>
        public async Task<string> VersionAsync(CancellationToken ct = default)
        {
            return await GetAsync<string>("version", null, ct);
        }

        /// <summary>
        /// A test method for checking API availability.
        /// </summary>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>An <see cref="OvkTest"/> object.</returns>
        public async Task<OvkTest> TestAsync(CancellationToken ct = default)
        {
            return await GetAsync<OvkTest>("test", null, ct);
        }
        
        /// <summary>
        /// Returns information about the OpenVK instance.
        /// </summary>
        /// <param name="fields">A set of fields to return about the instance.</param>
        /// <param name="adminFields">A set of fields to return for admin profiles.</param>
        /// <param name="groupFields">A set of fields to return for group profiles.</param>
        /// <param name="ct">A cancellation token for the operation.</param>
        /// <returns>An <see cref="OvkAboutInstance"/> object with instance details.</returns>
        public async Task<OvkAboutInstance> AboutInstanceAsync(OvkInstanceFields fields = OvkInstanceFields.None, UserFields adminFields = UserFields.None, GroupFields groupFields = GroupFields.None, CancellationToken ct = default)
        {
            var parameters = new RequestParams()
                .Add("fields", EnumHelper.GetEnumFlagsDescription(fields))
                .Add("admin_fields", EnumHelper.GetEnumFlagsDescription(adminFields))
                .Add("group_fields", EnumHelper.GetEnumFlagsDescription(groupFields))
                .ToDictionary();

            return await GetAsync<OvkAboutInstance>("aboutInstance", parameters, ct);
        }
    }
}
