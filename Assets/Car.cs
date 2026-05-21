using UnityEngine;

public class Car : MonoBehaviour
{
    public GameObject drivingObjectPrefab;

    float spawnInterval = 1f;

    float timer = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void SpawnDrivingObject()
    {
        float yPos = Random.Range(-5f, 5f);
        Vector3 spawnPos = new Vector3(transform.position.x, yPos, 0f);
        Instantiate(drivingObjectPrefab, spawnPos, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= spawnInterval)
        {
            SpawnDrivingObject();
            timer = 0f;
        }
    }
}
