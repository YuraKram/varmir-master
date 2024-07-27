using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner: MonoBehaviour
{
	public Transform spawnFishP;
	[SerializeField] Vector3 range;
	[SerializeField] GameObject Fish;
	void Start()
    {
		StartCoroutine(Spawn());
    }
	IEnumerator Spawn()
    {
		yield return new WaitForSeconds(5);
		Vector3 pos = spawnFishP.position + new Vector3(0,Random.Range(-range.y, range.y),Random.Range(-range.z, range.z));
		Instantiate(Fish, pos, Quaternion.identity);
		Repeat();

    }
	void Repeat()
    {
		StartCoroutine(Spawn());
    }
}
