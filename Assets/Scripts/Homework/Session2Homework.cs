using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session2Homework : MonoBehaviour
{

    string[] Constellations = { "Aquarius", "Aquila", "Aries", "Gemini", "Leo", "Orion" };

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Constellations[2]);

    //LOOPS
    //for loop (counter, end condition, step)

        for (int counter = 0; counter < Constellations.Length; counter = counter + 1)

        {
            Debug.Log("The name of the Constellation is :" + Constellations[counter]);
            Debug.Log("The number of starts in it are: " +counter);

        }

        // for loop for adding even numbers under 100

        int sumOfEvenNumbers = 0;
        for (int i = 0; i <= 100; i = i+2)
        {
            sumOfEvenNumbers += i;

        }
        Debug.Log("The sum of all the even numbers upto 100 equals:" + sumOfEvenNumbers);

        //Shorthand for loop

        foreach(string largestConstellation in Constellations)
        {
            Debug.Log("The Largest Constellation amongst all is :" + largestConstellation);

        }

        //While loop

        int whileCounter = 0;
        string typesOfConstellations = "Different types of Constellations:";
        while(whileCounter<Constellations.Length)
        {
            typesOfConstellations += Constellations[whileCounter] + ",";
            whileCounter++; 

        }
        Debug.Log(typesOfConstellations);

        //Conditionals
        //If Statement

        int section1GeneralEnglish = 11;
        int section2LogicalReasoning = 11;
        int section3DataInterpretation = 16;

        if (section1GeneralEnglish > 10 && section2LogicalReasoning > 10 && section3DataInterpretation > 15)
        {
            Debug.Log("The candidate has cleared the cutoff criterion for SNAP");

            if (section1GeneralEnglish >= 10 && section2LogicalReasoning >= 10 && section3DataInterpretation >= 15)
            {
                if (section1GeneralEnglish >= 18 || section2LogicalReasoning >= 18 || section3DataInterpretation >= 18)
                {
                    Debug.Log("We are happy to offer the candidate a seat at SIBM.");
                }
                else
                {
                    Debug.Log("The candidate will have to go through a second round of interview and will be re-evaluated.");
                }
            }
             if (section1GeneralEnglish >= 12 && section2LogicalReasoning >= 12 && section3DataInterpretation >= 15)
            {
                Debug.Log("The candidate can re test for SNAP after the next 15 days.");
            }
            else
            {
                Debug.Log("The candidate will have to re-apply next year.");
            }
        }
        else
        {
            Debug.Log("I regret to inform that the candidate has been unsuccessful at SNAP.");
            Debug.Log("Good Luck!");
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
