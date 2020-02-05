using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autokauppa.controller;
using Autokauppa.model;

namespace Autokauppa.view
{
    public partial class MainMenu : Form
    {
        KaupanLogiikka registerHandler;

        List<model.Auto> autolist;

        int CurrID;

        public MainMenu()
        {
            registerHandler = new KaupanLogiikka();
            registerHandler.TestDatabaseConnection();
            InitializeComponent();

            List<AutoMerkki> merkkiList = registerHandler.getAllAutoMakers().ToList();

            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = merkkiList;

            Merkki.DataSource = bindingSource1;

            Merkki.DisplayMember = "Merkki";
            Merkki.ValueMember = "ID";

            foreach (string a in registerHandler.getFuels())
            {
                Polttoaine.Items.Add(a);
            }
            foreach (string a in registerHandler.getPaints())
            {
                Vari.Items.Add(a);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kokeileYhteyttäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(registerHandler.TestDatabaseConnection())
            {
                MessageBox.Show("it does work");
            }
        }

        private void TallennaButton_Click(object sender, EventArgs e)
        {
            registerHandler.PutAuto(model.Auto.Make(0, Convert.ToDecimal(Hinta.Text), dateTimePicker1.Value, Convert.ToDecimal(Tilavuus.Text),
                                    Convert.ToInt32(MittariLukema.Text), Convert.ToInt32(Merkki.SelectedValue), Convert.ToInt32(Malli.SelectedValue),
                                    Vari.SelectedIndex, Polttoaine.SelectedIndex));
        }

        private void Merkki_SelectedIndexChanged(object sender, EventArgs e)
        {

            List<AutoMalli> malliList = registerHandler.getAutoModels(Convert.ToInt32(Merkki.SelectedValue)).ToList();

            var bindingSource2 = new BindingSource();
            bindingSource2.DataSource = malliList;

            Malli.DataSource = bindingSource2;

            Malli.DisplayMember = "Malli";
            Malli.ValueMember = "ID";


        }
        private void Malli_SelectedIndexChanged(object sender, EventArgs e)
        {
            autolist = registerHandler.GetAuto(Convert.ToInt32(Merkki.SelectedValue), Convert.ToInt32(Malli.SelectedValue)).ToList();

            CurrID = 1;

            UpdateSelection(CurrID);
        }
        private void UpdateSelection(int WantedID)
        {
            MittariLukema.Text = Convert.ToString(autolist[WantedID].Mittarilukema);
            Tilavuus.Text = Convert.ToString(autolist[WantedID].Moottorin_tilavuus);
            Hinta.Text = Convert.ToString(autolist[WantedID].Hinta);
            dateTimePicker1.Value = autolist[WantedID].Rekisteri_paivamaara;
            
        }

        private void UusiButton_Click(object sender, EventArgs e)
        {
            MittariLukema.Clear();
            Tilavuus.Clear();
            Hinta.Clear();
        }

        private void SeuraavaButton_Click(object sender, EventArgs e)
        {
            if (CurrID < autolist.Count -1)
            {
                CurrID++;
                UpdateSelection(CurrID);
            }
        }

        private void EdellinenButton_Click(object sender, EventArgs e)
        {
            if (CurrID > 0)
            {
                CurrID--;
                UpdateSelection(CurrID);
            }
        }

        private void PoistaButton_Click(object sender, EventArgs e)
        {

        }
    }
}
