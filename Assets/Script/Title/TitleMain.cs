using UnityEngine;
using System.Collections;

public class TitleMain : MonoBehaviour {

	bool toNextScene = false;

	FadeOut fadeOut;
	// Use this for initialization
	void Start ()
	{
		fadeOut = GameObject.Find("FadeOut").GetComponent<FadeOut>() as FadeOut;
	}
	
	// Update is called once per frame
	void Update () {
		if (!toNextScene && Input.touchCount > 0)
		{
			toNextScene = true;

		}
	}

	void StartFadeOut()
	{
		fadeOut.StartFadeOut();
	}
}
