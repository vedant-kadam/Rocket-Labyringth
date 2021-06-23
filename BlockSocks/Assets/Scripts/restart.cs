using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class restart : MonoBehaviour
{
    public void AGain()
    {
        FindObjectOfType<Spannners>().timetosap = Time.time + 3f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

    }
}
