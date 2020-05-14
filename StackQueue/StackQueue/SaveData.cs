using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueStack {
  [Serializable]
  class SaveData {
    public List<string> queue { get; }
    public List<string> stack { get; }
    public string queueTextBox { get; }
    public string stackTextBox { get; }


    public SaveData(List<string> queue, List<string> stack, string qtb, string stb) {
      this.queue = queue;
      this.stack = stack;
      this.queueTextBox = qtb;
      this.stackTextBox = stb;
    }
  }
}
