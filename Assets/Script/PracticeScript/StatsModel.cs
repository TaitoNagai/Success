using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;
using Unity.VisualScripting;

public class StatsModel
{
    ReactiveProperty<int> _numP = new ReactiveProperty<int>();
    int _powerStats = 1;
    ReactiveProperty<int> _numM = new ReactiveProperty<int>();
    int _meetStats = 1;
    ReactiveProperty<int> _numS = new ReactiveProperty<int>();
    int _speedStats = 1;
    ReactiveProperty<int> _numD = new ReactiveProperty<int>();
    int _defenseStats = 1;

    [SerializeField] int P;
    [SerializeField] int M;
    [SerializeField] int S;
    [SerializeField] int D;

    public void Subscribe(int type, System.Action<int> action, GameObject gameObject)
    {
        switch(type)
        {
            case 0:
                _numP.Subscribe(action).AddTo(gameObject);
                break;
            case 1:
                _numM.Subscribe(action).AddTo(gameObject);
                break;
            case 2:
                _numS.Subscribe(action).AddTo(gameObject);
                break;
            case 3:
                _numD.Subscribe(action).AddTo(gameObject);
                break;
        }
    }

    public StatsModel()
    {
        //スタートの値
        _numP.Value = _powerStats;
        _numM.Value = _meetStats;
        _numS.Value = _speedStats;
        _numD.Value = _defenseStats;
    }

    public void Kinryoku(int PPlus)
    {
        //ステータス範囲
        _numP.Value = Mathf.Clamp(_numP.Value += PPlus, 1, 100);
    }

    public void Dageki(int MPlus)
    {
        _numM.Value = Mathf.Clamp(_numM.Value += MPlus, 1, 100);
    }

    public void Sourui(int SPlus)
    {
        _numS.Value = Mathf.Clamp(_numS.Value += SPlus, 1, 100);
    }

    public void Syubi(int DPlus)
    {
        _numD.Value = Mathf.Clamp(_numD.Value += DPlus, 1, 100);
    }
}
