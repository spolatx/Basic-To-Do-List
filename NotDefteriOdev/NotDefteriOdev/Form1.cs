using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotDefteriOdev
{
    public partial class Form1 : Form
    {
        private Note selectedNote = null;
        public Form1()
        {
            InitializeComponent();
            Refresh();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(RchNote.Text))
            {
                var addedNote = new Note();
                addedNote.Description = RchNote.Text;

                /*
                  son kayıt çekme
                 */
                var lastNote = DataStore.notes[DataStore.notes.Count - 1];
                addedNote.Id = lastNote.Id + 1;

                DataStore.notes.Add(addedNote);



                //listBox1.Items.Add(RchNote.Text);
                RchNote.Text = string.Empty;
                Refresh();
            }

            //listBox1.Items.Add(addedNote.Description);

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            Application.Exit();
        }
        public void Refresh()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = DataStore.notes;
            listBox1.DisplayMember = "Description";
            listBox1.ValueMember = "Id";
        }

        private void BtnBaglan_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection(@"server=DESKTOP-7GNS0OU\SQLEXPRESS;Database=TutorialDb; integrated security=true");
            //conn.Open();
            //conn.Close();
            //Thread.Sleep(3000);
            ////SqlCommand cmd = new SqlCommand();
            ////cmd.Connection = conn;
            ////cmd.CommandType = System.Data.CommandType.Text;
            ////cmd.CommandText = "Select * from Notes";

            ////cmd.ExecuteNonQuery();

        }


        private void BtnSil_Click(object sender, EventArgs e)
        {
            //Datastore classı içerisindeki seçili notu sildik ve listeyi yeniden getirdik.

            //samet-murat

            DataStore.notes.Remove(selectedNote);
            selectedNote = null;
            RchNote.Text = string.Empty;
            Refresh();
            
        }

        private void BtnDuzenle_Click(object sender, EventArgs e)
        {
            //txt in içerisi boş mu kontrol et değilse seçili notun açıklamasına txtyi at.
            if (!string.IsNullOrEmpty(RchNote.Text))
            {
                selectedNote.Description = RchNote.Text;

                Refresh();
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //eğer item seçiliyse seçili nesneyi seçili note un içerisine at ve seçili notun açıklamasını txtboxa ata.
            if (listBox1.SelectedItem != null)
            {
                selectedNote = (Note)listBox1.SelectedItem;
                RchNote.Text = selectedNote.Description;
            }
        }

        
    }




}
