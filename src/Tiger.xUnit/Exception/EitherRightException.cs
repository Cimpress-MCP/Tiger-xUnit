﻿using JetBrains.Annotations;
using Tiger.Types;

// ReSharper disable once CheckNamespace
namespace Xunit.Sdk
{
    /// <summary>
    /// Exception thrown when an <see cref="Either{TLeft,TRight}"/>
    /// is unexpectedly not in the Right state.
    /// </summary>
    [PublicAPI]
    public class EitherRightException
        : AssertActualExpectedException
    {
        /// <summary>Initializes a new instance of the <see cref="EitherRightException"/> class.</summary>
        public EitherRightException()
            : base("Right", "Left", "The result was not in the expected state.", "Expected State", "Actual State")
        {
        }
    }
}