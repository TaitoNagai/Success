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
        _slider = GameObject.Find("Slider").GetComponent<Slider>();
    }

    void Update()
    {
        // HP�㏸
        _hp += 0.01f;
        if (_hp > 1)
        {
            // �ő�𒴂�����0�ɖ߂�
            _hp = 0;
        }
    }
}
