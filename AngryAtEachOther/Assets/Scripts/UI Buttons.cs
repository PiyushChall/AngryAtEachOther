using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIButtons : MonoBehaviour
{
    private int Tuto1 = 11;
    private int Lvl1 = 1;
    private int Lvl2 = 2;
    private int Lvl3 = 3;
    private int Lvl4 = 4;
    private int Lvl5 = 5;
    private int Lvl6 = 6;
    private int Lvl7 = 7;
    private int Lvl8 = 8;
    private int Lvl9 = 9;
    private int Lvl10 = 10;
    private int Mainmenu = 0;
    private int LevelSelector = 15;
    
    public void startTuto()
    {
        SceneManager.LoadScene(Tuto1);
    }
    public void quit()
    {
        Application.Quit();
    }
    public void startlvl1()
    {
        SceneManager.LoadScene(Lvl1);
    }
    public void startlvl2()
    {
        SceneManager.LoadScene(Lvl2);
    }
    public void startlvl3()
    {
        SceneManager.LoadScene(Lvl3);
    }
    public void startlvl4()
    {
        SceneManager.LoadScene(Lvl4);
    }
    public void startlvl5()
    {
        SceneManager.LoadScene(Lvl5);
    }
    public void startlvl6()
    {
        SceneManager.LoadScene(Lvl6);
    }
    public void startlvl7()
    {
        SceneManager.LoadScene(Lvl7);
    }
    public void startlvl8()
    {
        SceneManager.LoadScene(Lvl8);
    }
    public void startlvl9()
    {
        SceneManager.LoadScene(Lvl9);
    }
    public void startlvl10()
    {
        SceneManager.LoadScene(Lvl10);
    }
    public void mainmenu()
    {
        SceneManager.LoadScene(Mainmenu);
    }
    public void LevelSelect()
    {
        SceneManager.LoadScene(LevelSelector);
    }
}
