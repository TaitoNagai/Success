using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsButton : MonoBehaviour
{
    StatsModel _statsModel = new StatsModel();
    [SerializeField] StatsView _statsView;
    int power = 1;
    int meet = 1;
    int speed = 1;
    int defense = 1;

    private void Start()
    {
        ChangeStats();
    }
    //—ûK
    public void ChangeStats()
    {
        _statsModel.Subscribe(0, p => { _statsView.ChangePowerText(p); }, _statsView.gameObject);
        _statsModel.Subscribe(1, m => { _statsView.ChangeMeetText(m); }, _statsView.gameObject);
        _statsModel.Subscribe(2, s => { _statsView.ChangeSpeedText(s); }, _statsView.gameObject);
        _statsModel.Subscribe(3, d => { _statsView.ChangeDefenseText(d); }, _statsView.gameObject);
    }

    public void Kinryoku(int PPlus)
    {
        _statsModel.Kinryoku(PPlus);
    }

    public void Dageki(int MPlus)
    {
        _statsModel.Dageki(MPlus);
    }

    public void Sourui(int SPlus)
    {
        _statsModel.Sourui(SPlus);
    }

    public void Syubi(int DPlus)
    {
        _statsModel.Syubi(DPlus);
    }
}
