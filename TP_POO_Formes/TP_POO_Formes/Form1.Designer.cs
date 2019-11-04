namespace TP_POO_Formes
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TP_Dessin = new System.Windows.Forms.TabPage();
            this.Bt_Clear = new System.Windows.Forms.Button();
            this.Dgv_P_dessiner = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Tableau = new System.Windows.Forms.Panel();
            this.TP_CreeCarre = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.P_Carre_pos = new System.Windows.Forms.Panel();
            this.Tb_Y_carre = new System.Windows.Forms.TextBox();
            this.Tb_X_carre = new System.Windows.Forms.TextBox();
            this.Tb_Cote_carre = new System.Windows.Forms.TextBox();
            this.BT_Add_carre = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TP_CreeRect = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.P_Rectangle_pos = new System.Windows.Forms.Panel();
            this.Tb_long_Rectangle = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Tb_Y_Rectangle = new System.Windows.Forms.TextBox();
            this.Tb_X_Rectangle = new System.Windows.Forms.TextBox();
            this.Tb_larg_Rectangle = new System.Windows.Forms.TextBox();
            this.Bt_Add_Rectangle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TP_CreeCercle = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.P_Cercle_pos = new System.Windows.Forms.Panel();
            this.Tb_Y_Cercle = new System.Windows.Forms.TextBox();
            this.Tb_X_Cercle = new System.Windows.Forms.TextBox();
            this.Tb_Rayon_Cercle = new System.Windows.Forms.TextBox();
            this.Bt_Add_Cercle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TP_Quest = new System.Windows.Forms.TabPage();
            this.L_info_qu = new System.Windows.Forms.Label();
            this.INFO_Forme = new System.Windows.Forms.Label();
            this.L_Quest_num = new System.Windows.Forms.Label();
            this.TB_surface = new System.Windows.Forms.TextBox();
            this.L_surface = new System.Windows.Forms.Label();
            this.BT_Valider_Quest = new System.Windows.Forms.Button();
            this.TB_peri = new System.Windows.Forms.TextBox();
            this.L_peri = new System.Windows.Forms.Label();
            this.P_Quest = new System.Windows.Forms.Panel();
            this.BT_start = new System.Windows.Forms.Button();
            this.lb_Start = new System.Windows.Forms.Label();
            this.affiche_Fin_Quest = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.TP_Dessin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_P_dessiner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formeBindingSource)).BeginInit();
            this.TP_CreeCarre.SuspendLayout();
            this.TP_CreeRect.SuspendLayout();
            this.TP_CreeCercle.SuspendLayout();
            this.TP_Quest.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleDescription = "Locked";
            this.tabControl1.Controls.Add(this.TP_Dessin);
            this.tabControl1.Controls.Add(this.TP_CreeCarre);
            this.tabControl1.Controls.Add(this.TP_CreeRect);
            this.tabControl1.Controls.Add(this.TP_CreeCercle);
            this.tabControl1.Controls.Add(this.TP_Quest);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1068, 597);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseClick);
            // 
            // TP_Dessin
            // 
            this.TP_Dessin.Controls.Add(this.Bt_Clear);
            this.TP_Dessin.Controls.Add(this.Dgv_P_dessiner);
            this.TP_Dessin.Controls.Add(this.Tableau);
            this.TP_Dessin.Location = new System.Drawing.Point(4, 22);
            this.TP_Dessin.Name = "TP_Dessin";
            this.TP_Dessin.Padding = new System.Windows.Forms.Padding(3);
            this.TP_Dessin.Size = new System.Drawing.Size(1060, 571);
            this.TP_Dessin.TabIndex = 0;
            this.TP_Dessin.Text = "dessiner";
            this.TP_Dessin.UseVisualStyleBackColor = true;
            // 
            // Bt_Clear
            // 
            this.Bt_Clear.Location = new System.Drawing.Point(18, 445);
            this.Bt_Clear.Name = "Bt_Clear";
            this.Bt_Clear.Size = new System.Drawing.Size(75, 23);
            this.Bt_Clear.TabIndex = 13;
            this.Bt_Clear.Text = "Effacer";
            this.Bt_Clear.UseVisualStyleBackColor = true;
            this.Bt_Clear.Click += new System.EventHandler(this.Bt_Clear_Click);
            // 
            // Dgv_P_dessiner
            // 
            this.Dgv_P_dessiner.AllowUserToAddRows = false;
            this.Dgv_P_dessiner.AllowUserToDeleteRows = false;
            this.Dgv_P_dessiner.AllowUserToOrderColumns = true;
            this.Dgv_P_dessiner.AllowUserToResizeColumns = false;
            this.Dgv_P_dessiner.AllowUserToResizeRows = false;
            this.Dgv_P_dessiner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_P_dessiner.AutoGenerateColumns = false;
            this.Dgv_P_dessiner.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_P_dessiner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_P_dessiner.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.Dgv_P_dessiner.DataSource = this.formeBindingSource;
            this.Dgv_P_dessiner.Location = new System.Drawing.Point(653, 27);
            this.Dgv_P_dessiner.MultiSelect = false;
            this.Dgv_P_dessiner.Name = "Dgv_P_dessiner";
            this.Dgv_P_dessiner.ReadOnly = true;
            this.Dgv_P_dessiner.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.Dgv_P_dessiner.Size = new System.Drawing.Size(357, 134);
            this.Dgv_P_dessiner.TabIndex = 12;
            this.Dgv_P_dessiner.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_P_dessiner_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "numero de la forme";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type de forme";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // formeBindingSource
            // 
            this.formeBindingSource.DataSource = typeof(librairie.Forme);
            // 
            // Tableau
            // 
            this.Tableau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tableau.AutoSize = true;
            this.Tableau.BackColor = System.Drawing.Color.Gainsboro;
            this.Tableau.Location = new System.Drawing.Point(18, 18);
            this.Tableau.Name = "Tableau";
            this.Tableau.Size = new System.Drawing.Size(513, 408);
            this.Tableau.TabIndex = 8;
            // 
            // TP_CreeCarre
            // 
            this.TP_CreeCarre.Controls.Add(this.label11);
            this.TP_CreeCarre.Controls.Add(this.P_Carre_pos);
            this.TP_CreeCarre.Controls.Add(this.Tb_Y_carre);
            this.TP_CreeCarre.Controls.Add(this.Tb_X_carre);
            this.TP_CreeCarre.Controls.Add(this.Tb_Cote_carre);
            this.TP_CreeCarre.Controls.Add(this.BT_Add_carre);
            this.TP_CreeCarre.Controls.Add(this.label3);
            this.TP_CreeCarre.Controls.Add(this.label2);
            this.TP_CreeCarre.Controls.Add(this.label1);
            this.TP_CreeCarre.Location = new System.Drawing.Point(4, 22);
            this.TP_CreeCarre.Name = "TP_CreeCarre";
            this.TP_CreeCarre.Padding = new System.Windows.Forms.Padding(3);
            this.TP_CreeCarre.Size = new System.Drawing.Size(1060, 571);
            this.TP_CreeCarre.TabIndex = 1;
            this.TP_CreeCarre.Text = "Créer un Carre";
            this.TP_CreeCarre.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(27, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(445, 52);
            this.label11.TabIndex = 10;
            this.label11.Text = "Pour crée un carré il suffie d\'indiquer son côté et sa position (pour la position" +
    " vous pouvez cliquer sur le panel cela vous permeteras le le previsualiser en me" +
    "me temps)";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // P_Carre_pos
            // 
            this.P_Carre_pos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.P_Carre_pos.AutoSize = true;
            this.P_Carre_pos.BackColor = System.Drawing.Color.Gainsboro;
            this.P_Carre_pos.Location = new System.Drawing.Point(510, 57);
            this.P_Carre_pos.Name = "P_Carre_pos";
            this.P_Carre_pos.Size = new System.Drawing.Size(513, 408);
            this.P_Carre_pos.TabIndex = 9;
            // 
            // Tb_Y_carre
            // 
            this.Tb_Y_carre.Location = new System.Drawing.Point(249, 178);
            this.Tb_Y_carre.Name = "Tb_Y_carre";
            this.Tb_Y_carre.Size = new System.Drawing.Size(100, 20);
            this.Tb_Y_carre.TabIndex = 6;
            this.Tb_Y_carre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_peri_KeyPress);
            // 
            // Tb_X_carre
            // 
            this.Tb_X_carre.Location = new System.Drawing.Point(249, 143);
            this.Tb_X_carre.Name = "Tb_X_carre";
            this.Tb_X_carre.Size = new System.Drawing.Size(100, 20);
            this.Tb_X_carre.TabIndex = 5;
            this.Tb_X_carre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_peri_KeyPress);
            // 
            // Tb_Cote_carre
            // 
            this.Tb_Cote_carre.Location = new System.Drawing.Point(249, 108);
            this.Tb_Cote_carre.Name = "Tb_Cote_carre";
            this.Tb_Cote_carre.Size = new System.Drawing.Size(100, 20);
            this.Tb_Cote_carre.TabIndex = 4;
            this.Tb_Cote_carre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_peri_KeyPress);
            // 
            // BT_Add_carre
            // 
            this.BT_Add_carre.Location = new System.Drawing.Point(187, 230);
            this.BT_Add_carre.Name = "BT_Add_carre";
            this.BT_Add_carre.Size = new System.Drawing.Size(75, 23);
            this.BT_Add_carre.TabIndex = 3;
            this.BT_Add_carre.Text = "Ajouter";
            this.BT_Add_carre.UseVisualStyleBackColor = true;
            this.BT_Add_carre.Click += new System.EventHandler(this.BT_Add_carre_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Indiquer la position Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Indiquer la position X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Indiquer le Cote";
            // 
            // TP_CreeRect
            // 
            this.TP_CreeRect.Controls.Add(this.label12);
            this.TP_CreeRect.Controls.Add(this.P_Rectangle_pos);
            this.TP_CreeRect.Controls.Add(this.Tb_long_Rectangle);
            this.TP_CreeRect.Controls.Add(this.label10);
            this.TP_CreeRect.Controls.Add(this.Tb_Y_Rectangle);
            this.TP_CreeRect.Controls.Add(this.Tb_X_Rectangle);
            this.TP_CreeRect.Controls.Add(this.Tb_larg_Rectangle);
            this.TP_CreeRect.Controls.Add(this.Bt_Add_Rectangle);
            this.TP_CreeRect.Controls.Add(this.label7);
            this.TP_CreeRect.Controls.Add(this.label8);
            this.TP_CreeRect.Controls.Add(this.label9);
            this.TP_CreeRect.Location = new System.Drawing.Point(4, 22);
            this.TP_CreeRect.Name = "TP_CreeRect";
            this.TP_CreeRect.Padding = new System.Windows.Forms.Padding(3);
            this.TP_CreeRect.Size = new System.Drawing.Size(1060, 571);
            this.TP_CreeRect.TabIndex = 2;
            this.TP_CreeRect.Text = "Créer un Rectangle";
            this.TP_CreeRect.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(27, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(445, 52);
            this.label12.TabIndex = 17;
            this.label12.Text = "Pour crée un Rectangle il suffie d\'indiquer sa longeur et sa largeur puis sa posi" +
    "tion (pour la position vous pouvez cliquer sur le panel cela vous permeteras le " +
    "le previsualiser en meme temps)";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // P_Rectangle_pos
            // 
            this.P_Rectangle_pos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.P_Rectangle_pos.AutoSize = true;
            this.P_Rectangle_pos.BackColor = System.Drawing.Color.Gainsboro;
            this.P_Rectangle_pos.Location = new System.Drawing.Point(510, 57);
            this.P_Rectangle_pos.Name = "P_Rectangle_pos";
            this.P_Rectangle_pos.Size = new System.Drawing.Size(513, 408);
            this.P_Rectangle_pos.TabIndex = 16;
            // 
            // Tb_long_Rectangle
            // 
            this.Tb_long_Rectangle.Location = new System.Drawing.Point(249, 134);
            this.Tb_long_Rectangle.Name = "Tb_long_Rectangle";
            this.Tb_long_Rectangle.Size = new System.Drawing.Size(100, 20);
            this.Tb_long_Rectangle.TabIndex = 12;
            this.Tb_long_Rectangle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_peri_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(121, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Indiquer la Longeur";
            // 
            // Tb_Y_Rectangle
            // 
            this.Tb_Y_Rectangle.Location = new System.Drawing.Point(249, 186);
            this.Tb_Y_Rectangle.Name = "Tb_Y_Rectangle";
            this.Tb_Y_Rectangle.Size = new System.Drawing.Size(100, 20);
            this.Tb_Y_Rectangle.TabIndex = 14;
            this.Tb_Y_Rectangle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_peri_KeyPress);
            // 
            // Tb_X_Rectangle
            // 
            this.Tb_X_Rectangle.Location = new System.Drawing.Point(249, 160);
            this.Tb_X_Rectangle.Name = "Tb_X_Rectangle";
            this.Tb_X_Rectangle.Size = new System.Drawing.Size(100, 20);
            this.Tb_X_Rectangle.TabIndex = 13;
            this.Tb_X_Rectangle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_peri_KeyPress);
            // 
            // Tb_larg_Rectangle
            // 
            this.Tb_larg_Rectangle.Location = new System.Drawing.Point(249, 108);
            this.Tb_larg_Rectangle.Name = "Tb_larg_Rectangle";
            this.Tb_larg_Rectangle.Size = new System.Drawing.Size(100, 20);
            this.Tb_larg_Rectangle.TabIndex = 11;
            this.Tb_larg_Rectangle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_peri_KeyPress);
            // 
            // Bt_Add_Rectangle
            // 
            this.Bt_Add_Rectangle.Location = new System.Drawing.Point(179, 253);
            this.Bt_Add_Rectangle.Name = "Bt_Add_Rectangle";
            this.Bt_Add_Rectangle.Size = new System.Drawing.Size(75, 23);
            this.Bt_Add_Rectangle.TabIndex = 10;
            this.Bt_Add_Rectangle.Text = "Ajouter";
            this.Bt_Add_Rectangle.UseVisualStyleBackColor = true;
            this.Bt_Add_Rectangle.Click += new System.EventHandler(this.Bt_Add_Rectangle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(121, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Indiquer la position Y";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(121, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Indiquer la position X";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(121, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Indiquer la largeur";
            // 
            // TP_CreeCercle
            // 
            this.TP_CreeCercle.Controls.Add(this.label13);
            this.TP_CreeCercle.Controls.Add(this.P_Cercle_pos);
            this.TP_CreeCercle.Controls.Add(this.Tb_Y_Cercle);
            this.TP_CreeCercle.Controls.Add(this.Tb_X_Cercle);
            this.TP_CreeCercle.Controls.Add(this.Tb_Rayon_Cercle);
            this.TP_CreeCercle.Controls.Add(this.Bt_Add_Cercle);
            this.TP_CreeCercle.Controls.Add(this.label4);
            this.TP_CreeCercle.Controls.Add(this.label5);
            this.TP_CreeCercle.Controls.Add(this.label6);
            this.TP_CreeCercle.Location = new System.Drawing.Point(4, 22);
            this.TP_CreeCercle.Name = "TP_CreeCercle";
            this.TP_CreeCercle.Padding = new System.Windows.Forms.Padding(3);
            this.TP_CreeCercle.Size = new System.Drawing.Size(1060, 571);
            this.TP_CreeCercle.TabIndex = 3;
            this.TP_CreeCercle.Text = "Créer un Cercle";
            this.TP_CreeCercle.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(27, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(445, 52);
            this.label13.TabIndex = 15;
            this.label13.Text = "Pour crée un cercle il suffie d\'indiquer son rayon et sa position (pour la positi" +
    "on vous pouvez cliquer sur le panel cela vous permeteras le le previsualiser en " +
    "meme temps)";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // P_Cercle_pos
            // 
            this.P_Cercle_pos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.P_Cercle_pos.AutoSize = true;
            this.P_Cercle_pos.BackColor = System.Drawing.Color.Gainsboro;
            this.P_Cercle_pos.Location = new System.Drawing.Point(510, 57);
            this.P_Cercle_pos.Name = "P_Cercle_pos";
            this.P_Cercle_pos.Size = new System.Drawing.Size(513, 408);
            this.P_Cercle_pos.TabIndex = 14;
            // 
            // Tb_Y_Cercle
            // 
            this.Tb_Y_Cercle.Location = new System.Drawing.Point(249, 160);
            this.Tb_Y_Cercle.Name = "Tb_Y_Cercle";
            this.Tb_Y_Cercle.Size = new System.Drawing.Size(100, 20);
            this.Tb_Y_Cercle.TabIndex = 13;
            this.Tb_Y_Cercle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_peri_KeyPress);
            // 
            // Tb_X_Cercle
            // 
            this.Tb_X_Cercle.Location = new System.Drawing.Point(249, 134);
            this.Tb_X_Cercle.Name = "Tb_X_Cercle";
            this.Tb_X_Cercle.Size = new System.Drawing.Size(100, 20);
            this.Tb_X_Cercle.TabIndex = 12;
            this.Tb_X_Cercle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_peri_KeyPress);
            // 
            // Tb_Rayon_Cercle
            // 
            this.Tb_Rayon_Cercle.Location = new System.Drawing.Point(249, 108);
            this.Tb_Rayon_Cercle.Name = "Tb_Rayon_Cercle";
            this.Tb_Rayon_Cercle.Size = new System.Drawing.Size(100, 20);
            this.Tb_Rayon_Cercle.TabIndex = 11;
            this.Tb_Rayon_Cercle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_peri_KeyPress);
            // 
            // Bt_Add_Cercle
            // 
            this.Bt_Add_Cercle.Location = new System.Drawing.Point(200, 208);
            this.Bt_Add_Cercle.Name = "Bt_Add_Cercle";
            this.Bt_Add_Cercle.Size = new System.Drawing.Size(75, 23);
            this.Bt_Add_Cercle.TabIndex = 10;
            this.Bt_Add_Cercle.Text = "Ajouter";
            this.Bt_Add_Cercle.UseVisualStyleBackColor = true;
            this.Bt_Add_Cercle.Click += new System.EventHandler(this.Bt_Add_Cercle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Indiquer la position Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Indiquer la position X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Indiquer le Rayon";
            // 
            // TP_Quest
            // 
            this.TP_Quest.Controls.Add(this.affiche_Fin_Quest);
            this.TP_Quest.Controls.Add(this.L_info_qu);
            this.TP_Quest.Controls.Add(this.INFO_Forme);
            this.TP_Quest.Controls.Add(this.L_Quest_num);
            this.TP_Quest.Controls.Add(this.TB_surface);
            this.TP_Quest.Controls.Add(this.L_surface);
            this.TP_Quest.Controls.Add(this.BT_Valider_Quest);
            this.TP_Quest.Controls.Add(this.TB_peri);
            this.TP_Quest.Controls.Add(this.L_peri);
            this.TP_Quest.Controls.Add(this.P_Quest);
            this.TP_Quest.Controls.Add(this.BT_start);
            this.TP_Quest.Controls.Add(this.lb_Start);
            this.TP_Quest.Location = new System.Drawing.Point(4, 22);
            this.TP_Quest.Name = "TP_Quest";
            this.TP_Quest.Padding = new System.Windows.Forms.Padding(3);
            this.TP_Quest.Size = new System.Drawing.Size(1060, 571);
            this.TP_Quest.TabIndex = 4;
            this.TP_Quest.Text = "Serie Question";
            this.TP_Quest.UseVisualStyleBackColor = true;
            // 
            // L_info_qu
            // 
            this.L_info_qu.AutoSize = true;
            this.L_info_qu.Location = new System.Drawing.Point(721, 225);
            this.L_info_qu.Name = "L_info_qu";
            this.L_info_qu.Size = new System.Drawing.Size(176, 13);
            this.L_info_qu.TabIndex = 17;
            this.L_info_qu.Text = "Arrondire a 2 chiffre apres la virgule ";
            this.L_info_qu.Visible = false;
            // 
            // INFO_Forme
            // 
            this.INFO_Forme.AutoSize = true;
            this.INFO_Forme.Location = new System.Drawing.Point(652, 197);
            this.INFO_Forme.Name = "INFO_Forme";
            this.INFO_Forme.Size = new System.Drawing.Size(67, 13);
            this.INFO_Forme.TabIndex = 16;
            this.INFO_Forme.Text = "INFO_Forme";
            this.INFO_Forme.Visible = false;
            // 
            // L_Quest_num
            // 
            this.L_Quest_num.AutoSize = true;
            this.L_Quest_num.Location = new System.Drawing.Point(776, 156);
            this.L_Quest_num.Name = "L_Quest_num";
            this.L_Quest_num.Size = new System.Drawing.Size(58, 13);
            this.L_Quest_num.TabIndex = 15;
            this.L_Quest_num.Text = "Question 1";
            this.L_Quest_num.Visible = false;
            // 
            // TB_surface
            // 
            this.TB_surface.Location = new System.Drawing.Point(903, 309);
            this.TB_surface.Name = "TB_surface";
            this.TB_surface.Size = new System.Drawing.Size(100, 20);
            this.TB_surface.TabIndex = 12;
            this.TB_surface.Visible = false;
            this.TB_surface.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_peri_KeyPress);
            // 
            // L_surface
            // 
            this.L_surface.AutoSize = true;
            this.L_surface.Location = new System.Drawing.Point(652, 312);
            this.L_surface.Name = "L_surface";
            this.L_surface.Size = new System.Drawing.Size(78, 13);
            this.L_surface.TabIndex = 13;
            this.L_surface.Text = "Et sa surface ?";
            this.L_surface.Visible = false;
            // 
            // BT_Valider_Quest
            // 
            this.BT_Valider_Quest.Location = new System.Drawing.Point(769, 382);
            this.BT_Valider_Quest.Name = "BT_Valider_Quest";
            this.BT_Valider_Quest.Size = new System.Drawing.Size(75, 23);
            this.BT_Valider_Quest.TabIndex = 14;
            this.BT_Valider_Quest.Text = "Valider";
            this.BT_Valider_Quest.UseVisualStyleBackColor = true;
            this.BT_Valider_Quest.Visible = false;
            this.BT_Valider_Quest.Click += new System.EventHandler(this.BT_Valider_Quest_Click);
            // 
            // TB_peri
            // 
            this.TB_peri.Location = new System.Drawing.Point(903, 257);
            this.TB_peri.Name = "TB_peri";
            this.TB_peri.Size = new System.Drawing.Size(100, 20);
            this.TB_peri.TabIndex = 11;
            this.TB_peri.Visible = false;
            this.TB_peri.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_peri_KeyPress);
            // 
            // L_peri
            // 
            this.L_peri.AutoSize = true;
            this.L_peri.Location = new System.Drawing.Point(652, 260);
            this.L_peri.Name = "L_peri";
            this.L_peri.Size = new System.Drawing.Size(224, 13);
            this.L_peri.TabIndex = 10;
            this.L_peri.Text = "Quelle est le périmetre de cet forme (en pixel)?";
            this.L_peri.Visible = false;
            // 
            // P_Quest
            // 
            this.P_Quest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.P_Quest.AutoSize = true;
            this.P_Quest.BackColor = System.Drawing.Color.Gainsboro;
            this.P_Quest.Location = new System.Drawing.Point(18, 18);
            this.P_Quest.Name = "P_Quest";
            this.P_Quest.Size = new System.Drawing.Size(513, 408);
            this.P_Quest.TabIndex = 9;
            // 
            // BT_start
            // 
            this.BT_start.Location = new System.Drawing.Point(744, 44);
            this.BT_start.Name = "BT_start";
            this.BT_start.Size = new System.Drawing.Size(75, 23);
            this.BT_start.TabIndex = 1;
            this.BT_start.Text = "Commancer";
            this.BT_start.UseVisualStyleBackColor = true;
            this.BT_start.Click += new System.EventHandler(this.BT_start_Click);
            // 
            // lb_Start
            // 
            this.lb_Start.AutoSize = true;
            this.lb_Start.Location = new System.Drawing.Point(682, 18);
            this.lb_Start.Name = "lb_Start";
            this.lb_Start.Size = new System.Drawing.Size(204, 13);
            this.lb_Start.TabIndex = 0;
            this.lb_Start.Text = "Cliquer sur commancer pour debut la serie";
            // 
            // affiche_Fin_Quest
            // 
            this.affiche_Fin_Quest.AutoSize = true;
            this.affiche_Fin_Quest.Location = new System.Drawing.Point(555, 101);
            this.affiche_Fin_Quest.Name = "affiche_Fin_Quest";
            this.affiche_Fin_Quest.Size = new System.Drawing.Size(93, 13);
            this.affiche_Fin_Quest.TabIndex = 18;
            this.affiche_Fin_Quest.Text = "affiche_Fin_Quest";
            this.affiche_Fin_Quest.Visible = false;
            // 
            // Form1
            // 
            this.AccessibleDescription = "Un jeux super cool";
            this.AccessibleName = "Jeux des Forme";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 597);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Jeux des Forme";
            this.tabControl1.ResumeLayout(false);
            this.TP_Dessin.ResumeLayout(false);
            this.TP_Dessin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_P_dessiner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formeBindingSource)).EndInit();
            this.TP_CreeCarre.ResumeLayout(false);
            this.TP_CreeCarre.PerformLayout();
            this.TP_CreeRect.ResumeLayout(false);
            this.TP_CreeRect.PerformLayout();
            this.TP_CreeCercle.ResumeLayout(false);
            this.TP_CreeCercle.PerformLayout();
            this.TP_Quest.ResumeLayout(false);
            this.TP_Quest.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TP_Dessin;
        private System.Windows.Forms.TabPage TP_CreeCarre;
        private System.Windows.Forms.Panel Tableau;
        private System.Windows.Forms.TextBox Tb_Y_carre;
        private System.Windows.Forms.TextBox Tb_X_carre;
        private System.Windows.Forms.TextBox Tb_Cote_carre;
        private System.Windows.Forms.Button BT_Add_carre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage TP_CreeRect;
        private System.Windows.Forms.TabPage TP_CreeCercle;
        private System.Windows.Forms.TextBox Tb_Y_Cercle;
        private System.Windows.Forms.TextBox Tb_Rayon_Cercle;
        private System.Windows.Forms.Button Bt_Add_Cercle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Tb_X_Cercle;
        private System.Windows.Forms.TextBox Tb_long_Rectangle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Tb_Y_Rectangle;
        private System.Windows.Forms.TextBox Tb_X_Rectangle;
        private System.Windows.Forms.TextBox Tb_larg_Rectangle;
        private System.Windows.Forms.Button Bt_Add_Rectangle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView Dgv_P_dessiner;
        private System.Windows.Forms.Button Bt_Clear;
        private System.Windows.Forms.TabPage TP_Quest;
        private System.Windows.Forms.Button BT_start;
        private System.Windows.Forms.Label lb_Start;
        private System.Windows.Forms.Panel P_Quest;
        private System.Windows.Forms.TextBox TB_surface;
        private System.Windows.Forms.Label L_surface;
        private System.Windows.Forms.Button BT_Valider_Quest;
        private System.Windows.Forms.TextBox TB_peri;
        private System.Windows.Forms.Label L_peri;
        private System.Windows.Forms.Label L_Quest_num;
        private System.Windows.Forms.Label INFO_Forme;
        private System.Windows.Forms.Panel P_Carre_pos;
        private System.Windows.Forms.Panel P_Rectangle_pos;
        private System.Windows.Forms.Panel P_Cercle_pos;
        private System.Windows.Forms.Label L_info_qu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource formeBindingSource;
        private System.Windows.Forms.Label affiche_Fin_Quest;
    }
}

