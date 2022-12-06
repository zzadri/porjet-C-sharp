// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class DemoControllerLesson6 : MonoBehaviour
// {
//     // Start is called before the first frame update
//     public GameObject prefab;
//     public GameObject[] gameObjects;
//     private DemoData data;
//     void Start()
//     {
//         data = new DemoData( 5 );
//         var random = Random.Range(1, 100);

//         Debug.Log(random);

//         for (var i = 0; i < 10; i++)
//         {
//             Instantiate(prefab, new Vector3(i * 2.0f, 0, 0), Quaternion.identity); // ce code permet de généré des gameobject avec un prefab
//         }
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         if (Input.GetKey(KeyCode.A))
//         {
//             Destroy(gameObject);
//         }
//     }
// }
