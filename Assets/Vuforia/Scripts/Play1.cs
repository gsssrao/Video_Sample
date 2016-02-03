using UnityEngine;
using System.Collections;

public class Play1 : MonoBehaviour {
	
	public MovieTexture movTexture;
	public static int flag = 0;
	// Use this for initialization
	void Start () {
		// The commented script starts playing the video as soon as the app starts, but a more useful behaviour would be playing it when marker is detected. 
		//		GetComponent<Renderer>().material.mainTexture = movTexture;
		//		movTexture.Play();
		//		GetComponent<AudioSource> ().Play ();
	}
	
	// Update is called once per frame
	void Update () {
		if (flag == 1) {
			GetComponent<Renderer>().material.mainTexture = movTexture;
			movTexture.Play();
			GetComponent<AudioSource> ().Play ();
			flag = 0;
		}
		if (flag == 2) {
			movTexture.Pause();
			GetComponent<AudioSource>().Pause();
			flag = 0;
		}
		
	}
}
