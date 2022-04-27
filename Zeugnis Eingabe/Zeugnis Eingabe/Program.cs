﻿/*
 * Created by SharpDevelop.
 * User: schulung
 * Date: 26.04.2022
 * Time: 11:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Text.RegularExpressions;

namespace Zeugnis_Eingabe
{
	class Program
	{
		public static void Main(string[] args)
		{
			string Name;
			string Datum;
			
			//durchschnitt
			string eingabe = "0";
			int anzahl = 10;
			int gesamtwert;
			int aktuelleZahl = 0;
			
			int Deutsch, Englisch, Mathe, Biologie, Geschichte, Sport, Musik, Chemie;
			
			string Lk1;
			string Lk2;
			
			int AnzahlUnterkurse=0;
			
			int Fehltage;
			int EntschuldigteFehltage;
			
			int LKZähler1;
			
			int Lk1Nummer;
			int Lk2Nummer;
			
			Console.Write("Name: ");
			Name = Convert.ToString(Console.ReadLine());
			Regex rgx = new Regex("[^a-zA-Z- _]+");
			if (rgx.IsMatch(Name))
			{
				Console.Write("false");
				Console.Clear();
				
				Console.Write("Name: ");
			Name = Convert.ToString(Console.ReadLine());
			}
			
			Console.Write("Datum: ");
			Datum = Convert.ToString(Console.ReadLine());
			
			Console.Write("Deutsch: ");
			Deutsch = Convert.ToInt32(Console.ReadLine());
			
			if (Deutsch>15)
			{
				Console.Write("Diese Punktzahl gibt es nicht. Punktbereich von 0-15!");
			}
			
			Console.Write("Englisch: ");
			Englisch = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Mathe: ");
			Mathe = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Biologie: ");
			Biologie = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Geschichte: ");
			Geschichte = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Sport: ");
			Sport = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Musik: ");
			Musik = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Chemie: ");
			Chemie = Convert.ToInt32(Console.ReadLine());
			
			
			
			Console.Write("1.Leistungskurs: ");
			Lk1 = Convert.ToString(Console.ReadLine());
			Console.Write("Punktzahl in dem Leistungskurs: ");
			Lk1Nummer = Convert.ToInt32(Console.ReadLine());
			
			
			
			Console.Write("2.Leistungskurs: ");
			Lk2 = Convert.ToString(Console.ReadLine());
			Console.Write("Punktzahl in dem Leistungskurs: ");
			Lk2Nummer = Convert.ToInt32(Console.ReadLine());
			
			
			
			
			Console.Write("Entschuldigte Fehltage: ");
			EntschuldigteFehltage = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Unentschuldigte Fehltage: ");
			Fehltage = Convert.ToInt32(Console.ReadLine());
			
			
			if (Chemie>15)
			{
				Console.Write("Diese Punktzahl gibt es nicht. Punktbereich von 0-15!");
			}
			
			
			
			if (Sport<5)
			{
				AnzahlUnterkurse= AnzahlUnterkurse +1;
			}
			if (Deutsch<5)
			{
				AnzahlUnterkurse= AnzahlUnterkurse +1;
			}
			if (Mathe<5)
			{
				AnzahlUnterkurse= AnzahlUnterkurse +1;
			}
			if (Englisch<5)
			{
				AnzahlUnterkurse= AnzahlUnterkurse +1;
			}
			if (Biologie<5)
			{
				AnzahlUnterkurse= AnzahlUnterkurse +1;
			}
			if (Chemie<5)
			{
				AnzahlUnterkurse= AnzahlUnterkurse +1;
			}
			if (Geschichte<5)
			{
				AnzahlUnterkurse= AnzahlUnterkurse +1;
			}
			if (Musik<5)
			{
				AnzahlUnterkurse= AnzahlUnterkurse +1;
			}
			if (AnzahlUnterkurse>1)
			{
				Console.Write("Schüler*in wird nicht versetzt.");
			}
			else
				if (Fehltage>29)
			{
				Console.Write("Schüler*in wird nicht versetzt.");
			}
			if (AnzahlUnterkurse<2 && Fehltage<30)
			{
				Console.Write("Schüler*in wird versetzt.");
			}
			
			//Durschnitt berechnen
			
			gesamtwert = Deutsch+Englisch+Mathe+Biologie+Chemie+Musik+Sport+Geschichte+Lk1Nummer+Lk2Nummer;
			
			while(eingabe != "-1")
			{
				Console.WriteLine("Geben Sie -1 ein um den Durchschnitt zu berechnen");
				
				eingabe = Console.ReadLine();
				if(eingabe == "-1")
				{
					Console.WriteLine("--------------------------------------------------------------");
					double durchschnitt = (double)gesamtwert / (double)anzahl;
					durchschnitt = Math.Round(durchschnitt,1);
					Console.WriteLine("Der Durchschnitt ist " + durchschnitt);
					
					double Notendurchschnitt = (17-durchschnitt)/3;
					Notendurchschnitt= Math.Round(Notendurchschnitt,1);
					Console.WriteLine("Umgerechnet in Noten ist der Durchschnitt " + Notendurchschnitt);
				}
				
				if(Int32.TryParse(eingabe, out aktuelleZahl) && aktuelleZahl >0 && aktuelleZahl<16){
					gesamtwert=gesamtwert+aktuelleZahl;
				}
				else
				{
					if(!(eingabe=="-1"))
					{
						Console.WriteLine("Bitte geben Sie ganzzahlige Werte zwischen 1 und 15 ein!");
					}
					continue;
				}
				anzahl++;
			}
			
			
			
			Console.ReadKey(true);
		}
	}
	
}