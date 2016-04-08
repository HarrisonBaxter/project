using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void Pavs(){
        SceneManager.LoadScene("MyRoom");
    }
    void Courts()
    {
        SceneManager.LoadScene("Labs");
    }


    void Bray(){
        SceneManager.LoadScene("Hill");
    }

}
