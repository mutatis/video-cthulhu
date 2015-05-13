using UnityEngine;
using System.Collections;

public class MudaCena : MonoBehaviour {

	public void MudaCena2()
	{
		PlayerPrefs.SetInt("Cena", PlayerPrefs.GetInt("Cena") + 1);
		Application.LoadLevel(PlayerPrefs.GetInt("Cena"));
	}
}
