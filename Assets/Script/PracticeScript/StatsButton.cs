using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsButton : MonoBehaviour
{
    //ó˚èK
    public void Kinryoku()
    {
        FindObjectOfType<GameManager>().Kinryoku();
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

    //óVÇ—
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
