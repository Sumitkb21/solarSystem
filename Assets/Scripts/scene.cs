using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadSolarSystemScene()
    {
        Debug.Log("heee");
        SceneManager.LoadScene(1);
    }

    public void LoadIntroScene()
    {
        SceneManager.LoadScene(0);
    }
    public void LoadSolarEclipseScene()
    {
        SceneManager.LoadScene(2);
    }
    public void LoadLunarEclipseScene()
    {
        SceneManager.LoadScene(3);
    }
    public void LoadSeasonOnEarthScene()
    {
        SceneManager.LoadScene(3);
    }

}
