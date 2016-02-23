using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {
	public GameObject bulletPrefab;

    float reloadTimerMax;
    float reloadTimer;

	// Use this for initialization
	void Start () {
        reloadTimerMax = 0.7f;
        reloadTimer = 0.0f;
	}
	
	// Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (reloadTimer <= 0.0f)
            {
                CreateBullet();
                reloadTimer = reloadTimerMax;
            }
        }
        if (reloadTimer > 0.0f)
        {
            reloadTimer -= Time.deltaTime;
        }
	}

    void CreateBullet()
    {
        var pos = transform.position;
        pos.z += 1.0f;
        GameObject tempBullet = (GameObject)Instantiate(bulletPrefab,
                                             pos,
                                             Quaternion.identity);
    }
}
