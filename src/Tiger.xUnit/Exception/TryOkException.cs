// <copyright file="TryOkException.cs" company="Cimpress, Inc.">
//   Copyright 2017 Cimpress, Inc.
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>

using System.Diagnostics.CodeAnalysis;
using Tiger.Types;

namespace Xunit.Sdk
{
    /// <summary>
    /// Exception thrown when a <see cref="Try{TErr, TOk}"/> is unexpectedly not in the Ok state.
    /// </summary>
    [SuppressMessage("System", "CA1032", Justification = "Base class doesn't.")]
    [SuppressMessage("System", "RCS1194", Justification = "Base class doesn't.")]
#if XUNIT_VISIBILITY_INTERNAL
    internal
#else
    public
#endif
    class TryOkException
        : AssertActualExpectedException
    {
        /// <summary>Initializes a new instance of the <see cref="TryOkException"/> class.</summary>
        public TryOkException()
            : base("Ok", new[] { "None", "Err" }, "The result was not in the expected state.", "Expected State", "Actual State")
        {
        }
    }
}
