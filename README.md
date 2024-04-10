# USharpVideoModernUI
This is a fork from the popular VRChat USharpVideo video player with a new modern looking UI. It supports normal videos and live streams.

![image](https://github.com/DrBlackRat/USharpVideoModernUI/assets/46327609/8e0d9b69-fec2-441e-9fe4-c43ef9958826)


### See the [Wiki](https://github.com/MerlinVR/USharpVideo/wiki) for more info on advanced configuration and tips + guides
### Example World: https://vrchat.com/home/world/wrld_218396b0-f3c5-4f60-965c-0a27fa8d0a38

## Download
USharpVideoModernUI  is available via the [Creator Companion](https://vcc.docs.vrchat.com/) as a VPM package!
###  [⬇️ My VPM / Creator Companion Listing](https://drblackrat.github.io/vpm-listing/)


## Features
- Updated Modern UI
- Allows master only/everyone lock toggle for video playing
- Video seeking and duration info
- Pause/Play
- Loop video button
- Shows master and the last person to play a video
- Default playlist that plays when entering the world
- Stream player
- Support for YouTube timestamped URL's (youtube.com?v=\<video\>&t=\<seconds\>)
- Volume slider
- Reload button
- Supports YouTube link resolution in the editor the same as in VRC

## Installation
1. Install the latest VRCSDK and latest release of UdonSharp using the [VRChat Creator Companion](https://vrchat.com/home/download)
2. Install the [latest](https://github.com/MerlinVR/USharpVideo/releases/latest) release
2. Drag the USharpVideo prefab into your scene, resize to fit
3. Optionally bake realtime GI for the scene

There is also an example scene with the video player setup with lightmapping and everything in the `USharpVideo/Examples` directory.

## FAQ
### Does YouTube work on Quest?
Yes, YouTube is supported on Quest by default by VRChat now.

### Can this Fork replace exisitng USharpVideo without causing porblems?
Yes! When adding it to worlds that already have USharpVideo, it will just replace the UI and everything else should still work as expeced.

### Do custom Styles still work with this Fork?
Yes! The modernized UI still uses the default USharpVideo Sytles, however the default Sytles have been adjusted a bit and a few unused colors have been removed from the list.

## Credits:
- USharpVideo:
  - https://github.com/MerlinVR/USharpVideo
- Merlin (Original creator of USharpVideo & UdonSharp)
  - https://twitter.com/MerlinVR_
- DrBlackRat (Creator of this Fork)
  - https://drblackrat.xyz
