using Tiger.Types;

// ReSharper disable once CheckNamespace
namespace Xunit.Sdk
{
    /// <summary>
    /// Exception thrown when an <see cref="Option{TSome}"/> is unexpectedly not in the Some state.
    /// </summary>
#if XUNIT_VISIBILITY_INTERNAL
    internal
#else
    public
#endif
    class OptionSomeException
        : AssertActualExpectedException
    {
        /// <summary>Initializes a new instance of the <see cref="OptionSomeException"/> class.</summary>
        public OptionSomeException()
            : base("Some", "None", "The result was not in the expected state.", "Expected State", "Actual State")
        {
        }
    }
}
