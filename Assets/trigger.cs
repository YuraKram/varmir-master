using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    public GameObject player;
    public static bool points = false;
    public GameObject playercollider;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == playercollider.name)
        {
            points = true;
            player.transform.position = new Vector3(0f, -1f, 0);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == playercollider.name)
        {
            points = false;
            player.transform.position = new Vector3(0f, 0f, 0);
        }
    }
}
