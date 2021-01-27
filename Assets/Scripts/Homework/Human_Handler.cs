using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RC9Humans;

namespace Human_Homework_2_2{

 public class Human_Handler : MonoBehaviour

{
    //Variables 
    Human_Class Saee, Vaish,Suyash;

    // Start is called before the first frame update
    void Start()
    {
        Saee = new Human_Class("Saee", "London", 24, 5.2f);
        Vaish = new Human_Class("Vaish", "Mumbai", 24, 5.6f);
        Suyash = new Human_Class("Suyash", "Bangalore", 24, 5.9f);

        string[] statement = { "The name of the candidate is:", "Their current place of residence is:", "The age of the candidate is:", "The height is:" };

        Debug.Log(statement[0] + Saee.GetfirstName());
        Debug.Log(statement[1] + Saee.GetplaceOfResidence());
      
        Saee.Walking();

        Debug.Log(statement[0] + Vaish.GetfirstName());
        Debug.Log(statement[3] + Vaish.Getheight());
        Vaish.Siting();

        Debug.Log(statement[0] + Suyash.GetfirstName());
        Debug.Log(statement[1] + Suyash.GetplaceOfResidence());
        Debug.Log(statement[2] + Suyash.Getage());
        Suyash.Hungry();
    }


    // Update is called once per frame
    void Update()
    {

    }

}


}

