namespace yoketoruvs20
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.titleLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.leftLabel = new System.Windows.Forms.Label();
            this.hiLabel = new System.Windows.Forms.Label();
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.titleButton = new System.Windows.Forms.Button();
            this.clearLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TempLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("小塚ゴシック Pr6N B", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.titleLabel.Location = new System.Drawing.Point(173, 87);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(454, 117);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "よけとる2020";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.startButton.Font = new System.Drawing.Font("小塚ゴシック Pr6N B", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.startButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.startButton.Location = new System.Drawing.Point(292, 303);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(216, 84);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "スタート!!";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.AutoSize = true;
            this.copyrightLabel.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.copyrightLabel.Location = new System.Drawing.Point(270, 410);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(260, 22);
            this.copyrightLabel.TabIndex = 2;
            this.copyrightLabel.Text = "Copyright © 2020 田中　雄";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("小塚ゴシック Pr6N B", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.timeLabel.Location = new System.Drawing.Point(12, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(160, 59);
            this.timeLabel.TabIndex = 3;
            this.timeLabel.Text = "Time 100";
            // 
            // leftLabel
            // 
            this.leftLabel.AutoSize = true;
            this.leftLabel.Font = new System.Drawing.Font("小塚ゴシック Pr6N B", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.leftLabel.Location = new System.Drawing.Point(679, 9);
            this.leftLabel.Name = "leftLabel";
            this.leftLabel.Size = new System.Drawing.Size(109, 59);
            this.leftLabel.TabIndex = 4;
            this.leftLabel.Text = "★: 10";
            // 
            // hiLabel
            // 
            this.hiLabel.AutoSize = true;
            this.hiLabel.Font = new System.Drawing.Font("小塚ゴシック Pr6N B", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.hiLabel.Location = new System.Drawing.Point(282, 205);
            this.hiLabel.Name = "hiLabel";
            this.hiLabel.Size = new System.Drawing.Size(238, 59);
            this.hiLabel.TabIndex = 5;
            this.hiLabel.Text = "HighScore 100";
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.BackColor = System.Drawing.Color.Transparent;
            this.gameOverLabel.Font = new System.Drawing.Font("小塚ゴシック Pr6N B", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.gameOverLabel.ForeColor = System.Drawing.Color.Blue;
            this.gameOverLabel.Location = new System.Drawing.Point(219, 167);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(363, 117);
            this.gameOverLabel.TabIndex = 6;
            this.gameOverLabel.Text = "GameOver";
            // 
            // titleButton
            // 
            this.titleButton.BackColor = System.Drawing.SystemColors.Control;
            this.titleButton.Font = new System.Drawing.Font("小塚ゴシック Pr6N B", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.titleButton.ForeColor = System.Drawing.Color.Black;
            this.titleButton.Location = new System.Drawing.Point(292, 303);
            this.titleButton.Name = "titleButton";
            this.titleButton.Size = new System.Drawing.Size(216, 84);
            this.titleButton.TabIndex = 7;
            this.titleButton.Text = "タイトルへ";
            this.titleButton.UseVisualStyleBackColor = false;
            this.titleButton.Click += new System.EventHandler(this.titleButton_Click);
            // 
            // clearLabel
            // 
            this.clearLabel.AutoSize = true;
            this.clearLabel.BackColor = System.Drawing.Color.Transparent;
            this.clearLabel.Font = new System.Drawing.Font("小塚ゴシック Pr6N B", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.clearLabel.ForeColor = System.Drawing.Color.Red;
            this.clearLabel.Location = new System.Drawing.Point(264, 167);
            this.clearLabel.Name = "clearLabel";
            this.clearLabel.Size = new System.Drawing.Size(273, 117);
            this.clearLabel.TabIndex = 8;
            this.clearLabel.Text = "CLEAR!!";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TempLabel
            // 
            this.TempLabel.AutoSize = true;
            this.TempLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TempLabel.Location = new System.Drawing.Point(91, 272);
            this.TempLabel.Name = "TempLabel";
            this.TempLabel.Size = new System.Drawing.Size(47, 33);
            this.TempLabel.TabIndex = 9;
            this.TempLabel.Text = "★";
            this.TempLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TempLabel);
            this.Controls.Add(this.clearLabel);
            this.Controls.Add(this.titleButton);
            this.Controls.Add(this.gameOverLabel);
            this.Controls.Add(this.hiLabel);
            this.Controls.Add(this.leftLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "よけとる2020";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label copyrightLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label leftLabel;
        private System.Windows.Forms.Label hiLabel;
        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.Button titleButton;
        private System.Windows.Forms.Label clearLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label TempLabel;
    }
}

