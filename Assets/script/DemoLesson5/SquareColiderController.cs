using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareColiderController : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //OnCollisionEnter2D = Nom de méthode
    //associé à l'événement début de la collision

    // Collider2D = Type de collision
    // collision = paramètre
    // les composants de collision => le gameObject qui vien de percuté
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.tag);
    }
}
