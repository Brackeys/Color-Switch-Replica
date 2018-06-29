using UnityEngine;

public class SetRotation : MonoBehaviour {

	public float speedRotation = 100f;
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0f, 0f, speedRotation * Time.deltaTime);
	}
}
