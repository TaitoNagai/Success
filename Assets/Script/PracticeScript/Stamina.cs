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
        //スライダー取得
        _slider = GameObject.Find("Slider").GetComponent<Slider>();
    }

    void Update()
    {
        // HP上昇
        _hp += 0.01f;
        if (_hp > 1)
        {
            // 最大を超えたら0に戻す
            _hp = 0;
        }
    }
}
