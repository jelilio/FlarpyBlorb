using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;

    public float spawnRate = 10;
    private float _timer = 0;
    public float heightOffset = 10;
    
    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (_timer < spawnRate)
        {
            _timer += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            _timer = 0;
        }
    }

    void SpawnPipe()
    {
        var position = transform.position;
        
        float lowestPoint = position.y - heightOffset;
        float highestPoint = position.y + heightOffset;
        
        Instantiate(pipe, new Vector3(position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
