namespace XMLGameResults
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listOfPlayers = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.score = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblList = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaxScore = new System.Windows.Forms.TextBox();
            this.txtMinScore = new System.Windows.Forms.TextBox();
            this.groupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listOfPlayers
            // 
            this.listOfPlayers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.name,
            this.score,
            this.Time});
            this.listOfPlayers.HideSelection = false;
            this.listOfPlayers.Location = new System.Drawing.Point(26, 82);
            this.listOfPlayers.Name = "listOfPlayers";
            this.listOfPlayers.Size = new System.Drawing.Size(564, 493);
            this.listOfPlayers.TabIndex = 0;
            this.listOfPlayers.UseCompatibleStateImageBehavior = false;
            this.listOfPlayers.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "Номер";
            this.ID.Width = 87;
            // 
            // name
            // 
            this.name.Text = "Имя";
            // 
            // score
            // 
            this.score.Text = "Количество очков";
            this.score.Width = 156;
            // 
            // Time
            // 
            this.Time.Text = "Время выполнения в секундах";
            this.Time.Width = 258;
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Location = new System.Drawing.Point(57, 43);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(127, 20);
            this.lblList.TabIndex = 1;
            this.lblList.Text = "Список игроков";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.txtTime);
            this.groupBox.Controls.Add(this.btnSave);
            this.groupBox.Controls.Add(this.txtScore);
            this.groupBox.Controls.Add(this.lblScore);
            this.groupBox.Controls.Add(this.txtName);
            this.groupBox.Controls.Add(this.lblName);
            this.groupBox.Location = new System.Drawing.Point(641, 82);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(264, 298);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Добавление";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Время выполнения(сек) ";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(32, 206);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 26);
            this.txtTime.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(32, 250);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(173, 36);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(32, 136);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(144, 26);
            this.txtScore.TabIndex = 6;
            this.txtScore.TextChanged += new System.EventHandler(this.txtScore_TextChanged);
            this.txtScore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtScore_KeyPress);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(28, 103);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(148, 20);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "Количество очков";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(32, 59);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(144, 26);
            this.txtName.TabIndex = 4;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(28, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(40, 20);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Имя";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFilter);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaxScore);
            this.groupBox1.Controls.Add(this.txtMinScore);
            this.groupBox1.Location = new System.Drawing.Point(641, 386);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 173);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтр по количеству очков";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(168, 82);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(112, 44);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Text = "Применить";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Максимум";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Минимум";
            // 
            // txtMaxScore
            // 
            this.txtMaxScore.Location = new System.Drawing.Point(35, 129);
            this.txtMaxScore.Name = "txtMaxScore";
            this.txtMaxScore.Size = new System.Drawing.Size(100, 26);
            this.txtMaxScore.TabIndex = 1;
            // 
            // txtMinScore
            // 
            this.txtMinScore.Location = new System.Drawing.Point(35, 65);
            this.txtMinScore.Name = "txtMinScore";
            this.txtMinScore.Size = new System.Drawing.Size(100, 26);
            this.txtMinScore.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 627);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.listOfPlayers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Результаты прохождения игр";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listOfPlayers;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader score;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaxScore;
        private System.Windows.Forms.TextBox txtMinScore;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTime;
    }
}

