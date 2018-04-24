namespace NCH_Project
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
            this.components = new System.ComponentModel.Container();
            this.appointmentDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.systemsDataBase2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.systemsDataBase2DataSet = new NCH_Project.SystemsDataBase2DataSet();
            this.appointment_DataTableAdapter = new NCH_Project.SystemsDataBase2DataSetTableAdapters.Appointment_DataTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemsDataBase2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemsDataBase2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // appointmentDataBindingSource
            // 
            this.appointmentDataBindingSource.DataMember = "Appointment Data";
            this.appointmentDataBindingSource.DataSource = this.systemsDataBase2DataSetBindingSource;
            // 
            // systemsDataBase2DataSetBindingSource
            // 
            this.systemsDataBase2DataSetBindingSource.DataSource = this.systemsDataBase2DataSet;
            this.systemsDataBase2DataSetBindingSource.Position = 0;
            // 
            // systemsDataBase2DataSet
            // 
            this.systemsDataBase2DataSet.DataSetName = "SystemsDataBase2DataSet";
            this.systemsDataBase2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointment_DataTableAdapter
            // 
            this.appointment_DataTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 438);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemsDataBase2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemsDataBase2DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource systemsDataBase2DataSetBindingSource;
        private SystemsDataBase2DataSet systemsDataBase2DataSet;
        private System.Windows.Forms.BindingSource appointmentDataBindingSource;
        private SystemsDataBase2DataSetTableAdapters.Appointment_DataTableAdapter appointment_DataTableAdapter;
    }
}