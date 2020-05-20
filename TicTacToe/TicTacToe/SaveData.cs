using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe {
  [Serializable]
  public class SaveData {

    public List<Player> Players { get; } = new List<Player>();

    public void saveChanges() {
      IFormatter formatter = new BinaryFormatter();
      Stream fileStream = new FileStream("save.dat", FileMode.Create, FileAccess.Write);
      formatter.Serialize(fileStream, this);
      fileStream.Close();
    }

    public static SaveData load() {
      try {
        IFormatter formatter = new BinaryFormatter();
        Stream fileStream = new FileStream("save.dat", FileMode.Open, FileAccess.Read);
        SaveData loaded = (SaveData)formatter.Deserialize(fileStream);
        fileStream.Close();
        return loaded;
      } catch (Exception ex) {
        return new SaveData();
      }      
    }
  }
}
