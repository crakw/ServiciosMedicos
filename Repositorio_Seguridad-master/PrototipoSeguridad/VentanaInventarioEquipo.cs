﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.Odbc;

namespace PrototipoSeguridad
{
    public partial class VentanaInventarioEquipo : Form
    {
        Conexion con = new Conexion();
        OdbcCommand com;
        OdbcDataAdapter da;
        DataTable dt;
        OdbcDataReader dr;
        public VentanaInventarioEquipo()
        {
            InitializeComponent();
            
        }

     

        private void VentanaInventarioEquipo_Load(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "Driver ={ MySQL ODBC 3.51 Driver}; Dsn=servidor_seguridad; UID=root; PWD=;";
                string Query = "select * from invequipo ;";
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

        public struct tipoRegistro
        {
            public int no;
            public string DATO;
            public string COLUMNA;


        }
        List<tipoRegistro> listado = new List<tipoRegistro>();

        //numero registro  
        int id = 0;
        int id2 = 0;
        //numero de accion buttom
        int caseSwitch = 0;

        private void navegador1_NavInsertar(object sender, EventArgs e)
        {
            caseSwitch = 1;
        }

        private void navegador1_NavActualizar(object sender, EventArgs e)
        {
            caseSwitch = 2;
        }

        private void navegador1_NavGuardar(object sender, EventArgs e)
        {

            switch (caseSwitch)
            {
                case 1:

                    Navegador.INSERCION obj = new Navegador.INSERCION();
                    foreach (Control _textbox in this.Controls)
                    {
                        if (_textbox is TextBox && _textbox.Text != string.Empty)
                        {


                            obj.CREANDOSQL(_textbox.Tag.ToString());
                        }
                        if (_textbox is ComboBox && _textbox.Text != string.Empty)
                        {


                            obj.CREANDOSQL(_textbox.Tag.ToString());
                        }


                    }
                    obj.value();
                    id++;
                    foreach (Control _textbox in this.Controls)
                    {
                        if (_textbox is TextBox && _textbox.Text != string.Empty)
                        {



                            listado.Add(new tipoRegistro { no = id, DATO = _textbox.Text, COLUMNA = _textbox.Tag.ToString() });





                            obj.CREANDOSQL2(_textbox.Text);
                        }
                        if (_textbox is ComboBox && _textbox.Text != string.Empty)
                        {

                            listado.Add(new tipoRegistro { no = id, DATO = _textbox.Text, COLUMNA = _textbox.Tag.ToString() });




                            obj.CREANDOSQL2(_textbox.Text);
                        }

                        id2 = id;
                    }
                    obj.coma();
                    break;
                case 2:
                    Navegador.ACTUALIZAR obj2 = new Navegador.ACTUALIZAR();
                    foreach (Control _textbox in this.Controls)
                    {
                        if (_textbox is TextBox && _textbox.Name == "primarykey")
                        {


                            obj2.COMPARACION(_textbox.Text, _textbox.Tag.ToString());
                        }
                        else if (_textbox is TextBox && _textbox.Name != string.Empty)
                        { obj2.CREANDOSQL(_textbox.Text, _textbox.Tag.ToString()); }

                        if (_textbox is ComboBox && _textbox.Name == "primarykey")
                        {


                            obj2.COMPARACION(_textbox.Text, _textbox.Tag.ToString());
                        }
                        else if (_textbox is ComboBox && _textbox.Name != string.Empty)
                        { obj2.CREANDOSQL(_textbox.Text, _textbox.Tag.ToString()); }

                    }
                    obj2.coma();
                    obj2.finalizarsql();

                    break;



                case 3:
                    Navegador.ELIMINAR obj3 = new Navegador.ELIMINAR();
                    foreach (Control _textbox in this.Controls)
                    {
                        if (_textbox is TextBox && _textbox.Name == "primarykey")
                        {


                            obj3.finalizarsql(_textbox.Text, _textbox.Tag.ToString());
                        }


                        if (_textbox is ComboBox && _textbox.Name == "primarykey")
                        {

                            obj3.finalizarsql(_textbox.Text, _textbox.Tag.ToString());
                        }


                    }

                    break;
            }
        }

        private void navegador1_NavEliminar(object sender, EventArgs e)
        {
            caseSwitch = 3;

        }


        private void Form1_Load(object sender, EventArgs e)
        {




        }

        private void navegador1_NavSalir(object sender, EventArgs e)
        {
            this.Close();
        }

        private void navegador1_NavAnterior(object sender, EventArgs e)
        {
            id2--;

            foreach (Control _textbox in this.Controls)
            {
                if (_textbox is TextBox && _textbox.Text != string.Empty)
                {

                    _textbox.Text = listado.Where(a => a.no == id2 && a.COLUMNA == _textbox.Tag.ToString()).FirstOrDefault().DATO;




                }
                if (_textbox is ComboBox && _textbox.Text != string.Empty)
                    _textbox.Text = listado.Where(a => a.no == id2 && a.COLUMNA == _textbox.Tag.ToString()).FirstOrDefault().DATO;




            }
        }

        private void navegador1_NavSiguiente(object sender, EventArgs e)
        {
            id2++;
            foreach (Control _textbox in this.Controls)
            {
                if (_textbox is TextBox && _textbox.Text != string.Empty)
                {

                    _textbox.Text = listado.Where(a => a.no == id2 && a.COLUMNA == _textbox.Tag.ToString()).FirstOrDefault().DATO;




                }
                if (_textbox is ComboBox && _textbox.Text != string.Empty)
                    _textbox.Text = listado.Where(a => a.no == id2 && a.COLUMNA == _textbox.Tag.ToString()).FirstOrDefault().DATO;




            }
        }

        private void navegador1_NavInicio(object sender, EventArgs e)
        {

            foreach (Control _textbox in this.Controls)
            {
                if (_textbox is TextBox && _textbox.Text != string.Empty)
                {

                    _textbox.Text = listado.Where(a => a.no == 1 && a.COLUMNA == _textbox.Tag.ToString()).FirstOrDefault().DATO;




                }
                if (_textbox is ComboBox && _textbox.Text != string.Empty)
                    _textbox.Text = listado.Where(a => a.no == 1 && a.COLUMNA == _textbox.Tag.ToString()).FirstOrDefault().DATO;




            }
        }

        private void navegador1_NavFin(object sender, EventArgs e)
        {
            foreach (Control _textbox in this.Controls)
            {
                if (_textbox is TextBox && _textbox.Text != string.Empty)
                {

                    _textbox.Text = listado.Where(a => a.no == id && a.COLUMNA == _textbox.Tag.ToString()).FirstOrDefault().DATO;




                }
                if (_textbox is ComboBox && _textbox.Text != string.Empty)
                    _textbox.Text = listado.Where(a => a.no == id && a.COLUMNA == _textbox.Tag.ToString()).FirstOrDefault().DATO;




            }
        }
    }
}

    
