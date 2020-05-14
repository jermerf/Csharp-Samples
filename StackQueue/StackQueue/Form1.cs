using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueueStack {
  public partial class Form1 : Form {
    private string originalTitle;
    public Form1() {
      InitializeComponent();
      originalTitle = this.Text;
    }

    private void btnEnQueue_Click(object sender, EventArgs e) {
      listQueue.Items.Add(txtQueue.Text);
      txtQueue.Text = "";
    }

    private void btnDeQueue_Click(object sender, EventArgs e) {
      if (listQueue.Items.Count == 0) return;
      txtQueue.Text = listQueue.Items[0].ToString();
      listQueue.Items.RemoveAt(0);
    }

    private void btnPush_Click(object sender, EventArgs e) {
      listStack.Items.Add(txtStack.Text);
      txtStack.Text = "";
    }

    private void btnPop_Click(object sender, EventArgs e) {
      if (listStack.Items.Count == 0) return;
      txtStack.Text = listStack.Items[listStack.Items.Count - 1].ToString();
      listStack.Items.RemoveAt(listStack.Items.Count - 1);
    }

    private void btnLoad_Click(object sender, EventArgs e) {
      IFormatter formatter = new BinaryFormatter();
      Stream fileStream = new FileStream("save.dat", FileMode.Open, FileAccess.Read);
      SaveData data = (SaveData) formatter.Deserialize(fileStream);
      fileStream.Close();

      listQueue.Items.Clear();
      listStack.Items.Clear();
      listQueue.Items.AddRange(data.queue.ToArray());
      listStack.Items.AddRange(data.stack.ToArray());
      txtQueue.Text = data.queueTextBox;
      txtStack.Text = data.stackTextBox;
    }

    private void btnSave_Click(object sender, EventArgs e) {
      SaveData data = new SaveData(
        listQueue.Items.Cast<String>().ToList(),
        listStack.Items.Cast<String>().ToList(),
        txtQueue.Text, txtStack.Text
        );

      IFormatter formatter = new BinaryFormatter();
      Stream fileStream = new FileStream("save.dat", FileMode.Create, FileAccess.Write);
      formatter.Serialize(fileStream, data);
      fileStream.Close();
      this.Text = originalTitle + " - Saved";
      lblStatus.Text = "Saved successfully";
    }

  }
}
