﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Formulario realizado por Kimberly Alejandra Rivera Gonzalez
//En primer semestre 2018 en Ingenieria de Software

namespace PrototipoSeguridad
{
    public partial class Vista_alergias : Form
    {
        public Vista_alergias()
        {
            InitializeComponent();   
            llenarTablaM();  // inicializamos el componente con llenar la tabla de los datos ya ingresados en la BD
        }

        private void Vista_alergias_Load(object sender, EventArgs e)
        {
            llenarTablaM(); // cada vez que se vuelva a cargar el formulario se llenará el datagrid con los datos
        }

        // se crea la sentencia a la conexión a la BD
        string MyConnection2 = "Driver ={ MySQL ODBC 3.51 Driver }; Dsn=servidor_seguridad; UID=root; PWD = ;  ";

        // llena una tabla al iniciar con los datos de una vista realizada en la base de datos
        public void llenarTablaM()
        {
            try
            {
                string Query = "select * from Valergias_cliente;";
                OdbcConnection MyConn2 = new OdbcConnection(MyConnection2);
                OdbcCommand MyCommand2 = new OdbcCommand(Query, MyConn2);
                OdbcDataAdapter MyAdapter = new OdbcDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            // al presionar el boton guardar lo que hará es verificar el ultimo codigo ingresado y 
            // y sumarle 1, para que en el siguiente formulario aparezca ya el codigo que sigue
            Alergias aler = new Alergias();
            aler.MdiParent = this.MdiParent;

            int cod1;
            string MyConnection3 = "Driver ={ MySQL ODBC 3.51 Driver }; Dsn=servidor_seguridad; UID=root; PWD = ;  ";

            string Query2 = "Select id_alergia from alergias_cliente order by id_alergia DESC LIMIT 1;";
            OdbcConnection MyConn3 = new OdbcConnection(MyConnection3);
            OdbcCommand MyCommand3 = new OdbcCommand(Query2, MyConn3);
            MyConn3.Open();
            OdbcDataReader myreader3;
            myreader3 = MyCommand3.ExecuteReader();
            if (myreader3.Read())
            {
                cod1 = (int)myreader3["id_alergia"];
                int cod2 = cod1 + 1;

                aler.primarykey.Text = cod2.ToString();
                aler.primarykey.Visible = true;
            }
            aler.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        { // se utilizo para poder tomar la primer celda del datagrid
            dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[1];
        }

        private void button3_Click(object sender, EventArgs e)
        {  // se utilizo para poder tomar la ultima celda del datagrid
            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            string columna = dataGridView1.CurrentCell.RowIndex.ToString();  //selecciona numero de columna
            int columna_id = Convert.ToInt32(columna); // convierte el numero de colunma

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // al darle doble clic a cualquier celda, se llevarán los datos del datagrid al siguiente formulario
            Alergias alerg = new Alergias();
            alerg.MdiParent = this.MdiParent;
            int cod1;
            string columna = dataGridView1.CurrentCell.RowIndex.ToString();//selecciona numero de columna
            int columna_id = Convert.ToInt32(columna);
            string dato1 = dataGridView1.Rows[columna_id].Cells[0].Value.ToString();
            int datoint = Convert.ToInt32(dato1);
            //MessageBox.Show(datoint.ToString()); 
            string MyConnection3 = "Driver ={ MySQL ODBC 3.51 Driver }; Dsn=servidor_seguridad; UID=root; PWD = ;  ";

            string Query = "select descrip_alergia,id_alergia from alergias_cliente where id_alergia =" + datoint + ";";
            OdbcConnection MyConn2 = new OdbcConnection(MyConnection3);
            OdbcCommand MyCommand2 = new OdbcCommand(Query, MyConn2);
            MyConn2.Open();
            OdbcDataReader reader = MyCommand2.ExecuteReader();
            // coloca en los textBox, y comboBox correspondientes la informacion que se obtiene de la base de datos
            if (reader.Read())
            {
                alerg.descripcion.Text = (string)reader["descrip_alergia"];
                cod1 = (int)reader["id_alergia"];
                alerg.primarykey.Text = cod1.ToString();

            }
            reader.Close();
            MyConn2.Close();
            alerg.Show();
        }

        // al presionar el formulario se refresca y llena el datagrid con los datos actualizados
        private void Vista_alergias_Click(object sender, EventArgs e)
        {
            llenarTablaM();
        }

        private void button4_Click(object sender, EventArgs e)
        { // cierra formulario
            this.Close();
        }

        private void navegador1_Load(object sender, EventArgs e)
        {

        }
    }
}
