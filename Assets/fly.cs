using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class fly : MonoBehaviour {
    public Text s;
    private int score=0;
    private Rigidbody2D flying;
    public GameObject failure;
    // Use this for initialization
    void Start () {
        flying = GetComponent<Rigidbody2D>();
	}
	void OnCollisionEnter2D(Collision2D coll)
    {
     /*   string name = coll.collider.name; //获取碰撞到游戏物体名字
        print(name);//在控制台中显示其碰撞的东西
       if (coll.collider .tag=="empty")
        {
            score++;
            s.text = score.ToString();
   
        }*/
        
        if(coll.collider .tag == "pipe"|| coll.collider.tag == "ground")
        {
            Destroy(gameObject);
            failure.SetActive(true);
        }

    }
    void OnTriggerEnter2D(Collider2D other)
    {
       
        if (other.tag == "empty")
        {
            score++;
            s.text = score.ToString();

        }

     

    }
    /*   void scorepuls()
       {
           if(pipes.transform .position .x==transform.position .x)
           {
               if(transform.position .y<=pipes .transform .position .y+0.65f&&transform .position .y>=pipes.transform .position.y-0.65f)
               {
                   score++;
                   s.text = score.ToString();
               }
           }
       }*/
    // Update is called once per frame
    void Update () {
	    
        if(Input.GetMouseButton(0))
        {
            flying.AddForce(new Vector2(0, 5));
        }
        
	}
}
