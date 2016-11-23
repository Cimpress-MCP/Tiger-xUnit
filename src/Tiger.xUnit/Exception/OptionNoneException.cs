using JetBrains.Annotations;
using Tiger.Types;

// ReSharper disable once CheckNamespace
namespace Xunit.Sdk
{
    /// <summary>
    /// Exception thrown when an <see cref="Option{TSome}"/>
    /// is unexpectedly not in the None state.
    /// </summary>
    [PublicAPI]
#if XUNIT_VISIBILITY_INTERNAL
    internal
#else
    public
#endif
    class OptionNoneException
        : AssertActualExpectedException
    {
        /// <summary>Initializes a new instance of the <see cref="OptionNoneException"/> class.</summary>
        public OptionNoneException()
            : base("None", "Some", "The result was not in the expected state.", "Expected State", "Actual State")
        {
        }
    }
}
