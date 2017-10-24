using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyEmitter : MonoBehaviour
{

  //  public float minLength = 5f;
    //public float maxLength = 15f;
    public float maxEnemy1 = 10;
    public float maxEnemy2 = 3;

    public Enemy enemy1;
    public Enemy enemy2;

    void Start()
    {

    }

    void Update()
    {

    }

    private void OnGUI()
    {
        if (GUILayout.Button("Start"))
        {
            EmitEnemies();
        }
    }

    void EmitEnemies()
    {

        for (int i = 0; i < maxEnemy1; i++){
           // Vector3 rv = Random.onUnitSphere;

            //float rl = Random.Range(minLength, maxLength);

            //Instantiate(enemy, transform.position + rl * rv, Quaternion.identity);
            float x = Random.Range(-25f,25f);
            float y = Random.Range(5f, 7f);
            float z = Random.Range(-25f, 25f);
            Vector3 po1 = new Vector3(x, y, z);
            Instantiate(enemy1, po1, Quaternion.identity);
        }
        for (int b = 0; b < maxEnemy2; b++) {
            float v = Random.Range(-25f, 25f);
            float w = Random.Range(-25f, 25f);
            Vector3 po2 = new Vector3(v, 0, w);
            Instantiate(enemy2, po2, Quaternion.identity);


        }

    }

}
