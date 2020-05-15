using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.Structure;


namespace WebcamTracker {
  class FrameProcessor {
    public bool blurEdges { get; set; } = false;
    private List<Image<Bgr, byte>> frameBuffer = new List<Image<Bgr, byte>>();


    public static Image<Bgr, byte> bitmapToImageCV(Bitmap bmp) {
      return bmp.ToImage<Bgr, byte>();
    }

    public Bitmap edgeDetection(Bitmap bmp, int thresh, int linkSize) {
      var imageCV = bitmapToImageCV(bmp);
      frameBuffer.Add(imageCV);
      if (frameBuffer.Count > 10) frameBuffer.RemoveAt(0);

      

      var edges = imageCV.Canny(thresh, linkSize);

      if (blurEdges) {
        var blurEdges = edges.Convolution(Convolve.gauss5pxkernel);
        edges = blurEdges.Convert<Gray, byte>();
      }
      
      var edgeChannels = new Image<Gray, byte>[] { edges, edges, edges };
      var rgbEdges = new Image<Bgr, byte>(edgeChannels);
      var mashed = rgbEdges.Add(imageCV);
      var bitmap = mashed.ToBitmap();
      var g = Graphics.FromImage(bitmap);
      var pen = new Pen(Color.Black);
      g.DrawArc(pen, 10, 10, 50, 50, 0, 360);
      var sharpened = imageCV.Convolution(Convolve.sharpen3pxkernel);
      return sharpened.ToBitmap();
    }
  }
}
