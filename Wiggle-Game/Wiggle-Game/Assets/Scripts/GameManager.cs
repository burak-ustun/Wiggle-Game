using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement; // sahne yönetimi için gerekli kütüphane

public class GameManager : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private TMP_Text highScoreText; // En yüksek skoru göstermek için bir text alaný tanýmlýyoruz.

    



    private int score;

    private void Start()
    {
        score = 0; // score'u 0 yapýyoruz.
        scoreText.text = score.ToString(); // score bir int olduðu için ToString() ile string'e çeviriyoruz.
        highScoreText.text = "High Score: " + PlayerPrefs.GetInt("HighScore"); // En yüksek skoru gösteriyoruz. bir sorunla karþýlaþmamak için starta attýk
    }

    public void ÝncreaseScore() 
    { 
       score++; // score'u 1 arttýrýyoruz.

       scoreText.text = score.ToString();  // score bir int olduðu için ToString() ile string'e çeviriyoruz.

       if(score > PlayerPrefs.GetInt("HighScore")) // Eðer score, en yüksek skoru geçerse
       {

           PlayerPrefs.SetInt("HighScore", score); // En yüksek skoru güncelliyoruz. burada da score deðerinden çekiyoruz.
       }
       highScoreText.text = "High Score: " + PlayerPrefs.GetInt("HighScore"); // En yüksek skoru gösteriyoruz."
    
    
    }
    public void RestartGame() // Oyunu yeniden baþlatmak için bir fonksiyon
    {
        SceneManager.LoadScene("GameScence"); // Aktif sahneyi yeniden yüklüyoruz.
    }



    public void LoadingMainMenuScence()
    {
        SceneManager.LoadScene("MainMenuScence"); // Ana menü sahnesini yüklüyoruz.
    }


    public bool isPaused = false;

    void Update()
    {
        // Eðer oyun durduysa ve herhangi bir tuþa ya da mouse'a basýldýysa devam et
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
