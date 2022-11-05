using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class StatsView : MonoBehaviour
{
    [SerializeField] GameManager _gameManager = null;
    //テキスト表示
    [SerializeField] Text _powerText; 
    [SerializeField] Text _meetText;
    [SerializeField] Text _speedText;
    [SerializeField] Text _defenseText;


    public void ChangePowerText(int numPower)
    {
        _powerText.text = numPower.ToString();
    }

    private void Update()
    {
        //_powerText.text = _gameManager._powerIndex.ToString();
        _meetText.text = _gameManager._meetIndex.ToString();
        _speedText.text = _gameManager._speedIndex.ToString();
        _defenseText.text = _gameManager._defenseIndex.ToString();
    }
}
