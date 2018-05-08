// <copyright file="EitherAsserts.cs" company="Cimpress, Inc.">
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
    /// <summary>Assertions specialized for <see cref="Either{TLeft, TRight}"/>.</summary>
    [SuppressMessage("System", "CA1052", Justification = "Not ours to modify.")]
#if XUNIT_VISIBILITY_INTERNAL
    internal
#else
    public
#endif
    partial class Assert
    {
        /// <summary>Verifies that a given either is in the Right state.</summary>
        /// <typeparam name="TLeft">The Left type.</typeparam>
        /// <typeparam name="TRight">The Right type.</typeparam>
        /// <param name="either">The either.</param>
        /// <returns>The Right value of the either.</returns>
        /// <exception cref="EitherRightException">The either is not in the Right state.</exception>
        public static TRight Right<TLeft, TRight>(Either<TLeft, TRight> either)
        {
            if (!either.IsRight)
            {
                throw new EitherRightException();
            }

            return either.Value;
        }

        /// <summary>Verifies that a given either is in the Left state.</summary>
        /// <typeparam name="TLeft">The Left type.</typeparam>
        /// <typeparam name="TRight">The Right type.</typeparam>
        /// <param name="either">The either.</param>
        /// <returns>The Left value of the either.</returns>
        /// <exception cref="EitherLeftException">The either is not in the Left state.</exception>
        public static TLeft Left<TLeft, TRight>(Either<TLeft, TRight> either)
        {
            if (!either.IsLeft)
            {
                throw new EitherLeftException();
            }

            return (TLeft)either;
        }
    }
}
