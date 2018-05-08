// <copyright file="OptionAsserts.cs" company="Cimpress, Inc.">
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
    /// <summary>Assertions specialized for <see cref="Option{TSome}"/>.</summary>
    [SuppressMessage("System", "CA1052", Justification = "Not ours to modify.")]
#if XUNIT_VISIBILITY_INTERNAL
    internal
#else
    public
#endif
    partial class Assert
    {
        /// <summary>Verifies that a given option is in the Some state.</summary>
        /// <typeparam name="TSome">The Some type.</typeparam>
        /// <param name="option">The option.</param>
        /// <returns>The Some value of the option.</returns>
        /// <exception cref="OptionSomeException">The option is not in the Some state.</exception>
        public static TSome Some<TSome>(Option<TSome> option)
        {
            if (!option.IsSome)
            {
                throw new OptionSomeException();
            }

            return option.Value;
        }

        /// <summary>Verifies that a given option is in the None state.</summary>
        /// <typeparam name="TSome">The Some type.</typeparam>
        /// <param name="option">The option.</param>
        /// <exception cref="OptionNoneException">The result is not in the None state.</exception>
        public static void None<TSome>(Option<TSome> option)
        {
            if (!option.IsNone)
            {
                throw new OptionNoneException();
            }
        }
    }
}
