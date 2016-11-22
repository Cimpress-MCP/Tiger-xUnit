using JetBrains.Annotations;
using Tiger.ErrorTypes;

// ReSharper disable once CheckNamespace
namespace Xunit.Sdk
{
    /// <summary>
    /// Exception thrown when a <see cref="Try{TOk}"/>
    /// is unexpectedly not in the None state.
    /// </summary>
    [PublicAPI]
    public class TryNoneException
        : AssertActualExpectedException
    {
        /// <summary>Initializes a new instance of the <see cref="TryNoneException"/> class.</summary>
        public TryNoneException()
            : base("None", new[] { "Err", "OK" }, "The try was not in the expected state.", "Expected State", "Actual State")
        {
        }
    }
}
