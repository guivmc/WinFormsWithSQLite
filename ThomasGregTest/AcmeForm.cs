using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThomasGregTest
{
    public partial class AcmeForm : Form
    {
        private int IdSelected { get; set; }

        public AcmeForm()
        {
            this.InitializeComponent();

            this.InitDBConnection();

            this.LoadItemsToListView();
        }

        /// <summary>
        /// Load DB data into the list view.
        /// </summary>
        /// <returns>True if success, false if not.</returns>
        private bool LoadItemsToListView()
        {
            try
            {
                this.DBListView.Items.Clear();

                SQLiteConnection conn = new SQLiteConnection( "Data Source=acme.sqlite" );
                conn.Open();

                SQLiteCommand cmd = conn.CreateCommand();

                cmd.CommandText = "SELECT ID_VOO, DATA_VOO, CHAR(CAPTURA), NIVEL_DOR FROM TB_VOO";

                using( SQLiteDataReader reader = cmd.ExecuteReader() )
                {
                    while( reader.Read() )
                    {
                        this.AddToListView( reader[0].ToString(), DateTime.Parse( reader[1].ToString() ).ToString(), reader[2].ToString(), reader[3].ToString() );
                    }
                }

                conn.Close();
                return true;
            }
            catch( Exception e )
            {
                Console.WriteLine( e.Message );
                return false;
            }
        }

        /// <summary>
        /// Initialize a connection with the DB.
        /// </summary>
        /// <returns>The DB connection.</returns>
        private SQLiteConnection InitDBConnection()
        {
            if( File.Exists( "acme.sqlite" ) )
            {
                return new SQLiteConnection( "Data Source=acme.sqlite" );
            }
            else
            {
                if( this.CretaAcmeDB() )
                    return new SQLiteConnection( "Data Source=acme.sqlite" );
                else
                    return null;
            }
        }

        /// <summary>
        /// Creates a sqlite file with the TB_VOO table.
        /// </summary>
        /// <returns>True if success, false if not.</returns>
        private bool CretaAcmeDB()
        {
            try
            {
                SQLiteConnection.CreateFile( "acme.sqlite" );

                SQLiteConnection myConnection = new SQLiteConnection( "Data Source=acme.sqlite" );

                myConnection.Open();

                string createDb = "CREATE TABLE TB_VOO ( ID_VOO INT, DATA_VOO TEXT, CUSTO DECIMAL(10, 5), DISTANCIA INT, CAPTURA INT, NIVEL_DOR INT )";

                SQLiteCommand command = new SQLiteCommand( createDb, myConnection );

                command.ExecuteNonQuery();

                myConnection.Close();

                return true;
            }
            catch( Exception e )
            {
                Console.WriteLine( e.Message );

                return false;
            }
        }

        /// <summary>
        /// Add one item into the list view display.
        /// </summary>
        /// <param name="id">TB_VOO id.</param>
        /// <param name="data">TB_VOO data.</param>
        /// <param name="captura">TB_VOO captura.</param>
        /// <param name="niveldor">TB_VOO niveldor.</param>
        private void AddToListView( string id, string data, string captura, string niveldor )
        {
            string[] row = { id, data, captura, niveldor };

            ListViewItem item = new ListViewItem( row );

            this.DBListView.Items.Add( item );
        }         

        private void Incluir_Click( object sender, EventArgs e )
        {         
            this.DTPData.Text = "";
            this.NumNivelDor.Value = 0;
            this.NumCusto.Value = 0;
            this.NUMDistancia.Value = 0;
            this.CHKCapturaSim.Checked = false;
            this.CHKCapturaNao.Checked = false;
        }

        private void Salvar_Click( object sender, EventArgs e )
        {
            char captura = 'N';

            if( this.CHKCapturaSim.Checked )
                captura = 'S';
            else if( this.CHKCapturaNao.Checked )
                captura = 'N';

            decimal custo = this.NumCusto.Value;
            int distancia = (int)this.NUMDistancia.Value;
            int nivelDor = (int)this.NumNivelDor.Value;
            string data = this.DTPData.Text;

            SQLiteConnection conn = new SQLiteConnection( "Data Source=acme.sqlite" );
            conn.Open();

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "INSERT INTO TB_VOO ( ID_VOO, DATA_VOO, CAPTURA, NIVEL_DOR, CUSTO, DISTANCIA ) VALUES ( ?, ?, ? , ?, ?, ?)";
            cmd.Parameters.Add( new SQLiteParameter { Value = new Random().Next( 1, int.MaxValue ) } );
            cmd.Parameters.Add(new SQLiteParameter { Value = data } );
            cmd.Parameters.Add(new SQLiteParameter { Value = (int)captura } );
            cmd.Parameters.Add(new SQLiteParameter { Value = nivelDor } );
            cmd.Parameters.Add(new SQLiteParameter { Value = custo } );
            cmd.Parameters.Add( new SQLiteParameter { Value = distancia } );

            cmd.ExecuteNonQuery();

            conn.Close();

            this.BTNSalvar.Enabled = false;
            this.BTNSalvar.Enabled = false;
            this.LoadItemsToListView();
        }

        private void SelectListViewItem( object sender, EventArgs e )
        {
           this.IdSelected = int.Parse( this.DBListView.SelectedItems[0].SubItems[0].Text);

            SQLiteConnection conn = new SQLiteConnection( "Data Source=acme.sqlite" );
            conn.Open();

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT ID_VOO, DATA_VOO, CHAR(CAPTURA), NIVEL_DOR, CUSTO, DISTANCIA FROM TB_VOO WHERE ID_VOO = ?";
            cmd.Parameters.Add( new SQLiteParameter { Value = this.IdSelected } );

            using( SQLiteDataReader reader = cmd.ExecuteReader() )
            {
                while( reader.Read() )
                {                                                     
                    this.DTPData.Text = reader[1].ToString();

                    if( reader[2].ToString()[0] == 'S' )
                        this.CHKCapturaSim.Checked = true;
                    else if( reader[2].ToString()[0] == 'N' )
                        this.CHKCapturaNao.Checked = true;

                    this.NumNivelDor.Value = Convert.ToDecimal( reader[3]);
                    this.NumCusto.Value = Convert.ToDecimal( reader[4]);
                    this.NUMDistancia.Value = Convert.ToDecimal( reader[5]);
                }
            }

            conn.Close();

            this.BTNSalvar.Enabled = true;
            this.BTNSalvar.Enabled = true;
        }

        private void Cancelar_Click( object sender, EventArgs e )
        {
            this.BTNSalvar.Enabled = false;
            this.BTNSalvar.Enabled = false;
            this.LoadItemsToListView();
        }

        private void Excluir_Click( object sender, EventArgs e )
        {
            SQLiteConnection conn = new SQLiteConnection( "Data Source=acme.sqlite" );
            conn.Open();

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "DELETE FROM TB_VOO WHERE ID_VOO = ?";
            cmd.Parameters.Add( new SQLiteParameter { Value = this.IdSelected } );

            cmd.ExecuteNonQuery();

            conn.Close();

            this.LoadItemsToListView();
        }
    }
}
