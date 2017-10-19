using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyEmitter : MonoBehaviour
{

  //  public float minLength = 5f;
    //public float maxLength = 15f;
    public float maxEnemy = 10;

    public Enemy enemy;

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

        for (int i = 0; i < maxEnemy; i++)
        {
           // Vector3 rv = Random.onUnitSphere;

            //float rl = Random.Range(minLength, maxLength);

            //Instantiate(enemy, transform.position + rl * rv, Quaternion.identity);
            float x = Random.Range(-25f,25f);
            float y = Random.Range(5f, 7f);
            float z = Random.Range(-25f, 25f);
            Vector3 po = new Vector3(x, y, z);
            Instantiate(enemy, po, Quaternion.identity);
        }

    }

}
