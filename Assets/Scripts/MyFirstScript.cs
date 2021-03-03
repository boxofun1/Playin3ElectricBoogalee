using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    private int number;
    private string myName;
    private int counter;

    // Start is called before the first frame update
    void Start()
    {
        //number = 1;
        //myName = "David";
        ////print("Hello " + myName + ". Your number is " + number);

        //int localVariable = 3;
        ////print("local variable: " + localVariable);
        //counter = 0;

        //myFirstMethodApparently();

        Bike b1 = new Bike("My First Bike");
        b1.accelerate();
        b1.accelerate();
    }

    // Update is called once per frame
    void Update()
    {
        //print(myName);
        //print("local variable: " + localVariable);
        counter++;
        //print("counter =" + counter);
    }

    private void myFirstMethodApparently()
	{
        print("Sup Planet");
	}
}
