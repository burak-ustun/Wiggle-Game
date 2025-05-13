using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    [SerializeField] private float pipespeed = 3f;    
    
    private void Start()
    {
        Destroy(gameObject, 10f);
    }
    private void Update()
    {
        transform.position += Vector3.left * pipespeed * Time.deltaTime;
    }
}
