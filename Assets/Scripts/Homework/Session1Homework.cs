// LIBRARIES
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// CODE STRUCTURE
public class Session1Homework : MonoBehaviour
{
	// declaring variables

	public string hallOfresidence = "Stapleton House";
	public string room1 = "En-suite Single Room";
    public int numberOfRoom1 = 773;
	public string room2 = "En-suite Single Studio";
	public int numberOfRoom2 = 14;
	public string room3 = "Accessible En-suite Single Studio";
	public int numberOfRoom3 = 68;
    public float contractLength = 50.57f;
	public double rentPerWeek = 233.59d;
	private bool applicationsOpen = true;
	public bool runByUniteStudents = true;

	// declaring arrays

	public int[] numberOfRooms = new int[3];
	public string[] typeOfRooms = { "En-suite Single Room", "En-suite Single Studio", "Accessible En-suite Single Studio" };
	public float[] rentPerNightForEach = { 33.37f, 40.58f, 40.58f };

	// declaring lists

	public List<int> numberOfRoomsList = new List<int>();

	// declaring functions

	private int CalculatorSum (int _numberOfRoom1, int _numberOfRoom2, int _numberOfRoom3)
    {
		int TotalRooms = _numberOfRoom1 + _numberOfRoom2 + _numberOfRoom3;
		return TotalRooms;
     }


	// Start is called before the first frame update
	void Start ()
	{
		// printing in the console

		Debug.Log("Stapleton House");
		Debug.Log("Holloway Road,London");

		// printing the calculation

		int TotalRooms = CalculatorSum(numberOfRoom1, numberOfRoom2, numberOfRoom3);
		Debug.Log("The Total Number of Rooms are: " + TotalRooms.ToString());

		// addition of  data to the Array

		numberOfRooms[0] = 0;
		numberOfRooms[1] = 1;
		numberOfRooms[2] = 2;
		int Total = CalculatorSum(numberOfRooms[0], numberOfRooms[1], numberOfRooms[2]);
		Debug.Log("Total:" + Total.ToString());

		// addition of data to the lists

		//Add Data to the List
		numberOfRoomsList.Add(3);
		numberOfRoomsList[0] = 10;
		Debug.Log(numberOfRoomsList[0]);

        // creating dictionary

		var facilities = new Dictionary<string, string>();
		facilities.Add("Room", "Shelves,Pin board,Wardrobe,Bin,Bed,Desk");
		facilities.Add("Communal Kitchen", "Microwave,Fridge,Freezer,Cupboards,kettle,Hob and oven");
		facilities.Add("Building", "Reception,Printing facilities,Common room,Study areas,Lifts");

        Debug.Log(facilities["Room"]);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
