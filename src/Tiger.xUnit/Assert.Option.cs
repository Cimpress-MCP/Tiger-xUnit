using JetBrains.Annotations;
using Tiger.Types;
using Xunit.Sdk;

// ReSharper disable once CheckNamespace
namespace Xunit
{
#if XUNIT_VISIBILITY_INTERNAL
    internal
#else
    public
#endif
    partial class Assert
    {
        /// <summary>Verifies that a given option is in the Some state.</summary>
        /// <typeparam name="TSome">The Some type.</typeparam>
        /// <param name="option">The option.</param>
        /// <returns>The Some value of the option.</returns>
        /// <exception cref="OptionSomeException">The option is not in the Some state.</exception>
        [NotNull]
        public static TSome Some<TSome>(Option<TSome> option)
        {
            if (!option.IsSome)
            {
                throw new OptionSomeException();
            }

            return option.Value;
        }

        /// <summary>Verifies that a given option is in the None state.</summary>
        /// <typeparam name="TSome">The Some type.</typeparam>
        /// <param name="option">The option.</param>
        /// <exception cref="OptionNoneException">The result is not in the None state.</exception>
        // ReSharper disable once UnusedParameter.Global
        public static void None<TSome>(Option<TSome> option)
        {
            if (!option.IsNone)
            {
                throw new OptionNoneException();
            }
        }
    }
}
