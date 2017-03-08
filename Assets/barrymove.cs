using UnityEngine;
using System.Collections;

public class barrymove : MonoBehaviour {

	// Use this for initialization
	void Start () {
        InvokeRepeating("Hight", 5, 10);
    }
	void Hight()
    {
        float y = (float)Random.Range(-0.8f, 1.6f);
        Instantiate(gameObject, new Vector2(4, y), Quaternion.identity);
    }
    // Update is called once per frame

	void Update () {
        transform.Translate(Vector2.left * Time.deltaTime);
        if (transform.position.x <= -5)
            Destroy(gameObject);

    }
}
