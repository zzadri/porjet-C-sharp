using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerDeux : MonoBehaviour
{

    // Start is called before the first frame update
    Vector3 move;
    Vector3 moveDeux;
    // GameObject bullets;
    // public GameObject RedBullet;
    // public GameObject BlueBullet;
    // public GameObject GreenBullet;
    // public GameObject OrangeBullet;
    // public GameObject PinkBullet;
    // public GameObject PurpleBullet;

    public GameObject[] bullets;
    private int random;
    void Start()
    {
        move = new Vector3(0, -3, 0); // on possitionne le player
        moveDeux = new Vector3(0, -0.9f, 0); // on possitionne le point d'apparition des balles
    }

    void Update()
    {

        ////////////////
        //  MOUVEMENT //
        ////////////////

        if (Input.GetKey(KeyCode.LeftArrow) && move.x > -9) // si la flèche de gauche est appuyé alors...
        {
            move.x -= 0.05f; // on modifie la valeur de move.x avec - 0.05f a chaque updates
        }
        if (Input.GetKey(KeyCode.RightArrow)&& move.x < 9) // si la flèche de gauche est appuyé alors...
        {
            move.x += 0.05f; // on modifie la valeur de move.x avec + 0.05f a chaque updates
        }
        gameObject.transform.localPosition = move; // puis on modifie la position du player avec la variable move.



        ////////////////
        //    tir     //
        ////////////////


        if (Input.GetKeyDown(KeyCode.Space)) // si la barre espace est appuyer alors..
        {

            Instantiate(bullets[Random.Range(0, bullets.Length)], move - moveDeux, Quaternion.identity); //permet de généré des prefab aléatoirement 

            // random = Random.Range(0, 5); // on choisi un numéro entre 0 et 5 inclut.


            // switch (random) // puis on choisi quel balle on va envoyer grâce au numéro choisi au préalable.
            // {
            //     case 0: // Si random est égal à 0 alors..
            //         bullets = RedBullet; // bullets est égale a RedBullet
            //         break; // on stop le switch ici pour evité de regarder les autre condition
            //     case 1: // Si random est égal à 1 alors..
            //         bullets = BlueBullet; // bullets est égale a BlueBullet
            //         break; // on stop le switch ici pour evité de regarder les autre condition
            //     case 2: // Si random est égal à 2
            //         bullets = GreenBullet; // bullets est égale a GreenBullet
            //         break; // on stop le switch ici pour evité de regarder les autre condition
            //     case 3: // Si random est égal à 3
            //         bullets = OrangeBullet; // bullets est égale a OrangeBullet
            //         break; // on stop le switch ici pour evité de regarder les autre condition
            //     case 4: // Si random est égal à 4
            //         bullets = PinkBullet; // bullets est égale a PinkBullet
            //         break; // on stop le switch ici pour evité de regarder les autre condition
            //     case 5: // Si random est égal à 5
            //         bullets = PurpleBullet; // bullets est égale a PurpleBullet
            //         break; // on stop le switch ici pour evité de regarder les autre condition
            // }
            // Instantiate(bullets, move - moveDeux, Quaternion.identity); // puis pour finir on génére une balle au dessus de player.
        }
    }
}
