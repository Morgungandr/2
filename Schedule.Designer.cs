namespace AdventureTime
{
    partial class Schedule
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.newschedulebutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.schedulefullBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.advTimeDataSet1 = new AdventureTime.AdvTimeDataSet();
            this.advTimeDataSet = new AdventureTime.AdvTimeDataSet();
            this.scheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scheduleTableAdapter = new AdventureTime.AdvTimeDataSetTableAdapters.ScheduleTableAdapter();
            this.schedulefullTableAdapter = new AdventureTime.AdvTimeDataSetTableAdapters.SchedulefullTableAdapter();
            this.idscheduleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tourname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofdispatchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returndate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxchild = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxadult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departurecity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tourprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pitaniatip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vidturaname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatorname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulefullBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advTimeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advTimeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idscheduleDataGridViewTextBoxColumn,
            this.idturaDataGridViewTextBoxColumn,
            this.tourname,
            this.dateofdispatchDataGridViewTextBoxColumn,
            this.returndate,
            this.country,
            this.maxchild,
            this.maxadult,
            this.departurecity,
            this.tourprice,
            this.pitaniatip,
            this.vidturaname,
            this.operatorname});
            this.dataGridView1.DataSource = this.schedulefullBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1145, 478);
            this.dataGridView1.TabIndex = 0;
            // 
            // newschedulebutton
            // 
            this.newschedulebutton.Location = new System.Drawing.Point(-1, -2);
            this.newschedulebutton.Name = "newschedulebutton";
            this.newschedulebutton.Size = new System.Drawing.Size(96, 26);
            this.newschedulebutton.TabIndex = 1;
            this.newschedulebutton.Text = "Новый";
            this.newschedulebutton.UseVisualStyleBackColor = true;
            this.newschedulebutton.Click += new System.EventHandler(this.newschedulebutton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "Редактировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // schedulefullBindingSource
            // 
            this.schedulefullBindingSource.DataMember = "Schedulefull";
            this.schedulefullBindingSource.DataSource = this.advTimeDataSet1;
            // 
            // advTimeDataSet1
            // 
            this.advTimeDataSet1.DataSetName = "AdvTimeDataSet";
            this.advTimeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // advTimeDataSet
            // 
            this.advTimeDataSet.DataSetName = "AdvTimeDataSet";
            this.advTimeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scheduleBindingSource
            // 
            this.scheduleBindingSource.DataMember = "Schedule";
            this.scheduleBindingSource.DataSource = this.advTimeDataSet;
            // 
            // scheduleTableAdapter
            // 
            this.scheduleTableAdapter.ClearBeforeFill = true;
            // 
            // schedulefullTableAdapter
            // 
            this.schedulefullTableAdapter.ClearBeforeFill = true;
            // 
            // idscheduleDataGridViewTextBoxColumn
            // 
            this.idscheduleDataGridViewTextBoxColumn.DataPropertyName = "idschedule";
            this.idscheduleDataGridViewTextBoxColumn.HeaderText = "idschedule";
            this.idscheduleDataGridViewTextBoxColumn.Name = "idscheduleDataGridViewTextBoxColumn";
            this.idscheduleDataGridViewTextBoxColumn.ReadOnly = true;
            this.idscheduleDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idscheduleDataGridViewTextBoxColumn.Visible = false;
            // 
            // idturaDataGridViewTextBoxColumn
            // 
            this.idturaDataGridViewTextBoxColumn.DataPropertyName = "idtura";
            this.idturaDataGridViewTextBoxColumn.HeaderText = "idtura";
            this.idturaDataGridViewTextBoxColumn.Name = "idturaDataGridViewTextBoxColumn";
            this.idturaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idturaDataGridViewTextBoxColumn.Visible = false;
            // 
            // tourname
            // 
            this.tourname.DataPropertyName = "tourname";
            this.tourname.HeaderText = "Название тура";
            this.tourname.Name = "tourname";
            // 
            // dateofdispatchDataGridViewTextBoxColumn
            // 
            this.dateofdispatchDataGridViewTextBoxColumn.DataPropertyName = "dateofdispatch";
            this.dateofdispatchDataGridViewTextBoxColumn.HeaderText = "Дата отправки";
            this.dateofdispatchDataGridViewTextBoxColumn.Name = "dateofdispatchDataGridViewTextBoxColumn";
            // 
            // returndate
            // 
            this.returndate.DataPropertyName = "returndate";
            this.returndate.HeaderText = "Дата возвращения";
            this.returndate.Name = "returndate";
            // 
            // country
            // 
            this.country.DataPropertyName = "country";
            this.country.HeaderText = "Страна прибытия";
            this.country.Name = "country";
            // 
            // maxchild
            // 
            this.maxchild.DataPropertyName = "maxchild";
            this.maxchild.HeaderText = "Макс дет";
            this.maxchild.Name = "maxchild";
            // 
            // maxadult
            // 
            this.maxadult.DataPropertyName = "maxadult";
            this.maxadult.HeaderText = "Макс взр";
            this.maxadult.Name = "maxadult";
            // 
            // departurecity
            // 
            this.departurecity.DataPropertyName = "departurecity";
            this.departurecity.HeaderText = "Город отправления";
            this.departurecity.Name = "departurecity";
            // 
            // tourprice
            // 
            this.tourprice.DataPropertyName = "tourprice";
            this.tourprice.HeaderText = "Цена тура";
            this.tourprice.Name = "tourprice";
            // 
            // pitaniatip
            // 
            this.pitaniatip.DataPropertyName = "pitaniatip";
            this.pitaniatip.HeaderText = "Тип питания";
            this.pitaniatip.Name = "pitaniatip";
            // 
            // vidturaname
            // 
            this.vidturaname.DataPropertyName = "vidturaname";
            this.vidturaname.HeaderText = "Вид тура";
            this.vidturaname.Name = "vidturaname";
            // 
            // operatorname
            // 
            this.operatorname.DataPropertyName = "operatorname";
            this.operatorname.HeaderText = "Тур оператор";
            this.operatorname.Name = "operatorname";
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 506);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.newschedulebutton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Schedule";
            this.Text = "Расписание туров";
            this.Load += new System.EventHandler(this.Schedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulefullBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advTimeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advTimeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private AdvTimeDataSet advTimeDataSet;
        private System.Windows.Forms.BindingSource scheduleBindingSource;
        private AdvTimeDataSetTableAdapters.ScheduleTableAdapter scheduleTableAdapter;
        private AdvTimeDataSet advTimeDataSet1;
        private System.Windows.Forms.BindingSource schedulefullBindingSource;
        private AdvTimeDataSetTableAdapters.SchedulefullTableAdapter schedulefullTableAdapter;
        private System.Windows.Forms.Button newschedulebutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idscheduleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tourname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofdispatchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returndate;
        private System.Windows.Forms.DataGridViewTextBoxColumn country;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxchild;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxadult;
        private System.Windows.Forms.DataGridViewTextBoxColumn departurecity;
        private System.Windows.Forms.DataGridViewTextBoxColumn tourprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn pitaniatip;
        private System.Windows.Forms.DataGridViewTextBoxColumn vidturaname;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorname;
    }
}