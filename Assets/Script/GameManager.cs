using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

public class GameManager : MonoBehaviour
{
    [SerializeField] StatsView _statsView = null;
    [SerializeField] Slider _staminaSlider = null;
    public int _powerIndex { get => _numP.Value; }
    public int _meetIndex { get => NowM; }
    public int _speedIndex { get => NowS; }
    public int _defenseIndex { get => NowD; }
    private int _stamina = 100;

    //èàóùóp
    public int P;
    public int M;
    public int S;
    public int D;

    //public int NowP;
    public int NowM;
    public int NowS;
    public int NowD;

    //ë´Ç∑íl
    public int _powerNum = 5;
    public int _fishingNum = 3;
    public int _meetNum = 5;
    public int _golfNum = 3;
    public int _speedNum = 5;
    public int _gameNum = 3;
    public int _defenseNum = 5;
    public int _cafeNum = 3;

    ReactiveProperty<int> _numP = new ReactiveProperty<int>();
    int _powerStats = 0;

    public GameManager(int _startPower, System.Action<int>action, GameObject gameObject)
    {
        _powerStats = _startPower;
        _numP.Subscribe(action).AddTo(gameObject);
        _numP.Value = _powerStats;
    }
    public void Kinryoku(int KPlus)
    {
        _numP.Value = Mathf.Clamp(_numP.Value += KPlus, 0 , 100);

        if (_numP.Value == P)
        {
            IntN();
        }
    }

    private void Start()
    {
        //èâä˙íl
        //_numP.Value = 1;
        //NowM = 1;
        //NowS = 1;
        //NowD = 1;

        //_staminaSlider.GetComponent<Slider>();
    }
    //ó˚èKå¯â 
    
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

    //óVÇ—å¯â 
    public void Fishing()
    {
        _numP.Value += _fishingNum;
        if (_numP.Value >= 100)
        {
            _numP.Value = 100;
            _fishingNum = 0;
        }

        if (_numP.Value == P)
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
