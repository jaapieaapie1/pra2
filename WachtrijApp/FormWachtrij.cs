using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml;

namespace WachtrijApp
{
    public partial class FormWachtrij : Form
    {
        public FormWachtrij()
        {
            InitializeComponent();
        }

        //  Er is op het logo geklikt. Die actie start een event welke de onderstaande methode aanroept.
        private void AttractieLogo_Click(object sender, EventArgs e)
        {
            VerwerkWachtrijSensorData();

            VerwerkAttractieStatusData();
        }

        private void VerwerkWachtrijSensorData()
        {
            //  Roep de methode aan welke de wachttijd berekend.
            int Wachttijd = BerekenWachttijd();

            //  Gebruik de wachttijd om de tekst in de label 'labelWachttijdMelding' aan te passen.
            this.labelWachttijdMelding.Text = $"{Wachttijd} minuten";
        }

        //  Deze methode leest de sensordata in het betreffende XML bestand.
        //  Deze methode berekend vervolgens de de wachttijd in minuten en geeft deze terug.
        private int BerekenWachttijd()
        {
            int Wachttijd = 0;

            //  Lees het XML WachtrijSensoren bestand uit welke meet waar mensen staan te wachten.
            XmlDocument doc = new XmlDocument();
            doc.Load("SensorData\\WachtrijSensoren.xml");

            foreach (XmlNode childNode in doc.DocumentElement.SelectSingleNode("/Sensoren").ChildNodes)
            {
                string text = childNode.InnerText;
                if (text.ToLower() == "false")
                {                    
                    return Wachttijd;
                }
            
                Wachttijd += Convert.ToInt32(childNode.Attributes["time"].Value);
            }
            
            return Wachttijd;
        }

        private void VerwerkAttractieStatusData()
        {
            //  Lees het XML AttractieStatus bestand uit welke de data van de karretjes uitleest.
            XmlDocument doc = new XmlDocument();
            doc.Load("SensorData\\AttractieStatus.xml");

            //  Selecteer de XML node 'Kar01' en lees vervolgens de waarde binnen het element.
            //  Converteer de statuc-code in een status-beschrijving.
            //  Gebruik de status-beschrijving om de tekst in de label 'labelKar1' aan te passen.
            string node1 = doc.DocumentElement.SelectSingleNode("/Status/Kar01").InnerText;
            string status1 = ConvertStatus(node1);
            this.labelKar1.Text = $"Kar 1: {status1}";

            string node2 = doc.DocumentElement.SelectSingleNode("/Status/Kar02").InnerText;
            string status2 = ConvertStatus(node2);
            this.labelKar2.Text = $"Kar 2: {status2}";
        }

        //  Een methode welke een status-code omzet naar een status-beschrijving
        private string ConvertStatus(string StatusNr)
        {
            switch (StatusNr)
            {
                case "1":
                    return "uit/instappen";
                case "2":
                    return "Klaar voor vertrek";
                case "3":
                    return "Op avontuur";
                case "4":
                    return "Komt binnen";
                case "5":
                    return "In onderhoud";
            }

            return "";
        }
    }
}
