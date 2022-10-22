using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.UI;

public class Load : MonoBehaviour
{
    public Text textPrefab;
    private string SaveFilePath;
    private void Start()
    {
        SaveFilePath = Application.persistentDataPath + "/savedNum.save";

        LoadPlayer();
    }
    private void LoadPlayer()
    {
        if (File.Exists(SaveFilePath))
        {
            // バイナリ形式でデシリアライズ
            BinaryFormatter bf = new BinaryFormatter();
            // 指定したパスのファイルストリームを開く
            FileStream file = File.Open(SaveFilePath, FileMode.Open);
            try
            {
                // 指定したファイルストリームをオブジェクトにデシリアライズ。
                Save NowNumber = (Save)bf.Deserialize(file);
                // 読み込んだデータを反映。
                var numberText = Instantiate(textPrefab) as Text;
                NowNumber.GetComponent<StatsView>().Dageki();
            }
            finally
            {
                // ファイル操作には明示的な破棄が必要です。Closeを忘れないように。
                if (file != null)
                    file.Close();
            }
        }
        else
        {
            Debug.Log("no load file");
        }
    }
}
