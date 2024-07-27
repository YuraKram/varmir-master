using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changescene : MonoBehaviour
{
	public GameObject island1;
	public GameObject island2;

	void OnTriggerEnter(Collider other)
    {
		if (other.gameObject.name == island1.name)
        {
            island1.SetActive(false);
            island2.SetActive(true);
        }
    }
}
