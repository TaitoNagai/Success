using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    AudioSource _as;

    void Start()
    {
        _as = GetComponent<AudioSource>();
    }

    public void SceneChanger(string name)
    {
        SceneManager.LoadScene(name);
    }
}
