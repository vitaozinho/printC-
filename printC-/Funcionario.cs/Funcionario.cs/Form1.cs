using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;

namespace Funcionario.cs
{
    public partial class Form1 : Form
    {   
        private List<ClasseFuncionario> listaMemoria = new List<ClasseFuncionario>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carregarComboEstados();
            carregarComboCidades();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

        }

        private void carregarComboEstados() {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = Program.conexaoBD;
            conexao.Open();


            string comandoSQL = "SELECT * FROM estados";

            SqlCommand sqlCommand = new SqlCommand(comandoSQL, conexao);

            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);

            DataTable dtFuncionariosBD = new DataTable();

            sda.Fill(dtFuncionariosBD);

            comboSelect.DataSource = dtFuncionariosBD;

            comboSelect.DisplayMember = "nmEstado";




            conexao.Close();
        }

        private void carregarComboCidades()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = Program.conexaoBD;
            conexao.Open();


            string comandoSQL = "SELECT * FROM cidades";

            SqlCommand sqlCommand = new SqlCommand(comandoSQL, conexao);

            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);

            DataTable dtFuncionariosBD = new DataTable();

            sda.Fill(dtFuncionariosBD);

            comboCidade.DataSource = dtFuncionariosBD;

            comboCidade.DisplayMember = "nmCidade";




            conexao.Close();
        }



        private void comboSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        Bitmap memoryImage;
        private PrintDocument printDocument1 = new PrintDocument();

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void printDocument1_PrintPage(System.Object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CaptureScreen();
            printDocument1.Print();
        }

       
    }
}
