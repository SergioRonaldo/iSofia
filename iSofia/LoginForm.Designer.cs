namespace iSofia
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label uSUARIOLabel;
            System.Windows.Forms.Label pASSWORDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.sofiaDataSet = new iSofia.SofiaDataSet();
            this.mAE_USUARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mAE_USUARIOSTableAdapter = new iSofia.SofiaDataSetTableAdapters.MAE_USUARIOSTableAdapter();
            this.tableAdapterManager = new iSofia.SofiaDataSetTableAdapters.TableAdapterManager();
            this.uSUARIOTextBox = new System.Windows.Forms.TextBox();
            this.pASSWORDTextBox = new System.Windows.Forms.TextBox();
            this.cANCELARbutton = new System.Windows.Forms.Button();
            this.iNGRESARbutton = new System.Windows.Forms.Button();
            this.iMAGENpictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pRINCIPALpanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            uSUARIOLabel = new System.Windows.Forms.Label();
            pASSWORDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sofiaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAE_USUARIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMAGENpictureBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.pRINCIPALpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sofiaDataSet
            // 
            this.sofiaDataSet.DataSetName = "SofiaDataSet";
            this.sofiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mAE_USUARIOSBindingSource
            // 
            this.mAE_USUARIOSBindingSource.DataMember = "MAE_USUARIOS";
            this.mAE_USUARIOSBindingSource.DataSource = this.sofiaDataSet;
            // 
            // mAE_USUARIOSTableAdapter
            // 
            this.mAE_USUARIOSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MAE_ALMACENESTableAdapter = null;
            this.tableAdapterManager.MAE_CLIENTESTableAdapter = null;
            this.tableAdapterManager.MAE_PRODUCTOSTableAdapter = null;
            this.tableAdapterManager.MAE_USUARIOSTableAdapter = this.mAE_USUARIOSTableAdapter;
            this.tableAdapterManager.SOFIA_DETALLE_FACTURATableAdapter = null;
            this.tableAdapterManager.SOFIA_ENTRADASTableAdapter = null;
            this.tableAdapterManager.SOFIA_FACTURASTableAdapter = null;
            this.tableAdapterManager.SOFIA_INVENTARIOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = iSofia.SofiaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // uSUARIOLabel
            // 
            uSUARIOLabel.AutoSize = true;
            uSUARIOLabel.Location = new System.Drawing.Point(59, 277);
            uSUARIOLabel.Name = "uSUARIOLabel";
            uSUARIOLabel.Size = new System.Drawing.Size(59, 13);
            uSUARIOLabel.TabIndex = 5;
            uSUARIOLabel.Text = "USUARIO:";
            // 
            // uSUARIOTextBox
            // 
            this.uSUARIOTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.uSUARIOTextBox.Location = new System.Drawing.Point(138, 274);
            this.uSUARIOTextBox.Name = "uSUARIOTextBox";
            this.uSUARIOTextBox.Size = new System.Drawing.Size(139, 20);
            this.uSUARIOTextBox.TabIndex = 6;
            // 
            // pASSWORDLabel
            // 
            pASSWORDLabel.AutoSize = true;
            pASSWORDLabel.Location = new System.Drawing.Point(59, 323);
            pASSWORDLabel.Name = "pASSWORDLabel";
            pASSWORDLabel.Size = new System.Drawing.Size(73, 13);
            pASSWORDLabel.TabIndex = 7;
            pASSWORDLabel.Text = "PASSWORD:";
            // 
            // pASSWORDTextBox
            // 
            this.pASSWORDTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.pASSWORDTextBox.Location = new System.Drawing.Point(138, 320);
            this.pASSWORDTextBox.Name = "pASSWORDTextBox";
            this.pASSWORDTextBox.Size = new System.Drawing.Size(139, 20);
            this.pASSWORDTextBox.TabIndex = 8;
            // 
            // cANCELARbutton
            // 
            this.cANCELARbutton.Location = new System.Drawing.Point(62, 371);
            this.cANCELARbutton.Name = "cANCELARbutton";
            this.cANCELARbutton.Size = new System.Drawing.Size(104, 32);
            this.cANCELARbutton.TabIndex = 9;
            this.cANCELARbutton.Text = "Cancelar";
            this.cANCELARbutton.UseVisualStyleBackColor = true;
            this.cANCELARbutton.Click += new System.EventHandler(this.cANCELARbutton_Click);
            // 
            // iNGRESARbutton
            // 
            this.iNGRESARbutton.Location = new System.Drawing.Point(173, 371);
            this.iNGRESARbutton.Name = "iNGRESARbutton";
            this.iNGRESARbutton.Size = new System.Drawing.Size(104, 32);
            this.iNGRESARbutton.TabIndex = 10;
            this.iNGRESARbutton.Text = "Iniciar";
            this.iNGRESARbutton.UseVisualStyleBackColor = true;
            // 
            // iMAGENpictureBox
            // 
            this.iMAGENpictureBox.Image = global::iSofia.Properties.Resources.login;
            this.iMAGENpictureBox.Location = new System.Drawing.Point(91, 56);
            this.iMAGENpictureBox.Name = "iMAGENpictureBox";
            this.iMAGENpictureBox.Size = new System.Drawing.Size(164, 195);
            this.iMAGENpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iMAGENpictureBox.TabIndex = 11;
            this.iMAGENpictureBox.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pRINCIPALpanel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(395, 458);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // pRINCIPALpanel
            // 
            this.pRINCIPALpanel.Controls.Add(this.label4);
            this.pRINCIPALpanel.Controls.Add(this.label3);
            this.pRINCIPALpanel.Controls.Add(this.cANCELARbutton);
            this.pRINCIPALpanel.Controls.Add(this.iMAGENpictureBox);
            this.pRINCIPALpanel.Controls.Add(this.pASSWORDTextBox);
            this.pRINCIPALpanel.Controls.Add(this.iNGRESARbutton);
            this.pRINCIPALpanel.Controls.Add(pASSWORDLabel);
            this.pRINCIPALpanel.Controls.Add(this.uSUARIOTextBox);
            this.pRINCIPALpanel.Controls.Add(uSUARIOLabel);
            this.pRINCIPALpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pRINCIPALpanel.Location = new System.Drawing.Point(23, 3);
            this.pRINCIPALpanel.Name = "pRINCIPALpanel";
            this.pRINCIPALpanel.Size = new System.Drawing.Size(349, 452);
            this.pRINCIPALpanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(378, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 458);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 458);
            this.label2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 33);
            this.label3.TabIndex = 12;
            this.label3.Text = "Sofia Software";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gabriola", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(296, 51);
            this.label4.TabIndex = 13;
            this.label4.Text = "Desarrollado por Sergio Cortina";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(395, 458);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sofiaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAE_USUARIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMAGENpictureBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pRINCIPALpanel.ResumeLayout(false);
            this.pRINCIPALpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SofiaDataSet sofiaDataSet;
        private System.Windows.Forms.BindingSource mAE_USUARIOSBindingSource;
        private SofiaDataSetTableAdapters.MAE_USUARIOSTableAdapter mAE_USUARIOSTableAdapter;
        private SofiaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox uSUARIOTextBox;
        private System.Windows.Forms.TextBox pASSWORDTextBox;
        private System.Windows.Forms.Button cANCELARbutton;
        private System.Windows.Forms.Button iNGRESARbutton;
        private System.Windows.Forms.PictureBox iMAGENpictureBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pRINCIPALpanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}