using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tool : MonoBehaviour
{
    public enum Type
    {
        shoot,
        throws
    };
    public Type Tools;

    public int points = 0;
    public int dis = 30;
    public int Damage = 10;
    public string killable = "Cubie";

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            Vector3 rot = transform.TransformDirection(Vector3.forward);
            RaycastHit hit;
            Ray ray = new Ray(transform.position, rot);
            
            if (Physics.Raycast(ray, out hit, dis))
            {
                Debug.Log(hit.collider.gameObject.name);
                if (hit.collider.gameObject.name == killable) Destroy(hit.collider.gameObject);
                points++;
            };
        }
    }
}