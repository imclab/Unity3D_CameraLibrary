using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	private Vector3[] cubePositions = {
		new Vector3(0.0f, 0.0f, 0.0f),
		new Vector3(0.0f, 0.0f, 10.0f),
		new Vector3(10.0f, 0.0f, 0.0f),
		new Vector3(10.0f, 0.0f, 10.0f),

		new Vector3(0.0f, 10.0f, 0.0f),
		new Vector3(0.0f, 10.0f, 10.0f),
		new Vector3(10.0f, 10.0f, 0.0f),
		new Vector3(10.0f, 10.0f, 10.0f)
	};

	private int inc;

	void changeCameraPosition (int position) {
		gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, cubePositions[position], Time.deltaTime);
		gameObject.transform.LookAt(new Vector3(0, 0, 0));
	}

	void handleKeyEvents () {
		if(Input.GetKeyUp(KeyCode.RightArrow)) {
			inc ++;
			inc %= cubePositions.Length;
		}

		changeCameraPosition(inc);
	}

	// Use this for initialization
	void Start () {
		inc = 0;
	}

	// Update is called once per frame
	void FixedUpdate () {
		handleKeyEvents();
	}
}
