using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnControllerScript : MonoBehaviour
{
	private const string SelectForFireMethodName = "SelectForFire";
	const string FireMethodName = "Fire";

	[SerializeField] private float minInvokeTime = 0;
	[SerializeField] private float maxInvokeTime = 10;

	private float repeatRate ;

	void Start()
	{
		StartCoroutine(WaitAndFire());
		repeatRate = maxInvokeTime / 4;
	}

	private IEnumerator WaitAndFire()
	{
		yield return new WaitUntil(() => !CounterScript.IsCounterVisible);
		float rand = Random.Range(minInvokeTime, maxInvokeTime);
		InvokeRepeating(SelectForFireMethodName, rand,repeatRate);
	}

	void SelectForFire()
	{
		if (!LifeManager.gameOver && transform.childCount > 0)
		{
			transform.GetChild(0).gameObject.GetComponent<EnemyScript>().Invoke(FireMethodName,0f);
		}
		else if (transform.childCount == 0)
			Destroy(gameObject);
	}
}
