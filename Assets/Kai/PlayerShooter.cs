using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooter : MonoBehaviour
{

	//public GameObject Shot;
	//public GameObject Wave;
	public GameObject beam;
	public AudioSource sound;
	public AudioClip shotSound;


    void Start()
    {
		sound = this.gameObject.GetComponent<AudioSource>();    //Audio Sourceコンポーネントを代入
    }

    void Update()
    {
		//GameObject Bullet;
       // if (Input.GetKeyDown(KeyCode.Space))
       // {
        //    Instantiate(beam, transform.position, transform.rotation);
        //}

		/*if (Input.GetKeyDown(KeyCode.Space))
		{
			Bullet = Shot;
			//Fire
			GameObject s = (GameObject)Instantiate(Bullet, this.transform.position, this.transform.rotation);
			s.GetComponent<BeamParam>().SetBeamParam(this.GetComponent<BeamParam>());

			GameObject wav = (GameObject)Instantiate(Wave, this.transform.position, this.transform.rotation);
			wav.transform.localScale *= 0.25f;
			wav.transform.Rotate(Vector3.left, 90.0f);
			wav.GetComponent<BeamWave>().col = this.GetComponent<BeamParam>().BeamColor;

		}*/

		 if (Input.GetKeyDown(KeyCode.Space))
		 {
			sound.PlayOneShot(shotSound);
		    Instantiate(beam, transform.position, transform.rotation);
		}


    }

}
