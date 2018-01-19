using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterestPoint : MonoBehaviour {

    
    float amplitudeY = 0.05f;
    float omegaY = 2.0f;
    float index;
    public GameObject infoFrigo;

    // Use this for initialization
    void Start () {
        infoFrigo = GameObject.Find("texteRefrigerateur");
        infoFrigo.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        index += Time.deltaTime;
        float ypos = 1.2f + Mathf.Abs(amplitudeY * Mathf.Sin(omegaY * index));
        transform.localPosition = new Vector3(gameObject.transform.position.x, ypos, gameObject.transform.position.z);
        transform.Rotate(Vector3.up * 50 * Time.deltaTime, Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Controller")
        {
            gameObject.SetActive(false);
            infoFrigo.SetActive(true);
        }
    }
}
