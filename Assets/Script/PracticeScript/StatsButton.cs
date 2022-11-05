using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsButton : MonoBehaviour
{
    [SerializeField] GameManager _gameManager;
    [SerializeField] StatsView _statsView;
    int power = 0;

    private void Start()
    {
        ChangePower();
    }
    //—ûK
    public void ChangePower()
    {
        _gameManager = new GameManager(power, x => { _statsView.ChangePowerText(x); },_statsView.gameObject);
    }
    public void Kinryoku(int KPlus)
    {
        _gameManager.Kinryoku(KPlus);
    }
    public void Dageki()
    {
        FindObjectOfType<GameManager>().Dageki();
    }
    public void Sourui()
    {
        FindObjectOfType<GameManager>().Sourui();
    }
    public void Syubi()
    {
        FindObjectOfType<GameManager>().Syubi();
    }

    //—V‚Ñ
    public void Fishing()
    {
        FindObjectOfType<GameManager>().Fishing();
    }
    public void Golf()
    {
        FindObjectOfType<GameManager>().Golf();
    }
    public void Game()
    {
        FindObjectOfType<GameManager>().Game();
    }
    public void Cafe()
    {
        FindObjectOfType<GameManager>().Cafe();
    }

    public void IntN()
    {
        
    }
}
