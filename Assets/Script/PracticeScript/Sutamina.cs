using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sutamina : MonoBehaviour
{
    [SerializeField] private int _maxStamina = 100;
    int _useStamina = 5;

    StatsButton _statsButton = new StatsButton();

    public void DownStamina()
    {
        _statsButton.Kinryoku(_maxStamina - _useStamina);
    }
}
