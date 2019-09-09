using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    string names="Brytan";
    int age = 18;
    float height = 5.4f;
    bool married = false;






    // Start is called before the first frame update
    void Start()
    {
       Debug.Log("first name " + names);
       Debug.Log("age " + age);
       Debug.Log("height " + height);
       Debug.Log("married " + married);
    }

   
}
