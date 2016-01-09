using UnityEngine;
using System.Collections;

public class LightningController : MonoBehaviour {

	public GameObject blend;
	public AnimationCurve lightningCurve;

	private float alpha;
	private float grey;
	private Color color;
	private float pointer;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		alpha = lightningCurve.Evaluate(pointer);

		pointer += Time.deltaTime;

		color = new Color (grey,grey,grey,alpha);
		blend.GetComponent<SpriteRenderer> ().color = color;

		if (Random.value > 0.99f) {
			strike ();
		}
	}

	public void strike() {
		pointer = 0;
	}
}
