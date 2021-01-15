using System.Collections.Generic;
using System.Windows.Forms;

namespace ThomasGregTest
{
    public partial class AcmeForm 
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;     

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BTNIncluir = new System.Windows.Forms.Button();
            this.BTNExcluir = new System.Windows.Forms.Button();
            this.LBLData = new System.Windows.Forms.Label();
            this.LBLCusto = new System.Windows.Forms.Label();
            this.LBLDistancia = new System.Windows.Forms.Label();
            this.CHKCapturaSim = new System.Windows.Forms.CheckBox();
            this.LBLNivelDor = new System.Windows.Forms.Label();
            this.BTNSalvar = new System.Windows.Forms.Button();
            this.BTNCancelar = new System.Windows.Forms.Button();
            this.DBListView = new System.Windows.Forms.ListView();
            this.CLNMID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CLNMData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CLNMCaptura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CLNMNivelDor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHKCapturaNao = new System.Windows.Forms.CheckBox();
            this.LBLCaptura = new System.Windows.Forms.Label();
            this.NumNivelDor = new System.Windows.Forms.NumericUpDown();
            this.DTPData = new System.Windows.Forms.DateTimePicker();
            this.NumCusto = new System.Windows.Forms.NumericUpDown();
            this.NUMDistancia = new System.Windows.Forms.NumericUpDown();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.NumNivelDor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCusto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUMDistancia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNIncluir
            // 
            this.BTNIncluir.Location = new System.Drawing.Point(600, 48);
            this.BTNIncluir.Name = "BTNIncluir";
            this.BTNIncluir.Size = new System.Drawing.Size(75, 23);
            this.BTNIncluir.TabIndex = 0;
            this.BTNIncluir.Text = "Incluir";
            this.BTNIncluir.UseVisualStyleBackColor = true;
            this.BTNIncluir.Click += new System.EventHandler(this.Incluir_Click);
            // 
            // BTNExcluir
            // 
            this.BTNExcluir.Location = new System.Drawing.Point(701, 48);
            this.BTNExcluir.Name = "BTNExcluir";
            this.BTNExcluir.Size = new System.Drawing.Size(75, 23);
            this.BTNExcluir.TabIndex = 1;
            this.BTNExcluir.Text = "Excluir";
            this.BTNExcluir.UseVisualStyleBackColor = true;
            this.BTNExcluir.Click += new System.EventHandler( this.Excluir_Click );
            // 
            // LBLData
            // 
            this.LBLData.AutoSize = true;
            this.LBLData.Location = new System.Drawing.Point(545, 93);
            this.LBLData.Name = "LBLData";
            this.LBLData.Size = new System.Drawing.Size(36, 13);
            this.LBLData.TabIndex = 3;
            this.LBLData.Text = "Data: ";
            // 
            // LBLCusto
            // 
            this.LBLCusto.AutoSize = true;
            this.LBLCusto.Location = new System.Drawing.Point(545, 120);
            this.LBLCusto.Name = "LBLCusto";
            this.LBLCusto.Size = new System.Drawing.Size(37, 13);
            this.LBLCusto.TabIndex = 7;
            this.LBLCusto.Text = "Custo:";
            // 
            // LBLDistancia
            // 
            this.LBLDistancia.AutoSize = true;
            this.LBLDistancia.Location = new System.Drawing.Point(545, 147);
            this.LBLDistancia.Name = "LBLDistancia";
            this.LBLDistancia.Size = new System.Drawing.Size(54, 13);
            this.LBLDistancia.TabIndex = 8;
            this.LBLDistancia.Text = "Distancia:";
            // 
            // CHKCapturaSim
            // 
            this.CHKCapturaSim.AutoSize = true;
            this.CHKCapturaSim.Checked = true;
            this.CHKCapturaSim.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CHKCapturaSim.Location = new System.Drawing.Point(600, 176);
            this.CHKCapturaSim.Name = "CHKCapturaSim";
            this.CHKCapturaSim.Size = new System.Drawing.Size(43, 17);
            this.CHKCapturaSim.TabIndex = 9;
            this.CHKCapturaSim.Text = "Sim";
            this.CHKCapturaSim.UseVisualStyleBackColor = true;
            // 
            // LBLNivelDor
            // 
            this.LBLNivelDor.AutoSize = true;
            this.LBLNivelDor.Location = new System.Drawing.Point(545, 202);
            this.LBLNivelDor.Name = "LBLNivelDor";
            this.LBLNivelDor.Size = new System.Drawing.Size(52, 13);
            this.LBLNivelDor.TabIndex = 10;
            this.LBLNivelDor.Text = "Nivel dor:";
            // 
            // BTNSalvar
            // 
            this.BTNSalvar.Location = new System.Drawing.Point(600, 251);
            this.BTNSalvar.Name = "BTNSalvar";
            this.BTNSalvar.Size = new System.Drawing.Size(75, 23);
            this.BTNSalvar.TabIndex = 11;
            this.BTNSalvar.Text = "Salvar";
            this.BTNSalvar.UseVisualStyleBackColor = true;
            this.BTNSalvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // BTNCancelar
            // 
            this.BTNCancelar.Location = new System.Drawing.Point(701, 251);
            this.BTNCancelar.Name = "BTNCancelar";
            this.BTNCancelar.Size = new System.Drawing.Size(75, 23);
            this.BTNCancelar.TabIndex = 12;
            this.BTNCancelar.Text = "Cancelar";
            this.BTNCancelar.UseVisualStyleBackColor = true;
            this.BTNCancelar.Click += new System.EventHandler( this.Cancelar_Click );
            // 
            // DBListView
            // 
            this.DBListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CLNMID,
            this.CLNMData,
            this.CLNMCaptura,
            this.CLNMNivelDor});
            this.DBListView.FullRowSelect = true;
            this.DBListView.HideSelection = false;
            this.DBListView.Location = new System.Drawing.Point(12, 12);
            this.DBListView.Name = "DBListView";
            this.DBListView.Size = new System.Drawing.Size(450, 280);
            this.DBListView.TabIndex = 13;
            this.DBListView.UseCompatibleStateImageBehavior = false;
            this.DBListView.View = System.Windows.Forms.View.Details;
            this.DBListView.SelectedIndexChanged += new System.EventHandler(this.SelectListViewItem );
            // 
            // CLNMID
            // 
            this.CLNMID.Text = "ID";
            // 
            // CLNMData
            // 
            this.CLNMData.Text = "Data";
            // 
            // CLNMCaptura
            // 
            this.CLNMCaptura.Text = "Captura";
            // 
            // CLNMNivelDor
            // 
            this.CLNMNivelDor.Text = "Nivel Dor";
            // 
            // CHKCapturaNao
            // 
            this.CHKCapturaNao.AutoSize = true;
            this.CHKCapturaNao.Location = new System.Drawing.Point(701, 176);
            this.CHKCapturaNao.Name = "CHKCapturaNao";
            this.CHKCapturaNao.Size = new System.Drawing.Size(46, 17);
            this.CHKCapturaNao.TabIndex = 14;
            this.CHKCapturaNao.Text = "Nao";
            this.CHKCapturaNao.UseVisualStyleBackColor = true;
            // 
            // LBLCaptura
            // 
            this.LBLCaptura.AutoSize = true;
            this.LBLCaptura.Location = new System.Drawing.Point(548, 176);
            this.LBLCaptura.Name = "LBLCaptura";
            this.LBLCaptura.Size = new System.Drawing.Size(47, 13);
            this.LBLCaptura.TabIndex = 15;
            this.LBLCaptura.Text = "Captura:";
            // 
            // NumNivelDor
            // 
            this.NumNivelDor.Location = new System.Drawing.Point(600, 202);
            this.NumNivelDor.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumNivelDor.Name = "NumNivelDor";
            this.NumNivelDor.Size = new System.Drawing.Size(176, 20);
            this.NumNivelDor.TabIndex = 16;
            // 
            // DTPData
            // 
            this.DTPData.Location = new System.Drawing.Point(600, 91);
            this.DTPData.Name = "DTPData";
            this.DTPData.Size = new System.Drawing.Size(176, 20);
            this.DTPData.TabIndex = 17;
            // 
            // NumCusto
            // 
            this.NumCusto.Location = new System.Drawing.Point(600, 118);
            this.NumCusto.Name = "NumCusto";
            this.NumCusto.Size = new System.Drawing.Size(176, 20);
            this.NumCusto.TabIndex = 18;
            // 
            // NUMDistancia
            // 
            this.NUMDistancia.Location = new System.Drawing.Point(600, 147);
            this.NUMDistancia.Name = "NUMDistancia";
            this.NUMDistancia.Size = new System.Drawing.Size(176, 20);
            this.NUMDistancia.TabIndex = 19;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // AcmeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 304);
            this.Controls.Add(this.NUMDistancia);
            this.Controls.Add(this.NumCusto);
            this.Controls.Add(this.DTPData);
            this.Controls.Add(this.NumNivelDor);
            this.Controls.Add(this.LBLCaptura);
            this.Controls.Add(this.CHKCapturaNao);
            this.Controls.Add(this.DBListView);
            this.Controls.Add(this.BTNCancelar);
            this.Controls.Add(this.BTNSalvar);
            this.Controls.Add(this.LBLNivelDor);
            this.Controls.Add(this.CHKCapturaSim);
            this.Controls.Add(this.LBLDistancia);
            this.Controls.Add(this.LBLCusto);
            this.Controls.Add(this.LBLData);
            this.Controls.Add(this.BTNExcluir);
            this.Controls.Add(this.BTNIncluir);
            this.Name = "AcmeForm";
            this.Text = "ACME Flight Manager";
            ((System.ComponentModel.ISupportInitialize)(this.NumNivelDor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCusto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUMDistancia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNIncluir;
        private System.Windows.Forms.Button BTNExcluir;
        private System.Windows.Forms.Label LBLData;
        private System.Windows.Forms.Label LBLCusto;
        private System.Windows.Forms.Label LBLDistancia;
        private System.Windows.Forms.CheckBox CHKCapturaSim;
        private System.Windows.Forms.Label LBLNivelDor;
        private System.Windows.Forms.Button BTNSalvar;
        private System.Windows.Forms.Button BTNCancelar;
        private System.Windows.Forms.ListView DBListView;
        private System.Windows.Forms.ColumnHeader CLNMData;
        private System.Windows.Forms.ColumnHeader CLNMCaptura;
        private System.Windows.Forms.ColumnHeader CLNMNivelDor;
        private CheckBox CHKCapturaNao;
        private Label LBLCaptura;
        private ColumnHeader CLNMID;
        private NumericUpDown NumNivelDor;
        private DateTimePicker DTPData;
        private NumericUpDown NumCusto;
        private NumericUpDown NUMDistancia;
        private ContextMenuStrip contextMenuStrip1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

