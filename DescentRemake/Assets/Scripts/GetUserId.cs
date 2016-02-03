using UnityEngine;
using System.Collections;

public class GetUserId : MonoBehaviour {

    public string url = "http://oamkpo2016.esy.es/login?";

	// Use this for initialization
	void Start () {
        StartCoroutine(GetID("honkkis"));
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    IEnumerator GetID(string nname)
    {
        string Get_url = url + "nname=" + WWW.EscapeURL(nname);
        print(Get_url);

        // Post the URL to the site and create a download object to get the result.
        WWW hs_get = new WWW(Get_url);

        print("hs get: " + hs_get);
        yield return hs_get; // Wait until the download is done

        if (hs_get.error != null)
        {
            print("There was an error getting user id: " + hs_get.error);
        }
    }
}
