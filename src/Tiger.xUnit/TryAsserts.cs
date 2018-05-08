// <copyright file="TryAsserts.cs" company="Cimpress, Inc.">
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
using Xunit.Sdk;

namespace Xunit
{
    /// <summary>Assertions specialized for <see cref="Try{TErr, TOk}"/>.</summary>
    [SuppressMessage("System", "CA1052", Justification = "Not ours to modify.")]
#if XUNIT_VISIBILITY_INTERNAL
    internal
#else
    public
#endif
    partial class Assert
    {
        /// <summary>Verifies that a given result is in the Ok state.</summary>
        /// <typeparam name="TErr">The Err type.</typeparam>
        /// <typeparam name="TOk">The Ok type.</typeparam>
        /// <param name="result">The result.</param>
        /// <returns>The Ok value of the result.</returns>
        /// <exception cref="TryOkException">The result is not in the Ok state.</exception>
        public static TOk Ok<TErr, TOk>(Try<TErr, TOk> result)
        {
            if (!result.IsOk)
            {
                throw new TryOkException();
            }

            return result.Value;
        }

        /// <summary>Verifies that a given result is in the Err state.</summary>
        /// <typeparam name="TErr">The Err type.</typeparam>
        /// <typeparam name="TOk">The Ok type.</typeparam>
        /// <param name="result">The result.</param>
        /// <returns>The Err value of the result.</returns>
        /// <exception cref="TryErrException">The result is not in the Err state.</exception>
        public static TErr Err<TErr, TOk>(Try<TErr, TOk> result)
        {
            if (!result.IsErr)
            {
                throw new TryErrException();
            }

            return (TErr)result;
        }

        /// <summary>Verifies that a given result is in the None state.</summary>
        /// <typeparam name="TErr">The Err type.</typeparam>
        /// <typeparam name="TOk">The Ok type.</typeparam>
        /// <param name="result">The result.</param>
        /// <exception cref="TryNoneException">The result is not in the None state.</exception>
        public static void None<TErr, TOk>(Try<TErr, TOk> result)
        {
            if (!result.IsNone)
            {
                throw new TryNoneException();
            }
        }
    }
}
