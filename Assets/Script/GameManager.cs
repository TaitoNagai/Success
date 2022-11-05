using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

public class GameManager : MonoBehaviour
{
    [SerializeField] StatsView _statsView = null;
    [SerializeField] Slider _staminaSlider = null;
    public int _powerIndex { get => NowP; }
    public int _meetIndex { get => NowM; }
    public int _speedIndex { get => NowS; }
    public int _defenseIndex { get => NowD; }
    private int _stamina = 100;

    //ˆ——p
    public int P;
    public int M;
    public int S;
    public int D;

    public int NowP;
    public int NowM;
    public int NowS;
    public int NowD;

    //‘«‚·’l
    public int _powerNum = 5;
    public int _fishingNum = 3;
    public int _meetNum = 5;
    public int _golfNum = 3;
    public int _speedNum = 5;
    public int _gameNum = 3;
    public int _defenseNum = 5;
    public int _cafeNum = 3;

    private void Start()
    {
        //‰Šú’l
        NowP = 1;
        NowM = 1;
        NowS = 1;
        NowD = 1;

        //_staminaSlider.GetComponent<Slider>();
    }
    //—ûKŒø‰Ê
    public void Kinryoku()
    {
        NowP += _powerNum;
        if (NowP >= 100)
        {
            NowP = 100;
            _powerNum = 0;
        }

        if (NowP == P)
        {
            IntN();
        }
    }
    public void Dageki()
    {
        NowM += _meetNum;
        if (NowM >= 100)
        {
            NowM = 100;
            _meetNum = 0;
        }

        if (NowM == M)
        {
            IntN();
        }
    }
    public void Sourui()
    {
        NowS += _speedNum;
        if (NowS >= 100)
        {
            NowS = 100;
            _speedNum = 0;
        }

        if (NowS == S)
        {
            IntN();
        }
    }
    public void Syubi()
    {
        NowD += _defenseNum;
        if (NowD >= 100)
        {
            NowD = 100;
            _defenseNum = 0;
        }

        if (NowD == D)
        {
            IntN();
        }
    }

    //—V‚ÑŒø‰Ê
    public void Fishing()
    {
        NowP += _fishingNum;
        if (NowP >= 100)
        {
            NowP = 100;
            _fishingNum = 0;
        }

        if (NowP == P)
        {
            IntN();
        }
    }
    public void Golf()
    {
        NowM += _golfNum;
        if (NowM >= 100)
        {
            NowM = 100;
            _golfNum = 0;
        }

        if (NowM == M)
        {
            IntN();
        }
    }
    public void Game()
    {
        NowS += _gameNum;
        if (NowS >= 100)
        {
            NowS = 100;
            _gameNum = 0;
        }

        if (NowS == S)
        {
            IntN();
        }
    }
    public void Cafe()
    {
        NowD += _cafeNum;
        if (NowD >= 100)
        {
            NowD = 100;
            _cafeNum = 0;
        }

        if (NowD == D)
        {
            IntN();
        }
    }

    public void IntN()
    {
        FindObjectOfType<StatsButton>().IntN();
    }
}
