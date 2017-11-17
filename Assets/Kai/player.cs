using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class player : MonoBehaviour
{
    public readonly float maxLife = 100;
    public float life = 100;
  

    // Use this for initialization
    void Start()
    {
       
        life = maxLife;
    }

    // Update is called once per frame
    void Update()
    {
      
        if (life <= 0)
        {
            Dead();
        }
    }
    public void Damage(float damage)
    {
        life -= damage;
       
        //体力を減らす
    }

    //死亡処理（死亡時の演出）
    public void Dead()
    {
        GameOver(); //ゲームオーバーにする
    }

    //ゲームオーバー処理
    public void GameOver()
    {
        // Application.LoadLevel(Application.loadedLevel); //シーンの再読み込み
        SceneManager.LoadScene("GameOver");
   
    }
    public bool flag = true;    //trueの時体力を表示させる

    void OnGUI()
    {
        if (flag)
        {
            GUI.Label(new Rect(10, 40, 100, 100), "Life " + life);
        }

    }
}
