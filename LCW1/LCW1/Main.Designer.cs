namespace LCW1
{
    partial class Main
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
            this.addComponent = new System.Windows.Forms.Button();
            this.buildComputer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addComponent
            // 
            this.addComponent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(99)))), ((int)(((byte)(156)))));
            this.addComponent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addComponent.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addComponent.ForeColor = System.Drawing.Color.White;
            this.addComponent.Location = new System.Drawing.Point(12, 172);
            this.addComponent.Name = "addComponent";
            this.addComponent.Size = new System.Drawing.Size(154, 40);
            this.addComponent.TabIndex = 0;
            this.addComponent.Text = "Edit Component";
            this.addComponent.UseVisualStyleBackColor = false;
            this.addComponent.Click += new System.EventHandler(this.addComponent_Click);
            // 
            // buildComputer
            // 
            this.buildComputer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(99)))), ((int)(((byte)(156)))));
            this.buildComputer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buildComputer.Font = new System.Drawing.Font("Britannic Bold", 11.25F);
            this.buildComputer.ForeColor = System.Drawing.Color.White;
            this.buildComputer.Location = new System.Drawing.Point(12, 88);
            this.buildComputer.Name = "buildComputer";
            this.buildComputer.Size = new System.Drawing.Size(154, 38);
            this.buildComputer.TabIndex = 2;
            this.buildComputer.Text = "Build Computer";
            this.buildComputer.UseVisualStyleBackColor = false;
            this.buildComputer.Click += new System.EventHandler(this.buildComputer_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(99)))), ((int)(((byte)(156)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(0, 309);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 24);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::LCW1.Properties.Resources.monitor_1706152_1280;
            this.pictureBox1.InitialImage = global::LCW1.Properties.Resources.kisspng_computer_icons_bookkeeping_and_accounting_financia_taobao_blue_copywriter_5adb0ab7a03a71_4683974215243045676563;
            this.pictureBox1.Location = new System.Drawing.Point(205, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(497, 332);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buildComputer);
            this.Controls.Add(this.addComponent);
            this.Name = "Main";
            this.Text = "LBC";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addComponent;
        private System.Windows.Forms.Button buildComputer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

