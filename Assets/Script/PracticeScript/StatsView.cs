using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class StatsView : MonoBehaviour
{
    public int NowP;
    public int NowM;
    public int NowS;
    public int NowD;

    //足す値
    public int _powerNum = 5;
    public int _fishingNum = 3;
    public int _meetNum = 5;
    public int _golfNum = 3;
    public int _speedNum = 5;
    public int _gameNum = 3;
    public int _defenseNum = 5;
    public int _cafeNum = 3;

    //テキスト表示
    public Text PowerText;
    public Text MeetText;
    public Text SpeedText;
    public Text DefenseText;

    //処理用
    public int P;
    public int M;
    public int S;
    public int D;

    private void Start()
    {
        NowP = 1;
        NowM = 1;
        NowS = 1;
        NowD = 1;
        PowerText.GetComponent<Text>();
        MeetText.GetComponent<Text>();
        SpeedText.GetComponent<Text>();
        DefenseText.GetComponent<Text>();
    }

    //練習効果
    public void Kinryoku()
    {
        NowP += _powerNum;
        PowerText.text = NowP.ToString();

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
        MeetText.text = NowM.ToString();

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
        SpeedText.text = NowS.ToString();

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
        DefenseText.text = NowD.ToString();

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

    //遊び効果
    public void Fishing()
    {
        NowP += _fishingNum;
        PowerText.text = NowP.ToString();

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
        MeetText.text = NowM.ToString();

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
        SpeedText.text = NowS.ToString();

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
        DefenseText.text = NowD.ToString();

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
