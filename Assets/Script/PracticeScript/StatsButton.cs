using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsButton : MonoBehaviour
{
    //���K
    public void Kinryoku()
    {
        FindObjectOfType<StatsView>().Kinryoku();
    }
    public void Dageki()
    {
        FindObjectOfType<StatsView>().Dageki();
    }
    public void Sourui()
    {
        FindObjectOfType<StatsView>().Sourui();
    }
    public void Syubi()
    {
        FindObjectOfType<StatsView>().Syubi();
    }

    //�V��
    public void Fishing()
    {
        FindObjectOfType<StatsView>().Fishing();
    }
    public void Golf()
    {
        FindObjectOfType<StatsView>().Golf();
    }
    public void Game()
    {
        FindObjectOfType<StatsView>().Game();
    }
    public void Cafe()
    {
        FindObjectOfType<StatsView>().Cafe();
    }

    public void IntN()
    {
        
    }
}
