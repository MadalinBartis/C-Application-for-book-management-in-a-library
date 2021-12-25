using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class Form2 : Form
    {
        SqlConnection myCon = new SqlConnection();

        public void afisare()
        {
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Madalin\Postuniversitara IAP\An 2\Sem 2\Disertatie\Biblioteca\Biblioteca\Database1.mdf;Integrated Security=True";
            myCon.Open();
            SqlCommand cmd = new SqlCommand("SELECT t1.Id_carte as ID,t1.Titlu,t1.Editura,t1.An,t1.Categorie,t1.Limba,t1.Cantitate,t2.Prenume as 'Prenume Autor',t2.Nume as 'Nume Autor' FROM Carti as t1 INNER JOIN AScris as t3 On t1.Id_carte=t3.Id_carte INNER JOIN Autor as t2 on t2.Id_autor=t3.Id_autor ", myCon);

            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            myCon.Close();
        }
        public Form2()
        {
            InitializeComponent();
            afisare();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
          

        }

        private void adaugare_Click(object sender, EventArgs e)
        {
            text_id.Visible = true;
            text_titlu.Visible = true;
            text_autor_nume.Visible = true;
            text_autor_prenume.Visible = true;
            text_id_aut.Visible = true;
            text_editura.Visible = true;
            text_limba.Visible = true;
            text_an.Visible = true;
            text_cantitate.Visible = true;
            text_categorie.Visible = true;
            label_id.Visible = true;
            label_titlu.Visible = true;
            label_id_aut.Visible = true;
            label_autor.Visible = true;
            label_nume.Visible = true;
            label_prenume.Visible = true;
            label_editura.Visible = true;
            label_limba.Visible = true;
            label_an.Visible = true;
            label_cantitate.Visible = true;
            label_categorie.Visible = true;
            ok.Visible = true;

            text_id_clt.Visible = false;
            text_nume_clt.Visible = false;
            text_prenume_clt.Visible = false;
            text_adresa_clt.Visible = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            ok_impr.Visible = false;
            label_dela.Visible = false;
            label_panala.Visible = false;
            label_id_clt.Visible = false;
            label_nume_clt.Visible = false;
            label_prenume_clt.Visible = false;
            label_adresa_clt.Visible = false;



        }

        private void ok_Click(object sender, EventArgs e)
        {
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Madalin\Postuniversitara IAP\An 2\Sem 2\Disertatie\Biblioteca\Biblioteca\Database1.mdf;Integrated Security=True";
            myCon.Open();
            int val = Convert.ToInt32(text_id.Text);
            int val2 = Convert.ToInt32(text_id_aut.Text);
            SqlCommand cmd = new SqlCommand("SELECT COUNT(t1.Id_carte) FROM Carti as t1 WHERE t1.Id_carte='" + val + "'", myCon);
            SqlCommand cmd1 = new SqlCommand("SELECT COUNT(t1.Id_autor) FROM Autor as t1 WHERE t1.Id_autor='" + val2 + "'", myCon);
            Int32 count = (Int32)cmd.ExecuteScalar();
            Int32 count2 = (Int32)cmd1.ExecuteScalar();
            myCon.Close();
            if (count!=0)
            {
                MessageBox.Show("Alegeti alt id pentru carte");
            }
            else if (count2!=0)
            {
                myCon.Open();
                SqlCommand cmd2 = new SqlCommand("INSERT INTO Carti(Id_carte,Titlu,Editura,An,Categorie,Limba,Cantitate) VALUES (@Id_carte,@Titlu,@Editura,@An,@Categorie,@Limba,@Cantitate) ", myCon);
                cmd2.Parameters.AddWithValue("@Id_carte", Convert.ToInt32(text_id.Text));
                cmd2.Parameters.AddWithValue("@Titlu", text_titlu.Text);
                cmd2.Parameters.AddWithValue("@Editura", text_editura.Text);
                cmd2.Parameters.AddWithValue("@An", text_an.Text);
                cmd2.Parameters.AddWithValue("@Categorie", text_categorie.Text);
                cmd2.Parameters.AddWithValue("@Limba", text_limba.Text);
                cmd2.Parameters.AddWithValue("@Cantitate", Convert.ToInt32(text_cantitate.Text));
                cmd2.ExecuteNonQuery();

                SqlCommand cmd3 = new SqlCommand("INSERT INTO AScris(Id_carte,Id_autor) VALUES (@Id_carte,@Id_autor) ", myCon);
                cmd3.Parameters.AddWithValue("@Id_carte", Convert.ToInt32(text_id.Text));
                cmd3.Parameters.AddWithValue("@Id_autor", Convert.ToInt32(text_id_aut.Text));
                cmd3.ExecuteNonQuery();

                myCon.Close();
                afisare();

                text_id.Visible = false;
                text_titlu.Visible = false;
                text_id_aut.Visible = false;
                text_autor_nume.Visible = false;
                text_autor_prenume.Visible = false;
                text_editura.Visible = false;
                text_limba.Visible = false;
                text_an.Visible = false;
                text_cantitate.Visible = false;
                text_categorie.Visible = false;
                label_id.Visible = false;
                label_titlu.Visible = false;
                label_id_aut.Visible = false;
                label_autor.Visible = false;
                label_nume.Visible = false;
                label_prenume.Visible = false;
                label_editura.Visible = false;
                label_limba.Visible = false;
                label_an.Visible = false;
                label_cantitate.Visible = false;
                label_categorie.Visible = false;
                ok.Visible = false;


                text_id_clt.Visible = false;
                text_nume_clt.Visible = false;
                text_prenume_clt.Visible = false;
                text_adresa_clt.Visible = false;
                dateTimePicker1.Visible = false;
                dateTimePicker2.Visible = false;
                ok_impr.Visible = false;
                label_dela.Visible = false;
                label_panala.Visible = false;
                label_id_clt.Visible = false;
                label_nume_clt.Visible = false;
                label_prenume_clt.Visible = false;
                label_adresa_clt.Visible = false;

                text_id.Text = "";
                text_titlu.Text = "";
                text_id_aut.Text = "";
                text_autor_nume.Text = "";
                text_autor_prenume.Text = "";
                text_editura.Text = "";
                text_limba.Text = "";
                text_an.Text = "";
                text_cantitate.Text = "";
                text_categorie.Text = "";


            }
            else if (count2==0)
            {
                myCon.Open();
                SqlCommand cmd4 = new SqlCommand("INSERT INTO Carti(Id_carte,Titlu,Editura,An,Categorie,Limba,Cantitate) VALUES (@Id_carte,@Titlu,@Editura,@An,@Categorie,@Limba,@Cantitate) ", myCon);
                cmd4.Parameters.AddWithValue("@Id_carte", Convert.ToInt32(text_id.Text));
                cmd4.Parameters.AddWithValue("@Titlu", text_titlu.Text);
                cmd4.Parameters.AddWithValue("@Editura", text_editura.Text);
                cmd4.Parameters.AddWithValue("@An", text_an.Text);
                cmd4.Parameters.AddWithValue("@Categorie", text_categorie.Text);
                cmd4.Parameters.AddWithValue("@Limba", text_limba.Text);
                cmd4.Parameters.AddWithValue("@Cantitate", Convert.ToInt32(text_cantitate.Text));
                cmd4.ExecuteNonQuery();

                SqlCommand cmd6 = new SqlCommand("INSERT INTO Autor(Id_autor,Nume,Prenume) VALUES (@Id_autor,@Nume,@Prenume) ", myCon);
                cmd6.Parameters.AddWithValue("@Id_autor", Convert.ToInt32(text_id_aut.Text));
                cmd6.Parameters.AddWithValue("@Nume", text_autor_nume.Text);
                cmd6.Parameters.AddWithValue("@Prenume", text_autor_prenume.Text);
                cmd6.ExecuteNonQuery();

                SqlCommand cmd5 = new SqlCommand("INSERT INTO AScris(Id_carte,Id_autor) VALUES (@Id_carte,@Id_autor) ", myCon);
                cmd5.Parameters.AddWithValue("@Id_carte", Convert.ToInt32(text_id.Text));
                cmd5.Parameters.AddWithValue("@Id_autor", Convert.ToInt32(text_id_aut.Text));
                cmd5.ExecuteNonQuery();

                

                myCon.Close();
                afisare();

                text_id.Visible = false;
                text_titlu.Visible = false;
                text_id_aut.Visible = false;
                text_autor_nume.Visible = false;
                text_autor_prenume.Visible = false;
                text_editura.Visible = false;
                text_limba.Visible = false;
                text_an.Visible = false;
                text_cantitate.Visible = false;
                text_categorie.Visible = false;
                label_id.Visible = false;
                label_titlu.Visible = false;
                label_id_aut.Visible = false;
                label_autor.Visible = false;
                label_nume.Visible = false;
                label_prenume.Visible = false;
                label_editura.Visible = false;
                label_limba.Visible = false;
                label_an.Visible = false;
                label_cantitate.Visible = false;
                label_categorie.Visible = false;
                ok.Visible = false;


                text_id_clt.Visible = false;
                text_nume_clt.Visible = false;
                text_prenume_clt.Visible = false;
                text_adresa_clt.Visible = false;
                dateTimePicker1.Visible = false;
                dateTimePicker2.Visible = false;
                ok_impr.Visible = false;
                label_dela.Visible = false;
                label_panala.Visible = false;
                label_id_clt.Visible = false;
                label_nume_clt.Visible = false;
                label_prenume_clt.Visible = false;
                label_adresa_clt.Visible = false;

                text_id.Text = "";
                text_titlu.Text = "";
                text_id_aut.Text = "";
                text_autor_nume.Text = "";
                text_autor_prenume.Text = "";
                text_editura.Text = "";
                text_limba.Text = "";
                text_an.Text = "";
                text_cantitate.Text = "";
                text_categorie.Text = "";
            }
            

            
        }

        private void editare_Click(object sender, EventArgs e)
        {
            text_id.Visible = false;
            text_titlu.Visible = false;
            text_id_aut.Visible = false;
            text_autor_nume.Visible = false;
            text_autor_prenume.Visible = false;
            text_editura.Visible = false;
            text_limba.Visible = false;
            text_an.Visible = false;
            text_categorie.Visible = false;
            label_id.Visible = false;
            label_titlu.Visible = false;
            label_id_aut.Visible = false;
            label_autor.Visible = false;
            label_nume.Visible = false;
            label_prenume.Visible = false;
            label_editura.Visible = false;
            label_limba.Visible = false;
            label_an.Visible = false;
            label_categorie.Visible = false;
            ok.Visible = false;




            text_id_clt.Visible = true;
            text_nume_clt.Visible = true;
            text_prenume_clt.Visible = true;
            text_adresa_clt.Visible = true;
            dateTimePicker1.Visible = true;
            dateTimePicker2.Visible = true;
            ok_impr.Visible = true;
            label_dela.Visible = true;
            label_panala.Visible = true;
            label_id_clt.Visible = true;
            label_nume_clt.Visible = true;
            label_prenume_clt.Visible = true;
            label_adresa_clt.Visible = true;
            label_cantitate.Visible = true;
            text_cantitate.Visible = true;
            ok_impr.Visible = true;
        }

        private void cautare_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem=="Titlu")
            {
                myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Madalin\Postuniversitara IAP\An 2\Sem 2\Disertatie\Biblioteca\Biblioteca\Database1.mdf;Integrated Security=True";
                myCon.Open();
                string val = text_cautare.Text;
                dataGridView1.DataSource = null;
                SqlCommand cmd = new SqlCommand("SELECT t1.Id_carte as ID,t1.Titlu,t1.Editura,t1.An,t1.Categorie,t1.Limba,t1.Cantitate,t2.Prenume as 'Prenume Autor',t2.Nume as 'Nume Autor' FROM Carti as t1 INNER JOIN AScris as t3 On t1.Id_carte=t3.Id_carte INNER JOIN Autor as t2 on t2.Id_autor=t3.Id_autor WHERE t1.Titlu LIKE" + "'%"+ val+"%'", myCon);
                SqlDataAdapter adap1 = new SqlDataAdapter(cmd);
                DataSet ds1 = new DataSet();
                adap1.Fill(ds1);
                dataGridView1.DataSource = ds1.Tables[0].DefaultView;
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                myCon.Close();
            }
            else if (comboBox1.SelectedItem == "Autor")
            {
                myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Madalin\Postuniversitara IAP\An 2\Sem 2\Disertatie\Biblioteca\Biblioteca\Database1.mdf;Integrated Security=True";
                myCon.Open();
                string val = text_cautare.Text;
                dataGridView1.DataSource = null;
                SqlCommand cmd = new SqlCommand("SELECT t1.Id_carte as ID, t1.Titlu,t1.Editura,t1.An,t1.Categorie,t1.Limba,t1.Cantitate,t2.Prenume as 'Prenume Autor',t2.Nume as 'Nume Autor' FROM Carti as t1 INNER JOIN AScris as t3 On t1.Id_carte=t3.Id_carte INNER JOIN Autor as t2 on t2.Id_autor=t3.Id_autor WHERE t2.Nume LIKE" + "'%" + val + "%'"+ "OR t2.Prenume LIKE" + "'%" + val + "%'", myCon);
                SqlDataAdapter adap1 = new SqlDataAdapter(cmd);
                DataSet ds1 = new DataSet();
                adap1.Fill(ds1);
                dataGridView1.DataSource = ds1.Tables[0].DefaultView;
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                myCon.Close();
            }
            else
            {
                myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Madalin\Postuniversitara IAP\An 2\Sem 2\Disertatie\Biblioteca\Biblioteca\Database1.mdf;Integrated Security=True";
                myCon.Open();
                string val = text_cautare.Text;
                dataGridView1.DataSource = null;
                SqlCommand cmd = new SqlCommand("SELECT t1.Id_carte as ID, t1.Titlu,t1.Editura,t1.An,t1.Categorie,t1.Limba,t1.Cantitate,t2.Prenume as 'Prenume Autor',t2.Nume as 'Nume Autor' FROM Carti as t1 INNER JOIN AScris as t3 On t1.Id_carte=t3.Id_carte INNER JOIN Autor as t2 on t2.Id_autor=t3.Id_autor WHERE t2.Nume LIKE" + "'%" + val + "%'" + "OR t2.Prenume LIKE" + "'%" + val + "%'" + "OR t1.Titlu LIKE" + "'%" + val + "%'", myCon);
                SqlDataAdapter adap1 = new SqlDataAdapter(cmd);
                DataSet ds1 = new DataSet();
                adap1.Fill(ds1);
                dataGridView1.DataSource = ds1.Tables[0].DefaultView;
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                myCon.Close();
            }
        }

        private void afisare_totala_Click(object sender, EventArgs e)
        {
            afisare();
        }

        private void stergere_Click(object sender, EventArgs e)
        {
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Madalin\Postuniversitara IAP\An 2\Sem 2\Disertatie\Biblioteca\Biblioteca\Database1.mdf;Integrated Security=True";
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Select a row");
            }
            else
            {
                foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                {
                    int val = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    myCon.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM AScris WHERE Id_carte='" + val + "'", myCon);
                    cmd.ExecuteNonQuery();
                    SqlCommand cmd2 = new SqlCommand("DELETE FROM Imprumut WHERE Id_carte='" + val + "'", myCon);
                    cmd2.ExecuteNonQuery();
                    SqlCommand cmd1 = new SqlCommand("DELETE FROM Carti WHERE Id_carte='" + val + "'", myCon);
                    cmd1.ExecuteNonQuery();
                    dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);

                    myCon.Close();

                }
            }
        }

        private void ok_impr_Click(object sender, EventArgs e)
        {

            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Madalin\Postuniversitara IAP\An 2\Sem 2\Disertatie\Biblioteca\Biblioteca\Database1.mdf;Integrated Security=True";

            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Select a row");
            }
            else
            {
                int val = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                int id = Convert.ToInt32(text_id_clt.Text);
                myCon.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(t1.Id_client) FROM Client as t1 WHERE t1.Id_client='" + id + "'", myCon);
                Int32 count = (Int32)cmd.ExecuteScalar();
                myCon.Close();

                if (count != 0)
                {
                    if (Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[6].Value) == 0 || Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[6].Value) - Convert.ToInt32(text_cantitate.Text) < 0)
                    {
                        MessageBox.Show("Nu sunt suficiente carti!");
                    }
                    else
                    {
                        myCon.Open();
                        SqlCommand cmd2 = new SqlCommand("INSERT INTO Imprumut(Id_client,Id_carte,dela,panala) VALUES (@Id_client,@Id_carte,@dela,@panala) ", myCon);
                        cmd2.Parameters.AddWithValue("@Id_client", Convert.ToInt32(text_id_clt.Text));
                        cmd2.Parameters.AddWithValue("@Id_carte", val);
                        cmd2.Parameters.AddWithValue("@dela", dateTimePicker1.Value.Date);
                        cmd2.Parameters.AddWithValue("@panala", dateTimePicker2.Value.Date);
                        cmd2.ExecuteNonQuery();


                        SqlCommand cmd5 = new SqlCommand("UPDATE Carti SET Cantitate=Cantitate-@Cantitate WHERE Id_carte=" + val, myCon);
                        cmd5.Parameters.AddWithValue("@Cantitate", Convert.ToInt32(text_cantitate.Text));
                        cmd5.ExecuteNonQuery();

                        myCon.Close();
                        afisare();


                        text_id_clt.Visible = false;
                        text_nume_clt.Visible = false;
                        text_prenume_clt.Visible = false;
                        text_adresa_clt.Visible = false;
                        dateTimePicker1.Visible = false;
                        dateTimePicker2.Visible = false;
                        ok_impr.Visible = false;
                        label_dela.Visible = false;
                        label_panala.Visible = false;
                        label_id_clt.Visible = false;
                        label_nume_clt.Visible = false;
                        label_prenume_clt.Visible = false;
                        label_adresa_clt.Visible = false;
                        text_id.Visible = false;
                        text_titlu.Visible = false;
                        text_id_aut.Visible = false;
                        text_autor_nume.Visible = false;
                        text_autor_prenume.Visible = false;
                        text_editura.Visible = false;
                        text_limba.Visible = false;
                        text_an.Visible = false;
                        text_categorie.Visible = false;
                        label_id.Visible = false;
                        label_titlu.Visible = false;
                        label_id_aut.Visible = false;
                        label_autor.Visible = false;
                        label_nume.Visible = false;
                        label_prenume.Visible = false;
                        label_editura.Visible = false;
                        label_limba.Visible = false;
                        label_an.Visible = false;
                        label_categorie.Visible = false;
                        ok.Visible = false;
                        text_cantitate.Visible = false;
                        label_cantitate.Visible = false;

                        text_cantitate.Text = "";
                        text_id_clt.Text = "";
                        text_nume_clt.Text = "";
                        text_prenume_clt.Text = "";
                        text_adresa_clt.Text = "";
                    }

                }
                else
                {
                    if (Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[6].Value) == 0 || Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[6].Value) - Convert.ToInt32(text_cantitate.Text) < 0)
                    {
                        MessageBox.Show("Nu sunt suficiente carti!");
                    }
                    else
                    {
                        myCon.Open();
                        SqlCommand cmd4 = new SqlCommand("INSERT INTO Client(Id_client,Nume,Prenume,Adresa) VALUES (@Id_client,@Nume,@Prenume,@Adresa) ", myCon);
                        cmd4.Parameters.AddWithValue("@Id_client", Convert.ToInt32(text_id_clt.Text));
                        cmd4.Parameters.AddWithValue("@Nume", text_nume_clt.Text);
                        cmd4.Parameters.AddWithValue("@Prenume", text_prenume_clt.Text);
                        cmd4.Parameters.AddWithValue("@Adresa", text_adresa_clt.Text);
                        cmd4.ExecuteNonQuery();

                        SqlCommand cmd3 = new SqlCommand("INSERT INTO Imprumut(Id_client,Id_carte,dela,panala) VALUES (@Id_client,@Id_carte,@dela,@panala) ", myCon);
                        cmd3.Parameters.AddWithValue("@Id_client", Convert.ToInt32(text_id_clt.Text));
                        cmd3.Parameters.AddWithValue("@Id_carte", val);
                        cmd3.Parameters.AddWithValue("@dela", dateTimePicker1.Value.Date);
                        cmd3.Parameters.AddWithValue("@panala", dateTimePicker2.Value.Date);
                        cmd3.ExecuteNonQuery();

                        SqlCommand cmd6 = new SqlCommand("UPDATE Carti SET Cantitate=Cantitate-@Cantitate WHERE Id_carte=" + val, myCon);
                        cmd6.Parameters.AddWithValue("@Cantitate", Convert.ToInt32(text_cantitate.Text));
                        cmd6.ExecuteNonQuery();

                        myCon.Close();
                        afisare();

                        text_id_clt.Visible = false;
                        text_nume_clt.Visible = false;
                        text_prenume_clt.Visible = false;
                        text_adresa_clt.Visible = false;
                        dateTimePicker1.Visible = false;
                        dateTimePicker2.Visible = false;
                        ok_impr.Visible = false;
                        label_dela.Visible = false;
                        label_panala.Visible = false;
                        label_id_clt.Visible = false;
                        label_nume_clt.Visible = false;
                        label_prenume_clt.Visible = false;
                        label_adresa_clt.Visible = false;
                        text_id.Visible = false;
                        text_titlu.Visible = false;
                        text_id_aut.Visible = false;
                        text_autor_nume.Visible = false;
                        text_autor_prenume.Visible = false;
                        text_editura.Visible = false;
                        text_limba.Visible = false;
                        text_an.Visible = false;
                        text_categorie.Visible = false;
                        label_id.Visible = false;
                        label_titlu.Visible = false;
                        label_id_aut.Visible = false;
                        label_autor.Visible = false;
                        label_nume.Visible = false;
                        label_prenume.Visible = false;
                        label_editura.Visible = false;
                        label_limba.Visible = false;
                        label_an.Visible = false;
                        label_categorie.Visible = false;
                        ok.Visible = false;
                        text_cantitate.Visible = false;
                        label_cantitate.Visible = false;

                        text_cantitate.Text = "";
                        text_id_clt.Text = "";
                        text_nume_clt.Text = "";
                        text_prenume_clt.Text = "";
                        text_adresa_clt.Text = "";
                    }
                }

            }
            
        }

        private void text_titlu_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_id_TextChanged(object sender, EventArgs e)
        {
            if (text_id.Text == "")
            {
                text_id.BackColor = Color.White;
            }
            else
            {
                myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Madalin\Postuniversitara IAP\An 2\Sem 2\Disertatie\Biblioteca\Biblioteca\Database1.mdf;Integrated Security=True";
                myCon.Open();
                int val = Convert.ToInt32(text_id.Text);
                SqlCommand cmd = new SqlCommand("SELECT COUNT(t1.Id_carte) FROM Carti as t1 WHERE t1.Id_carte='" + val + "'", myCon);
                Int32 count = (Int32)cmd.ExecuteScalar();
                myCon.Close();
                if (count == 0)
                {
                    text_id.BackColor = Color.LightGreen;
                }

                else
                    text_id.BackColor = Color.LightSalmon;
            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }
    }
}
