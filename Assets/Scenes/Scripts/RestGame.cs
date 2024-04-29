using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class RestGame : MonoBehaviour
{
    public float threshHold = -5f;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < threshHold)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
