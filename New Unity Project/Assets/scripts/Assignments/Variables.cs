using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    string nyame="Brytan";
    int age = 18;
    float height = 5.4f;
    bool married = false;






    // Start is called before the first frame update
    void Start()
    {
       Debug.Log("first name; " + (nyame); 
       Debug.Log("age; " + age);
       Debug.Log("heaight; " + height);
       Debug.Log("married; " + married);
    }

   
}
