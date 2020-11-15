using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextSence : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Raycast(){
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100))
            {
                if(hit.collider.gameObject.tag == "Play")
                {
                    SceneManager.LoadScene("PlayScene");
                }
                if(hit.collider.gameObject.tag == "Select"){
                    SceneManager.LoadScene("SelectScene");
                }
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        Raycast();
    }
}
