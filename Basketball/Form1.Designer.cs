namespace Basketball
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tColorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Basketball.DataSet1();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.teamBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new Basketball.DataSet1();
            this.teamBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pFNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.cIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDutyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.gIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gT1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gT2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gScoreT1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gScoreT2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamTableAdapter = new Basketball.DataSet1TableAdapters.TeamTableAdapter();
            this.playerTableAdapter = new Basketball.DataSet1TableAdapters.PlayerTableAdapter();
            this.coachTableAdapter = new Basketball.DataSet1TableAdapters.CoachTableAdapter();
            this.gameTableAdapter = new Basketball.DataSet1TableAdapters.GameTableAdapter();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachBindingSource)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(44, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(977, 385);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox16);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(969, 359);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Team";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(210, 227);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(100, 20);
            this.textBox16.TabIndex = 19;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(110, 224);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 18;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(484, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Color";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(460, 174);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(337, 174);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tIDDataGridViewTextBoxColumn,
            this.tNameDataGridViewTextBoxColumn,
            this.tColorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.teamBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(186, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(425, 98);
            this.dataGridView1.TabIndex = 0;
            // 
            // tIDDataGridViewTextBoxColumn
            // 
            this.tIDDataGridViewTextBoxColumn.DataPropertyName = "T_ID";
            this.tIDDataGridViewTextBoxColumn.HeaderText = "T_ID";
            this.tIDDataGridViewTextBoxColumn.Name = "tIDDataGridViewTextBoxColumn";
            this.tIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tNameDataGridViewTextBoxColumn
            // 
            this.tNameDataGridViewTextBoxColumn.DataPropertyName = "T_Name";
            this.tNameDataGridViewTextBoxColumn.HeaderText = "T_Name";
            this.tNameDataGridViewTextBoxColumn.Name = "tNameDataGridViewTextBoxColumn";
            // 
            // tColorDataGridViewTextBoxColumn
            // 
            this.tColorDataGridViewTextBoxColumn.DataPropertyName = "T_Color";
            this.tColorDataGridViewTextBoxColumn.HeaderText = "T_Color";
            this.tColorDataGridViewTextBoxColumn.Name = "tColorDataGridViewTextBoxColumn";
            // 
            // teamBindingSource
            // 
            this.teamBindingSource.DataMember = "Team";
            this.teamBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox20);
            this.tabPage2.Controls.Add(this.textBox17);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(969, 359);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Player";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(168, 193);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(100, 20);
            this.textBox20.TabIndex = 24;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(168, 243);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(100, 20);
            this.textBox17.TabIndex = 23;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(78, 240);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 22;
            this.button6.Text = "Delete";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.teamBindingSource2, "T_ID", true));
            this.comboBox1.DataSource = this.teamBindingSource1;
            this.comboBox1.DisplayMember = "T_Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(644, 193);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.ValueMember = "T_ID";
            // 
            // teamBindingSource2
            // 
            this.teamBindingSource2.DataMember = "Team";
            this.teamBindingSource2.DataSource = this.dataSet11;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teamBindingSource1
            // 
            this.teamBindingSource1.DataMember = "Team";
            this.teamBindingSource1.DataSource = this.dataSet11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(405, 193);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 20;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(289, 193);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 19;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(521, 193);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(78, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pIDDataGridViewTextBoxColumn,
            this.pFNameDataGridViewTextBoxColumn,
            this.pLNameDataGridViewTextBoxColumn,
            this.pAgeDataGridViewTextBoxColumn,
            this.tIDDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.playerBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(116, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(599, 150);
            this.dataGridView2.TabIndex = 0;
            // 
            // pIDDataGridViewTextBoxColumn
            // 
            this.pIDDataGridViewTextBoxColumn.DataPropertyName = "P_ID";
            this.pIDDataGridViewTextBoxColumn.HeaderText = "P_ID";
            this.pIDDataGridViewTextBoxColumn.Name = "pIDDataGridViewTextBoxColumn";
            this.pIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pFNameDataGridViewTextBoxColumn
            // 
            this.pFNameDataGridViewTextBoxColumn.DataPropertyName = "P_FName";
            this.pFNameDataGridViewTextBoxColumn.HeaderText = "P_FName";
            this.pFNameDataGridViewTextBoxColumn.Name = "pFNameDataGridViewTextBoxColumn";
            // 
            // pLNameDataGridViewTextBoxColumn
            // 
            this.pLNameDataGridViewTextBoxColumn.DataPropertyName = "P_LName";
            this.pLNameDataGridViewTextBoxColumn.HeaderText = "P_LName";
            this.pLNameDataGridViewTextBoxColumn.Name = "pLNameDataGridViewTextBoxColumn";
            // 
            // pAgeDataGridViewTextBoxColumn
            // 
            this.pAgeDataGridViewTextBoxColumn.DataPropertyName = "P_Age";
            this.pAgeDataGridViewTextBoxColumn.HeaderText = "P_Age";
            this.pAgeDataGridViewTextBoxColumn.Name = "pAgeDataGridViewTextBoxColumn";
            // 
            // tIDDataGridViewTextBoxColumn1
            // 
            this.tIDDataGridViewTextBoxColumn1.DataPropertyName = "T_ID";
            this.tIDDataGridViewTextBoxColumn1.HeaderText = "T_ID";
            this.tIDDataGridViewTextBoxColumn1.Name = "tIDDataGridViewTextBoxColumn1";
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataMember = "Player";
            this.playerBindingSource.DataSource = this.dataSet1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox21);
            this.tabPage3.Controls.Add(this.textBox18);
            this.tabPage3.Controls.Add(this.button7);
            this.tabPage3.Controls.Add(this.textBox9);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.comboBox2);
            this.tabPage3.Controls.Add(this.textBox8);
            this.tabPage3.Controls.Add(this.textBox7);
            this.tabPage3.Controls.Add(this.textBox6);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(969, 359);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Coach";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(138, 248);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(100, 20);
            this.textBox18.TabIndex = 28;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(57, 245);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 27;
            this.button7.Text = "Delete";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(570, 196);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 26;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(57, 193);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.teamBindingSource2, "T_ID", true));
            this.comboBox2.DataSource = this.teamBindingSource1;
            this.comboBox2.DisplayMember = "T_Name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(708, 196);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 24;
            this.comboBox2.ValueMember = "T_ID";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(464, 196);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 23;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(358, 196);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 22;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(252, 196);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 21;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIDDataGridViewTextBoxColumn,
            this.cFNameDataGridViewTextBoxColumn,
            this.cLNameDataGridViewTextBoxColumn,
            this.cPhoneDataGridViewTextBoxColumn,
            this.cDutyDataGridViewTextBoxColumn,
            this.tIDDataGridViewTextBoxColumn2});
            this.dataGridView3.DataSource = this.coachBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(83, 6);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(651, 150);
            this.dataGridView3.TabIndex = 1;
            // 
            // cIDDataGridViewTextBoxColumn
            // 
            this.cIDDataGridViewTextBoxColumn.DataPropertyName = "C_ID";
            this.cIDDataGridViewTextBoxColumn.HeaderText = "C_ID";
            this.cIDDataGridViewTextBoxColumn.Name = "cIDDataGridViewTextBoxColumn";
            this.cIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cFNameDataGridViewTextBoxColumn
            // 
            this.cFNameDataGridViewTextBoxColumn.DataPropertyName = "C_FName";
            this.cFNameDataGridViewTextBoxColumn.HeaderText = "C_FName";
            this.cFNameDataGridViewTextBoxColumn.Name = "cFNameDataGridViewTextBoxColumn";
            // 
            // cLNameDataGridViewTextBoxColumn
            // 
            this.cLNameDataGridViewTextBoxColumn.DataPropertyName = "C_LName";
            this.cLNameDataGridViewTextBoxColumn.HeaderText = "C_LName";
            this.cLNameDataGridViewTextBoxColumn.Name = "cLNameDataGridViewTextBoxColumn";
            // 
            // cPhoneDataGridViewTextBoxColumn
            // 
            this.cPhoneDataGridViewTextBoxColumn.DataPropertyName = "C_Phone";
            this.cPhoneDataGridViewTextBoxColumn.HeaderText = "C_Phone";
            this.cPhoneDataGridViewTextBoxColumn.Name = "cPhoneDataGridViewTextBoxColumn";
            // 
            // cDutyDataGridViewTextBoxColumn
            // 
            this.cDutyDataGridViewTextBoxColumn.DataPropertyName = "C_Duty";
            this.cDutyDataGridViewTextBoxColumn.HeaderText = "C_Duty";
            this.cDutyDataGridViewTextBoxColumn.Name = "cDutyDataGridViewTextBoxColumn";
            // 
            // tIDDataGridViewTextBoxColumn2
            // 
            this.tIDDataGridViewTextBoxColumn2.DataPropertyName = "T_ID";
            this.tIDDataGridViewTextBoxColumn2.HeaderText = "T_ID";
            this.tIDDataGridViewTextBoxColumn2.Name = "tIDDataGridViewTextBoxColumn2";
            // 
            // coachBindingSource
            // 
            this.coachBindingSource.DataMember = "Coach";
            this.coachBindingSource.DataSource = this.dataSet1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.textBox22);
            this.tabPage4.Controls.Add(this.comboBox3);
            this.tabPage4.Controls.Add(this.textBox19);
            this.tabPage4.Controls.Add(this.button8);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.textBox14);
            this.tabPage4.Controls.Add(this.textBox15);
            this.tabPage4.Controls.Add(this.textBox10);
            this.tabPage4.Controls.Add(this.textBox11);
            this.tabPage4.Controls.Add(this.textBox12);
            this.tabPage4.Controls.Add(this.textBox13);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.button4);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(969, 359);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Game";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.teamBindingSource2, "T_ID", true));
            this.comboBox3.DataSource = this.teamBindingSource1;
            this.comboBox3.DisplayMember = "T_Name";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(842, 222);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 40;
            this.comboBox3.ValueMember = "T_ID";
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(97, 278);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(100, 20);
            this.textBox19.TabIndex = 39;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(16, 275);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 38;
            this.button8.Text = "Delete";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(759, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Team 2 Score";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(648, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Team 1 Score";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(629, 224);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(100, 20);
            this.textBox14.TabIndex = 35;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(735, 223);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(100, 20);
            this.textBox15.TabIndex = 34;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(205, 224);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 31;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(311, 224);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 20);
            this.textBox11.TabIndex = 30;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(417, 224);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 20);
            this.textBox12.TabIndex = 29;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(523, 224);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 20);
            this.textBox13.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(558, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Time";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(16, 218);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 25;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(457, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Team 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Team 1";
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gIDDataGridViewTextBoxColumn,
            this.gT1DataGridViewTextBoxColumn,
            this.gT2DataGridViewTextBoxColumn,
            this.gDateDataGridViewTextBoxColumn,
            this.gTimeDataGridViewTextBoxColumn,
            this.gScoreT1DataGridViewTextBoxColumn,
            this.gScoreT2DataGridViewTextBoxColumn,
            this.tIDDataGridViewTextBoxColumn3});
            this.dataGridView4.DataSource = this.gameBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(1, 3);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(855, 150);
            this.dataGridView4.TabIndex = 0;
            // 
            // gIDDataGridViewTextBoxColumn
            // 
            this.gIDDataGridViewTextBoxColumn.DataPropertyName = "G_ID";
            this.gIDDataGridViewTextBoxColumn.HeaderText = "G_ID";
            this.gIDDataGridViewTextBoxColumn.Name = "gIDDataGridViewTextBoxColumn";
            this.gIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gT1DataGridViewTextBoxColumn
            // 
            this.gT1DataGridViewTextBoxColumn.DataPropertyName = "G_T1";
            this.gT1DataGridViewTextBoxColumn.HeaderText = "G_T1";
            this.gT1DataGridViewTextBoxColumn.Name = "gT1DataGridViewTextBoxColumn";
            // 
            // gT2DataGridViewTextBoxColumn
            // 
            this.gT2DataGridViewTextBoxColumn.DataPropertyName = "G_T2";
            this.gT2DataGridViewTextBoxColumn.HeaderText = "G_T2";
            this.gT2DataGridViewTextBoxColumn.Name = "gT2DataGridViewTextBoxColumn";
            // 
            // gDateDataGridViewTextBoxColumn
            // 
            this.gDateDataGridViewTextBoxColumn.DataPropertyName = "G_Date";
            this.gDateDataGridViewTextBoxColumn.HeaderText = "G_Date";
            this.gDateDataGridViewTextBoxColumn.Name = "gDateDataGridViewTextBoxColumn";
            // 
            // gTimeDataGridViewTextBoxColumn
            // 
            this.gTimeDataGridViewTextBoxColumn.DataPropertyName = "G_Time";
            this.gTimeDataGridViewTextBoxColumn.HeaderText = "G_Time";
            this.gTimeDataGridViewTextBoxColumn.Name = "gTimeDataGridViewTextBoxColumn";
            // 
            // gScoreT1DataGridViewTextBoxColumn
            // 
            this.gScoreT1DataGridViewTextBoxColumn.DataPropertyName = "G_ScoreT1";
            this.gScoreT1DataGridViewTextBoxColumn.HeaderText = "G_ScoreT1";
            this.gScoreT1DataGridViewTextBoxColumn.Name = "gScoreT1DataGridViewTextBoxColumn";
            // 
            // gScoreT2DataGridViewTextBoxColumn
            // 
            this.gScoreT2DataGridViewTextBoxColumn.DataPropertyName = "G_ScoreT2";
            this.gScoreT2DataGridViewTextBoxColumn.HeaderText = "G_ScoreT2";
            this.gScoreT2DataGridViewTextBoxColumn.Name = "gScoreT2DataGridViewTextBoxColumn";
            // 
            // tIDDataGridViewTextBoxColumn3
            // 
            this.tIDDataGridViewTextBoxColumn3.DataPropertyName = "T_ID";
            this.tIDDataGridViewTextBoxColumn3.HeaderText = "T_ID";
            this.tIDDataGridViewTextBoxColumn3.Name = "tIDDataGridViewTextBoxColumn3";
            // 
            // gameBindingSource
            // 
            this.gameBindingSource.DataMember = "Game";
            this.gameBindingSource.DataSource = this.dataSet1;
            // 
            // teamTableAdapter
            // 
            this.teamTableAdapter.ClearBeforeFill = true;
            // 
            // playerTableAdapter
            // 
            this.playerTableAdapter.ClearBeforeFill = true;
            // 
            // coachTableAdapter
            // 
            this.coachTableAdapter.ClearBeforeFill = true;
            // 
            // gameTableAdapter
            // 
            this.gameTableAdapter.ClearBeforeFill = true;
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(138, 197);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(100, 20);
            this.textBox21.TabIndex = 29;
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(99, 224);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(100, 20);
            this.textBox22.TabIndex = 41;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 467);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachBindingSource)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource teamBindingSource;
        private DataSet1TableAdapters.TeamTableAdapter teamTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tColorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource playerBindingSource;
        private DataSet1TableAdapters.PlayerTableAdapter playerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pFNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource coachBindingSource;
        private DataSet1TableAdapters.CoachTableAdapter coachTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDutyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource gameBindingSource;
        private DataSet1TableAdapters.GameTableAdapter gameTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gT1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gT2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gScoreT1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gScoreT2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox3;
        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource teamBindingSource1;
        private System.Windows.Forms.BindingSource teamBindingSource2;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox22;
    }
}

