using Emgu.CV;

namespace WebcamTracker {
  class Convolve {

    public static ConvolutionKernelF sharpen3pxkernel = new ConvolutionKernelF(new float[,] {
        {0, -1, 0},
        {-1, 5, -1},
        {0, -1, 0 }
      });
    public static ConvolutionKernelF gauss3pxkernel = new ConvolutionKernelF(new float[,] {
        {0.0625f, 0.125f, 0.0625f},
        {0.125f, 0.25f, 0.125f},
        {0.0625f, 0.125f, 0.0625f }
      });
    public static ConvolutionKernelF gauss5pxkernel = new ConvolutionKernelF(new float[,] {
        { 0.00390625f, 0.015625f, 0.0234375f, 0.015625f, 0.00390625f },
        { 0.015625f, 0.0625f, 0.09375f, 0.0625f, 0.015625f },
        { 0.0234375f, 0.09375f, 0.140625f, 0.09375f, 0.0234375f },
        { 0.015625f, 0.0625f, 0.09375f, 0.0625f, 0.015625f },
        { 0.00390625f, 0.015625f, 0.0234375f, 0.015625f, 0.00390625f }
      });
  }
}
