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
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxEdite = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLoad.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonLoad.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonLoad.Location = new System.Drawing.Point(640, 36);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(137, 69);
            this.buttonLoad.TabIndex = 0;
            this.buttonLoad.Text = "Load Date";
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(551, 152);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(226, 184);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(211, 113);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearch.TabIndex = 2;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(102, 113);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(90, 16);
            this.labelSearch.TabIndex = 3;
            this.labelSearch.Text = "Binary Search";
            this.labelSearch.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxEdite
            // 
            this.textBoxEdite.Location = new System.Drawing.Point(211, 218);
            this.textBoxEdite.Name = "textBoxEdite";
            this.textBoxEdite.Size = new System.Drawing.Size(100, 20);
            this.textBoxEdite.TabIndex = 6;
            this.textBoxEdite.TextChanged += new System.EventHandler(this.textBoxEdite_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Edit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(256, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "Astronomical Processing";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(223, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "Sort";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Button_Search
            // 
            this.Button_Search.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Search.Location = new System.Drawing.Point(364, 287);
            this.Button_Search.Name = "Button_Search";
            this.Button_Search.Size = new System.Drawing.Size(77, 35);
            this.Button_Search.TabIndex = 10;
            this.Button_Search.Text = "Search";
            this.Button_Search.UseVisualStyleBackColor = true;
            this.Button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // Button_Edit
            // 
            this.Button_Edit.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Edit.Location = new System.Drawing.Point(73, 287);
            this.Button_Edit.Name = "Button_Edit";
            this.Button_Edit.Size = new System.Drawing.Size(91, 34);
            this.Button_Edit.TabIndex = 11;
            this.Button_Edit.Text = "Edit";
            this.Button_Edit.UseVisualStyleBackColor = true;
            this.Button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // buttonMid_Extreme
            // 
            this.buttonMid_Extreme.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMid_Extreme.Location = new System.Drawing.Point(230, 405);
            this.buttonMid_Extreme.Name = "buttonMid_Extreme";
            this.buttonMid_Extreme.Size = new System.Drawing.Size(88, 33);
            this.buttonMid_Extreme.TabIndex = 12;
            this.buttonMid_Extreme.Text = "Mid-Extreme";
            this.buttonMid_Extreme.UseVisualStyleBackColor = true;
            this.buttonMid_Extreme.Click += new System.EventHandler(this.buttonMid_Extreme_Click);
            // 
            // buttonMode
            // 
            this.buttonMode.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMode.Location = new System.Drawing.Point(73, 340);
            this.buttonMode.Name = "buttonMode";
            this.buttonMode.Size = new System.Drawing.Size(91, 33);
            this.buttonMode.TabIndex = 13;
            this.buttonMode.Text = "Mode";
            this.buttonMode.UseVisualStyleBackColor = true;
            this.buttonMode.Click += new System.EventHandler(this.buttonMode_Click);
            // 
            // buttonAverage
            // 
            this.buttonAverage.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAverage.Location = new System.Drawing.Point(230, 340);
            this.buttonAverage.Name = "buttonAverage";
            this.buttonAverage.Size = new System.Drawing.Size(88, 33);
            this.buttonAverage.TabIndex = 14;
            this.buttonAverage.Text = "Average";
            this.buttonAverage.UseVisualStyleBackColor = true;
            this.buttonAverage.Click += new System.EventHandler(this.buttonAverage_Click);
            // 
            // buttonRange
            // 
            this.buttonRange.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRange.Location = new System.Drawing.Point(364, 342);
            this.buttonRange.Name = "buttonRange";
            this.buttonRange.Size = new System.Drawing.Size(80, 31);
            this.buttonRange.TabIndex = 15;
            this.buttonRange.Text = "Range";
            this.buttonRange.UseVisualStyleBackColor = true;
            this.buttonRange.Click += new System.EventHandler(this.buttonRange_Click);
            // 
            // buttonSequencial_Search
            // 
            this.buttonSequencial_Search.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSequencial_Search.Location = new System.Drawing.Point(601, 377);
            this.buttonSequencial_Search.Name = "buttonSequencial_Search";
            this.buttonSequencial_Search.Size = new System.Drawing.Size(154, 42);
            this.buttonSequencial_Search.TabIndex = 16;
            this.buttonSequencial_Search.Text = "Sequential Search";
            this.buttonSequencial_Search.UseVisualStyleBackColor = true;
            this.buttonSequencial_Search.Click += new System.EventHandler(this.buttonSequencial_Search_Click);
            // 
            // textBoxLinear_Search
            // 
            this.textBoxLinear_Search.Location = new System.Drawing.Point(211, 169);
            this.textBoxLinear_Search.Name = "textBoxLinear_Search";
            this.textBoxLinear_Search.Size = new System.Drawing.Size(100, 20);
            this.textBoxLinear_Search.TabIndex = 17;
            // 
            // labelLineal_Search
            // 
            this.labelLineal_Search.AutoSize = true;
            this.labelLineal_Search.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLineal_Search.Location = new System.Drawing.Point(101, 170);
            this.labelLineal_Search.Name = "labelLineal_Search";
            this.labelLineal_Search.Size = new System.Drawing.Size(97, 19);
            this.labelLineal_Search.TabIndex = 18;
            this.labelLineal_Search.Text = "Linear Search";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxEdite);
            this.Controls.Add(this.labelSearch);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Button_Search;
        private System.Windows.Forms.Button Button_Edit;
        private System.Windows.Forms.Button buttonMid_Extreme;
        private System.Windows.Forms.Button buttonMode;
        private System.Windows.Forms.Button buttonAverage;
        private System.Windows.Forms.Button buttonRange;
        private System.Windows.Forms.Button buttonSequencial_Search;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxLinear_Search;
        private System.Windows.Forms.Label labelLineal_Search;
    }
}

