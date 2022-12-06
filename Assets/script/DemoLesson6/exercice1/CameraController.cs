using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 move;
    public GameObject[] birds;
    public float instanceTime;
    float time;
    void Start()
    {
        move = new Vector3(0, 10, 0);
        time = 0;
        instanceTime = 2;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > instanceTime)
        {
            time = 0;
            Debug.Log(Time.deltaTime);
            Instantiate(birds[Random.Range(0, birds.Length)], new Vector3(Random.Range(-10, 10), 5 , 0), Quaternion.identity);
        }
    }
}
