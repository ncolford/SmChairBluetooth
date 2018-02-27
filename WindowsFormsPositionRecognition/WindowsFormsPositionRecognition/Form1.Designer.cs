namespace WindowsFormsPositionRecognition
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBoxresult = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxleft = new System.Windows.Forms.TextBox();
            this.textBoxright = new System.Windows.Forms.TextBox();
            this.textBoxforward = new System.Windows.Forms.TextBox();
            this.textBoxback = new System.Windows.Forms.TextBox();
            this.textBoxbackpercent = new System.Windows.Forms.TextBox();
            this.textBoxforwardpercent = new System.Windows.Forms.TextBox();
            this.textBoxrightpercent = new System.Windows.Forms.TextBox();
            this.textBoxleftpercent = new System.Windows.Forms.TextBox();
            this.textBoxdifference = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(162, 300);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(162, 326);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(162, 352);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(162, 378);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(268, 300);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(268, 326);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 5;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(268, 352);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 6;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(268, 378);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 7;
            // 
            // textBoxresult
            // 
            this.textBoxresult.Location = new System.Drawing.Point(162, 12);
            this.textBoxresult.Name = "textBoxresult";
            this.textBoxresult.Size = new System.Drawing.Size(100, 20);
            this.textBoxresult.TabIndex = 8;
            this.textBoxresult.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "left";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "right";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "forward";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "back";
            // 
            // textBoxleft
            // 
            this.textBoxleft.Location = new System.Drawing.Point(162, 135);
            this.textBoxleft.Name = "textBoxleft";
            this.textBoxleft.Size = new System.Drawing.Size(100, 20);
            this.textBoxleft.TabIndex = 14;
            // 
            // textBoxright
            // 
            this.textBoxright.Location = new System.Drawing.Point(162, 161);
            this.textBoxright.Name = "textBoxright";
            this.textBoxright.Size = new System.Drawing.Size(100, 20);
            this.textBoxright.TabIndex = 15;
            // 
            // textBoxforward
            // 
            this.textBoxforward.Location = new System.Drawing.Point(162, 187);
            this.textBoxforward.Name = "textBoxforward";
            this.textBoxforward.Size = new System.Drawing.Size(100, 20);
            this.textBoxforward.TabIndex = 16;
            // 
            // textBoxback
            // 
            this.textBoxback.Location = new System.Drawing.Point(162, 213);
            this.textBoxback.Name = "textBoxback";
            this.textBoxback.Size = new System.Drawing.Size(100, 20);
            this.textBoxback.TabIndex = 17;
            // 
            // textBoxbackpercent
            // 
            this.textBoxbackpercent.Location = new System.Drawing.Point(268, 213);
            this.textBoxbackpercent.Name = "textBoxbackpercent";
            this.textBoxbackpercent.Size = new System.Drawing.Size(100, 20);
            this.textBoxbackpercent.TabIndex = 21;
            // 
            // textBoxforwardpercent
            // 
            this.textBoxforwardpercent.Location = new System.Drawing.Point(268, 187);
            this.textBoxforwardpercent.Name = "textBoxforwardpercent";
            this.textBoxforwardpercent.Size = new System.Drawing.Size(100, 20);
            this.textBoxforwardpercent.TabIndex = 20;
            // 
            // textBoxrightpercent
            // 
            this.textBoxrightpercent.Location = new System.Drawing.Point(268, 161);
            this.textBoxrightpercent.Name = "textBoxrightpercent";
            this.textBoxrightpercent.Size = new System.Drawing.Size(100, 20);
            this.textBoxrightpercent.TabIndex = 19;
            // 
            // textBoxleftpercent
            // 
            this.textBoxleftpercent.Location = new System.Drawing.Point(268, 135);
            this.textBoxleftpercent.Name = "textBoxleftpercent";
            this.textBoxleftpercent.Size = new System.Drawing.Size(100, 20);
            this.textBoxleftpercent.TabIndex = 18;
            // 
            // textBoxdifference
            // 
            this.textBoxdifference.Location = new System.Drawing.Point(395, 90);
            this.textBoxdifference.Name = "textBoxdifference";
            this.textBoxdifference.Size = new System.Drawing.Size(100, 20);
            this.textBoxdifference.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 435);
            this.Controls.Add(this.textBoxdifference);
            this.Controls.Add(this.textBoxbackpercent);
            this.Controls.Add(this.textBoxforwardpercent);
            this.Controls.Add(this.textBoxrightpercent);
            this.Controls.Add(this.textBoxleftpercent);
            this.Controls.Add(this.textBoxback);
            this.Controls.Add(this.textBoxforward);
            this.Controls.Add(this.textBoxright);
            this.Controls.Add(this.textBoxleft);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxresult);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Position identification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBoxresult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxleft;
        private System.Windows.Forms.TextBox textBoxright;
        private System.Windows.Forms.TextBox textBoxforward;
        private System.Windows.Forms.TextBox textBoxback;
        private System.Windows.Forms.TextBox textBoxbackpercent;
        private System.Windows.Forms.TextBox textBoxforwardpercent;
        private System.Windows.Forms.TextBox textBoxrightpercent;
        private System.Windows.Forms.TextBox textBoxleftpercent;
        private System.Windows.Forms.TextBox textBoxdifference;
    }
}

