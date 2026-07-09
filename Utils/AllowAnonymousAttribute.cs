using System;
using System.Collections.Generic;
using System.Reflection;

namespace OpenVkNetApi.Utils
{
    /// <summary>
    /// Indicates that the API method can be called without authorization (no access token required).
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public class AllowAnonymousAttribute : Attribute
    {
        private static HashSet<string> _anonymousMethods;
        private static readonly object _lock = new object();

        /// <summary>
        /// Checks if the specified full API method name (e.g. "users.get") is marked as AllowAnonymous.
        /// </summary>
        public static bool IsAnonymous(string method)
        {
            if (_anonymousMethods == null)
            {
                lock (_lock)
                {
                    if (_anonymousMethods == null)
                    {
                        _anonymousMethods = DetectAnonymousMethods();
                    }
                }
            }
            return _anonymousMethods.Contains(method);
        }

        private static HashSet<string> DetectAnonymousMethods()
        {
            var result = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            try
            {
                var methodBaseType = typeof(MethodBase);
                var assembly = typeof(AllowAnonymousAttribute).GetTypeInfo().Assembly;
                foreach (var typeInfo in assembly.DefinedTypes)
                {
                    if (typeInfo.IsSubclassOf(methodBaseType))
                    {
                        string category = typeInfo.Name.ToLower();

                        foreach (var method in typeInfo.AsType().GetRuntimeMethods())
                        {
                            if (method.IsPublic && !method.IsStatic)
                            {
                                var attr = method.GetCustomAttribute<AllowAnonymousAttribute>();
                                if (attr != null)
                                {
                                    string methodName = method.Name;
                                    if (methodName.EndsWith("Async"))
                                    {
                                        methodName = methodName.Substring(0, methodName.Length - 5);
                                    }

                                    if (methodName.Length > 0)
                                    {
                                        methodName = char.ToLower(methodName[0]) + methodName.Substring(1);
                                    }

                                    result.Add(string.Format("{0}.{1}", category, methodName));
                                }
                            }
                        }
                    }
                }
            }
            catch { }
            return result;
        }
    }
}
