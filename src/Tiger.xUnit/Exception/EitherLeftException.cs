using JetBrains.Annotations;
using Tiger.Types;

// ReSharper disable once CheckNamespace
namespace Xunit.Sdk
{
    /// <summary>
    /// Exception thrown when an <see cref="Either{TLeft,TRight}"/>
    /// is unexpectedly not in the Left state.
    /// </summary>
    [PublicAPI]
#if XUNIT_VISIBILITY_INTERNAL
    internal
#else
    public
#endif
    class EitherLeftException
        : AssertActualExpectedException
    {
        /// <summary>Initializes a new instance of the <see cref="EitherLeftException"/> class.</summary>
        public EitherLeftException()
            : base("Left", "Right", "The result was not in the expected state.", "Expected State", "Actual State")
        {
        }
    }
}
