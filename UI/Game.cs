using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    [SerializeField] private int _playerScore = 0;
    [SerializeField] private Text _scoreText;
    [SerializeField] private GameObject _gameOverScreen;
    [SerializeField] private AudioSource _gameOverMusic;
    [SerializeField] private AudioSource _gameMusic;

    public GameObject GameOverScreen { get => _gameOverScreen; set => _gameOverScreen = value; }

    private void Start()
    {
        _gameMusic.Play();
        AudioListener.volume = PlayerPrefs.GetFloat(Constants.MasterVolume, 1f);
    }

    [ContextMenu("Increase Score")]
    public void AddScore(int scoreToAdd)
    {
        Debug.Log("Adding +" + scoreToAdd + " score");
        _playerScore += scoreToAdd;
        _scoreText.text = _playerScore.ToString();
    }

    public void RestartGame()
    {
        Time.timeScale = 1;
        Debug.Log("Restart Game");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Start Menu");
    }

    public void GameOver()
    {
        if (!GameOverScreen.activeSelf)
        {
            _gameMusic.Stop();
            GameOverScreen.SetActive(true);
            _gameOverMusic.Play();
            Time.timeScale = 0;
        }
    }
}