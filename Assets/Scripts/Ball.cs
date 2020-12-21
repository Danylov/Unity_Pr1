using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Transform cam;
    public float speed = 80;
    public float jumpForce = 1;
    public Rigidbody rig;
    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        rig.AddTorque(h * speed * Time.deltaTime * cam.transform.forward, ForceMode.Acceleration);
        rig.AddTorque(v * speed * Time.deltaTime * cam.transform.right, ForceMode.Acceleration);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RaycastHit hit;
            Ray ray = new Ray(transform.position, Vector3.down);
            if (Physics.Raycast(ray, out hit, 1)) rig.AddForce(new Vector3(0,100*jumpForce,0));
            print(hit.collider.gameObject.name);
        }
    }
}
