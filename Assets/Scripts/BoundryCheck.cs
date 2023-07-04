using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundryCheck : MonoBehaviour
{
    // Start is called before the first frame update
    public static float leftside =-3.5f;
    public static float rightside = 3.5f;
    public float internalLeft;
    public float internalRight;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        internalLeft = leftside;
        internalRight = rightside;
    }
}
