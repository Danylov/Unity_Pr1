using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRot : MonoBehaviour
{
    public float speed;

    public bool xAxis = true;
    // Update is called once per frame
    void Update()
    {
        if (xAxis == true) transform.Rotate(speed * Time.deltaTime * new Vector3(0, Input.GetAxis("Mouse X"), 0));
        else transform.Rotate(speed * Time.deltaTime * new Vector3(- 1 * Input.GetAxis("Mouse Y"),0, 0));
    }
}
