// Copyright (c) Xenko contributors (https://xenko.com) and Silicon Studio Corp. (https://www.siliconstudio.co.jp)
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.

namespace Xenko.Input
{
    /// <summary>
    /// Provides information about an object exposed by a gamepad
    /// </summary>
    public class GameControllerObjectInfo
    {
        /// <summary>
        /// The name of the object, reported by the device
        /// </summary>
        public string Name;

        public override string ToString()
        {
            return $"GameController Object {{{Name}}}";
        }
    }
}