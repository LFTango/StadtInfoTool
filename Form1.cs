using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StadtInfoTool
{
	public partial class Form1 : Form
	{

		private Antwort deserialized; 

		public string Get(string uri) //Läd eine JSON herunter mit Werten zur 
		{
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
			request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate; //Dekompressiert die datei die man über die webrequest erhählt

			using (HttpWebResponse response = (HttpWebResponse)request.GetResponse()) //returned die antwort auf die request in einer variable
			using (Stream stream = response.GetResponseStream()) //Erstellt einen byte stream aus der response
			using (StreamReader reader = new StreamReader(stream)) //Ließt den byte stream aus und pakt diese als string in die variable
			{
				return reader.ReadToEnd(); //Der ausgelesene string wird returned
			}
		}

		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string apistringurl = "https://www.distance24.org/route.json?stops=" + Stadt1TB.Text + "|" + Stadt2TB.Text + "|" + Stadt3TB.Text + "";
			string jsonstring = Get(apistringurl); //Deklariert jsonstring. jsonstring beinhaltet die heruntergeladene JSON in string form

			deserialized = JsonConvert.DeserializeObject<Antwort>(jsonstring);

			Distance.Text = "Distanz gesamt: " + deserialized.Distance;

			if (deserialized.Distances.Length >= 1) //Überprüft ob der distance array auch wirklich daten besitzt und stellt sicher das man nicht out of range kommt. Das passiert auch in den restlichen if's
			Distance01.Text = "Distanz zwischen den beiden Städten: " + deserialized.Distances[0]; //schreibt die passende distanz in das label rein
			if (deserialized.Distances.Length >= 2)
				Distance12.Text = "Distanz zwischen den beiden Städten: " + deserialized.Distances[1];

			if (deserialized.stops.Length >= 1)
			{
				Pop0.Text = "Bevölkerung: " + deserialized.stops[0].wikipedia.population;
				Tz0.Text = "Zeitzone: " + deserialized.stops[0].timeZone.abbr;
			}

			if (deserialized.stops.Length >= 2)
			{
				Pop1.Text = "Bevölkerung: " + deserialized.stops[1].wikipedia.population;
				Tz1.Text = "Zeitzone: " + deserialized.stops[1].timeZone.abbr;
			}

			if (deserialized.stops.Length >= 3)
			{
				Pop2.Text = "Bevölkerung: " + deserialized.stops[2].wikipedia.population;
				Tz2.Text = "Zeitzone: " + deserialized.stops[2].timeZone.abbr;
			}
		}

		private void button2_Click(object sender, EventArgs e) //Ein button der die heruntergeladenen werte der JSON unter StadtInfoTool\bin\Debug speichert. 
		{
			if (deserialized != null) //überprüft ob die klasse nicht null ist
			{
				File.WriteAllText("SavedInfo.json", JsonConvert.SerializeObject(deserialized, Formatting.Indented)); //Speichert und Formatiert die JSON
			}
		}
	}
}
