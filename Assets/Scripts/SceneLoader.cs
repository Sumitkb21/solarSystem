using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{
    public void LoadSolarSystemScene()
    {
        Debug.Log("hello");
        SceneManager.LoadScene(1);
        
    }

    public void LoadFirstScene()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadsolarEclipseScene()
    {
        SceneManager.LoadScene(2);
    }
    public void LoadSeasonOnEarthScene()
    {
        SceneManager.LoadScene(3);
    }
    public void LoadLunarEclipseScene()
    {
        SceneManager.LoadScene(4);
    }
}
