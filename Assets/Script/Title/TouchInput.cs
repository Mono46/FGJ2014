/*
 * TouchInput class
 * Author : Onodera Yuto
 * Created : 2014 / 8 / 3
 * Last Update : 2014 / 8 / 3
 */

using UnityEngine;
using System.Collections;

/// <summary>
/// Touch input.
/// Singletone class.
/// This class is for integrate touch evengt process and mouse event on editor.
/// support single touch event only.
/// Don't destroy object.
/// </summary>
public class TouchInput : MonoBehaviour
{

	public const float flickAcc = 5.0f;
	private TouchInput(){}

	/// <summary>
	/// Singleton instance.
	/// </summary>
	private static TouchInput instance = null;

	/// <summary>
	/// Gets the instance.
	/// </summary>
	/// <value>The instance.</value>
	public static TouchInput Instance
	{
		get
		{
			if (TouchInput.instance == null)
			{
				TouchInput.instance = this;
			}
			return TouchInput.instance;
		}
	}

	void OnDestroy()
	{
		if (instance != null)
		{
			instance.Release();
		}
	}

	void Awake()
	{
		DontDestroyOnLoad(this);
	}
	
	/// <summary>
	/// Release this instance.
	/// </summary>
	public void Release()
	{
		TouchInput.instance = null;
	}

	/// <summary>
	/// Releases and destroy this instance.
	/// </summary>
	public void ReleasAndDestroy()
	{
		Destroy(this);
		TochInput.Instance = null;
	}
	
	/// <summary>
	/// Initialize this instance.
	/// </summary>
	private void Initialize()
	{

	}

	Touch touchInfo = null;

	void Update()
	{




	}


	private int lastTouchCount = 0;

	public bool OnTouch()
	{


		return false;
	}

	private List<ITouchEvent> events;
	
	public bool OnRelease()
	{

	}
}
