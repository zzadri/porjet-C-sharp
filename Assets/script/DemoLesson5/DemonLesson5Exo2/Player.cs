using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Vector3 move;
    int life = 4;
    public PlayerData playerData;
    // Start is called before the first frame update
    void Start()
    {
        playerData = new PlayerData(life);
        move = new Vector3(0,-3,0);
    }

    // Update is called once per frame
    void Update()
    {


     if (Input.GetKey("left") && move.x > -9)
     {
        move.x -= 0.05f;
     }   
     if (Input.GetKey("right") && move.x < 9)
     {
        move.x += 0.05f;
     }

     gameObject.transform.localPosition = move;
    }

    void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.tag == "bulletsdeux")
        {
            Destroy(collision.gameObject);
            life -= 1;
            Debug.Log("tu a perdu une vie. plus que (" + life +") restante.");
        }
        if (life == 0)
        {
           Destroy(gameObject);
           Debug.Log("tu na plus de vie");
        }
    }
}
