using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    public void Back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

    }

    public void FemaleAvatar()
    {
        SceneManager.LoadScene("Maestra Scene");
    }

    public void MaleAvatar()
    {
        SceneManager.LoadScene("Maestro Scene");
    }

    public void SelecctionScreen()
    {
        SceneManager.LoadScene("SelectionScreen");
    }

    public void OptionsScreen()
    {
        SceneManager.LoadScene("OptionsScreen");
    }

    public void MenuScreen()
    {
        SceneManager.LoadScene("Menu");
    }

    List<int> widths = new List<int>() { 1024, 1280, 1920, 1920 };
    List<int> heights = new List<int>() { 576, 720, 1080, 1200 };

    public void SetScreenSize(int index)
    {
        bool fullscreen = Screen.fullScreen;
        int width = widths[index];
        int height = heights[index];
        Screen.SetResolution(width, height, fullscreen);

    }

    public void SetFullscreen(bool _fullscreen)
    {
        Screen.fullScreen = _fullscreen;
    }


}
