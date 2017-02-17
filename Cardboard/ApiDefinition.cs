using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace Cardboard
{
   // @interface GCSCardboardAudioEngine : NSObject
   [BaseType(typeof(NSObject))]
   [Protocol]
   interface GCSCardboardAudioEngine
   {
      // -(id)initWithRenderingMode:(renderingMode)rendering_mode;
      [Export("initWithRenderingMode:")]
      IntPtr Constructor(renderingMode rendering_mode);

      // -(_Bool)start;
      [Export("start")]
      bool Start();

      // -(void)stop;
      [Export("stop")]
      void Stop();

      // -(void)update;
      [Export("update")]
      void Update();

      // -(_Bool)preloadSoundFile:(const NSString *)filename;
      [Export("preloadSoundFile:")]
      bool PreloadSoundFile(string filename);

      // -(int)createSoundObject:(const NSString *)filename;
      [Export("createSoundObject:")]
      int CreateSoundObject(string filename);

      // -(int)createSoundfield:(const NSString *)filename;
      [Export("createSoundfield:")]
      int CreateSoundfield(string filename);

      // -(void)playSound:(int)soundId loopingEnabled:(_Bool)loopingEnabled;
      [Export("playSound:loopingEnabled:")]
      void PlaySound(int soundId, bool loopingEnabled);

      // -(void)stopSound:(int)soundId;
      [Export("stopSound:")]
      void StopSound(int soundId);

      // -(void)setSoundObjectPosition:(int)soundObjectId x:(float)x y:(float)y z:(float)z;
      [Export("setSoundObjectPosition:x:y:z:")]
      void SetSoundObjectPosition(int soundObjectId, float x, float y, float z);

      // -(void)setSoundVolume:(int)soundId volume:(float)volume;
      [Export("setSoundVolume:volume:")]
      void SetSoundVolume(int soundId, float volume);

      // -(_Bool)isSoundPlaying:(int)soundId;
      [Export("isSoundPlaying:")]
      bool IsSoundPlaying(int soundId);

      // -(void)setHeadPosition:(float)x y:(float)y z:(float)z;
      [Export("setHeadPosition:y:z:")]
      void SetHeadPosition(float x, float y, float z);

      // -(void)setHeadRotation:(float)x y:(float)y z:(float)z w:(float)w;
      [Export("setHeadRotation:y:z:w:")]
      void SetHeadRotation(float x, float y, float z, float w);

      // -(void)enableRoom:(_Bool)enable;
      [Export("enableRoom:")]
      void EnableRoom(bool enable);

      // -(void)setRoomProperties:(float)size_x size_y:(float)size_y size_z:(float)size_z wall_material:(materialName)wall_material ceiling_material:(materialName)ceiling_material floor_material:(materialName)floor_material;
      [Export("setRoomProperties:size_y:size_z:wall_material:ceiling_material:floor_material:")]
      void SetRoomProperties(float size_x, float size_y, float size_z, materialName wall_material, materialName ceiling_material, materialName floor_material);
   }
}
