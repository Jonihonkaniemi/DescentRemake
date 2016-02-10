using UnityEngine;
using System.Collections;
using LitJson;


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
        // string Get_url = url + "nname=" + WWW.EscapeURL(nname);
        print(nname);
        string Get_url = new System.Net.WebClient().DownloadString(url + "nname=" + WWW.EscapeURL(nname));
        // Post the URL to the site and create a download object to get the result.
        print(Get_url);
        JsonData data = JsonMapper.ToObject(Get_url);
        //Debug.Log(data["Reply"][0]["ID"]);
        int id = int.Parse((string)data["Reply"][0]["ID"]);
        print("Pelaajan id on: " + id);




        yield return Get_url; // Wait until the download is done
    }
}
