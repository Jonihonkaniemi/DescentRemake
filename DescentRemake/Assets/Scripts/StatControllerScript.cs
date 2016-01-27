using UnityEngine;
using System.Collections;

public class StatControllerScript : MonoBehaviour
{
    private string secretKey = "mySecretKey"; //Editoidaan samaksi kuin serverillä, kun se on pystytetty
    public string addScoreURL = "http://localhost/unity_test/addscore.php?"; //tähän addscore urli. muista "?"
    public string highscoreURL = "http://localhost/unity_test/display.php"; //Tähän highscore näkymän urli

    void Start ()
    {
        StartCoroutine(GetScores());
	}

    IEnumerator PostScores(string name, int score)
    {
        //This connects to a server side php script that will add the name and score to a MySQL DB.
        // Supply it with a string representing the players name and the players score.
        string hash = MD5Test.Md5Sum(name + score + secretKey);

        string post_url = addScoreURL + "name=" + WWW.EscapeURL(name) + "&score=" + score + "&hash=" + hash;

        // Post the URL to the site and create a download object to get the result.
        WWW hs_post = new WWW(post_url);
        yield return hs_post; // Wait until the download is done

        if (hs_post.error != null)
        {
            print("There was an error posting the high score: " + hs_post.error);
        }
    }

    
    IEnumerator GetScores()
    {
     
    }
    
}
