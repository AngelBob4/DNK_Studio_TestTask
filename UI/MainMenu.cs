using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame(int dificultCoefficient) 
    {
        PlayerPrefs.SetInt(Constants.GameDificulty, dificultCoefficient); 
        PlayerPrefs.Save();  
        SceneManager.LoadScene("Game");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}