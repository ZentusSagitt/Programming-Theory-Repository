using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitWithMouse : MonoBehaviour
{
    public GameObject shapes;
    private ShapeChild shapeChildScript;

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SetJumpForce(2f);
        }
        if (Input.GetMouseButtonUp(0))
        {
            SetJumpForce(0f);
        }
    }

    // ABSTRACTION
    void SetJumpForce(float jF)
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.tag == "Player")
            {
                shapeChildScript = hit.transform.GetComponent<ShapeChild>();
                shapeChildScript.DisplayText();
                shapeChildScript.JumpForce = jF;
            }
            else
            {
                shapeChildScript.JumpForce = jF;
            }
        }
    }
}
