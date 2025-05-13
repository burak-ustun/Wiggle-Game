using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float jumpspeed = 5f;
    [SerializeField] private GameObject DeathScreen; // �l�m ekran�
    [SerializeField] private AudioSource DieSound; // �l�m sesi
    [SerializeField] private AudioSource Point; // coins sesi

    private Rigidbody2D rb2d;

    private void Start()
    {
        DeathScreen.SetActive(false); // �l�m ekran�n� ba�ta kapal� yap�yoruz.
        Time.timeScale = 1; // Oyun ba�larken zaman akmaya ba�las�n.
        rb2d = GetComponent<Rigidbody2D>(); // Rigidbody2D bile�enini al�yoruz.
    }


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) // Space tu�una bas�ld���nda
        {
            rb2d.linearVelocity = Vector2.up * jumpspeed; // Rigidbody2D'nin yukar� do�ru bir h�z almas�n� sa�l�yoruz.
        }

       
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if( other.gameObject.tag == "Scoring")
        {
           FindAnyObjectByType<GameManager>().�ncreaseScore(); // GameManager'daki IncreaseScore() fonksiyonunu �a��r�yoruz.
        }
        Point.Play(); // coins sesi
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Obstacle")
        {
            Time.timeScale = 0; // Oyun duracak. ve �ld���n� g�steriyoruz.
            DeathScreen.SetActive(true); // �l�m ekran�n� aktif ediyoruz.
        }

        DieSound.Play(); // �l�m sesini �al�yoruz.
    }

}

