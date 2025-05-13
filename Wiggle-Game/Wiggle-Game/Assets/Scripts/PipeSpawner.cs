using System.Collections;
using UnityEngine;
using UnityEngine.Rendering;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject PipesPrefab;
    [SerializeField] private float PipeSpawnTime = 1.5f;
    [SerializeField] private float height = 0.5f;

    private void Start()
    {
        StartCoroutine(SpawnPipe());
    }

    private IEnumerator SpawnPipe()
    {
        while (true)
        {
            Instantiate (PipesPrefab, new Vector3(3f, Random.Range(-height, height), 0), Quaternion.identity);
            yield return new WaitForSeconds(PipeSpawnTime);
        }
    }
}
