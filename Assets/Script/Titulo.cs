using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Titulo : MonoBehaviour {

	public ParticleSystem[] play;
	public Animator anim;
	public CameraMov camera;
	public Text text;

	// Use this for initialization
	void Start () 
	{
		PlayerPrefs.SetInt("Cena", 0);	
	}
	
	// Update is called once per frame
	void Update () 
	{
		text.color = new Color(0, 0, 0, text.color.a);
	}

	public void Inicio()
	{
		/*play[0].Pause();
		play[1].Pause();
		play[2].Pause();*/
	}

	public void Cabo()
	{
		camera.desce = true;
		/*play[0].Play();
		play[1].Play();
		play[2].Play();*/
		anim.enabled = false;
	}
}
