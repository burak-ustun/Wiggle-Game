using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement; // sahne y�netimi i�in gerekli k�t�phane

public class MainMenuManager : MonoBehaviour
{
    
    
    public void RestartGame() // Oyunu yeniden ba�latmak i�in bir fonksiyon
    {
        SceneManager.LoadScene("GameScence"); // Aktif sahneyi yeniden y�kl�yoruz.
    }


}
