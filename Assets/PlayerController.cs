using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float rotationSpeed;
    public Rigidbody2D rigidbody;
    public float accelerationSpeed;
    
    // Update is called once per frame
    void Update() {
        var horizontalInput = Input.GetAxis("Horizontal");
        rigidbody.AddTorque(horizontalInput * rotationSpeed * Time.deltaTime, ForceMode2D.Force);
        
        var verticalInput = Input.GetAxis("Vertical");
        rigidbody.AddForce(transform.up * verticalInput * accelerationSpeed * Time.deltaTime, ForceMode2D.Force);
    }
}
