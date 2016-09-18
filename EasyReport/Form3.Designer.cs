namespace EasyReport
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.EasyReportDataSet = new EasyReport.EasyReportDataSet();
            this.zaposlenici_projektiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zaposlenici_projektiTableAdapter = new EasyReport.EasyReportDataSetTableAdapters.zaposlenici_projektiTableAdapter();
            this.projektiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projektiTableAdapter = new EasyReport.EasyReportDataSetTableAdapters.projektiTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.EasyReportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenici_projektiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // EasyReportDataSet
            // 
            this.EasyReportDataSet.DataSetName = "EasyReportDataSet";
            this.EasyReportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zaposlenici_projektiBindingSource
            // 
            this.zaposlenici_projektiBindingSource.DataMember = "zaposlenici_projekti";
            this.zaposlenici_projektiBindingSource.DataSource = this.EasyReportDataSet;
            // 
            // zaposlenici_projektiTableAdapter
            // 
            this.zaposlenici_projektiTableAdapter.ClearBeforeFill = true;
            // 
            // projektiBindingSource
            // 
            this.projektiBindingSource.DataMember = "projekti";
            this.projektiBindingSource.DataSource = this.EasyReportDataSet;
            // 
            // projektiTableAdapter
            // 
            this.projektiTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(916, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1033, 576);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "User";
            ((System.ComponentModel.ISupportInitialize)(this.EasyReportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenici_projektiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource zaposlenici_projektiBindingSource;
        private EasyReportDataSet EasyReportDataSet;
        private System.Windows.Forms.BindingSource projektiBindingSource;
        private EasyReportDataSetTableAdapters.zaposlenici_projektiTableAdapter zaposlenici_projektiTableAdapter;
        private EasyReportDataSetTableAdapters.projektiTableAdapter projektiTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}