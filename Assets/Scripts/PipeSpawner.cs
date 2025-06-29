using UnityEngine;

// This class is used to spawn pipes from a pipe prefab.
// Pipes are destroyed after some time.

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject pipePrefab;
    [SerializeField] private float timeToSpawn;
    [SerializeField] private float heightOfPipes;
    private float timer = 0f;

    void Start()
    {
        GameObject newPipe = Instantiate(pipePrefab);
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-heightOfPipes, heightOfPipes), 0);
        Destroy(newPipe, 10f);
    }

    void Update()
    {
        if (timer > timeToSpawn)
        {
            GameObject newPipe = Instantiate(pipePrefab);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-heightOfPipes, heightOfPipes), 0);
            Destroy(newPipe, 10f);
            timer = 0f;
        }

        timer += Time.deltaTime;
    }
}
