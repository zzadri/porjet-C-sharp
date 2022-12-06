using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsulesController : MonoBehaviour
{

    private GameObject[]capsule; // on cree le tableau 
    
    // Start is called before the first frame update
    void Start()
    {
        capsule = GameObject.FindGameObjectsWithTag("capsule"); //on cree une variable qui contien la class GameObject pour trouvé tous les tag "capsule"

        Debug.Log(capsule.Length);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
