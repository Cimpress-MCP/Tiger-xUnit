using Tiger.ErrorTypes;

// ReSharper disable once CheckNamespace
namespace Xunit.Sdk
{
    /// <summary>
    /// Exception thrown when a <see cref="Result{TOk}"/> is unexpectedly not in the OK state.
    /// </summary>
#if XUNIT_VISIBILITY_INTERNAL
    internal
#else
    public
#endif
    class ResultOkException
        : AssertActualExpectedException
    {
        /// <summary>Initializes a new instance of the <see cref="ResultOkException"/> class.</summary>
        public ResultOkException()
            : base("OK", "Err", "The result was not in the expected state.", "Expected State", "Actual State")
        {
        }
    }
}
