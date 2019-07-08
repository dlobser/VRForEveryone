using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowToScript : MonoBehaviour
{
    public int integerValue;
    public float floatValue;
    public float secondFloatValue;

    public string stringValue;
    public Vector3 vectorValue;

    //This is a function, everything inside it gets called on start
    void Start()
    {
        
    }

    //This function is called automatically every frame
    //It says "void" because it doesn't return anything
    void Update()
    {
        Debug.Log("Integers are whole numbers, such as: " + integerValue + "\n");
        Debug.Log("Floating point numbers contain decimal points, such as: " + floatValue + "\n");
        Debug.Log("Strings are letters, words and sentences: " + stringValue + "\n");
        Debug.Log("Vectors are special objects which contain 2, 3, or 4 floats: " + vectorValue + "\n");
        Debug.Log("Functions can do things like add numbers together: " + Add(floatValue,secondFloatValue) + "\n");

    }

    //This function says float because it returns the sum of two floats we give it
    float Add(float A, float B){
        return A + B;
    }
}
