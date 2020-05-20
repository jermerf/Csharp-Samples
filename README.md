# WebCam Instructions

To try the webcam project:
* Download the git files either the zip or in a terminal
  ```
  git clone https://github.com/jermerf/Csharp-Samples.git
  ```
* Open the WebcamTracker project in Visual Studio
  ```
  WebcamTacker/WebcamTracker.sln
  ```
* Open the dependency package manager
  ```
  Tools -> NuGet Package Manager -> Manage NuGet Packages for Solution
  ```
* At the top of the package manager you'll see a bar that mentions restoring your online packages.
  * Click Restore on the right

* You should have these packages and some dependencies installed:
  * AForge
  * AForge.Video.DirectShow
  * Emgu.CV
  * Emgu.CV.runtime.windows
* Go look at a code file like ```FrameProcessor.cs```, everything is red.
* The project just needs to be rebuilt
  ```
  Build -> Rebuild Solution
  ```
* Run it