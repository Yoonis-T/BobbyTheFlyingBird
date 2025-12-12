using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class pipeSpawnerscript : MonoBehaviour
{
    private float timer = 0;
    public GameObject Pipe;
    public float spawnrate = 2;

    public float heightOffset = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(Pipe, new Vector3(transform.position.x, transform.position.y, 0), transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        

        if(timer<spawnrate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }

    }

    void spawnPipe()
    {
        float lowestpoint = transform.position.y - heightOffset;
        float highesttpoint = transform.position.y + heightOffset;
        Instantiate(Pipe, new Vector3(transform.position.x, Random.Range(lowestpoint, highesttpoint), 0),transform.rotation);
    }
}
