namespace Astronomical_Processing_Sprint1
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
            this.buttonLoad = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.textBoxEdite = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Button_Search = new System.Windows.Forms.Button();
            this.Button_Edit = new System.Windows.Forms.Button();
            this.buttonMid_Extreme = new System.Windows.Forms.Button();
            this.buttonMode = new System.Windows.Forms.Button();
            this.buttonAverage = new System.Windows.Forms.Button();
            this.buttonRange = new System.Windows.Forms.Button();
            this.buttonSequencial_Search = new System.Windows.Forms.Button();
            this.textBoxLinear_Search = new System.Windows.Forms.TextBox();
            this.labelLineal_Search = new System.Windows.Forms.Label();
            this.textBoxMode = new System.Windows.Forms.TextBox();
            this.textBoxAverage = new System.Windows.Forms.TextBox();
            this.textBoxRange = new System.Windows.Forms.TextBox();
            this.textBoxMid_extrem = new System.Windows.Forms.TextBox();
            this.textBoxFrecuency = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLoad.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonLoad.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonLoad.Location = new System.Drawing.Point(592, 23);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(137, 39);
            this.buttonLoad.TabIndex = 0;
            this.buttonLoad.Text = "Load Date";
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Comic Sans MS", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(551, 83);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(226, 355);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(183, 68);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearch.TabIndex = 2;
            // 
            // textBoxEdite
            // 
            this.textBoxEdite.Location = new System.Drawing.Point(183, 182);
            this.textBoxEdite.Name = "textBoxEdite";
            this.textBoxEdite.Size = new System.Drawing.Size(100, 20);
            this.textBoxEdite.TabIndex = 6;
            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(262, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "Astronomical Processing";
           
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(397, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "Sort";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Button_Search
            // 
            this.Button_Search.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Search.Location = new System.Drawing.Point(42, 62);
            this.Button_Search.Name = "Button_Search";
            this.Button_Search.Size = new System.Drawing.Size(96, 30);
            this.Button_Search.TabIndex = 10;
            this.Button_Search.Text = "Binary Search";
            this.Button_Search.UseVisualStyleBackColor = true;
            this.Button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // Button_Edit
            // 
            this.Button_Edit.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Edit.Location = new System.Drawing.Point(45, 177);
            this.Button_Edit.Name = "Button_Edit";
            this.Button_Edit.Size = new System.Drawing.Size(56, 29);
            this.Button_Edit.TabIndex = 11;
            this.Button_Edit.Text = "Edit";
            this.Button_Edit.UseVisualStyleBackColor = true;
            this.Button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // buttonMid_Extreme
            // 
            this.buttonMid_Extreme.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMid_Extreme.Location = new System.Drawing.Point(47, 396);
            this.buttonMid_Extreme.Name = "buttonMid_Extreme";
            this.buttonMid_Extreme.Size = new System.Drawing.Size(84, 24);
            this.buttonMid_Extreme.TabIndex = 12;
            this.buttonMid_Extreme.Text = "Mid-Extreme";
            this.buttonMid_Extreme.UseVisualStyleBackColor = true;
            this.buttonMid_Extreme.Click += new System.EventHandler(this.buttonMid_Extreme_Click);
            // 
            // buttonMode
            // 
            this.buttonMode.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMode.Location = new System.Drawing.Point(47, 237);
            this.buttonMode.Name = "buttonMode";
            this.buttonMode.Size = new System.Drawing.Size(56, 23);
            this.buttonMode.TabIndex = 13;
            this.buttonMode.Text = "Mode";
            this.buttonMode.UseVisualStyleBackColor = true;
            this.buttonMode.Click += new System.EventHandler(this.buttonMode_Click);
            // 
            // buttonAverage
            // 
            this.buttonAverage.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAverage.Location = new System.Drawing.Point(45, 290);
            this.buttonAverage.Name = "buttonAverage";
            this.buttonAverage.Size = new System.Drawing.Size(67, 24);
            this.buttonAverage.TabIndex = 14;
            this.buttonAverage.Text = "Average";
            this.buttonAverage.UseVisualStyleBackColor = true;
            this.buttonAverage.Click += new System.EventHandler(this.buttonAverage_Click);
            // 
            // buttonRange
            // 
            this.buttonRange.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRange.Location = new System.Drawing.Point(47, 341);
            this.buttonRange.Name = "buttonRange";
            this.buttonRange.Size = new System.Drawing.Size(56, 27);
            this.buttonRange.TabIndex = 15;
            this.buttonRange.Text = "Range";
            this.buttonRange.UseVisualStyleBackColor = true;
            this.buttonRange.Click += new System.EventHandler(this.buttonRange_Click);
            // 
            // buttonSequencial_Search
            // 
            this.buttonSequencial_Search.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSequencial_Search.Location = new System.Drawing.Point(42, 119);
            this.buttonSequencial_Search.Name = "buttonSequencial_Search";
            this.buttonSequencial_Search.Size = new System.Drawing.Size(96, 29);
            this.buttonSequencial_Search.TabIndex = 16;
            this.buttonSequencial_Search.Text = "Linear Search";
            this.buttonSequencial_Search.UseVisualStyleBackColor = true;
            this.buttonSequencial_Search.Click += new System.EventHandler(this.buttonSequencial_Search_Click);
            // 
            // textBoxLinear_Search
            // 
            this.textBoxLinear_Search.Location = new System.Drawing.Point(183, 124);
            this.textBoxLinear_Search.Name = "textBoxLinear_Search";
            this.textBoxLinear_Search.Size = new System.Drawing.Size(100, 20);
            this.textBoxLinear_Search.TabIndex = 17;
            // 
            // labelLineal_Search
            // 
            this.labelLineal_Search.AutoSize = true;
            this.labelLineal_Search.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLineal_Search.Location = new System.Drawing.Point(41, 226);
            this.labelLineal_Search.Name = "labelLineal_Search";
            this.labelLineal_Search.Size = new System.Drawing.Size(0, 19);
            this.labelLineal_Search.TabIndex = 18;
            // 
            // textBoxMode
            // 
            this.textBoxMode.Location = new System.Drawing.Point(183, 239);
            this.textBoxMode.Name = "textBoxMode";
            this.textBoxMode.Size = new System.Drawing.Size(100, 20);
            this.textBoxMode.TabIndex = 19;
            // 
            // textBoxAverage
            // 
            this.textBoxAverage.Location = new System.Drawing.Point(183, 293);
            this.textBoxAverage.Name = "textBoxAverage";
            this.textBoxAverage.Size = new System.Drawing.Size(100, 20);
            this.textBoxAverage.TabIndex = 20;
            // 
            // textBoxRange
            // 
            this.textBoxRange.Location = new System.Drawing.Point(183, 347);
            this.textBoxRange.Name = "textBoxRange";
            this.textBoxRange.Size = new System.Drawing.Size(100, 20);
            this.textBoxRange.TabIndex = 21;
            // 
            // textBoxMid_extrem
            // 
            this.textBoxMid_extrem.Location = new System.Drawing.Point(183, 399);
            this.textBoxMid_extrem.Name = "textBoxMid_extrem";
            this.textBoxMid_extrem.Size = new System.Drawing.Size(100, 20);
            this.textBoxMid_extrem.TabIndex = 22;
            // 
            // textBoxFrecuency
            // 
            this.textBoxFrecuency.Location = new System.Drawing.Point(401, 244);
            this.textBoxFrecuency.Name = "textBoxFrecuency";
            this.textBoxFrecuency.Size = new System.Drawing.Size(100, 20);
            this.textBoxFrecuency.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Frecuency";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFrecuency);
            this.Controls.Add(this.textBoxMid_extrem);
            this.Controls.Add(this.textBoxRange);
            this.Controls.Add(this.textBoxAverage);
            this.Controls.Add(this.textBoxMode);
            this.Controls.Add(this.labelLineal_Search);
            this.Controls.Add(this.textBoxLinear_Search);
            this.Controls.Add(this.buttonSequencial_Search);
            this.Controls.Add(this.buttonRange);
            this.Controls.Add(this.buttonAverage);
            this.Controls.Add(this.buttonMode);
            this.Controls.Add(this.buttonMid_Extreme);
            this.Controls.Add(this.Button_Edit);
            this.Controls.Add(this.Button_Search);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxEdite);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonLoad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.TextBox textBoxEdite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Button_Search;
        private System.Windows.Forms.Button Button_Edit;
        private System.Windows.Forms.Button buttonMid_Extreme;
        private System.Windows.Forms.Button buttonMode;
        private System.Windows.Forms.Button buttonAverage;
        private System.Windows.Forms.Button buttonRange;
        private System.Windows.Forms.Button buttonSequencial_Search;
        private System.Windows.Forms.TextBox textBoxLinear_Search;
        private System.Windows.Forms.Label labelLineal_Search;
        private System.Windows.Forms.TextBox textBoxMode;
        private System.Windows.Forms.TextBox textBoxAverage;
        private System.Windows.Forms.TextBox textBoxRange;
        private System.Windows.Forms.TextBox textBoxMid_extrem;
        private System.Windows.Forms.TextBox textBoxFrecuency;
        private System.Windows.Forms.Label label1;
    }
}

