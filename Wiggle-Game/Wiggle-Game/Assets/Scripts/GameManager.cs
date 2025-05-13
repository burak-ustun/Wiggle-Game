using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement; // sahne y�netimi i�in gerekli k�t�phane

public class GameManager : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private TMP_Text highScoreText; // En y�ksek skoru g�stermek i�in bir text alan� tan�ml�yoruz.

    



    private int score;

    private void Start()
    {
        score = 0; // score'u 0 yap�yoruz.
        scoreText.text = score.ToString(); // score bir int oldu�u i�in ToString() ile string'e �eviriyoruz.
        highScoreText.text = "High Score: " + PlayerPrefs.GetInt("HighScore"); // En y�ksek skoru g�steriyoruz. bir sorunla kar��la�mamak i�in starta att�k
    }

    public void �ncreaseScore() 
    { 
       score++; // score'u 1 artt�r�yoruz.

       scoreText.text = score.ToString();  // score bir int oldu�u i�in ToString() ile string'e �eviriyoruz.

       if(score > PlayerPrefs.GetInt("HighScore")) // E�er score, en y�ksek skoru ge�erse
       {

           PlayerPrefs.SetInt("HighScore", score); // En y�ksek skoru g�ncelliyoruz. burada da score de�erinden �ekiyoruz.
       }
       highScoreText.text = "High Score: " + PlayerPrefs.GetInt("HighScore"); // En y�ksek skoru g�steriyoruz."
    
    
    }
    public void RestartGame() // Oyunu yeniden ba�latmak i�in bir fonksiyon
    {
        SceneManager.LoadScene("GameScence"); // Aktif sahneyi yeniden y�kl�yoruz.
    }



    public void LoadingMainMenuScence()
    {
        SceneManager.LoadScene("MainMenuScence"); // Ana men� sahnesini y�kl�yoruz.
    }


    public bool isPaused = false;

    void Update()
    {
        // E�er oyun durduysa ve herhangi bir tu�a ya da mouse'a bas�ld�ysa devam et
        if (isPaused && Input.anyKeyDown)
        {
            ResumeGame();
        }
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        isPaused = false;
    }









}
