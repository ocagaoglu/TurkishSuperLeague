namespace Turkish_Super_League
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
            this.topPnl = new System.Windows.Forms.Panel();
            this.selector = new System.Windows.Forms.Panel();
            this.teamPnl = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.teamBtn = new System.Windows.Forms.Button();
            this.matchBtn = new System.Windows.Forms.Button();
            this.stadiumBtn = new System.Windows.Forms.Button();
            this.refereeBtn = new System.Windows.Forms.Button();
            this.assistBtn = new System.Windows.Forms.Button();
            this.goalBtn = new System.Windows.Forms.Button();
            this.managerBtn = new System.Windows.Forms.Button();
            this.playerBtn = new System.Windows.Forms.Button();
            this.topPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPnl
            // 
            this.topPnl.Controls.Add(this.exitBtn);
            this.topPnl.Controls.Add(this.teamBtn);
            this.topPnl.Controls.Add(this.matchBtn);
            this.topPnl.Controls.Add(this.stadiumBtn);
            this.topPnl.Controls.Add(this.refereeBtn);
            this.topPnl.Controls.Add(this.assistBtn);
            this.topPnl.Controls.Add(this.goalBtn);
            this.topPnl.Controls.Add(this.managerBtn);
            this.topPnl.Controls.Add(this.playerBtn);
            this.topPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPnl.Location = new System.Drawing.Point(0, 0);
            this.topPnl.Name = "topPnl";
            this.topPnl.Size = new System.Drawing.Size(1540, 120);
            this.topPnl.TabIndex = 0;
            // 
            // selector
            // 
            this.selector.BackColor = System.Drawing.Color.Goldenrod;
            this.selector.Location = new System.Drawing.Point(0, 120);
            this.selector.Name = "selector";
            this.selector.Size = new System.Drawing.Size(154, 10);
            this.selector.TabIndex = 1;
            this.selector.Visible = false;
            // 
            // teamPnl
            // 
            this.teamPnl.Location = new System.Drawing.Point(0, 150);
            this.teamPnl.Name = "teamPnl";
            this.teamPnl.Size = new System.Drawing.Size(1540, 883);
            this.teamPnl.TabIndex = 2;
            // 
            // exitBtn
            // 
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Image = global::Turkish_Super_League.Properties.Resources.iconfinder_exit_3226;
            this.exitBtn.Location = new System.Drawing.Point(1224, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(316, 120);
            this.exitBtn.TabIndex = 9;
            this.exitBtn.Text = "Exit";
            this.exitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // teamBtn
            // 
            this.teamBtn.FlatAppearance.BorderSize = 0;
            this.teamBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teamBtn.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teamBtn.ForeColor = System.Drawing.Color.White;
            this.teamBtn.Image = global::Turkish_Super_League.Properties.Resources.rsz_pitch;
            this.teamBtn.Location = new System.Drawing.Point(0, 0);
            this.teamBtn.Name = "teamBtn";
            this.teamBtn.Size = new System.Drawing.Size(154, 120);
            this.teamBtn.TabIndex = 0;
            this.teamBtn.Text = "Teams";
            this.teamBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.teamBtn.UseVisualStyleBackColor = true;
            this.teamBtn.Click += new System.EventHandler(this.teamBtn_Click);
            // 
            // matchBtn
            // 
            this.matchBtn.FlatAppearance.BorderSize = 0;
            this.matchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.matchBtn.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.matchBtn.ForeColor = System.Drawing.Color.White;
            this.matchBtn.Image = global::Turkish_Super_League.Properties.Resources.rsz_pennant1;
            this.matchBtn.Location = new System.Drawing.Point(1078, 0);
            this.matchBtn.Name = "matchBtn";
            this.matchBtn.Size = new System.Drawing.Size(154, 120);
            this.matchBtn.TabIndex = 7;
            this.matchBtn.Text = "Matches";
            this.matchBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.matchBtn.UseVisualStyleBackColor = true;
            this.matchBtn.Click += new System.EventHandler(this.matchBtn_Click);
            // 
            // stadiumBtn
            // 
            this.stadiumBtn.FlatAppearance.BorderSize = 0;
            this.stadiumBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stadiumBtn.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stadiumBtn.ForeColor = System.Drawing.Color.White;
            this.stadiumBtn.Image = global::Turkish_Super_League.Properties.Resources.rsz_stadium;
            this.stadiumBtn.Location = new System.Drawing.Point(924, 0);
            this.stadiumBtn.Name = "stadiumBtn";
            this.stadiumBtn.Size = new System.Drawing.Size(154, 120);
            this.stadiumBtn.TabIndex = 6;
            this.stadiumBtn.Text = "Stadiums";
            this.stadiumBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.stadiumBtn.UseVisualStyleBackColor = true;
            this.stadiumBtn.Click += new System.EventHandler(this.stadiumBtn_Click);
            // 
            // refereeBtn
            // 
            this.refereeBtn.FlatAppearance.BorderSize = 0;
            this.refereeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refereeBtn.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.refereeBtn.ForeColor = System.Drawing.Color.White;
            this.refereeBtn.Image = global::Turkish_Super_League.Properties.Resources.rsz_whistle;
            this.refereeBtn.Location = new System.Drawing.Point(770, 0);
            this.refereeBtn.Name = "refereeBtn";
            this.refereeBtn.Size = new System.Drawing.Size(154, 120);
            this.refereeBtn.TabIndex = 5;
            this.refereeBtn.Text = "Referees";
            this.refereeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.refereeBtn.UseVisualStyleBackColor = true;
            this.refereeBtn.Click += new System.EventHandler(this.refereeBtn_Click);
            // 
            // assistBtn
            // 
            this.assistBtn.FlatAppearance.BorderSize = 0;
            this.assistBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assistBtn.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.assistBtn.ForeColor = System.Drawing.Color.White;
            this.assistBtn.Image = global::Turkish_Super_League.Properties.Resources.rsz_championship;
            this.assistBtn.Location = new System.Drawing.Point(616, 0);
            this.assistBtn.Name = "assistBtn";
            this.assistBtn.Size = new System.Drawing.Size(154, 120);
            this.assistBtn.TabIndex = 4;
            this.assistBtn.Text = "Assist Table";
            this.assistBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.assistBtn.UseVisualStyleBackColor = true;
            this.assistBtn.Click += new System.EventHandler(this.assistBtn_Click);
            // 
            // goalBtn
            // 
            this.goalBtn.FlatAppearance.BorderSize = 0;
            this.goalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goalBtn.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.goalBtn.ForeColor = System.Drawing.Color.White;
            this.goalBtn.Image = global::Turkish_Super_League.Properties.Resources.rsz_trophy;
            this.goalBtn.Location = new System.Drawing.Point(462, 0);
            this.goalBtn.Name = "goalBtn";
            this.goalBtn.Size = new System.Drawing.Size(154, 120);
            this.goalBtn.TabIndex = 3;
            this.goalBtn.Text = "Goal Table";
            this.goalBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.goalBtn.UseVisualStyleBackColor = true;
            this.goalBtn.Click += new System.EventHandler(this.goalBtn_Click);
            // 
            // managerBtn
            // 
            this.managerBtn.FlatAppearance.BorderSize = 0;
            this.managerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.managerBtn.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.managerBtn.ForeColor = System.Drawing.Color.White;
            this.managerBtn.Image = global::Turkish_Super_League.Properties.Resources.rsz_strategy;
            this.managerBtn.Location = new System.Drawing.Point(308, 0);
            this.managerBtn.Name = "managerBtn";
            this.managerBtn.Size = new System.Drawing.Size(154, 120);
            this.managerBtn.TabIndex = 2;
            this.managerBtn.Text = "Managers";
            this.managerBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.managerBtn.UseVisualStyleBackColor = true;
            this.managerBtn.Click += new System.EventHandler(this.managerBtn_Click);
            // 
            // playerBtn
            // 
            this.playerBtn.FlatAppearance.BorderSize = 0;
            this.playerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playerBtn.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.playerBtn.ForeColor = System.Drawing.Color.White;
            this.playerBtn.Image = global::Turkish_Super_League.Properties.Resources.rsz_uniform;
            this.playerBtn.Location = new System.Drawing.Point(154, 0);
            this.playerBtn.Name = "playerBtn";
            this.playerBtn.Size = new System.Drawing.Size(154, 120);
            this.playerBtn.TabIndex = 1;
            this.playerBtn.Text = "Players";
            this.playerBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.playerBtn.UseVisualStyleBackColor = true;
            this.playerBtn.Click += new System.EventHandler(this.playerBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1540, 1055);
            this.Controls.Add(this.teamPnl);
            this.Controls.Add(this.selector);
            this.Controls.Add(this.topPnl);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.topPnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPnl;
        private System.Windows.Forms.Button teamBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button matchBtn;
        private System.Windows.Forms.Button stadiumBtn;
        private System.Windows.Forms.Button refereeBtn;
        private System.Windows.Forms.Button assistBtn;
        private System.Windows.Forms.Button goalBtn;
        private System.Windows.Forms.Button managerBtn;
        private System.Windows.Forms.Button playerBtn;
        private System.Windows.Forms.Panel selector;
        private System.Windows.Forms.Panel teamPnl;
    }
}

