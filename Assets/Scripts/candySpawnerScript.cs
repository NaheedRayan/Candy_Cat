using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class candySpawnerScript : MonoBehaviour
{

    public GameObject candy;
    public float spawnRate = 2;
    public float timer = 0;
    public float offset = 5;





    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("startSpawning");
        //Instantiate(candy, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {

        
        
    }

    void spawnCandy()
    {
        float low = transform.position.x - offset;
        float high = transform.position.x + offset;

        Instantiate(candy, new Vector3(Random.Range(low, high), transform.position.y, transform.position.z), transform.rotation);
    }

    IEnumerator startSpawning()
    {
        yield return new WaitForSeconds(2f);

        while (true)
        {
            spawnCandy();
            yield return new WaitForSeconds(1f);
        }
    }
}
