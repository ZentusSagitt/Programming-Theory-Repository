using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeChild : ShapeParent   // INHETIRANCE
{
    // ENCAPSULATION
    [SerializeField] float jumpForce;
    public float JumpForce
    {
        get { return jumpForce; }
        set
        {
            if (value < 0.0f)
            {
                Debug.Log("The Jump Force set can't be negative");
            }
            else
            {
                jumpForce = value;
            }
        }
    }
    //////////

    public override void DisplayText()  // POLYMORPHISM
    {
        Debug.Log(gameObject.name + " has been clicked");
    }

    private void Update()
    {
        if (jumpForce > 0)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce, ForceMode.Impulse); 
        }
    }
}
