using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class logoControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(NextScene() );
    }
    IEnumerator NextScene(){
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("MainScene");
    }

}
