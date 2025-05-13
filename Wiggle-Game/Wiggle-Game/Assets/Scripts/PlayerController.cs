using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float jumpspeed = 5f;
    [SerializeField] private GameObject DeathScreen; // ölüm ekraný
    [SerializeField] private AudioSource DieSound; // ölüm sesi
    [SerializeField] private AudioSource Point; // coins sesi

    private Rigidbody2D rb2d;

    private void Start()
    {
        DeathScreen.SetActive(false); // Ölüm ekranýný baþta kapalý yapýyoruz.
        Time.timeScale = 1; // Oyun baþlarken zaman akmaya baþlasýn.
        rb2d = GetComponent<Rigidbody2D>(); // Rigidbody2D bileþenini alýyoruz.
    }


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) // Space tuþuna basýldýðýnda
        {
            rb2d.linearVelocity = Vector2.up * jumpspeed; // Rigidbody2D'nin yukarý doðru bir hýz almasýný saðlýyoruz.
        }

       
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if( other.gameObject.tag == "Scoring")
        {
           FindAnyObjectByType<GameManager>().ÝncreaseScore(); // GameManager'daki IncreaseScore() fonksiyonunu çaðýrýyoruz.
        }
        Point.Play(); // coins sesi
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Obstacle")
        {
            Time.timeScale = 0; // Oyun duracak. ve öldüðünü gösteriyoruz.
            DeathScreen.SetActive(true); // Ölüm ekranýný aktif ediyoruz.
        }

        DieSound.Play(); // Ölüm sesini çalýyoruz.
    }

}

