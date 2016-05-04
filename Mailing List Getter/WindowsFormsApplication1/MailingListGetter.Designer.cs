namespace WindowsFormsApplication1
{
    partial class MailingListGetter
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datraBrowseButton = new System.Windows.Forms.Button();
            this.mailBrowseButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.dataTextbox = new System.Windows.Forms.TextBox();
            this.mailTextbox = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.dataErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.mailErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Sheet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mailing List";
            // 
            // datraBrowseButton
            // 
            this.datraBrowseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datraBrowseButton.Location = new System.Drawing.Point(506, 42);
            this.datraBrowseButton.Name = "datraBrowseButton";
            this.datraBrowseButton.Size = new System.Drawing.Size(87, 33);
            this.datraBrowseButton.TabIndex = 2;
            this.datraBrowseButton.Text = "Browse";
            this.datraBrowseButton.UseVisualStyleBackColor = true;
            this.datraBrowseButton.Click += new System.EventHandler(this.datraBrowseButton_Click);
            // 
            // mailBrowseButton
            // 
            this.mailBrowseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailBrowseButton.Location = new System.Drawing.Point(506, 126);
            this.mailBrowseButton.Name = "mailBrowseButton";
            this.mailBrowseButton.Size = new System.Drawing.Size(87, 33);
            this.mailBrowseButton.TabIndex = 3;
            this.mailBrowseButton.Text = "Browse";
            this.mailBrowseButton.UseVisualStyleBackColor = true;
            this.mailBrowseButton.Click += new System.EventHandler(this.mailBrowseButton_Click);
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(506, 200);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(87, 33);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // dataTextbox
            // 
            this.dataTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataTextbox.Location = new System.Drawing.Point(28, 45);
            this.dataTextbox.Name = "dataTextbox";
            this.dataTextbox.Size = new System.Drawing.Size(459, 26);
            this.dataTextbox.TabIndex = 5;
            // 
            // mailTextbox
            // 
            this.mailTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailTextbox.Location = new System.Drawing.Point(28, 129);
            this.mailTextbox.Name = "mailTextbox";
            this.mailTextbox.Size = new System.Drawing.Size(459, 26);
            this.mailTextbox.TabIndex = 6;
            // 
            // dataErrorProvider
            // 
            this.dataErrorProvider.ContainerControl = this;
            // 
            // mailErrorProvider
            // 
            this.mailErrorProvider.ContainerControl = this;
            // 
            // MailingListGetter
            // 
            this.AcceptButton = this.startButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 259);
            this.Controls.Add(this.mailTextbox);
            this.Controls.Add(this.dataTextbox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.mailBrowseButton);
            this.Controls.Add(this.datraBrowseButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MailingListGetter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail List Getter";
            ((System.ComponentModel.ISupportInitialize)(this.dataErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button datraBrowseButton;
        private System.Windows.Forms.Button mailBrowseButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox dataTextbox;
        private System.Windows.Forms.TextBox mailTextbox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ErrorProvider dataErrorProvider;
        private System.Windows.Forms.ErrorProvider mailErrorProvider;
    }
}

