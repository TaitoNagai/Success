using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonGenerator : MonoBehaviour
{
    [SerializeField] GameObject _button = null;

    private void Start()
    {
        _button = GetComponent<GameObject>();
    }


}
