//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;
//using UniRx;
//using OpenCover.Framework.Model;

//public class GameManager : MonoBehaviour
//{
//    [SerializeField] StatsView _statsView = null;
//    [SerializeField] Slider _staminaSlider = null;
//    public int _powerIndex { get => _numP.Value; }
//    public int _meetIndex { get => _numM.Value; }
//    public int _speedIndex { get => _numS.Value; }
//    public int _defenseIndex { get => _numD.Value; }

    //private int _stamina = 100;

    //処理用
    

    //public int NowP;
    //public int NowM;
    //public int NowS;
    //public int NowD;

    ////足す値
    //public int _powerNum = 5;
    //public int _fishingNum = 3;
    //public int _meetNum = 5;
    //public int _golfNum = 3;
    //public int _speedNum = 5;
    //public int _gameNum = 3;
    //public int _defenseNum = 5;
    //public int _cafeNum = 3;

    //ReactiveProperty<int> _numP = new ReactiveProperty<int>();
    //int _powerStats = 0;
    //ReactiveProperty<int> _numM = new ReactiveProperty<int>();
    //int _meetStats = 0;
    //ReactiveProperty<int> _numS = new ReactiveProperty<int>();
    //int _speedStats = 0;
    //ReactiveProperty<int> _numD = new ReactiveProperty<int>();
    //int _defenseStats = 0;

//    public GameManager(int _startStats, System.Action<int>action, GameObject gameObject)
//    {
//        //スタートの値
//        _powerStats = _startStats;
//        _meetStats = _startStats;
//        _speedStats = _startStats;
//        _defenseStats = _startStats;

//        _numP.Subscribe(action).AddTo(gameObject);
//        _numM.Subscribe(action).AddTo(gameObject);
//        _numS.Subscribe(action).AddTo(gameObject);
//        _numD.Subscribe(action).AddTo(gameObject);

//        _numP.Value = _powerStats;
//        _numM.Value = _meetStats;
//        _numS.Value = _speedStats;
//        _numD.Value = _defenseStats;
//    }

    

//    //遊び効果
//    //public void Fishing()
//    //{
//    //    _numP.Value += _fishingNum;
//    //    if (_numP.Value >= 100)
//    //    {
//    //        _numP.Value = 100;
//    //        _fishingNum = 0;
//    //    }

//    //    if (_numP.Value == P)
//    //    {
//    //        IntN();
//    //    }
//    //}
//    //public void Golf()
//    //{
//    //    NowM += _golfNum;
//    //    if (NowM >= 100)
//    //    {
//    //        NowM = 100;
//    //        _golfNum = 0;
//    //    }

//    //    if (NowM == M)
//    //    {
//    //        IntN();
//    //    }
//    //}
//    //public void Game()
//    //{
//    //    NowS += _gameNum;
//    //    if (NowS >= 100)
//    //    {
//    //        NowS = 100;
//    //        _gameNum = 0;
//    //    }

//    //    if (NowS == S)
//    //    {
//    //        IntN();
//    //    }
//    //}
//    //public void Cafe()
//    //{
//    //    NowD += _cafeNum;
//    //    if (NowD >= 100)
//    //    {
//    //        NowD = 100;
//    //        _cafeNum = 0;
//    //    }

//    //    if (NowD == D)
//    //    {
//    //        IntN();
//    //    }
//    //}

   
//}
