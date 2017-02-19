using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(FPSCounter))]
public class FPSDisplay : MonoBehaviour {

	public Text fpsText;

	FPSCounter fpsCounter;

	// Use this for initialization
	void Start () {
		fpsCounter = GetComponent<FPSCounter> ();
	}
	
	// Update is called once per frame
	void Update () {
		fpsText.text = fpsCounter.FPS.ToString ();
	}
}
