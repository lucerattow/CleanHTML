namespace CleanHTML
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lvFiles = new ListView();
            btnBuscar = new Button();
            btnExport = new Button();
            label2 = new Label();
            txtTag = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lvFiles
            // 
            lvFiles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvFiles.CheckBoxes = true;
            lvFiles.Location = new Point(12, 75);
            lvFiles.Name = "lvFiles";
            lvFiles.ShowGroups = false;
            lvFiles.Size = new Size(435, 150);
            lvFiles.Sorting = SortOrder.Ascending;
            lvFiles.TabIndex = 2;
            lvFiles.UseCompatibleStateImageBehavior = false;
            lvFiles.View = View.List;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(12, 46);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(109, 23);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar carpeta";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnExport
            // 
            btnExport.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnExport.Location = new Point(12, 231);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(109, 23);
            btnExport.TabIndex = 4;
            btnExport.Text = "Exportar";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(435, 34);
            label2.TabIndex = 5;
            label2.Text = "Esta pequeña aplicación se encarga de eliminar código sobrante HTML de tu archivo.";
            // 
            // txtTag
            // 
            txtTag.Location = new Point(358, 46);
            txtTag.Name = "txtTag";
            txtTag.Size = new Size(86, 23);
            txtTag.TabIndex = 6;
            txtTag.Text = "header";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(267, 50);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 7;
            label1.Text = "Etiqueta HTML";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 265);
            Controls.Add(label1);
            Controls.Add(txtTag);
            Controls.Add(label2);
            Controls.Add(btnExport);
            Controls.Add(btnBuscar);
            Controls.Add(lvFiles);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clean HTML";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView lvFiles;
        private Button btnBuscar;
        private Button btnExport;
        private Label label2;
        private TextBox txtTag;
        private Label label1;
    }
}