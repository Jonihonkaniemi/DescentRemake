using UnityEngine;
using System.Collections;

public class TrackFiringScript : MonoBehaviour {

    private PlayerShoot playerShoot;
    public int bulletCount = 0;
    public int bulletCountOld;

	// Use this for initialization
	void Start () {
        playerShoot = this.GetComponent<PlayerShoot>();
	
	}
	
	// Update is called once per frame
	void Update () {
        if(bulletCount != bulletCountOld)
        {
            bulletCountOld = bulletCount;
            print("Shots fired: " + bulletCount);
        }
	
	}
}
