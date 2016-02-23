using UnityEngine;
using System.Collections;

public class BulletBehavior : MonoBehaviour {
    float deathTimer = 0.8f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    void Update() {
        transform.Translate(0.0f, 0.0f, .5f);
        deathTimer -= Time.deltaTime;
        if (deathTimer <= 0.0f)
        {
            Destroy(this.gameObject);
        }
	}

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision");
        Destroy(collision.gameObject);
        Destroy(this.gameObject);
    }
}
