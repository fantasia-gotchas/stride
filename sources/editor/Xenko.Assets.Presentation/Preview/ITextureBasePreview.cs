// Copyright (c) Xenko contributors (https://xenko.com) and Silicon Studio Corp. (https://www.siliconstudio.co.jp)
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.
using System;
using System.Collections.Generic;

using Xenko.Core.Mathematics;

namespace Xenko.Assets.Presentation.Preview
{
    public interface ITextureBasePreview
    {
        float SpriteScale { get; set; }

        event EventHandler SpriteScaleChanged;

        IEnumerable<int> GetAvailableMipMaps();

        void DisplayMipMap(int parseMipMapLevel);

        void ZoomIn(Vector2? centerPosition);

        void ZoomOut(Vector2? centerPosition);

        void FitOnScreen();

        void ScaleToRealSize();
    }
}
