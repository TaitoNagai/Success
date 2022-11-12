using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class StatsView : MonoBehaviour
{
    //�e�L�X�g�\��
    [SerializeField] Text _powerText; 
    [SerializeField] Text _meetText;
    [SerializeField] Text _speedText;
    [SerializeField] Text _defenseText;


    public void ChangePowerText(int numPower)
    {
        _powerText.text = numPower.ToString();
    }

    public void ChangeMeetText(int numMeet)
    {
        _meetText.text = numMeet.ToString();
    }

    public void ChangeSpeedText(int numSpeed)
    {
        _speedText.text = numSpeed.ToString();
    }

    public void ChangeDefenseText(int numDefense)
    {
        _defenseText.text = numDefense.ToString();
    }
}
