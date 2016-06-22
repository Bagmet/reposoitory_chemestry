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
		random = Random.Range(1, 25);
		random2 = Random.Range (1, 5);
		Debug.Log (random);
		clock = 30;

	}

	// Уже имеется : Кислород (О2), Азот (N2), Водород (H2), Алюминий (Al), Хлор (Cl), Олово (Sn), Франций (Fr), Никель (Ni), Марганец (Mn), Ртуть (Hg), Гелий (He), Рубидий (Rb), Цезий (Cs), Криптон (Kr)
	//Также: Натрий (Na), Магний (Mg), Железо (Fe), Медь (Cu), Серебро (Ag), Йод (I2), Свинец(Pb), Барий(Ba), Вольфрам(W), Кальций(Ca)
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
				random = Random.Range(1, 25);
				random2 = Random.Range (1, 5);
				clock_to_next = 0.5f;
				Texty.text = "";
				score++;
			}
		}
		if (random == 2) {
			target_finish = "N2";
			target.text = "Азот";
			if (random2 == 1) {
				card_text1 = "A";
				card_text2 = "N";
				card_text3 = "2";
				card_text4 = "4";
			}
			if (random2 == 2) {
				card_text1 = "I";
				card_text2 = "6";
				card_text3 = "2";
				card_text4 = "N";
			}
			if (random2 == 3) {
				card_text1 = "F";
				card_text2 = "2";
				card_text3 = "N";
				card_text4 = "A";
			}
			if (random2 == 4) {
				card_text1 = "H";
				card_text2 = "N";
				card_text3 = "N2";
				card_text4 = "4";
			}
			card1.text = card_text1;
			card2.text = card_text2;
			card3.text = card_text3;
			card4.text = card_text4;
		}
		if (random == 3)
		{
			target_finish = "H2";
			target.text = "Водород";
			if (random2 == 1) {
				card_text1 = "B";
				card_text2 = "H";
				card_text3 = "H2";
				card_text4 = "C0";
			}
			if (random2 == 2) {
				card_text1 = "P2";
				card_text2 = "H3";
				card_text3 = "H2";
				card_text4 = "16";

			}
			if (random2 == 3) {
				card_text1 = "H";
				card_text2 = "H";
				card_text3 = "2";
				card_text4 = "Au";
			}
			if (random2 == 4) {
				card_text1 = "Fe";
				card_text2 = "HS";
				card_text3 = "H2";
				card_text4 = "Al";
			}
			card1.text = card_text1;
			card2.text = card_text2;
			card3.text = card_text3;
			card4.text = card_text4;
		}
		if (random == 4)
		{
			target_finish = "Al";
			target.text = "Алюминий";
			if (random2 == 1) {
				card_text1 = "A";
				card_text2 = "l";
				card_text3 = "H";
				card_text4 = "M2";
			}
			if (random2 == 2) {
				card_text1 = "Br";
				card_text2 = "l2";
				card_text3 = "A";
				card_text4 = "l";
			}
			if (random2 == 3) {
				card_text1 = "Zn";
				card_text2 = "Fe";
				card_text3 = "Al";
				card_text4 = "l2";
			}
			if (random2 == 4) {
				card_text1 = "Al";
				card_text2 = "Cl";
				card_text3 = "P";
				card_text4 = "Se";
			}
			card1.text = card_text1;
			card2.text = card_text2;
			card3.text = card_text3;
			card4.text = card_text4;
		}
		if (random == 5)
		{
			target_finish = "Cl2";
			target.text = "Хлор";
			if (random2 == 1) {
				card_text1 = "Cl";
				card_text2 = "2";
				card_text3 = "X2";
				card_text4 = "X2";
			}
			if (random2 == 2) {
				card_text1 = "NO";
				card_text2 = "2";
				card_text3 = "Cl2";
				card_text4 = "Cl3";
			}
			if (random2 == 3) {
				card_text1 = "Ag";
				card_text2 = "2";
				card_text3 = "Cl2";
				card_text4 = "Cl";
			}
			if (random2 == 4) {
				card_text1 = "C";
				card_text2 = "Li";
				card_text3 = "J";
				card_text4 = "l2";
			}
			card1.text = card_text1;
			card2.text = card_text2;
			card3.text = card_text3;
			card4.text = card_text4;
		}


		////////////////////////////////////////////////////////////////////////////////////////
		/// 
		if (random == 6)
		{
			target_finish = "Sn";
			target.text = "Олово";
			if (random2 == 1) {
				card_text1 = "n3";
				card_text2 = "2";
				card_text3 = "S";
				card_text4 = "n";
			}
			if (random2 == 2) {
				card_text1 = "n";
				card_text2 = "S";
				card_text3 = "S2";
				card_text4 = "C";
			}
			if (random2 == 3) {
				card_text1 = "Ag";
				card_text2 = "Sn";
				card_text3 = "K";
				card_text4 = "L";
			}
			if (random2 == 4) {
				card_text1 = "B";
				card_text2 = "F";
				card_text3 = "n";
				card_text4 = "S";
			}
			card1.text = card_text1;
			card2.text = card_text2;
			card3.text = card_text3;
			card4.text = card_text4;
		}
		/////////
		if (random == 7)
		{
			target_finish = "Fr";
			target.text = "Франций";
			if (random2 == 1) {
				card_text1 = "N";
				card_text2 = "F";
				card_text3 = "r";
				card_text4 = "2";
			}
			if (random2 == 2) {
				card_text1 = "r";
				card_text2 = "2";
				card_text3 = "F";
				card_text4 = "z";
			}
			if (random2 == 3) {
				card_text1 = "r";
				card_text2 = "F";
				card_text3 = "N";
				card_text4 = "C";
			}
			if (random2 == 4) {
				card_text1 = "C";
				card_text2 = "r";
				card_text3 = "S";
				card_text4 = "F";
			}
			card1.text = card_text1;
			card2.text = card_text2;
			card3.text = card_text3;
			card4.text = card_text4;
		}
		if (random == 8)
		{
			target_finish = "Ni";
			target.text = "Никель";
			if (random2 == 1) {
				card_text1 = "Ni";
				card_text2 = "Nk";
				card_text3 = "k";
				card_text4 = "N";
			}
			if (random2 == 2) {
				card_text1 = "N";
				card_text2 = "K";
				card_text3 = "N";
				card_text4 = "i";
			}
			if (random2 == 3) {
				card_text1 = "Br";
				card_text2 = "2";
				card_text3 = "Ni";
				card_text4 = "2";
			}
			if (random2 == 4) {
				card_text1 = "Fr";
				card_text2 = "Se";
				card_text3 = "Ni";
				card_text4 = "N";
			}
			card1.text = card_text1;
			card2.text = card_text2;
			card3.text = card_text3;
			card4.text = card_text4;
		}
		if (random == 9)
		{
			target_finish = "Mn";
			target.text = "Марганец";
			if (random2 == 1) {
				card_text1 = "M";
				card_text2 = "16";
				card_text3 = "2";
				card_text4 = "n";
			}
			if (random2 == 2) {
				card_text1 = "n";
				card_text2 = "K";
				card_text3 = "M";
				card_text4 = "g";
			}
			if (random2 == 3) {
				card_text1 = "g";
				card_text2 = "Mg";
				card_text3 = "M";
				card_text4 = "n";
			}
			if (random2 == 4) {
				card_text1 = "C";
				card_text2 = "Zn";
				card_text3 = "Mn";
				card_text4 = "Mg";
			}
			card1.text = card_text1;
			card2.text = card_text2;
			card3.text = card_text3;
			card4.text = card_text4;
		}
		////////////////////////////////
		/// 
		if (random == 10)
		{
			target_finish = "Hg";
			target.text = "Ртуть";
			if (random2 == 1) {
				card_text1 = "R";
				card_text2 = "g";
				card_text3 = "H";
				card_text4 = "n";
			}
			if (random2 == 2) {
				card_text1 = "H";
				card_text2 = "U";
				card_text3 = "M";
				card_text4 = "g";
			}
			if (random2 == 3) {
				card_text1 = "g";
				card_text2 = "Mg";
				card_text3 = "H";
				card_text4 = "R";
			}
			if (random2 == 4) {
				card_text1 = "Hg";
				card_text2 = "Rt";
				card_text3 = "Mn";
				card_text4 = "Mg";
			}
			card1.text = card_text1;
			card2.text = card_text2;
			card3.text = card_text3;
			card4.text = card_text4;
		}

		if (random == 11)
		{
			target_finish = "He";
			target.text = "Гелий";
			if (random2 == 1) {
				card_text1 = "He";
				card_text2 = "He2";
				card_text3 = "Gi";
				card_text4 = "Hg";
			}
			if (random2 == 2) {
				card_text1 = "N";
				card_text2 = "H";
				card_text3 = "g";
				card_text4 = "e";
			}
			if (random2 == 3) {
				card_text1 = "g";
				card_text2 = "e";
				card_text3 = "M";
				card_text4 = "H";
			}
			if (random2 == 4) {
				card_text1 = "Ge";
				card_text2 = "Zn";
				card_text3 = "Mn";
				card_text4 = "He";
			}
			card1.text = card_text1;
			card2.text = card_text2;
			card3.text = card_text3;
			card4.text = card_text4;
		}
		if (random == 12)
		{
			target_finish = "Rb";
			target.text = "Рубидий";
			if (random2 == 1) {
				card_text1 = "R";
				card_text2 = "b";
				card_text3 = "2";
				card_text4 = "u";
			}
			if (random2 == 2) {
				card_text1 = "u";
				card_text2 = "Rb";
				card_text3 = "Ru";
				card_text4 = "R";
			}
			if (random2 == 3) {
				card_text1 = "R";
				card_text2 = "Mg";
				card_text3 = "b";
				card_text4 = "y";
			}
			if (random2 == 4) {
				card_text1 = "C";
				card_text2 = "3";
				card_text3 = "Rb";
				card_text4 = "2";
			}
			card1.text = card_text1;
			card2.text = card_text2;
			card3.text = card_text3;
			card4.text = card_text4;
		}
		if (random == 13)
		{
			target_finish = "Cs";
			target.text = "Цезий";
			if (random2 == 1) {
				card_text1 = "C";
				card_text2 = "s";
				card_text3 = "2";
				card_text4 = "Ze";
			}
			if (random2 == 2) {
				card_text1 = "Cs";
				card_text2 = "Rb";
				card_text3 = "Zs";
				card_text4 = "R";
			}
			if (random2 == 3) {
				card_text1 = "R";
				card_text2 = "z";
				card_text3 = "Cs";
				card_text4 = "S";
			}
			if (random2 == 4) {
				card_text1 = "C";
				card_text2 = "s";
				card_text3 = "Z";
				card_text4 = "e";
			}
			card1.text = card_text1;
			card2.text = card_text2;
			card3.text = card_text3;
			card4.text = card_text4;
		}
		if (random == 14) {
			target_finish = "Kr";
			target.text = "Криптон";
			if (random2 == 1) {
				card_text1 = "Cr";
				card_text2 = "K";
				card_text3 = "2";
				card_text4 = "r";
			}
			if (random2 == 2) {
				card_text1 = "r";
				card_text2 = "b";
				card_text3 = "C";
				card_text4 = "Kr";
			}
			if (random2 == 3) {
				card_text1 = "K";
				card_text2 = "g";
				card_text3 = "i";
				card_text4 = "r";
			}
			if (random2 == 4) {
				card_text1 = "Cr";
				card_text2 = "3";
				card_text3 = "Kr";
				card_text4 = "2";
			}
			card1.text = card_text1;
			card2.text = card_text2;
			card3.text = card_text3;
			card4.text = card_text4;
		}
		if (random == 15)
		{
			target_finish = "Na";
			target.text = "Натрий";
			if (random2 == 1)
			{
				card_text1 = "Nt";
				card_text2 = "N";
				card_text3 = "2";
				card_text4 = "a";
			}
			if (random2 == 2)
			{
				card_text1 = "Na";
				card_text2 = "a";
				card_text3 = "3";
				card_text4 = "T";
			}
			if (random2 == 3)
			{
				card_text1 = "Ne";
				card_text2 = "Mg";
				card_text3 = "a";
				card_text4 = "N";
			}
			if (random2 == 4)
			{
				card_text1 = "a";
				card_text2 = "Ne";
				card_text3 = "N";
				card_text4 = "O2";
			}
			card1.text = card_text1;
			card2.text = card_text2;
			card3.text = card_text3;
			card4.text = card_text4;
		}
		if (random == 16)
		{
			target_finish = "Mg";
			target.text = "Магний";
			if (random2 == 1)
			{
				card_text1 = "N";
				card_text2 = "Mg";
				card_text3 = "2";
				card_text4 = "a";
			}
			if (random2 == 2)
			{
				card_text1 = "Na";
				card_text2 = "g";
				card_text3 = "3";
				card_text4 = "M";
			}
			if (random2 == 3)
			{
				card_text1 = "Ne";
				card_text2 = "Mg";
				card_text3 = "I";
				card_text4 = "Mn";
			}
			if (random2 == 4)
			{
				card_text1 = "M";
				card_text2 = "n";
				card_text3 = "2";
				card_text4 = "g";
			}
			card1.text = card_text1;
			card2.text = card_text2;
			card3.text = card_text3;
			card4.text = card_text4;
		}
		if (random == 17)
		{
			target_finish = "Fe";
			target.text = "Железо";
			if (random2 == 1)
			{
				card_text1 = "F";
				card_text2 = "2";
				card_text3 = "e";
				card_text4 = "G";
			}
			if (random2 == 2)
			{
				card_text1 = "I";
				card_text2 = "Fe";
				card_text3 = "Sc";
				card_text4 = "r";
			}
			if (random2 == 3)
			{
				card_text1 = "N";
				card_text2 = "Mg";
				card_text3 = "e";
				card_text4 = "F";
			}
			if (random2 == 4)
			{
				card_text1 = "a";
				card_text2 = "e";
				card_text3 = "Fe";
				card_text4 = "N";
			}
			card1.text = card_text1;
			card2.text = card_text2;
			card3.text = card_text3;
			card4.text = card_text4;
		}

		if (random == 18)
		{
			target_finish = "Cu";
			target.text = "Медь";
			if (random2 == 1)
			{
				card_text1 = "Me";
				card_text2 = "C";
				card_text3 = "2";
				card_text4 = "u";
			}
			if (random2 == 2)
			{
				card_text1 = "Na";
				card_text2 = "d";
				card_text3 = "Cu";
				card_text4 = "M";
			}
			if (random2 == 3)
			{
				card_text1 = "Cu";
				card_text2 = "Mg";
				card_text3 = "a";
				card_text4 = "M";
			}
			if (random2 == 4)
			{
				card_text1 = "C";
				card_text2 = "Ne";
				card_text3 = "u";
				card_text4 = "O2";
			}
			card1.text = card_text1;
			card2.text = card_text2;
			card3.text = card_text3;
			card4.text = card_text4;
		}

		if (random == 19)
		{
			target_finish = "Ag";
			target.text = "Серебро";
			if (random2 == 1)
			{
				card_text1 = "g";
				card_text2 = "C";
				card_text3 = "A";
				card_text4 = "2";
			}
			if (random2 == 2)
			{
				card_text1 = "Sr";
				card_text2 = "g";
				card_text3 = "Cg";
				card_text4 = "A";
			}
			if (random2 == 3)
			{
				card_text1 = "C";
				card_text2 = "Ag";
				card_text3 = "r";
				card_text4 = "S";
			}
			if (random2 == 4)
			{
				card_text1 = "C";
				card_text2 = "Ag";
				card_text3 = "u";
				card_text4 = "2";
			}
			card1.text = card_text1;
			card2.text = card_text2;
			card3.text = card_text3;
			card4.text = card_text4;
		}

		if (random == 20)
		{
			target_finish = "I2";
			target.text = "Йод";
			if (random2 == 1)
			{
				card_text1 = "Me";
				card_text2 = "I";
				card_text3 = "2";
				card_text4 = "d";
			}
			if (random2 == 2)
			{
				card_text1 = "Io";
				card_text2 = "d";
				card_text3 = "I";
				card_text4 = "2";
			}
			if (random2 == 3)
			{
				card_text1 = "I";
				card_text2 = "Mg";
				card_text3 = "2";
				card_text4 = "d";
			}
			if (random2 == 4)
			{
				card_text1 = "c";
				card_text2 = "3";
				card_text3 = "I";
				card_text4 = "2";
			}
			card1.text = card_text1;
			card2.text = card_text2;
			card3.text = card_text3;
			card4.text = card_text4;
		}

		if (random == 21)
		{
			target_finish = "Pb";
			target.text = "Свинец";
			if (random2 == 1)
			{
				card_text1 = "P";
				card_text2 = "I";
				card_text3 = "2";
				card_text4 = "b";
			}
			if (random2 == 2)
			{
				card_text1 = "Pb";
				card_text2 = "d";
				card_text3 = "I";
				card_text4 = "P";
			}
			if (random2 == 3)
			{
				card_text1 = "P";
				card_text2 = "Mg";
				card_text3 = "2";
				card_text4 = "b";
			}
			if (random2 == 4)
			{
				card_text1 = "c";
				card_text2 = "3";
				card_text3 = "P";
				card_text4 = "Pb";
			}
			card1.text = card_text1;
			card2.text = card_text2;
			card3.text = card_text3;
			card4.text = card_text4;
		}

		if (random == 22)
		{
			target_finish = "Ba";
			target.text = "Барий";
			if (random2 == 1)
			{
				card_text1 = "B";
				card_text2 = "a";
				card_text3 = "r";
				card_text4 = "i";
			}
			if (random2 == 2)
			{
				card_text1 = "Ba";
				card_text2 = "r";
				card_text3 = "B";
				card_text4 = "2";
			}
			if (random2 == 3)
			{
				card_text1 = "I";
				card_text2 = "Mg";
				card_text3 = "2";
				card_text4 = "Ba";
			}
			if (random2 == 4)
			{
				card_text1 = "B";
				card_text2 = "3";
				card_text3 = "a";
				card_text4 = "2";
			}
			card1.text = card_text1;
			card2.text = card_text2;
			card3.text = card_text3;
			card4.text = card_text4;
		}

		if (random == 23)
		{
			target_finish = "W";
			target.text = "Вольфрам";
			if (random2 == 1)
			{
				card_text1 = "Mg";
				card_text2 = "W";
				card_text3 = "e";
				card_text4 = "Wf";
			}
			if (random2 == 2)
			{
				card_text1 = "W";
				card_text2 = "Wo";
				card_text3 = "3";
				card_text4 = "2";
			}
			if (random2 == 3)
			{
				card_text1 = "I";
				card_text2 = "W";
				card_text3 = "2";
				card_text4 = "V";
			}
			if (random2 == 4)
			{
				card_text1 = "W";
				card_text2 = "3";
				card_text3 = "I";
				card_text4 = "2";
			}
			card1.text = card_text1;
			card2.text = card_text2;
			card3.text = card_text3;
			card4.text = card_text4;
		}

		if (random == 24)
		{
			target_finish = "Ca";
			target.text = "Кальций";
			if (random2 == 1)
			{
				card_text1 = "a";
				card_text2 = "I";
				card_text3 = "2";
				card_text4 = "C";
			}
			if (random2 == 2)
			{
				card_text1 = "a";
				card_text2 = "K";
				card_text3 = "Ca";
				card_text4 = "2";
			}
			if (random2 == 3)
			{
				card_text1 = "C";
				card_text2 = "Mg";
				card_text3 = "2";
				card_text4 = "a";
			}
			if (random2 == 4)
			{
				card_text1 = "c";
				card_text2 = "C";
				card_text3 = "a";
				card_text4 = "2";
			}
			card1.text = card_text1;
			card2.text = card_text2;
			card3.text = card_text3;
			card4.text = card_text4;
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