using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stamina : MonoBehaviour
{
    Slider _slider;
    float _hp = 0;

    private void Start()
    {
        //�X���C�_�[�擾
        GameObject ui = (GameObject)Resources.Load("");
        _slider = GameObject.Find("Slider").GetComponent<Slider>();
    }

    void Update()
    {
        // HP�㏸
        if (_hp > 1)
        {
            // �ő�𒴂�����0�ɖ߂�
            _hp = 0;
        }
    }
}
