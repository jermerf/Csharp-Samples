using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace WebcamTracker {
  public partial class MainForm : Form {
    public MainForm() {
      InitializeComponent();
    }

    FilterInfoCollection filterInfoCollection;
    VideoCaptureDevice videoDevice;
    bool capturing = false;

    FrameProcessor frameProcessor = new FrameProcessor();

    private void MainForm_Load(object sender, EventArgs e) {
      filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
      foreach(FilterInfo info in filterInfoCollection) {
        chooseCamera.Items.Add(info.Name);
      }
      chooseCamera.SelectedIndex = 0;
      videoDevice = new VideoCaptureDevice();
      btnCapture_Click(null, null);
    }

    private void btnCapture_Click(object sender, EventArgs e) {
      if (capturing) {
        videoDevice.Stop();
        btnCapture.Text = "Capture";
        capturing = false;
      } else {
        string deviceMoniker = filterInfoCollection[chooseCamera.SelectedIndex].MonikerString;
        videoDevice = new VideoCaptureDevice(deviceMoniker);
        videoDevice.NewFrame += videoDevice_Frame;
        videoDevice.Start();
        btnCapture.Text = "Stop";
        capturing = true;
      }
    }

    private void videoDevice_Frame(object sender, NewFrameEventArgs e) {
      imgCapture.Image = frameProcessor.edgeDetection(e.Frame, (int)numThreshold.Value, (int)numLinkSize.Value);
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
      if(videoDevice.IsRunning)
        videoDevice.Stop();
    }

    private void checkBlur_CheckedChanged(object sender, EventArgs e) {
      frameProcessor.blurEdges = checkBlur.Checked;
    }
  }
}
