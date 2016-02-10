using UnityEngine;
using System.Collections;
using System.Collections.Specialized;

public class StatController : MonoBehaviour
{
   
    public string addScoreURL = "http://oamkpo2016.esy.es/shots"; //be sure to add a ? to your url
 
    void Start()
    {
        //StartCoroutine(PostScores(8, 1337));
    } 

    public void SendData()
    {
        StartCoroutine(PostScores(8, 1));
    }

    IEnumerator PostScores(int ID, int shots)
    {
        using (var wb = new System.Net.WebClient())
        {
            var data = new NameValueCollection();
            data["ID"] = ID.ToString();
            data["shots"] = shots.ToString();

            var response = wb.UploadValues(addScoreURL, "POST", data);
            yield return response;
        }
    }
}
