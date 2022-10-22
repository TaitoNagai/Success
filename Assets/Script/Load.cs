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
            // �o�C�i���`���Ńf�V���A���C�Y
            BinaryFormatter bf = new BinaryFormatter();
            // �w�肵���p�X�̃t�@�C���X�g���[�����J��
            FileStream file = File.Open(SaveFilePath, FileMode.Open);
            try
            {
                // �w�肵���t�@�C���X�g���[�����I�u�W�F�N�g�Ƀf�V���A���C�Y�B
                Save NowNumber = (Save)bf.Deserialize(file);
                // �ǂݍ��񂾃f�[�^�𔽉f�B
                var numberText = Instantiate(textPrefab) as Text;
                NowNumber.GetComponent<StatsView>().Dageki();
            }
            finally
            {
                // �t�@�C������ɂ͖����I�Ȕj�����K�v�ł��BClose��Y��Ȃ��悤�ɁB
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
