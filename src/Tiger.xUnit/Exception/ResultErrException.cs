using JetBrains.Annotations;
using Tiger.ErrorTypes;

// ReSharper disable once CheckNamespace
namespace Xunit.Sdk
{
    /// <summary>
    /// Exception thrown when a <see cref="Result{TOk}"/>
    /// is unexpectedly not in the Err state.
    /// </summary>
    [PublicAPI]
#if XUNIT_VISIBILITY_INTERNAL
    internal
#else
    public
#endif
    class ResultErrException
        : AssertActualExpectedException
    {
        /// <summary>Initializes a new instance of the <see cref="ResultErrException"/> class.</summary>
        public ResultErrException()
            : base("Err", "OK", "The result was not in the expected state.", "Expected State", "Actual State")
        {
        }
    }
}
