# SVT-AV1 GUI [![Travis Build Status](https://travis-ci.org/moisesmcardona/svt-av1-gui.svg?branch=master)](https://travis-ci.org/moisesmcardona/svt-av1-gui) [![AppVeyor Build Status](https://ci.appveyor.com/api/projects/status/github/moisesmcardona/svt-av1-gui?branch=master&svg=true)](https://ci.appveyor.com/project/moisesmcardona/svt-av1-gui)

A GUI to convert video files to AV1 using SVT-AV1

(Screenshot goes here)

I wrote this software to test the rav1e software. Unfortunately, at the current state, rav1e is single-threaded. This GUI solves the issue and enable multithreading by converting and splitting the input video file into segments of the length specified by the user in y4m format and encoding the audio to Opus ffmpeg. It then encodes each file using a CPU thread. After the encoding is finished, the .ivf files are concatenated. Lastly, the .ivf and .opus files are merged into a .webm or .mkv container.

Written in Visual Basic .NET using Visual Studio 2019.

## Dependencies:

* You need ffmpeg as found here: https://ffmpeg.zeranoe.com/builds/. Use the nightly builds. [Instructions here.](https://moisescardona.me/downloading-ffmpeg-svt-av1-gui/)

Builds comes with opusenc and SVT-AV1 bundled, but not ffmpeg due to licensing restrictions.

# Updated components builds:

Ocasionally, SVT-AV1 and opusenc gets updated. You can download the latest version of SVT-AV1 GUI with these updated tools included here: [https://moisescardona.me/rav1e-gui](https://moisescardona.me/rav1e-gui)

Enjoy!
