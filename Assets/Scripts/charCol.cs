using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charCol : MonoBehaviour
{
    public CharacterController con;
    public float walkSpeed =  5;
    public float turnSpeed = 80;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(turnSpeed * Time.deltaTime * new Vector3(0, Input.GetAxis("Mouse X"), 0));
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        float input = walkSpeed * Input.GetAxis("Vertical");
        con.SimpleMove(forward * input);
    }
}
