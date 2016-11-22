using JetBrains.Annotations;
using Tiger.ErrorTypes;
using Xunit.Sdk;

// ReSharper disable once CheckNamespace
namespace Xunit
{
    /// <summary>XUnit assertions specialized for <see cref="Result{TOk}"/>.</summary>
    public partial class Assert
    {
        /// <summary>Verifies that a given result is in the OK state.</summary>
        /// <typeparam name="TOk">The OK type.</typeparam>
        /// <param name="result">The result.</param>
        /// <returns>The OK value of the result.</returns>
        /// <exception cref="ResultOkException">The result is not in the OK state.</exception>
        [NotNull]
        public static TOk Ok<TOk>(Result<TOk> result)
        {
            if (!result.IsOk)
            {
                throw new ResultOkException();
            }

            return result.Value;
        }

        /// <summary>Verifies that a given result is in the Err state.</summary>
        /// <typeparam name="TOk">The OK type.</typeparam>
        /// <param name="result">The result.</param>
        /// <returns>The Err value of the result.</returns>
        /// <exception cref="ResultErrException">The result is not in the Err state.</exception>
        public static Error Err<TOk>(Result<TOk> result)
        {
            if (!result.IsErr)
            {
                throw new ResultErrException();
            }

            return (Error)result;
        }
    }
}
