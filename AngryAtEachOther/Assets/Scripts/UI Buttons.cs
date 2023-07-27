using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIButtons : MonoBehaviour
{
    private int Tuto1 = 4;
    private int Lvl1 = 5;
    private int Lvl2 = 7;
    private int Lvl3 = 9;
    private int Mainmenu = 0;
    
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
    public void mainmenu()
    {
        SceneManager.LoadScene(Mainmenu);
    }
}
