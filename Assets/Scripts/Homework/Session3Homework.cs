using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session3Homework : MonoBehaviour
{
    // Variables
    public GameObject human;
    public int noOfHumans = 10;
    public int noOfHumans1 = 12;
    public float spacing = 0.1f;
    private List<GameObject> humanCopies = new List<GameObject>();
    private int frameCount = 1;



    // Start is called before the first frame update
    void Start()
    {
      // Create an array of humans
      for(int i = 0; i<noOfHumans; i++)
        {
            Vector3 humanCopyPosition = new Vector3(i * spacing, i * spacing, i * spacing);
            Quaternion humanCopyRotation = Quaternion.identity;
            GameObject humanCopy = Instantiate(human, humanCopyPosition, humanCopyRotation);
            Color humanCopyColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
            humanCopy.GetComponent<MeshRenderer>().material.color = humanCopyColor;
            humanCopies.Add(humanCopy);

        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < humanCopies.Count; i++)
        {
            GameObject humanCopy = humanCopies[i];
            Color humanCopyColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
            humanCopy.GetComponent<MeshRenderer>().material.color = humanCopyColor;

        }
        //Time since the game started

        Debug.Log("Number of frames since the game started:" + frameCount);
        frameCount++;
        Debug.Log("Unity counted frames:" + Time.frameCount);
        Debug.Log("Unity draws a frame in :" + Time.deltaTime + "Seconds");

        //Moving prefabs(translating)

        foreach (GameObject humanCopy in humanCopies)
        {
            //Translation
            Vector3 moveCopy = new Vector3(Random.Range(-0.5f, 0.25f), 0, 0);
            humanCopy.GetComponent<Transform>().Translate(moveCopy * Time.deltaTime);

            //Rotation
            Vector3 rotateCopy = new Vector3(0, Random.Range(-45.0f, 45.0f), 0);
            humanCopy.transform.Rotate(rotateCopy);

            //Scaling
            float scaleAmount = Random.Range(2f, 0.3f);
            Vector3 scaleCopy = new Vector3(scaleAmount, scaleAmount, scaleAmount);
            humanCopy.transform.localScale = scaleCopy;

        }

        //Input 
        //Keyboard
        if (Input.GetKey(KeyCode.Space))
        {
            foreach (GameObject humanCopy in humanCopies)
            {
                float scaleAmount = 1.5f;
                Vector3 scaleCopy = new Vector3(scaleAmount, scaleAmount, scaleAmount);
                humanCopy.transform.localScale = scaleCopy;

            }

        }
        //Mouse Input
        if (Input.GetMouseButton(0))
        {
            foreach (GameObject humanCopy in humanCopies)
            {

                Color greenColor = new Color(0, 1, 0);
                humanCopy.GetComponent<MeshRenderer>().material.color = greenColor;

            }
        }
    }   
}
