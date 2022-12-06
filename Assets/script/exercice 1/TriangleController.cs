using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleController : MonoBehaviour
{
    public float size;

    // Start is called before the first frame update
    void Start()
    {
        size = 2;
        //gameObject.transform.localScale = new Vector3(1, 1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.localScale = new Vector3(size, size, 0);
    }
}
