using System.Collections;
using UnityEngine;

public class Changer : MonoBehaviour
{
    public GameObject[] tools;

    void Start()
    {
        for (int a = 0; a < tools.Length; a++)
        {
            if (a != 0) tools[a].active = false;
        }
    }

    int cur = 0;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            cur = 0;
            Debug.Log("cur = 0");
            for (int a = 0; a < tools.Length; a++)
            {
                if (a != 0) tools[a].active = false;
                else        tools[a].active = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            cur = 1;
            Debug.Log("cur = 1");
            for (int a = 0; a < tools.Length; a++)
            {
                if (a != 1) tools[a].active = false;
                else        tools[a].active = true;
            }
        }
        if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            cur = 2;
            Debug.Log("cur = 2");
            for (int a = 0; a < tools.Length; a++)
            {
                if (a != 2) tools[a].active = false;
                else        tools[a].active = true;
            }
        }
    }
}