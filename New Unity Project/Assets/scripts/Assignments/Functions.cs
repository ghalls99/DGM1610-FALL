using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    // string firstname;
    // string lastname;
    // int age;

    int num1;
    int num2;
    int total;

    // Start is called before the first frame update

    void Start()
    {
        // firstname = "brytan";

        // lastname = "hagerman";

        // age = "18";

        // Customer (firstname, lastname, age); 
        CalAdd(11,23);
    }

    int CalAdd (int n1, int n2)
    {
        Debug.Log("Number 1 = " + n1 + "Number 2 =" + n2);
        total = n1 + n2;
        

        return total;
        Debug.Log(total);
    }

    // void Customer (string fname, string lname, int a)

    //     Debug.Log(fname + " " + lname + " " + a);
    void Update ()
    {

    }
}
