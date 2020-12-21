using UnityEngine;
using System.Collections.Generic;

public class Cubie : MonoBehaviour
{
   public static int g;
   
   public string name = "null";
   public List<Transform> waypoints = new List<Transform>();
   public int cur = 0;
   public Transform curWayPoint;
   void Start()
   {
      if (name == "null") print("You've not set your name");
      g += 1;
      print(g);
   }

   void Update()
   {
      if (cur < 1) curWayPoint = waypoints[0];
      if (Vector3.Distance(this.transform.position, curWayPoint.position) < 0.1f)
      {
         cur += 1;
         if (waypoints.Count <= cur)
         {
            cur = 0;
            curWayPoint = waypoints[0];
         } else curWayPoint = waypoints[cur];
      }
      transform.position = Vector3.MoveTowards(this.transform.position, curWayPoint.position, 0.01f);
   }
}
