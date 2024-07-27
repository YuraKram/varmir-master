using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger1 : MonoBehaviour
{
    public GameObject righthand, lefthand;
    // Start is called before the first frame update
    void OnTriggerExit(Collider other)
    {
        bool points = trigger.points;
        if (other.gameObject.name == righthand.name || other.gameObject.name == lefthand.name)
        {
            points = false;
        }
    }
}
