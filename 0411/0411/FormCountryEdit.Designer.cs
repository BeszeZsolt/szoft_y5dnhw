namespace _0411
{
    partial class FormCountryEdit
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            textBox1 = new TextBox();
            countryDataBindingSource = new BindingSource(components);
            textBox2 = new TextBox();
            countryDataBindingSource1 = new BindingSource(components);
            textBox3 = new TextBox();
            countryDataBindingSource2 = new BindingSource(components);
            label2 = new Label();
            label3 = new Label();
            buttonSave = new Button();
            bindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)countryDataBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)countryDataBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)countryDataBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 0;
            label1.Text = "Country Name";
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", countryDataBindingSource, "Name", true));
            textBox1.Location = new Point(12, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(278, 23);
            textBox1.TabIndex = 1;
            // 
            // countryDataBindingSource
            // 
            countryDataBindingSource.DataSource = typeof(CountryData);
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", countryDataBindingSource1, "Population", true));
            textBox2.Location = new Point(12, 86);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(278, 23);
            textBox2.TabIndex = 2;
            // 
            // countryDataBindingSource1
            // 
            countryDataBindingSource1.DataSource = typeof(CountryData);
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", countryDataBindingSource2, "AreaInSquareKm", true));
            textBox3.Location = new Point(12, 154);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(278, 23);
            textBox3.TabIndex = 3;
            // 
            // countryDataBindingSource2
            // 
            countryDataBindingSource2.DataSource = typeof(CountryData);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 68);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 4;
            label2.Text = "Population";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 136);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 5;
            label3.Text = "Area in km2";
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSave.Location = new Point(206, 268);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "&Ok";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = countryDataBindingSource;
            // 
            // FormCountryEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 299);
            Controls.Add(buttonSave);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "FormCountryEdit";
            Text = "FormCountryEdit";
            ((System.ComponentModel.ISupportInitialize)countryDataBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)countryDataBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)countryDataBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label2;
        private Label label3;
        private Button buttonSave;
        private BindingSource countryDataBindingSource;
        private BindingSource countryDataBindingSource1;
        private BindingSource countryDataBindingSource2;
        private BindingSource bindingSource1;
    }
}