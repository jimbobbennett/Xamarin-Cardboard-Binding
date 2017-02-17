using System;

namespace Cardboard
{
   public enum renderingMode : uint
   {
      StereoPanning,
      BinauralLowQuality,
      BinauralHighQuality
   }

   public enum materialName : uint
   {
      Transparent,
      AcousticCeilingTiles,
      BrickBare,
      BrickPainted,
      ConcreteBlockCoarse,
      ConcreteBlockPainted,
      CurtainHeavy,
      FiberGlassInsulation,
      GlassThin,
      GlassThick,
      Grass,
      LinoleumOnConcrete,
      Marble,
      ParquetOnConcrete,
      PlasterRough,
      PlasterSmooth,
      PlywoodPanel,
      PolishedConcreteOrTile,
      Sheetrock,
      WaterOrIceSurface,
      WoodCeiling,
      WoodPanel
   }
}
