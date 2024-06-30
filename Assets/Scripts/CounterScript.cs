using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CounterScript : MonoBehaviour
{
	private const int INTERVAL = 1;
	private Text m_counterLabel;
	public static int count = 3;
	public static bool IsCounterVisible = true;
	
	void Start () {
		m_counterLabel = GetComponent<Text> ();
		UpdateCounter();
		StartCoroutine(DecrementCounter());
	}
	IEnumerator DecrementCounter()
	{
		//Count Down to start the game
		while (count > 0)
		{
			yield return new WaitForSeconds(INTERVAL);
			count--;
			UpdateCounter();
		}

		IsCounterVisible = false;
		m_counterLabel.gameObject.SetActive(false);
	}

	void UpdateCounter ( ) {
		m_counterLabel.text = count.ToString();
	}
}
