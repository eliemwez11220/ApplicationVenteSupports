namespace VenteSupports
{
    partial class ListingEnseignants
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
            System.Windows.Forms.Label matriculeEnseignantLabel;
            System.Windows.Forms.Label nomCompletLabel;
            System.Windows.Forms.Label gradeEnseignantLabel;
            System.Windows.Forms.Label fonctionEnseignantLabel;
            System.Windows.Forms.Label numeroTelephoneLabel;
            System.Windows.Forms.Label adresseMaisonLabel;
            System.Windows.Forms.Label adresseBureauLabel;
            System.Windows.Forms.Label departementIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListingEnseignants));
            this.iss_vente_supportsDataSet = new VenteSupports.iss_vente_supportsDataSet();
            this.tb_enseignantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_enseignantsTableAdapter = new VenteSupports.iss_vente_supportsDataSetTableAdapters.tb_enseignantsTableAdapter();
            this.tableAdapterManager = new VenteSupports.iss_vente_supportsDataSetTableAdapters.TableAdapterManager();
            this.tb_enseignantsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tb_enseignantsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matriculeEnseignantTextBox = new System.Windows.Forms.TextBox();
            this.nomCompletTextBox = new System.Windows.Forms.TextBox();
            this.gradeEnseignantTextBox = new System.Windows.Forms.TextBox();
            this.fonctionEnseignantTextBox = new System.Windows.Forms.TextBox();
            this.numeroTelephoneTextBox = new System.Windows.Forms.TextBox();
            this.adresseMaisonTextBox = new System.Windows.Forms.TextBox();
            this.adresseBureauTextBox = new System.Windows.Forms.TextBox();
            this.departementIDComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            matriculeEnseignantLabel = new System.Windows.Forms.Label();
            nomCompletLabel = new System.Windows.Forms.Label();
            gradeEnseignantLabel = new System.Windows.Forms.Label();
            fonctionEnseignantLabel = new System.Windows.Forms.Label();
            numeroTelephoneLabel = new System.Windows.Forms.Label();
            adresseMaisonLabel = new System.Windows.Forms.Label();
            adresseBureauLabel = new System.Windows.Forms.Label();
            departementIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iss_vente_supportsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_enseignantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_enseignantsBindingNavigator)).BeginInit();
            this.tb_enseignantsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_enseignantsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // matriculeEnseignantLabel
            // 
            matriculeEnseignantLabel.AutoSize = true;
            matriculeEnseignantLabel.Location = new System.Drawing.Point(27, 46);
            matriculeEnseignantLabel.Name = "matriculeEnseignantLabel";
            matriculeEnseignantLabel.Size = new System.Drawing.Size(165, 21);
            matriculeEnseignantLabel.TabIndex = 2;
            matriculeEnseignantLabel.Text = "matricule Enseignant:";
            // 
            // nomCompletLabel
            // 
            nomCompletLabel.AutoSize = true;
            nomCompletLabel.Location = new System.Drawing.Point(27, 81);
            nomCompletLabel.Name = "nomCompletLabel";
            nomCompletLabel.Size = new System.Drawing.Size(114, 21);
            nomCompletLabel.TabIndex = 4;
            nomCompletLabel.Text = "nom Complet:";
            // 
            // gradeEnseignantLabel
            // 
            gradeEnseignantLabel.AutoSize = true;
            gradeEnseignantLabel.Location = new System.Drawing.Point(27, 116);
            gradeEnseignantLabel.Name = "gradeEnseignantLabel";
            gradeEnseignantLabel.Size = new System.Drawing.Size(140, 21);
            gradeEnseignantLabel.TabIndex = 6;
            gradeEnseignantLabel.Text = "grade Enseignant:";
            // 
            // fonctionEnseignantLabel
            // 
            fonctionEnseignantLabel.AutoSize = true;
            fonctionEnseignantLabel.Location = new System.Drawing.Point(27, 151);
            fonctionEnseignantLabel.Name = "fonctionEnseignantLabel";
            fonctionEnseignantLabel.Size = new System.Drawing.Size(159, 21);
            fonctionEnseignantLabel.TabIndex = 8;
            fonctionEnseignantLabel.Text = "fonction Enseignant:";
            // 
            // numeroTelephoneLabel
            // 
            numeroTelephoneLabel.AutoSize = true;
            numeroTelephoneLabel.Location = new System.Drawing.Point(508, 49);
            numeroTelephoneLabel.Name = "numeroTelephoneLabel";
            numeroTelephoneLabel.Size = new System.Drawing.Size(151, 21);
            numeroTelephoneLabel.TabIndex = 10;
            numeroTelephoneLabel.Text = "numero Telephone:";
            // 
            // adresseMaisonLabel
            // 
            adresseMaisonLabel.AutoSize = true;
            adresseMaisonLabel.Location = new System.Drawing.Point(508, 84);
            adresseMaisonLabel.Name = "adresseMaisonLabel";
            adresseMaisonLabel.Size = new System.Drawing.Size(127, 21);
            adresseMaisonLabel.TabIndex = 12;
            adresseMaisonLabel.Text = "adresse Maison:";
            // 
            // adresseBureauLabel
            // 
            adresseBureauLabel.AutoSize = true;
            adresseBureauLabel.Location = new System.Drawing.Point(508, 119);
            adresseBureauLabel.Name = "adresseBureauLabel";
            adresseBureauLabel.Size = new System.Drawing.Size(125, 21);
            adresseBureauLabel.TabIndex = 14;
            adresseBureauLabel.Text = "adresse Bureau:";
            // 
            // departementIDLabel
            // 
            departementIDLabel.AutoSize = true;
            departementIDLabel.Location = new System.Drawing.Point(508, 154);
            departementIDLabel.Name = "departementIDLabel";
            departementIDLabel.Size = new System.Drawing.Size(130, 21);
            departementIDLabel.TabIndex = 16;
            departementIDLabel.Text = "departement ID:";
            // 
            // iss_vente_supportsDataSet
            // 
            this.iss_vente_supportsDataSet.DataSetName = "iss_vente_supportsDataSet";
            this.iss_vente_supportsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_enseignantsBindingSource
            // 
            this.tb_enseignantsBindingSource.DataMember = "tb_enseignants";
            this.tb_enseignantsBindingSource.DataSource = this.iss_vente_supportsDataSet;
            // 
            // tb_enseignantsTableAdapter
            // 
            this.tb_enseignantsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_enseignantsTableAdapter = this.tb_enseignantsTableAdapter;
            this.tableAdapterManager.tb_supportsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = VenteSupports.iss_vente_supportsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tb_enseignantsBindingNavigator
            // 
            this.tb_enseignantsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tb_enseignantsBindingNavigator.BindingSource = this.tb_enseignantsBindingSource;
            this.tb_enseignantsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tb_enseignantsBindingNavigator.DeleteItem = null;
            this.tb_enseignantsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem});
            this.tb_enseignantsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tb_enseignantsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tb_enseignantsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tb_enseignantsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tb_enseignantsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tb_enseignantsBindingNavigator.Name = "tb_enseignantsBindingNavigator";
            this.tb_enseignantsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tb_enseignantsBindingNavigator.Size = new System.Drawing.Size(979, 25);
            this.tb_enseignantsBindingNavigator.TabIndex = 0;
            this.tb_enseignantsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(166, 22);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouvel enseignant";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(68, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(80, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Precedent";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(66, 22);
            this.bindingNavigatorMoveNextItem.Text = "Suivant";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(65, 22);
            this.bindingNavigatorMoveLastItem.Text = "Dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tb_enseignantsDataGridView
            // 
            this.tb_enseignantsDataGridView.AutoGenerateColumns = false;
            this.tb_enseignantsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tb_enseignantsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tb_enseignantsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_enseignantsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.tb_enseignantsDataGridView.DataSource = this.tb_enseignantsBindingSource;
            this.tb_enseignantsDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tb_enseignantsDataGridView.Location = new System.Drawing.Point(0, 235);
            this.tb_enseignantsDataGridView.Name = "tb_enseignantsDataGridView";
            this.tb_enseignantsDataGridView.Size = new System.Drawing.Size(979, 220);
            this.tb_enseignantsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "matriculeEnseignant";
            this.dataGridViewTextBoxColumn1.HeaderText = "matriculeEnseignant";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nomComplet";
            this.dataGridViewTextBoxColumn2.HeaderText = "nomComplet";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "gradeEnseignant";
            this.dataGridViewTextBoxColumn3.HeaderText = "gradeEnseignant";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "fonctionEnseignant";
            this.dataGridViewTextBoxColumn4.HeaderText = "fonctionEnseignant";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "numeroTelephone";
            this.dataGridViewTextBoxColumn5.HeaderText = "numeroTelephone";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "adresseMaison";
            this.dataGridViewTextBoxColumn6.HeaderText = "adresseMaison";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "adresseBureau";
            this.dataGridViewTextBoxColumn7.HeaderText = "adresseBureau";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "departementID";
            this.dataGridViewTextBoxColumn8.HeaderText = "departementID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // matriculeEnseignantTextBox
            // 
            this.matriculeEnseignantTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_enseignantsBindingSource, "matriculeEnseignant", true));
            this.matriculeEnseignantTextBox.Location = new System.Drawing.Point(198, 43);
            this.matriculeEnseignantTextBox.Name = "matriculeEnseignantTextBox";
            this.matriculeEnseignantTextBox.Size = new System.Drawing.Size(288, 29);
            this.matriculeEnseignantTextBox.TabIndex = 3;
            // 
            // nomCompletTextBox
            // 
            this.nomCompletTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_enseignantsBindingSource, "nomComplet", true));
            this.nomCompletTextBox.Location = new System.Drawing.Point(198, 78);
            this.nomCompletTextBox.Name = "nomCompletTextBox";
            this.nomCompletTextBox.Size = new System.Drawing.Size(288, 29);
            this.nomCompletTextBox.TabIndex = 5;
            // 
            // gradeEnseignantTextBox
            // 
            this.gradeEnseignantTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_enseignantsBindingSource, "gradeEnseignant", true));
            this.gradeEnseignantTextBox.Location = new System.Drawing.Point(198, 113);
            this.gradeEnseignantTextBox.Name = "gradeEnseignantTextBox";
            this.gradeEnseignantTextBox.Size = new System.Drawing.Size(288, 29);
            this.gradeEnseignantTextBox.TabIndex = 7;
            // 
            // fonctionEnseignantTextBox
            // 
            this.fonctionEnseignantTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_enseignantsBindingSource, "fonctionEnseignant", true));
            this.fonctionEnseignantTextBox.Location = new System.Drawing.Point(198, 148);
            this.fonctionEnseignantTextBox.Name = "fonctionEnseignantTextBox";
            this.fonctionEnseignantTextBox.Size = new System.Drawing.Size(288, 29);
            this.fonctionEnseignantTextBox.TabIndex = 9;
            // 
            // numeroTelephoneTextBox
            // 
            this.numeroTelephoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_enseignantsBindingSource, "numeroTelephone", true));
            this.numeroTelephoneTextBox.Location = new System.Drawing.Point(679, 46);
            this.numeroTelephoneTextBox.Name = "numeroTelephoneTextBox";
            this.numeroTelephoneTextBox.Size = new System.Drawing.Size(288, 29);
            this.numeroTelephoneTextBox.TabIndex = 11;
            // 
            // adresseMaisonTextBox
            // 
            this.adresseMaisonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_enseignantsBindingSource, "adresseMaison", true));
            this.adresseMaisonTextBox.Location = new System.Drawing.Point(679, 81);
            this.adresseMaisonTextBox.Name = "adresseMaisonTextBox";
            this.adresseMaisonTextBox.Size = new System.Drawing.Size(288, 29);
            this.adresseMaisonTextBox.TabIndex = 13;
            // 
            // adresseBureauTextBox
            // 
            this.adresseBureauTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_enseignantsBindingSource, "adresseBureau", true));
            this.adresseBureauTextBox.Location = new System.Drawing.Point(679, 116);
            this.adresseBureauTextBox.Name = "adresseBureauTextBox";
            this.adresseBureauTextBox.Size = new System.Drawing.Size(288, 29);
            this.adresseBureauTextBox.TabIndex = 15;
            // 
            // departementIDComboBox
            // 
            this.departementIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_enseignantsBindingSource, "departementID", true));
            this.departementIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departementIDComboBox.FormattingEnabled = true;
            this.departementIDComboBox.Items.AddRange(new object[] {
            "INFORMATIQUE ",
            "COMPTABILITE & FINANCE",
            "DEMOGRAPHIE",
            "MATHEMATIQUE DE GESTION"});
            this.departementIDComboBox.Location = new System.Drawing.Point(679, 151);
            this.departementIDComboBox.Name = "departementIDComboBox";
            this.departementIDComboBox.Size = new System.Drawing.Size(288, 29);
            this.departementIDComboBox.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(512, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 39);
            this.button1.TabIndex = 28;
            this.button1.Text = "Enregistrer  enseignant";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(707, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(260, 39);
            this.button2.TabIndex = 30;
            this.button2.Text = "Modifier enseignant";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ListingEnseignants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(979, 455);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(matriculeEnseignantLabel);
            this.Controls.Add(this.matriculeEnseignantTextBox);
            this.Controls.Add(nomCompletLabel);
            this.Controls.Add(this.nomCompletTextBox);
            this.Controls.Add(gradeEnseignantLabel);
            this.Controls.Add(this.gradeEnseignantTextBox);
            this.Controls.Add(fonctionEnseignantLabel);
            this.Controls.Add(this.fonctionEnseignantTextBox);
            this.Controls.Add(numeroTelephoneLabel);
            this.Controls.Add(this.numeroTelephoneTextBox);
            this.Controls.Add(adresseMaisonLabel);
            this.Controls.Add(this.adresseMaisonTextBox);
            this.Controls.Add(adresseBureauLabel);
            this.Controls.Add(this.adresseBureauTextBox);
            this.Controls.Add(departementIDLabel);
            this.Controls.Add(this.departementIDComboBox);
            this.Controls.Add(this.tb_enseignantsDataGridView);
            this.Controls.Add(this.tb_enseignantsBindingNavigator);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ListingEnseignants";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListingEnseignants";
            this.Load += new System.EventHandler(this.ListingEnseignants_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iss_vente_supportsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_enseignantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_enseignantsBindingNavigator)).EndInit();
            this.tb_enseignantsBindingNavigator.ResumeLayout(false);
            this.tb_enseignantsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_enseignantsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private iss_vente_supportsDataSet iss_vente_supportsDataSet;
        private System.Windows.Forms.BindingSource tb_enseignantsBindingSource;
        private iss_vente_supportsDataSetTableAdapters.tb_enseignantsTableAdapter tb_enseignantsTableAdapter;
        private iss_vente_supportsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tb_enseignantsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView tb_enseignantsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox matriculeEnseignantTextBox;
        private System.Windows.Forms.TextBox nomCompletTextBox;
        private System.Windows.Forms.TextBox gradeEnseignantTextBox;
        private System.Windows.Forms.TextBox fonctionEnseignantTextBox;
        private System.Windows.Forms.TextBox numeroTelephoneTextBox;
        private System.Windows.Forms.TextBox adresseMaisonTextBox;
        private System.Windows.Forms.TextBox adresseBureauTextBox;
        private System.Windows.Forms.ComboBox departementIDComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}