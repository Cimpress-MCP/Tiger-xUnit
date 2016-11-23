using JetBrains.Annotations;
using Tiger.ErrorTypes;
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
        /// <summary>Verifies that a given result is in the OK state.</summary>
        /// <typeparam name="TOk">The OK type.</typeparam>
        /// <param name="result">The result.</param>
        /// <returns>The OK value of the result.</returns>
        /// <exception cref="TryOkException">The result is not in the OK state.</exception>
        [NotNull]
        public static TOk Ok<TOk>(Try<TOk> result)
        {
            if (!result.IsOk)
            {
                throw new TryOkException();
            }

            return result.Value;
        }

        /// <summary>Verifies that a given result is in the Err state.</summary>
        /// <typeparam name="TOk">The OK type.</typeparam>
        /// <param name="result">The result.</param>
        /// <returns>The Err value of the result.</returns>
        /// <exception cref="TryErrException">The result is not in the Err state.</exception>
        public static Error Err<TOk>(Try<TOk> result)
        {
            if (!result.IsErr)
            {
                throw new TryErrException();
            }

            return (Error)result;
        }

        /// <summary>Verifies that a given result is in the None state.</summary>
        /// <typeparam name="TOk">The OK type.</typeparam>
        /// <param name="result">The result.</param>
        /// <exception cref="TryNoneException">The result is not in the None state.</exception>
        public static void None<TOk>(Try<TOk> result)
        {
            if (!result.IsNone)
            {
                throw new TryNoneException();
            }
        }
    }
}
