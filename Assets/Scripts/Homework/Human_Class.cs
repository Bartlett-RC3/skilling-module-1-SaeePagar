using System;
using UnityEngine;

namespace RC9Humans 
{
    public class Human_Class : MonoBehaviour
    {
        //Variables
        string firstName;
        string familyName;
        string placeOfResidence;

        int age;
        float height;
        double weight;

        bool above20YearsOfAge;
        bool employed;


        //Constructor

        public Human_Class(string _firstName, string _placeOfResidence, int _age, float _height)

        {
            firstName = _firstName;
            placeOfResidence = _placeOfResidence;
            age = _age;
            height = _height;

        }
        //Functions

        public string GetfirstName()
        {
            return firstName;
        }

        public string GetplaceOfResidence()
        {
            return placeOfResidence;
        }

        public int Getage()
        {
            return age;
        }

        public float Getheight()
        {
            return height;
        }

        public void SetfamilyName(string _familyName)
        {
            familyName = _familyName;
        }

        public void Setweight(double _weight)
        {
            weight = _weight;
        }

        public void Walking()
        {
            Debug.Log("I am going for a walk.");
        }
        public void Siting()
        {
            Debug.Log("I have sat down to get some work done.");
        }
        public void Hungry()
        {
            Debug.Log("I am going out to grab some takeaway.");
        }
    }

       
}

