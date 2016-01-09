using UnityEngine;
using System.Collections;

public class ZombieScript : MonoBehaviour {

	public bool left = true;
	public float height = 0.5f;
	public float width = 0.5f;
	public LayerMask bounce;

	private Rigidbody2D rigidBody;
	private SpriteRenderer spriterRenderer;

	// Use this for initialization
	void Start () {
		rigidBody = this.GetComponent<Rigidbody2D> ();
		spriterRenderer = this.GetComponentInChildren<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {

		spriterRenderer.flipX = left;

		Vector2 dir = left ? new Vector2 (-1, 0) : new Vector2 (1, 0);

		rigidBody.velocity = new Vector2 (dir.x,rigidBody.velocity.y);

		RaycastHit2D hitHigh = Physics2D.Raycast (toVec2(transform.position) + (new Vector2 (height / 2, 0)) + dir * width / 2, dir, 0.05f, bounce);
		RaycastHit2D hitMiddle = Physics2D.Raycast (toVec2(transform.position) + dir * width / 2, dir, 0.05f, bounce);
		RaycastHit2D hitLow = Physics2D.Raycast (toVec2(transform.position) - (new Vector2 (height / 2, 0)) + dir * width / 2, dir, 0.05f, bounce);

		if (hitHigh.collider != null && hitMiddle.collider != null && hitLow.collider != null) {
			left = left ? false : true;
		}


	}

	private Vector2 toVec2(Vector3 vec3) {
		return new Vector2 (vec3.x, vec3.y);
	}
}
