using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Vector3 move;
    int life = 4;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("left"))
        {
            move.x -= 0.05f;
        }
        if (Input.GetKey("right"))
        {
            move.x += 0.05f;
        }
        if (Input.GetKey("up"))
        {
            move.y += 0.05f;
        }

        gameObject.transform.localPosition = move;
    }
}
