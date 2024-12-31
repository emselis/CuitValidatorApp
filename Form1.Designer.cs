namespace CuitValidatorApp
{
    partial class Form_principal
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
            txt_cuit = new TextBox();
            gbx_cuit = new GroupBox();
            btn_validar = new Button();
            lst_nacional = new ListBox();
            lst_internacional = new ListBox();
            lst_invalid = new ListBox();
            gbx_resultados = new GroupBox();
            lbl_invalid = new Label();
            lbl_internacional = new Label();
            lbl_nacional = new Label();
            gbx_cuit.SuspendLayout();
            gbx_resultados.SuspendLayout();
            SuspendLayout();
            // 
            // txt_cuit
            // 
            txt_cuit.Location = new Point(12, 32);
            txt_cuit.Multiline = true;
            txt_cuit.Name = "txt_cuit";
            txt_cuit.PlaceholderText = "33123456780";
            txt_cuit.ScrollBars = ScrollBars.Vertical;
            txt_cuit.Size = new Size(125, 222);
            txt_cuit.TabIndex = 1;
            // 
            // gbx_cuit
            // 
            gbx_cuit.Controls.Add(btn_validar);
            gbx_cuit.Controls.Add(txt_cuit);
            gbx_cuit.Dock = DockStyle.Top;
            gbx_cuit.ForeColor = Color.White;
            gbx_cuit.Location = new Point(0, 0);
            gbx_cuit.Name = "gbx_cuit";
            gbx_cuit.Size = new Size(454, 272);
            gbx_cuit.TabIndex = 2;
            gbx_cuit.TabStop = false;
            gbx_cuit.Text = "Lista de CUIL/CUIT para validar";
            // 
            // btn_validar
            // 
            btn_validar.ForeColor = Color.Black;
            btn_validar.Location = new Point(175, 32);
            btn_validar.Name = "btn_validar";
            btn_validar.Size = new Size(92, 37);
            btn_validar.TabIndex = 0;
            btn_validar.Text = "Validar";
            btn_validar.UseVisualStyleBackColor = true;
            btn_validar.Click += btn_Validar_Click;
            // 
            // lst_nacional
            // 
            lst_nacional.FormattingEnabled = true;
            lst_nacional.ItemHeight = 15;
            lst_nacional.Location = new Point(12, 58);
            lst_nacional.Name = "lst_nacional";
            lst_nacional.Size = new Size(125, 184);
            lst_nacional.TabIndex = 3;
            // 
            // lst_internacional
            // 
            lst_internacional.FormattingEnabled = true;
            lst_internacional.ItemHeight = 15;
            lst_internacional.Location = new Point(159, 58);
            lst_internacional.Name = "lst_internacional";
            lst_internacional.Size = new Size(125, 184);
            lst_internacional.TabIndex = 4;
            // 
            // lst_invalid
            // 
            lst_invalid.FormattingEnabled = true;
            lst_invalid.ItemHeight = 15;
            lst_invalid.Location = new Point(306, 58);
            lst_invalid.Name = "lst_invalid";
            lst_invalid.Size = new Size(125, 184);
            lst_invalid.TabIndex = 5;
            // 
            // gbx_resultados
            // 
            gbx_resultados.Controls.Add(lbl_invalid);
            gbx_resultados.Controls.Add(lbl_internacional);
            gbx_resultados.Controls.Add(lbl_nacional);
            gbx_resultados.Controls.Add(lst_nacional);
            gbx_resultados.Controls.Add(lst_invalid);
            gbx_resultados.Controls.Add(lst_internacional);
            gbx_resultados.Dock = DockStyle.Top;
            gbx_resultados.ForeColor = Color.White;
            gbx_resultados.Location = new Point(0, 272);
            gbx_resultados.Name = "gbx_resultados";
            gbx_resultados.Size = new Size(454, 261);
            gbx_resultados.TabIndex = 6;
            gbx_resultados.TabStop = false;
            gbx_resultados.Text = "Resultados";
            // 
            // lbl_invalid
            // 
            lbl_invalid.AutoSize = true;
            lbl_invalid.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_invalid.Location = new Point(340, 27);
            lbl_invalid.Name = "lbl_invalid";
            lbl_invalid.Size = new Size(56, 15);
            lbl_invalid.TabIndex = 8;
            lbl_invalid.Text = "Inválidos";
            // 
            // lbl_internacional
            // 
            lbl_internacional.AutoSize = true;
            lbl_internacional.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_internacional.Location = new Point(175, 27);
            lbl_internacional.Name = "lbl_internacional";
            lbl_internacional.Size = new Size(92, 15);
            lbl_internacional.TabIndex = 7;
            lbl_internacional.Text = "Internacionales";
            // 
            // lbl_nacional
            // 
            lbl_nacional.AutoSize = true;
            lbl_nacional.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl_nacional.Location = new Point(41, 27);
            lbl_nacional.Name = "lbl_nacional";
            lbl_nacional.Size = new Size(66, 15);
            lbl_nacional.TabIndex = 6;
            lbl_nacional.Text = "Nacionales";
            // 
            // Form_principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 90, 120);
            ClientSize = new Size(454, 535);
            Controls.Add(gbx_resultados);
            Controls.Add(gbx_cuit);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form_principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CUIT Validator";
            gbx_cuit.ResumeLayout(false);
            gbx_cuit.PerformLayout();
            gbx_resultados.ResumeLayout(false);
            gbx_resultados.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txt_cuit;
        private GroupBox gbx_cuit;
        private Button btn_validar;
        private ListBox lst_nacional;
        private ListBox lst_internacional;
        private ListBox lst_invalid;
        private GroupBox gbx_resultados;
        private Label lbl_invalid;
        private Label lbl_internacional;
        private Label lbl_nacional;
    }
}
