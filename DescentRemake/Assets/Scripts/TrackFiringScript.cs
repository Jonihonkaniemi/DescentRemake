using UnityEngine;
using System.Collections;

public class TrackFiringScript : MonoBehaviour {

    private PlayerShoot playerShoot;
    private StatController statController;
    public int bulletCountOld = 0;
    public int bulletCount = 0;

	void Start () {
        playerShoot = GameObject.Find("Player").GetComponent<PlayerShoot>();
        statController = GetComponent<StatController>();
        
	
	}
	
	void Update () {
        bulletCount = playerShoot.bulletCounter;
        print("Shots fired: " + bulletCount);
        if (bulletCount != bulletCountOld)
        {
            statController.SendData();
            bulletCountOld = playerShoot.bulletCounter;
            print("Shots fired: " + bulletCountOld);
        }
	
	}
}
