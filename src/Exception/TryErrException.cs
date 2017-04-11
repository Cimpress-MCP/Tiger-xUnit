using Tiger.ErrorTypes;

// ReSharper disable once CheckNamespace
namespace Xunit.Sdk
{
    /// <summary>
    /// Exception thrown when a <see cref="Try{TOk}"/> is unexpectedly not in the Err state.
    /// </summary>
#if XUNIT_VISIBILITY_INTERNAL
    internal
#else
    public
#endif
    class TryErrException
        : AssertActualExpectedException
    {
        /// <summary>Initializes a new instance of the <see cref="TryErrException"/> class.</summary>
        public TryErrException()
            : base("Err", new[] { "None", "OK" }, "The try was not in the expected state.", "Expected State", "Actual State")
        {
        }
    }
}
