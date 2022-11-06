using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Aircraft : MonoBehaviour
{
    public float speed = 10f;
    public float rotationSpeed = 50f;
    public float verticalInput = 15f;

    //protected abstract void MoveAircraft();

    protected virtual void MoveAircraft()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * verticalInput);
    }
}
