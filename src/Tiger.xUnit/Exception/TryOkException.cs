using JetBrains.Annotations;
using Tiger.ErrorTypes;

// ReSharper disable once CheckNamespace
namespace Xunit.Sdk
{
    /// <summary>
    /// Exception thrown when a <see cref="Try{TOk}"/>
    /// is unexpectedly not in the OK state.
    /// </summary>
    [PublicAPI]
    public class TryOkException
        : AssertActualExpectedException
    {
        /// <summary>Initializes a new instance of the <see cref="TryOkException"/> class.</summary>
        public TryOkException()
            : base("OK", new[] { "None", "Err" }, "The result was not in the expected state.", "Expected State", "Actual State")
        {
        }
    }
}
