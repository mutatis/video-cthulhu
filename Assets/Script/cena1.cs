using UnityEngine;
using System.Collections;

public class cena1 : MonoBehaviour {

	public Animator anim;
	public SpriteRenderer sprite;
	public bool ok;

	void Update()
	{
		if(ok)
		{
			sprite.color = new Color(1, 1, 1, sprite.color.a + 0.01f);
		}
	}

	public void Muda()
	{
		anim.enabled = false;
	}
}
