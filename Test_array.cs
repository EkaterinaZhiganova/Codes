using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_array : MonoBehaviour
{
    //The array of numbers
    private int[] numbersArray;

    private void Start()
    {
        //Initialization of ints
        numbersArray = new int[] { 7, 8, 9, 3 };
        for (int i =0; i < numbersArray.Length; i++)
        {
            //This shows which number is used
            Debug.Log(numbersArray[i]);
        }
    }
}
