using UnityEngine;
using System.Collections;

public class TrackFiringScript : MonoBehaviour {

    private PlayerShoot playerShoot;
    public int bulletCount = 0;
    public int bulletCountOld;
    public int shots = 10;

	void Start () {
        playerShoot = this.GetComponent<PlayerShoot>();
	
	}
	
	void Update () {
        if(bulletCount != bulletCountOld)
        {
            bulletCountOld = bulletCount;
            print("Shots fired: " + bulletCount);
        }
	
	}
}
