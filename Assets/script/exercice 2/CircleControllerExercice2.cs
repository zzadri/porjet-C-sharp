using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleControllerExercice2 : MonoBehaviour
{
    Vector3 gOtl;
    public int speed = 2;

    void Start()
    {
        transform.position = new Vector3(-13.64f, -4.5f, 0); // on set la position de la balle a des coordonés spesifique
    }

    void Update()
    {


        // gOtl = gameObject.transform.localPosition;
        // if (gOtl.x < 13.5f && gOtl.y <= -4.5f) 
        // {
        //     gameObject.transform.localPosition += Vector3.right * speed * Time.deltaTime;
        // }
        // else if (gOtl.x <= -13.5f && gOtl.y <= 4.5f)
        // {
        //     gameObject.transform.localPosition += Vector3.down * speed * Time.deltaTime;
        // }
        // else if (gOtl.x >= -13.5f && gOtl.y >= 4.5f)
        // {
        //     gameObject.transform.localPosition += Vector3.left * speed * Time.deltaTime;
        // }
        // else
        // {
        //     gameObject.transform.localPosition += Vector3.up * speed * Time.deltaTime;
        // }

        gOtl = gameObject.transform.localPosition; // pour evité d'avoir des if trop grand on met une partie du code dans une variable que l'on va appeler

        if (gOtl.x < 13.64 && gOtl.y <= -4.5) // si la position est egal a x: -13.64 y: -4.5 alors on execute une modification au niveau de l'orientation
        {
            gameObject.transform.localPosition += Vector3.right * speed * Time.deltaTime;
            Debug.Log("right");
        }
        else if (gOtl.x > 13.64f && gOtl.y < 4.5f) // si la position est egal a x: 13.64 y: 4.5 alors on execute une modification au niveau de l'orientation
        {
            gameObject.transform.localPosition += Vector3.up * speed * Time.deltaTime;
            Debug.Log("up");
        }
        else if (gOtl.x > -13.64 && gOtl.y >= 4.5) // si la position est egal a x: -13.64 y: 4.5 alors on execute une modification au niveau de l'orientation
        {
            gameObject.transform.localPosition += Vector3.left * speed * Time.deltaTime;
            Debug.Log("left");
        }
        else //if (gOtl.x <= -13.64 && gOtl.y > -4.5) // si la position est egal a x: -13.64 y: -4.5 alors on execute une modification au niveau de l'orientation
        {
            gameObject.transform.localPosition += Vector3.down * speed * Time.deltaTime;
            Debug.Log("down");
        }

        
    
    }
}
