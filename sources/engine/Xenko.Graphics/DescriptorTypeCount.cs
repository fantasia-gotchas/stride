// Copyright (c) Xenko contributors (https://xenko.com) and Silicon Studio Corp. (https://www.siliconstudio.co.jp)
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.
using Xenko.Shaders;

namespace Xenko.Graphics
{
    /// <summary>
    /// Describes how many descriptor of a specific type will need to be allocated in a <see cref="DescriptorPool"/>.
    /// </summary>
    public struct DescriptorTypeCount
    {
        public EffectParameterClass Type;
        public int Count;

        public DescriptorTypeCount(EffectParameterClass type, int count)
        {
            Type = type;
            Count = count;
        }
    }
}
