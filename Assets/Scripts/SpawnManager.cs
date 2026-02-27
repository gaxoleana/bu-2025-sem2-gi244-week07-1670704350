using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject obstaclePrefab;

    void Start()
    {
        InvokeRepeating(nameof(Spawn), 0, 2.0f);
    }

    void Spawn()
    {
        Instantiate(
            obstaclePrefab,
            spawnPoint.position,
            obstaclePrefab.transform.rotation
        );
    }
}
