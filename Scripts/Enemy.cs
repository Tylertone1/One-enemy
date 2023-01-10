using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public Rigidbody2D m_toge;
    public int m_HP;
    public float speed = -10f;
    public int MaxTurns = 3;
    private int turns = 0;
    public GameObject m_player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public GameObject ui_congrats;

    void BeShot(int damage)
    {
        m_HP -= damage;
        if (m_HP == 0)
        {
            Destroy(gameObject);
            turns++;
            print("success");
            Vector2 v = new Vector2( 0,0);
            m_toge.velocity = v * Time.deltaTime;
            ui_congrats.SetActive(true);



           

        }
    }

   
}
