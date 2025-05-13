using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement; // sahne yönetimi için gerekli kütüphane

public class MainMenuManager : MonoBehaviour
{
    
    
    public void RestartGame() // Oyunu yeniden baþlatmak için bir fonksiyon
    {
        SceneManager.LoadScene("GameScence"); // Aktif sahneyi yeniden yüklüyoruz.
    }


}
