using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletsController : MonoBehaviour
{
    // Start is called before the first frame update
    public int speed;
    void Start()
    {
        speed = 2; // on deffini la vitesse a 2
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.localPosition.y > 10) // si la position y du GameObject est supérieur à 10
        {
            Destroy(gameObject); // On supprime le GameObject
        }
        gameObject.transform.localPosition += Vector3.up * speed * Time.deltaTime; // on change la possition
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        Destroy(collision.gameObject);
    }
}
