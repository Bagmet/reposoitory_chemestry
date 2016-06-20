using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class version1 : MonoBehaviour {
	public AudioClip click, cancel;
	private float random, clock, clock_to_next, random2;
	public Text target, card1, card2, card3, card4, Texty, clock_Text, score_Text;
	private string target_text, target_finish;
	private string card_text1, card_text2, card_text3, card_text4;
	private int score;

	// Use this for initialization
	void Start () {
		clock_to_next = 0.5f;
		score = 0;
		target_finish = "not";
		random = Random.Range(1, 15);
		random2 = Random.Range (1, 5);
		Debug.Log (random);
		clock = 30;
	
	}
	
	// Update is called once per frame
	void Update () {
		score_Text.text = "" +  score;
		clock_Text.text = "" + Mathf.RoundToInt (clock);
		clock = clock - Time.deltaTime;


		if (random == 1) {
			target_finish = "O2"; 
			target.text = "Кислород"; 
			if (random2 == 1) {
				card_text1 = "H";
				card_text2 = "K";
				card_text3 = "O";
				card_text4 = "2";
			}
			if (random2 == 2) {
				card_text1 = "3";
				card_text2 = "K";
				card_text3 = "O";
				card_text4 = "2";
			}
			if (random2 == 3) {
				card_text1 = "H2";
				card_text2 = "Mg";
				card_text3 = "O2";
				card_text4 = "3";
			}
			if (random2 == 4) {
				card_text1 = "C";
				card_text2 = "K";
				card_text3 = "2";
				card_text4 = "O"; 
			} 
			card1.text = card_text1; 
			card2.text = card_text2; 
			card3.text = card_text3; 
			card4.text = card_text4; 
		} 

									
									
		if (Texty.text == target_finish) {

			clock_to_next -= Time.deltaTime;
			if (clock_to_next <= 0) {
				random = Random.Range(1, 15);
				random2 = Random.Range (1, 5);
				clock_to_next = 0.5f;
				Texty.text = "";
				score = score + 1;
			}
		

		}
									if (random == 2) {
			if (random2 == 1) {
				target_finish = "N2";
				target.text = "Азот";
				card_text1 = "A";
				card1.text = card_text1;
				card_text2 = "N";
				card2.text = card_text2;
				card_text3 = "2";
				card3.text = card_text3;
				card_text4 = "4";
				card4.text = card_text4;
			}
			if (random2 == 2) {
				target_finish = "N2";
				target.text = "Азот";
				card_text1 = "I";
				card1.text = card_text1;
				card_text2 = "6";
				card2.text = card_text2;
				card_text3 = "2";
				card3.text = card_text3;
				card_text4 = "N";
				card4.text = card_text4;
			}
			if (random2 == 3) {
				target_finish = "N2";
				target.text = "Азот";
				card_text1 = "F";
				card1.text = card_text1;
				card_text2 = "2";
				card2.text = card_text2;
				card_text3 = "N";
				card3.text = card_text3;
				card_text4 = "A";
				card4.text = card_text4;
			}
			if (random2 == 4) {
				target_finish = "N2";
				target.text = "Азот";
				card_text1 = "H";
				card1.text = card_text1;
				card_text2 = "N";
				card2.text = card_text2;
				card_text3 = "N2";
				card3.text = card_text3;
				card_text4 = "4";
				card4.text = card_text4;
			}
												}
		if (random == 3) {
			if (random2 == 1) {
				target_finish = "H2";
				target.text = "Водород";
				card_text1 = "B";
				card1.text = card_text1;
				card_text2 = "H";
				card2.text = card_text2;
				card_text3 = "H2";
				card3.text = card_text3;
				card_text4 = "C0";
				card4.text = card_text4;
			}
			if (random2 == 2) {
				target_finish = "H2";
				target.text = "Водород";
				card_text1 = "P2";
				card1.text = card_text1;
				card_text2 = "H3";
				card2.text = card_text2;
				card_text3 = "H2";
				card3.text = card_text3;
				card_text4 = "16";
				card4.text = card_text4;
			}
			if (random2 == 3) {
				target_finish = "H2";
				target.text = "Водород";
				card_text1 = "H";
				card1.text = card_text1;
				card_text2 = "H";
				card2.text = card_text2;
				card_text3 = "2";
				card3.text = card_text3;
				card_text4 = "Au";
				card4.text = card_text4;
			}
			if (random2 == 4) {
				target_finish = "H2";
				target.text = "Водород";
				card_text1 = "Fe";
				card1.text = card_text1;
				card_text2 = "HS";
				card2.text = card_text2;
				card_text3 = "H2";
				card3.text = card_text3;
				card_text4 = "Al";
				card4.text = card_text4;
			}
		}
		if (random == 4) {
			if (random2 == 1) {
				target_finish = "Al";
				target.text = "Алюминий";
				card_text1 = "A";
				card1.text = card_text1;
				card_text2 = "l";
				card2.text = card_text2;
				card_text3 = "H";
				card3.text = card_text3;
				card_text4 = "M2";
				card4.text = card_text4;
			}
			if (random2 == 2) {
				target_finish = "Al";
				target.text = "Алюминий";
				card_text1 = "Br";
				card1.text = card_text1;
				card_text2 = "l2";
				card2.text = card_text2;
				card_text3 = "A";
				card3.text = card_text3;
				card_text4 = "l";
				card4.text = card_text4;
			}
			if (random2 == 3) {
				target_finish = "Al";
				target.text = "Алюминий";
				card_text1 = "Zn";
				card1.text = card_text1;
				card_text2 = "Fe";
				card2.text = card_text2;
				card_text3 = "Al";
				card3.text = card_text3;
				card_text4 = "l2";
				card4.text = card_text4;
			}
			if (random2 == 4) {
				target_finish = "Al";
				target.text = "Алюминий";
				card_text1 = "Al";
				card1.text = card_text1;
				card_text2 = "Cl";
				card2.text = card_text2;
				card_text3 = "P";
				card3.text = card_text3;
				card_text4 = "Se";
				card4.text = card_text4;
			}
		}
		if (random == 5) {
			if (random2 == 1) {
				target_finish = "Cl2";
				target.text = "Хлор";
				card_text1 = "Cl";
				card1.text = card_text1;
				card_text2 = "2";
				card2.text = card_text2;
				card_text3 = "X2";
				card3.text = card_text3;
				card_text4 = "X2";
				card4.text = card_text4;
			}
			if (random2 == 2) {
				target_finish = "Cl2";
				target.text = "Хлор";
				card_text1 = "NO";
				card1.text = card_text1;
				card_text2 = "2";
				card2.text = card_text2;
				card_text3 = "Cl2";
				card3.text = card_text3;
				card_text4 = "Cl3";
				card4.text = card_text4;
			}
			if (random2 == 3) {
				target_finish = "Cl2";
				target.text = "Хлор";
				card_text1 = "Ag";
				card1.text = card_text1;
				card_text2 = "2";
				card2.text = card_text2;
				card_text3 = "Cl2";
				card3.text = card_text3;
				card_text4 = "Cl";
				card4.text = card_text4;
			}
			if (random2 == 4) {
				target_finish = "Cl2";
				target.text = "Хлор";
				card_text1 = "C";
				card1.text = card_text1;
				card_text2 = "Li";
				card2.text = card_text2;
				card_text3 = "J";
				card3.text = card_text3;
				card_text4 = "l2";
				card4.text = card_text4;
			}
		}


		////////////////////////////////////////////////////////////////////////////////////////
		/// 
		if (random == 6) {
			if (random2 == 1) {
				target_finish = "SN";
				target.text = "Олово";
				card_text1 = "N";
				card1.text = card_text1;
				card_text2 = "2";
				card2.text = card_text2;
				card_text3 = "S";
				card3.text = card_text3;
				card_text4 = "N";
				card4.text = card_text4;
			}
			if (random2 == 2) {
				target_finish = "SN";
				target.text = "Олово";
				card_text1 = "N";
				card1.text = card_text1;
				card_text2 = "S";
				card2.text = card_text2;
				card_text3 = "S2";
				card3.text = card_text3;
				card_text4 = "C";
				card4.text = card_text4;
			}
			if (random2 == 3) {
				target_finish = "Sn";
				target.text = "Олово";
				card_text1 = "Ag";
				card1.text = card_text1;
				card_text2 = "Sn";
				card2.text = card_text2;
				card_text3 = "K";
				card3.text = card_text3;
				card_text4 = "L";
				card4.text = card_text4;
			}
			if (random2 == 4) {
				target_finish = "Sn";
				target.text = "Олово";
				card_text1 = "B";
				card1.text = card_text1;
				card_text2 = "F";
				card2.text = card_text2;
				card_text3 = "n";
				card3.text = card_text3;
				card_text4 = "S";
				card4.text = card_text4;
			}
		}
		/////////
		if (random == 7) {
			if (random2 == 1) {
				target_finish = "Fr";
				target.text = "Франций";
				card_text1 = "N";
				card1.text = card_text1;
				card_text2 = "F";
				card2.text = card_text2;
				card_text3 = "r";
				card3.text = card_text3;
				card_text4 = "2";
				card4.text = card_text4;
			}
			if (random2 == 2) {
				target_finish = "Fr";
				target.text = "Франций";
				card_text1 = "r";
				card1.text = card_text1;
				card_text2 = "2";
				card2.text = card_text2;
				card_text3 = "F";
				card3.text = card_text3;
				card_text4 = "z";
				card4.text = card_text4;
			}
			if (random2 == 3) {
				target_finish = "Fr";
				target.text = "Франций";
				card_text1 = "r";
				card1.text = card_text1;
				card_text2 = "F";
				card2.text = card_text2;
				card_text3 = "N";
				card3.text = card_text3;
				card_text4 = "C";
				card4.text = card_text4;
			}
			if (random2 == 4) {
				target_finish = "Fr";
				target.text = "Франций";
				card_text1 = "C";
				card1.text = card_text1;
				card_text2 = "r";
				card2.text = card_text2;
				card_text3 = "S";
				card3.text = card_text3;
				card_text4 = "F";
				card4.text = card_text4;
			}
		}
		if (random == 8) {
			if (random2 == 1) {
				target_finish = "Ni";
				target.text = "Никель";
				card_text1 = "Ni";
				card1.text = card_text1;
				card_text2 = "Nk";
				card2.text = card_text2;
				card_text3 = "k";
				card3.text = card_text3;
				card_text4 = "N";
				card4.text = card_text4;
			}
			if (random2 == 2) {
				target_finish = "Ni";
				target.text = "Никель";
				card_text1 = "N";
				card1.text = card_text1;
				card_text2 = "K";
				card2.text = card_text2;
				card_text3 = "N";
				card3.text = card_text3;
				card_text4 = "i";
				card4.text = card_text4;
			}
			if (random2 == 3) {
				target_finish = "Ni";
				target.text = "Никель";
				card_text1 = "Br";
				card1.text = card_text1;
				card_text2 = "2";
				card2.text = card_text2;
				card_text3 = "Ni";
				card3.text = card_text3;
				card_text4 = "2";
				card4.text = card_text4;
			}
			if (random2 == 4) {
				target_finish = "Ni";
				target.text = "Никель";
				card_text1 = "Fr";
				card1.text = card_text1;
				card_text2 = "Se";
				card2.text = card_text2;
				card_text3 = "Ni";
				card3.text = card_text3;
				card_text4 = "N";
				card4.text = card_text4;
			}
		}
		if (random == 9) {
			if (random2 == 1) {
				target_finish = "Mn";
				target.text = "Марганец";
				card_text1 = "M";
				card1.text = card_text1;
				card_text2 = "16";
				card2.text = card_text2;
				card_text3 = "2";
				card3.text = card_text3;
				card_text4 = "n";
				card4.text = card_text4;
			}
			if (random2 == 2) {
				target_finish = "Mn";
				target.text = "Марганец";
				card_text1 = "n";
				card1.text = card_text1;
				card_text2 = "K";
				card2.text = card_text2;
				card_text3 = "M";
				card3.text = card_text3;
				card_text4 = "g";
				card4.text = card_text4;
			}
			if (random2 == 3) {
				target_finish = "Mn";
				target.text = "Марганец";
				card_text1 = "g";
				card1.text = card_text1;
				card_text2 = "Mg";
				card2.text = card_text2;
				card_text3 = "M";
				card3.text = card_text3;
				card_text4 = "n";
				card4.text = card_text4;
			}
			if (random2 == 4) {
				target_finish = "Mn";
				target.text = "Марганец";
				card_text1 = "C";
				card1.text = card_text1;
				card_text2 = "Zn";
				card2.text = card_text2;
				card_text3 = "Mn";
				card3.text = card_text3;
				card_text4 = "Mg";
				card4.text = card_text4;
			}
		}
		////////////////////////////////
		/// 
		if (random == 10) {
			if (random2 == 1) {
				target_finish = "Hg";
				target.text = "Ртуть";
				card_text1 = "R";
				card1.text = card_text1;
				card_text2 = "g";
				card2.text = card_text2;
				card_text3 = "H";
				card3.text = card_text3;
				card_text4 = "n";
				card4.text = card_text4;
			}
			if (random2 == 2) {
				target_finish = "Hg";
				target.text = "Ртуть";
				card_text1 = "H";
				card1.text = card_text1;
				card_text2 = "U";
				card2.text = card_text2;
				card_text3 = "M";
				card3.text = card_text3;
				card_text4 = "g";
				card4.text = card_text4;
			}
			if (random2 == 3) {
				target_finish = "Hg";
				target.text = "Ртуть";
				card_text1 = "g";
				card1.text = card_text1;
				card_text2 = "Mg";
				card2.text = card_text2;
				card_text3 = "H";
				card3.text = card_text3;
				card_text4 = "R";
				card4.text = card_text4;
			}
			if (random2 == 4) {
				target_finish = "Hg";
				target.text = "Ртуть";
				card_text1 = "Hg";
				card1.text = card_text1;
				card_text2 = "Rt";
				card2.text = card_text2;
				card_text3 = "Mn";
				card3.text = card_text3;
				card_text4 = "Mg";
				card4.text = card_text4;
			}
		}

		if (random == 11) {
			if (random2 == 1) {
				target_finish = "He";
				target.text = "Гелий";
				card_text1 = "He";
				card1.text = card_text1;
				card_text2 = "He2";
				card2.text = card_text2;
				card_text3 = "Gi";
				card3.text = card_text3;
				card_text4 = "Hg";
				card4.text = card_text4;
			}
			if (random2 == 2) {
				target_finish = "He";
				target.text = "Гелий";
				card_text1 = "N";
				card1.text = card_text1;
				card_text2 = "H";
				card2.text = card_text2;
				card_text3 = "g";
				card3.text = card_text3;
				card_text4 = "e";
				card4.text = card_text4;
			}
			if (random2 == 3) {
				target_finish = "He";
				target.text = "Гелий";
				card_text1 = "g";
				card1.text = card_text1;
				card_text2 = "e";
				card2.text = card_text2;
				card_text3 = "M";
				card3.text = card_text3;
				card_text4 = "H";
				card4.text = card_text4;
			}
			if (random2 == 4) {
				target_finish = "He";
				target.text = "Гелий";
				card_text1 = "Ge";
				card1.text = card_text1;
				card_text2 = "Zn";
				card2.text = card_text2;
				card_text3 = "Mn";
				card3.text = card_text3;
				card_text4 = "He";
				card4.text = card_text4;
			}
		}
		if (random == 12) {
			if (random2 == 1) {
				target_finish = "Rb";
				target.text = "Рубидий";
				card_text1 = "R";
				card1.text = card_text1;
				card_text2 = "b";
				card2.text = card_text2;
				card_text3 = "2";
				card3.text = card_text3;
				card_text4 = "u";
				card4.text = card_text4;
			}
			if (random2 == 2) {
				target_finish = "Rb";
				target.text = "Рубидий";
				card_text1 = "u";
				card1.text = card_text1;
				card_text2 = "Rb";
				card2.text = card_text2;
				card_text3 = "Ru";
				card3.text = card_text3;
				card_text4 = "R";
				card4.text = card_text4;
			}
			if (random2 == 3) {
				target_finish = "Rb";
				target.text = "Рубидий";
				card_text1 = "R";
				card1.text = card_text1;
				card_text2 = "Mg";
				card2.text = card_text2;
				card_text3 = "b";
				card3.text = card_text3;
				card_text4 = "y";
				card4.text = card_text4;
			}
			if (random2 == 4) {
				target_finish = "Rb";
				target.text = "Рубидий";
				card_text1 = "C";
				card1.text = card_text1;
				card_text2 = "3";
				card2.text = card_text2;
				card_text3 = "Rb";
				card3.text = card_text3;
				card_text4 = "2";
				card4.text = card_text4;
			}
		}
		if (random == 13) {
			if (random2 == 1) {
				target_finish = "Cs";
				target.text = "Цезий";
				card_text1 = "C";
				card1.text = card_text1;
				card_text2 = "s";
				card2.text = card_text2;
				card_text3 = "2";
				card3.text = card_text3;
				card_text4 = "Ze";
				card4.text = card_text4;
			}
			if (random2 == 2) {
				target_finish = "Cs";
				target.text = "Цезий";
				card_text1 = "Cs";
				card1.text = card_text1;
				card_text2 = "Rb";
				card2.text = card_text2;
				card_text3 = "Zs";
				card3.text = card_text3;
				card_text4 = "R";
				card4.text = card_text4;
			}
			if (random2 == 3) {
				target_finish = "Cs";
				target.text = "Цезий";
				card_text1 = "R";
				card1.text = card_text1;
				card_text2 = "z";
				card2.text = card_text2;
				card_text3 = "Cs";
				card3.text = card_text3;
				card_text4 = "S";
				card4.text = card_text4;
			}
			if (random2 == 4) {
				target_finish = "Cs";
				target.text = "Цезий";
				card_text1 = "C";
				card1.text = card_text1;
				card_text2 = "s";
				card2.text = card_text2;
				card_text3 = "Z";
				card3.text = card_text3;
				card_text4 = "e";
				card4.text = card_text4;
			}
		}
		if (random == 14) {
			if (random2 == 1) {
				target_finish = "Kr";
				target.text = "Криптон";
				card_text1 = "Cr";
				card1.text = card_text1;
				card_text2 = "K";
				card2.text = card_text2;
				card_text3 = "2";
				card3.text = card_text3;
				card_text4 = "r";
				card4.text = card_text4;
			}
			if (random2 == 2) {
				target_finish = "Kr";
				target.text = "Криптон";
				card_text1 = "r";
				card1.text = card_text1;
				card_text2 = "b";
				card2.text = card_text2;
				card_text3 = "C";
				card3.text = card_text3;
				card_text4 = "Kr";
				card4.text = card_text4;
			}
			if (random2 == 3) {
				target_finish = "Kr";
				target.text = "Криптон";
				card_text1 = "K";
				card1.text = card_text1;
				card_text2 = "g";
				card2.text = card_text2;
				card_text3 = "i";
				card3.text = card_text3;
				card_text4 = "r";
				card4.text = card_text4;
			}
			if (random2 == 4) {
				target_finish = "Kr";
				target.text = "Криптон";
				card_text1 = "Cr";
				card1.text = card_text1;
				card_text2 = "3";
				card2.text = card_text2;
				card_text3 = "Kr";
				card3.text = card_text3;
				card_text4 = "2";
				card4.text = card_text4;
			}
		}
		if (clock <= 0) {
			PlayerPrefs.SetInt ("score", score);
			if (PlayerPrefs.GetInt ("hight") < PlayerPrefs.GetInt ("score")) {
				PlayerPrefs.SetInt ("hight", score);
			}
			Application.LoadLevel ("Gameover");
		}
	}
	public void OnCard1(){
		AudioSource.PlayClipAtPoint (click, transform.position);
		Texty.text = Texty.text+ card_text1;
	}
	public void OnCard2(){
		AudioSource.PlayClipAtPoint (click, transform.position);
		Texty.text = Texty.text+ card_text2;
	}
	public void OnCard3(){
		AudioSource.PlayClipAtPoint (click, transform.position);
		Texty.text = Texty.text+ card_text3;
	}
	public void OnCard4(){
		AudioSource.PlayClipAtPoint (click, transform.position);
		Texty.text = Texty.text+ card_text4;
	}
	public void OnClear(){
		AudioSource.PlayClipAtPoint (cancel, transform.position);
		Texty.text = "";
	}
}
