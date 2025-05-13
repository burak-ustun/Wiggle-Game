using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public Sprite[] numberSprites; // 0-9 Sprite’larýný sýrayla ekle
    public Image[] digitImages;    // UI üzerindeki Image alanlarý (basamaklar)

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
    //    score = 0; // score'u 0 yapýyoruz.
    //    scoreText.text = score.ToString(); // score bir int olduðu için ToString() ile string'e çeviriyoruz.
    //    highScoreText.text = "High Score: " + PlayerPrefs.GetInt("HighScore"); // En yüksek skoru gösteriyoruz. bir sorunla karþýlaþmamak için starta attýk
    //}
    //
    //public void ÝncreaseScore()
    //{
    //    score++; // score'u 1 arttýrýyoruz.
    //
    //    scoreText.text = score.ToString();  // score bir int olduðu için ToString() ile string'e çeviriyoruz.
    //
    //    if (score > PlayerPrefs.GetInt("HighScore")) // Eðer score, en yüksek skoru geçerse
    //    {
    //
    //        PlayerPrefs.SetInt("HighScore", score); // En yüksek skoru güncelliyoruz. burada da score deðerinden çekiyoruz.
    //    }
    //    highScoreText.text = "High Score: " + PlayerPrefs.GetInt("HighScore"); // En yüksek skoru gösteriyoruz."
    //
    //
    //}

}