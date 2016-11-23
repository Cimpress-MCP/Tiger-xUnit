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
        /// <summary>Verifies that a given either is in the Right state.</summary>
        /// <typeparam name="TLeft">The Left type.</typeparam>
        /// <typeparam name="TRight">The Right type.</typeparam>
        /// <param name="either">The either.</param>
        /// <returns>The Right value of the either.</returns>
        /// <exception cref="EitherRightException">The either is not in the Right state.</exception>
        [NotNull]
        public static TRight Right<TLeft, TRight>(Either<TLeft, TRight> either)
        {
            if (!either.IsRight)
            {
                throw new EitherRightException();
            }

            return either.Value;
        }

        /// <summary>Verifies that a given either is in the Left state.</summary>
        /// <typeparam name="TLeft">The Left type.</typeparam>
        /// <typeparam name="TRight">The Right type.</typeparam>
        /// <param name="either">The either.</param>
        /// <returns>The Left value of the either.</returns>
        /// <exception cref="EitherLeftException">The either is not in the Left state.</exception>
        [NotNull]
        public static TLeft Left<TLeft, TRight>(Either<TLeft, TRight> either)
        {
            if (!either.IsLeft)
            {
                throw new EitherLeftException();
            }

            return (TLeft)either;
        }
    }
}
