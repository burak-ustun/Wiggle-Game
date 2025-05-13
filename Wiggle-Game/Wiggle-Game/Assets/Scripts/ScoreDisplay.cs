using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public Sprite[] numberSprites; // 0-9 Sprite�lar�n� s�rayla ekle
    public Image[] digitImages;    // UI �zerindeki Image alanlar� (basamaklar)

    public int score = 0;

    void Update()
    {
        UpdateScore(score);
    }

    void UpdateScore(int scoreValue)
    {
        string scoreStr = scoreValue.ToString().PadLeft(digitImages.Length, '0');
    
        for (int i = 0; i < digitImages.Length; i++)
        {
            int digit = int.Parse(scoreStr[i].ToString());
            digitImages[i].sprite = numberSprites[digit];
        }
    }






    //private int score;
    //
    //private void Start()
    //{
    //    score = 0; // score'u 0 yap�yoruz.
    //    scoreText.text = score.ToString(); // score bir int oldu�u i�in ToString() ile string'e �eviriyoruz.
    //    highScoreText.text = "High Score: " + PlayerPrefs.GetInt("HighScore"); // En y�ksek skoru g�steriyoruz. bir sorunla kar��la�mamak i�in starta att�k
    //}
    //
    //public void �ncreaseScore()
    //{
    //    score++; // score'u 1 artt�r�yoruz.
    //
    //    scoreText.text = score.ToString();  // score bir int oldu�u i�in ToString() ile string'e �eviriyoruz.
    //
    //    if (score > PlayerPrefs.GetInt("HighScore")) // E�er score, en y�ksek skoru ge�erse
    //    {
    //
    //        PlayerPrefs.SetInt("HighScore", score); // En y�ksek skoru g�ncelliyoruz. burada da score de�erinden �ekiyoruz.
    //    }
    //    highScoreText.text = "High Score: " + PlayerPrefs.GetInt("HighScore"); // En y�ksek skoru g�steriyoruz."
    //
    //
    //}

}