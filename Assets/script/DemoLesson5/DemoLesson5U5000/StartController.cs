using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartController : MonoBehaviour
{
    private GameObject[]bullets;

    // Start is called before the first frame update
    void Start()
    {
        bullets = GameObject.FindGameObjectsWithTag("bullets"); //on cree une variable qui contien la class GameObject pour trouvé tous les tag "bullets"

        Debug.Log(bullets.Length);

        foreach (var Ybullets in bullets)
        {
            Ybullets.GetComponent<SpriteRenderer>().color = new Color(210,152,165);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
